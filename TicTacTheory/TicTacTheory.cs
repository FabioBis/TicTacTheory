using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

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

        /// <summary>
        /// Constructor.
        /// </summary>
        public TicTacTheory()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Switch the state of a given button.
        /// 
        /// Usage:
        /// <code>buttonStateOut = switchButtonState(buttonStateIn);</code>
        /// </summary>
        /// <param name="state">The input button state.</param>
        /// <returns>The opposite input button state.</returns>
        private ButtonState switchButtonState(ButtonState state)
        {
            if (state.Equals(ButtonState.Start))
            {
                return ButtonState.Stop;
            }
            else
            {
                return ButtonState.Start;
            }
        }

        /* Single Game methods. */

        /// <summary>
        /// Start the single game.
        /// </summary>
        private void SingleGameStart()
        {
            // TODO
        }

        /* Game streak methods. */

        /// <summary>
        /// Start the single game.
        /// </summary>
        private void MultiGameStart()
        {
            // TODO
        }

        /* Event handlers for the single game mode. */

        /// <summary>
        /// The player click a label to choose a square. This is his next move.
        /// </summary>
        private void square_Click(object sender, EventArgs e)
        {
            // TODO
        }

        /// <summary>
        /// The player click the button to start the single game.
        /// </summary>
        private void singleGameButton_Click(object sender, EventArgs e)
        {
            if (singleButtonState.Equals(ButtonState.Start))
            {
                singleGameThread = new Thread(new ThreadStart(SingleGameStart));
                singleGameThread.Start();
            }
            else
            {
                singleGameThread.Abort();
            }
            singleButtonState = switchButtonState(singleButtonState);
        }

        /// <summary>
        /// The player select the opponent in the single game.
        /// </summary>
        private void selectOpponentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (multiButtonState.Equals(ButtonState.Start))
            {
                multiGameThread = new Thread(new ThreadStart(MultiGameStart));
                multiGameThread.Start();
            }
            else
            {
                multiGameThread.Abort();
            }
            multiButtonState = switchButtonState(multiButtonState);
        }

        /// <summary>
        /// The player select who move first in the next single game.
        /// </summary>
        private void firtToMoveBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO
        }

        /* Event handlers for the game streak test mode. */

        /// <summary>
        /// The user click the button to start the tests.
        /// </summary>
        private void multiGameButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// The user selects the first player for the test.
        /// </summary>
        private void player1Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO
        }

        /// <summary>
        /// The user selects the second player for the test.
        /// </summary>
        private void player2Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO
        }

        /// <summary>
        /// The user selects the number of match to be played.
        /// </summary>
        private void numberOfMatchesBox_ValueChanged(object sender, EventArgs e)
        {
            // TODO
        }
       
    }
}
