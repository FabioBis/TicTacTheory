using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using BoardGameCore;

namespace TicTacTheory
{
    /// <summary>
    /// Defines the type of opponent for the single game.
    /// </summary>
    enum Opponent
    {
        // Player VS Player.
        Manual,
        // Player VS AI.
        Sheldon,
        Penny,
        Stuart,
        // Not yet defined.
        Empty
    }

    /// <summary>
    /// Defines the first to move for the single game.
    /// </summary>
    enum First
    {
        // The player.
        Me,
        // The AI.
        Opponent,
        // Not yet defined.
        Empty
    }

    /// <summary>
    /// Defines AI agents for the game streak test.
    /// </summary>
    enum AI
    {
        // Defined AI.
        Sheldon,
        Penny,
        Stuart,
        // Not yet defined.
        Empty
    }

    /// <summary>
    /// Define the state of a standard start/stop button.
    /// </summary>
    enum ButtonState
    {
        Start,
        Stop
    }

    public partial class TicTacTheory : Form
    {
        // Button states.
        ButtonState singleButtonState = ButtonState.Start;
        ButtonState multiButtonState = ButtonState.Start;

        // Threads.
        Thread singleGameThread = null;
        Thread multiGameThread = null;

        // Delegates.
        delegate void UpdateTextDelegate(Control ctl, string text);
        delegate void UpdateEnabledDelegate(Control crl, bool p);
        delegate void ShowProgressDelegate(int result);
        delegate void UpdateResultsDelegate(int total);
        delegate void InitStatisticsDelegate(int total);
        delegate void UpdateMaximumDelegate(ProgressBar ctl, int total);

        // The game core.
        private TicTacToeCore game;


        /* Single Game Mode Data. */

        // The players names.
        string player1;
        string player2;

        // The list of all the board square.
        List<Label> squares;

        // The choosen opponent.
        Opponent opponent = Opponent.Empty;

        // The first to move.
        First first = First.Empty;

        // A boolean flag to check if the current move is the first one.
        bool firstMove = true;

        // The AI strategy.
        TicTacToeStrategy strategy { get; set; }


        /* Multi Matches Mode Data. */

        // The choosen opponents.
        AI aiPlayer1 = AI.Empty;
        AI aiPlayer2 = AI.Empty;

        // The AI strategies.
        TicTacToeStrategy strategy1 { get; set; }
        TicTacToeStrategy strategy2 { get; set; }
        
        // The number of matches to play.
        int totalMatches = 0;
        int matchesLeft = 0;

        // Statistics.
        int draws = 0;
        int p1Wins = 0;
        int p2Wins = 0;

        // Is streak ended?
        bool streakEnded = false;

        /// <summary>
        /// Constructor.
        /// </summary>
        public TicTacTheory()
        {
            InitializeComponent();
            squares = new List<Label>() {
                square0, square1, square2, square3, square4,
                square5, square6, square7, square8
            };
        }

        /* Delegators helpers. */

        private void UpdateText(Control ctl, string text)
        {
            if (ctl.InvokeRequired)
            {
                UpdateTextDelegate callbackMethod =
                    new UpdateTextDelegate(UpdateText);
                this.Invoke(callbackMethod, ctl, text);
            }
            else
            {
                ctl.Text = text;
            }
        }


        private void UpdateEnabled(Control ctl, bool p)
        {
            if (ctl.InvokeRequired)
            {
                UpdateEnabledDelegate callbackMethod =
                    new UpdateEnabledDelegate(UpdateEnabled);
                this.Invoke(callbackMethod, ctl, p);
            }
            else
            {
                ctl.Enabled = p;
            }
        }

        private void ShowProgress(int result)
        {
            switch (result)
            {
                case -2:
                    progressP1.PerformStep();
                    break;
                case 2:
                    progressP2.PerformStep();
                    break;
                case 1:
                    progressDraws.PerformStep();
                    break;
                default:
                    break;
            }
            totalGameProgress.PerformStep();
        }

        private void UpdateResults(int total)
        {
            if (p1Wins > p2Wins)
            {
                UpdateText(messageTestsLabel, aiPlayer1.ToString() + " is the winner!");
            }
            else if (p2Wins > p1Wins)
            {
                UpdateText(messageTestsLabel, aiPlayer2.ToString() + " is the winner!");
            }
            else
            {
                UpdateText(messageTestsLabel, "The competition is a draw!");
            }
            UpdateText(statisticsLabel, printStatistics());
        }

        private string printStatistics()
        {
            return
                "Game Streak Statistics\n" +
                "----------------------\n" +
                "Total matches played: " + (totalMatches - matchesLeft).ToString() +
                ".\n" +
                "Player 1 (" + aiPlayer1.ToString() + ") won " + p1Wins.ToString() +
                " matches " + "(" + ((float)p1Wins) / totalMatches * 100 + "%).\n" +
                "Player 2 (" + aiPlayer2.ToString() + ") won " + p2Wins.ToString() +
                " matches " + "(" + ((float)p2Wins) / totalMatches * 100 + "%).\n" +
                "Total draws " + draws +
                " (" + ((float)draws) / totalMatches * 100 + "%).";
        }

        private void InitStatistics(int total)
        {
            UpdateMaximum(totalGameProgress, total);
            UpdateMaximum(progressDraws, total);
            UpdateMaximum(progressP1, total);
            UpdateMaximum(progressP2, total);
        }

        private void UpdateMaximum(ProgressBar ctl, int total)
        {
        if (ctl.InvokeRequired)
            {
                UpdateMaximumDelegate callbackMethod =
                    new UpdateMaximumDelegate(UpdateMaximum);
                this.Invoke(callbackMethod, ctl, total);
            }
            else
            {
                ctl.Maximum = total;
            }
        }

        /* Class functions and methods. */

        /// <summary>
        /// Switch the state of a given button.
        /// 
        /// Usage:
        /// <code>buttonStateOut = switchButtonState(buttonStateIn);</code>
        /// </summary>
        /// <param name="state">The input button state.</param>
        /// <returns>The opposite input button state.</returns>
        private ButtonState switchButtonState(ButtonState state, Control btn)
        {
            if (state.Equals(ButtonState.Start))
            {
                UpdateText(btn, "Stop");
                return ButtonState.Stop;
            }
            else
            {
                UpdateText(btn, "Start");
                return ButtonState.Start;
            }
        }

        /// <summary>
        /// Returns the string representing the current player symbol.
        /// The first player will use "O" and the second will use "X".
        /// This method assume that the current player has already made
        /// his move (game.Move), so now it's the opponent turn.
        /// </summary>
        /// <returns>A string representing the current player.</returns>
        private string playerSymbol()
        {
            if (game.GetTurn() == -1)
            {
                // Turn -1 mean that the next player will be
                // the first, so the current player is the second.
                return "X";
            }
            else
            {
                return "O";
            }
        }

        /* Single Game methods. */

        /// <summary>
        /// Start the single game.
        /// </summary>
        private void SingleGameStart()
        {
            game = new TicTacToeCore();
            foreach (Label square in squares)
            {
                UpdateEnabled(square, true);
                UpdateText(square, "");
            }
            if (opponent.Equals(Opponent.Manual))
            {
                player1 = "Player 1";
                player2 = "Player 2";
                UpdateText(messageLabel, "Player 1 make your move!");
            }
            else
            {
                if (first.Equals(First.Me))
                {
                    player1 = "You";
                    player2 = opponent.ToString();
                    UpdateText(messageLabel, "Make your moves!");
                }
                else
                {
                    player1 = opponent.ToString();
                    player2 = "You";
                    initializeAI(opponent, -1);
                    aiMove();
                }
            }
        }

        /// <summary>
        /// Initialize the AI strategy.
        /// Given an opponent, this method load the related
        /// strategy. The integer parameter "square" represent the
        /// first move of the player. If the AI should be the fist
        /// to move, than square must be equals -1.
        /// </summary>
        /// <param name="opponent">The current opponent AI.</param>
        /// <param name="square">The first move of the player,
        /// if it is the case</param>
        private void initializeAI(Opponent opponent, int square)
        {
            switch (opponent)
            {
                case Opponent.Manual:
                    // Player VS player, nothing to load.
                    break;
                case Opponent.Sheldon:
                    initSheldonAI(square);
                    break;
                case Opponent.Penny:
                    initPennyAI();
                    break;
                case Opponent.Stuart:
                    initStuartAI();
                    break;
                case Opponent.Empty:
                    // Nothing to load.
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Initialize the AI for Sheldon, the perfect player.
        /// The user cannot win.
        /// Sheldon expoit MiniMax search strategy.
        /// </summary>
        /// <param name="square"></param>
        private void initSheldonAI(int square)
        {
            if (square != -1)
            {
                strategy = new TicTacToeMinMaxStrategy(game.GetBoard(),
                    new SharpSearch.MinMaxDecision(square, SharpSearch.MiniMax.Max));
            }
            else
            {
                strategy = new TicTacToeMinMaxStrategy(game.GetBoard(),
                    new SharpSearch.MinMaxDecision(null, SharpSearch.MiniMax.Max));
            }
        }

        /// <summary>
        /// Initialize the AI for Penny, a suboptimal player.
        /// </summary>
        private void initPennyAI()
        {
            if (first.Equals(First.Opponent))
            {
                strategy = new TicTacToeSimpleStrategy(game.GetBoard(), -1);
            }
            else
            {
                strategy = new TicTacToeSimpleStrategy(game.GetBoard(), 1);
            }

        }

        /// <summary>
        /// Initialize the AI for Stuart, a suboptimal player.
        /// </summary>
        private void initStuartAI()
        {
            if (first.Equals(First.Opponent))
            {
                strategy = new TicTacToeBetterSimpleStrategy(game.GetBoard(), -1);
            }
            else
            {
                strategy = new TicTacToeBetterSimpleStrategy(game.GetBoard(), 1);
            }

        }

        /// <summary>
        /// Executes an AI move based on the related strategy.
        /// </summary>
        private void aiMove()
        {
            // The AI make his move, return the related square index.
            int square = strategy.OwnMove();
            if (game.Move(square))
            {
                // The Ai move is valid, update the board.
                Label label = indexToLabel(square);
                UpdateText(label, playerSymbol());
                switch (game.CheckForWinner())
                {
                    case -2:
                        UpdateText(messageLabel, player1 + " won!");
                        stopSingleGame();
                        UpdateText(singleGameButton, "Reset");
                        break;
                    case 2:
                        UpdateText(messageLabel, player2 + " won!");
                        stopSingleGame();
                        UpdateText(singleGameButton, "Reset");
                        break;
                    case 1:
                        UpdateText(messageLabel, "This match is a draw!");
                        stopSingleGame();
                        UpdateText(singleGameButton, "Reset");
                        break;
                    default:
                        UpdateText(messageLabel, "Make your moves!");
                        break;
                }
            }
            else
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Auxiliary method to alternate the AI moves within a single game.
        /// </summary>
        private void aiMove(
            TicTacToeStrategy strategy1,
            TicTacToeStrategy strategy2,
            int turn)
        {
            if (turn == -1)
            {
                aiMove(strategy1, strategy2);
            }
            else
            {
                aiMove(strategy2, strategy1);
            }
        }

        /// <summary>
        /// Executes an AI move and update the opponent AI strategy.
        /// </summary>
        /// <param name="strategy1">The AI who moves.</param>
        /// <param name="strategy2">The opponent AI.</param>
        private void aiMove(
            TicTacToeStrategy strategy1,
            TicTacToeStrategy strategy2)
        {
            // The AI make his move, return the related square index.
            int square = strategy1.OwnMove();
            if (game.Move(square))
            {
                // The Ai move is valid, update the board.
                strategy2.OpponentMove(square);
            }
            else
            {
                throw new Exception();
            }
        }

        private void stopSingleGame()
        {
            foreach (Label square in squares)
            {
                UpdateEnabled(square, false);
            }
        }

        /// <summary>
        /// Reset data and gui elements for the single game mode.
        /// </summary>
        private void resetSingleGame()
        {
            stopSingleGame();
            clearBoard();
            UpdateText(messageLabel, "");
            firstMove = true;
            player1 = "";
            player2 = "";
            return;
        }

        /// <summary>
        /// Clear the game board gui.
        /// </summary>
        private void clearBoard()
        {
            foreach (Label square in squares)
            {
                UpdateText(square, "");
            }
        }

        /// <summary>
        /// Given an index of the board returns the board square label.
        /// </summary>
        /// <param name="label">An index of the board representation.</param>
        /// <returns>The board square label</returns>
        private Label indexToLabel(int index)
        {
            Label label = null; ;
            switch (index)
            {
                case 0:
                    label = square0;
                    break;
                case 1:
                    label = square1;
                    break;
                case 2:
                    label = square2;
                    break;
                case 3:
                    label = square3;
                    break;
                case 4:
                    label = square4;
                    break;
                case 5:
                    label = square5;
                    break;
                case 6:
                    label = square6;
                    break;
                case 7:
                    label = square7;
                    break;
                case 8:
                    label = square8;
                    break;
                default:
                    break;
            }
            return label;
        }

        /// <summary>
        /// Given a label representing a square of the game board
        /// this method returns the square index.
        /// </summary>
        /// <param name="label">The board square label.</param>
        /// <returns>The index of the board representation.</returns>
        private int labelToIndex(Label label)
        {
            if (label.Name == "square0")
            {
                return 0;
            }
            else if (label.Name == "square1")
            {
                return 1;
            }
            else if (label.Name == "square2")
            {
                return 2;
            }
            else if (label.Name == "square3")
            {
                return 3;
            }
            else if (label.Name == "square4")
            {
                return 4;
            }
            else if (label.Name == "square5")
            {
                return 5;
            }
            else if (label.Name == "square6")
            {
                return 6;
            }
            else if (label.Name == "square7")
            {
                return 7;
            }
            else if (label.Name == "square8")
            {
                return 8;
            }
            else
            {
                return -1;
            }
        }

        /* Game streak methods. */

        /// <summary>
        /// Start the game streak.
        /// </summary>
        private void MultiGameStart()
        {
            // Init new data.
            UpdateText(messageTestsLabel, "");
            game = new TicTacToeCore();
            p1Wins = 0;
            p2Wins = 0;
            draws = 0;
            streakEnded = false;
            matchesLeft = totalMatches;
            InitStatisticsDelegate initStats =
                new InitStatisticsDelegate(InitStatistics);
            this.Invoke(initStats, totalMatches);

            strategy1 = initializeAI(aiPlayer1, -1);
            strategy2 = initializeAI(aiPlayer2, 1);

            // Get ready to show progress asynchronously
            ShowProgressDelegate showProgress =
              new ShowProgressDelegate(ShowProgress);

            // Play the matches
            while (matchesLeft > 0)
            {
                matchesLeft--;
                // Initialize a new game.
                game = new TicTacToeCore();
                strategy1.Reset();
                strategy2.Reset();
                int result = playSingleMatch(strategy1, strategy2);
                // Show progress
                this.Invoke(showProgress,
                  new object[] { result });
            }
            streakEnded = true;
            UpdateText(multiGameButton, "Reset");
            // Update the results.
            UpdateResultsDelegate updateResults =
                new UpdateResultsDelegate(UpdateResults);
            this.Invoke(updateResults, new object[] { matchesLeft });
        }

        /// <summary>
        /// Implements a single match among two AI player.
        /// </summary>
        private int playSingleMatch(
            TicTacToeStrategy strategy1,
            TicTacToeStrategy strategy2)
        {
            int turn = -1;
            int result = 0;
            do
            {
                aiMove(strategy1, strategy2, turn);
                turn *= -1;
            } while (!game.End());
            switch (game.CheckForWinner())
            {
                case -2:
                    p1Wins++;
                    result = -2;
                    break;
                case 2:
                    p2Wins++;
                    result = 2;
                    break;
                case 1:
                    draws++;
                    result = 1;
                    break;
                default:
                    break;
            }
            return result;
        }

        /// <summary>
        /// Initialize the AI strategy for the AI vs AI game.
        /// </summary>
        private TicTacToeStrategy initializeAI(AI aiPlayer, int turn)
        {
            TicTacToeStrategy result = null;
            switch (aiPlayer)
            {
                case AI.Sheldon:
                    result = new TicTacToeMinMaxStrategy(turn);
                    break;
                case AI.Penny:
                    result = new TicTacToeSimpleStrategy(game.GetBoard(), turn);
                    break;
                case AI.Stuart:
                    result = new TicTacToeBetterSimpleStrategy(game.GetBoard(), turn);
                    break;
                default:
                    break;
            }
            return result;
        }

        /* Event handlers for the single game mode. */

        /// <summary>
        /// The player click a label to choose a square. This is his next move.
        /// </summary>
        private void square_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            int square = labelToIndex(clickedLabel);
            if (square == -1)
            {
                MessageBox.Show("Error", "An Error occourred! We're Sorry...");
            }
            else if (game.Move(square))
            {
                // The move is valid, set the symbol on the square.
                UpdateText(clickedLabel, playerSymbol());
                // Check for a winner.
                switch (game.CheckForWinner())
                {
                    case -2:
                        UpdateText(messageLabel, player1 + " won!");
                        stopSingleGame();
                        UpdateText(singleGameButton, "Reset");
                        break;
                    case 2:
                        UpdateText(messageLabel, player2 + " won!");
                        stopSingleGame();
                        UpdateText(singleGameButton, "Reset");
                        break;
                    case 1:
                        UpdateText(messageLabel, "This match is a draw!");
                        stopSingleGame();
                        UpdateText(singleGameButton, "Reset");
                        break;
                    default:
                        if (opponent.Equals(Opponent.Manual))
                        {
                            UpdateText(messageLabel, "Player " + playerTurn() +
                                " make your move!");
                        }
                        else
                        {
                            if (firstMove)
                            {
                                firstMove = false;
                                // Initialize the AI strategy.
                                initializeAI(opponent, square);
                            }
                            else
                            {
                                strategy.OpponentMove(square);
                            }
                            aiMove();
                        }
                        break;
                }
            }
            else
            {
                UpdateText(messageLabel, "Occupied square, try again!");
            }
            return;
        }

        /// <summary>
        /// Returns the string representing the current player for output
        /// purpose. This methos assume that the current player has not already
        /// made his move.
        /// </summary>
        /// <returns>A display string representing the current player.</returns>
        private string playerTurn()
        {
            if (game.GetTurn() == -1)
            {
                return "1";
            }
            else
            {
                return "2";
            }
        }

        /// <summary>
        /// The player click the button to start the single game.
        /// </summary>
        private void singleGameButton_Click(object sender, EventArgs e)
        {
            if (singleButtonState.Equals(ButtonState.Start))
            {
                singleButtonState = switchButtonState(
                    singleButtonState,
                    singleGameButton);
                singleGameThread = new Thread(new ThreadStart(SingleGameStart));
                singleGameThread.Start();
            }
            else
            {
                singleButtonState = switchButtonState(
                    singleButtonState,
                    singleGameButton);
                singleGameThread.Abort();
                resetSingleGame();
            }
        }

        /// <summary>
        /// The player select the opponent in the single game.
        /// </summary>
        private void selectOpponentBox_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (Enum.TryParse<Opponent>(selectOpponentBox.SelectedItem.ToString(),
                    true, out opponent))
            {
                switch (opponent)
                {
                    case Opponent.Manual:
                        UpdateText(descriptionLabel, "Player VS Player mode. ");
                        break;
                    case Opponent.Sheldon:
                        UpdateText(descriptionLabel, "You know, Sheldon is too"
                            + " smart for anyone. You can just draw a match"
                            + " against him, if You are good enough! ");
                        break;
                    case Opponent.Penny:
                        UpdateText(descriptionLabel, "Ok, Penny is not the best"
                        + " player, but don't underestimate her. ");
                        break;
                    case Opponent.Stuart:
                        UpdateText(descriptionLabel, "Stuart is not the smarter"
                        + " player, more aggressive than Penny, but still beatable. ");
                        break;
                    default:
                        UpdateText(messageLabel, "A problem occoured,"
                        + " please chose the opponent again");
                        break;
                }
            }
            else
            {
                opponent = Opponent.Empty;
                UpdateText(messageLabel, "A problem occoured, please choose" +
                    " the opponent again.");
            }
        }

        /// <summary>
        /// The player select who move first in the next single game.
        /// </summary>
        private void firstToMoveBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstToMoveBox.SelectedItem != null)
            {
                if (Enum.TryParse<First>(firstToMoveBox.SelectedItem.ToString(),
                    true, out first))
                {
                    switch (first)
                    {
                        case First.Me:
                            break;
                        case First.Opponent:
                            break;
                        default:
                            first = First.Empty;
                            UpdateText(messageLabel, 
                                "A problem occoured, please choose" +
                                " the first to move again.");
                            break;
                    }
                }
            }
            else
            {
                first = First.Empty;
            }
        }

        /* Event handlers for the game streak test mode. */

        /// <summary>
        /// The user click the button to start the tests.
        /// </summary>
        private void multiGameButton_Click(object sender, EventArgs e)
        {
            if (multiButtonState.Equals(ButtonState.Start))
            {
                if (aiPlayer1 == AI.Empty || aiPlayer2 == AI.Empty)
                {
                    UpdateText(messageTestsLabel, "Please select both opponents.");
                }
                else if (totalMatches == 0 || totalMatches > 100000)
                {
                    UpdateText(messageTestsLabel,
                       "Please insert a valid number " +
                       "of matches (1-100000).");
                }
                else
                {
                    multiButtonState = switchButtonState(   
                        multiButtonState, multiGameButton);
                    multiGameThread = new Thread(new ThreadStart(MultiGameStart));
                    multiGameThread.Start();
                }
               
            }
            else if (streakEnded)
            {
                resetMultiGame();
                resetMultiGameStats();
                multiButtonState = switchButtonState(
                    multiButtonState,
                    multiGameButton);
            }
            else
            {
                multiGameThread.Abort();
                streakEnded = true;
                UpdateText(messageTestsLabel, "");
                UpdateText(multiGameButton, "Reset");
            }
        }

        /// <summary>
        /// Resets game streak mode statistics.
        /// </summary>
        private void resetMultiGameStats()
        {
            totalGameProgress.Value = 0;
            progressP1.Value = 0;
            progressP2.Value = 0;
            progressDraws.Value = 0;

            UpdateText(statisticsLabel, "");
        }

        /// <summary>
        /// Resets game streak mode data. 
        /// </summary>
        private void resetMultiGame()
        {
            UpdateText(messageTestsLabel, "");
            player1Box.SelectedItem = null;
            aiPlayer1 = AI.Empty;
            player2Box.SelectedItem = null;
            aiPlayer2 = AI.Empty;
            numberOfMatchesBox.Value = 1;
        }

        /// <summary>
        /// The user selects the first player for the test.
        /// </summary>
        private void player1Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (player1Box.SelectedItem != null)
            {
                if (Enum.TryParse<AI>(player1Box.SelectedItem.ToString(),
                    true, out aiPlayer1))
                {
                    switch (aiPlayer1)
                    {
                        case AI.Sheldon:
                            break;
                        case AI.Penny:
                            break;
                        case AI.Stuart:
                            break;
                        default:
                            UpdateText(messageLabel, "A problem occoured,"
                            + " please chose the opponent again");
                            break;
                    }
                }
                else
                {
                    aiPlayer1 = AI.Empty;
                    UpdateText(messageLabel, "A problem occoured,"
                            + " please chose the opponent again");
                }
            }
        }

        /// <summary>
        /// The user selects the second player for the test.
        /// </summary>
        private void player2Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (player2Box.SelectedItem != null)
            {
                if (Enum.TryParse<AI>(player2Box.SelectedItem.ToString(),
                    true, out aiPlayer2))
                {
                    switch (aiPlayer2)
                    {
                        case AI.Sheldon:
                            break;
                        case AI.Penny:
                            break;
                        case AI.Stuart:
                            break;
                        default:
                            UpdateText(messageLabel, "A problem occoured,"
                            + " please chose the opponent again");
                            break;
                    }
                }
                else
                {
                    aiPlayer2 = AI.Empty;
                    UpdateText(messageLabel, "A problem occoured,"
                            + " please chose the opponent again");
                }
            }
        }

        /// <summary>
        /// The user selects the number of match to be played.
        /// </summary>
        private void numberOfMatchesBox_ValueChanged(object sender, EventArgs e)
        {
            totalMatches = (int)numberOfMatchesBox.Value;
        }

    }
}
