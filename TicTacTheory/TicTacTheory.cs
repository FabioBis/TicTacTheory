using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

    public partial class TicTacTheory : Form
    {
        // Delegators for safe multithread.
        delegate void SingleGameDelegate();
        delegate void MultiGameDelegate();

        /// <summary>
        /// Constructor.
        /// </summary>
        public TicTacTheory()
        {
            InitializeComponent();
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
            SingleGameDelegate singleGame = new SingleGameDelegate(SingleGameStart);
            singleGame.BeginInvoke(null, null);
        }

        /// <summary>
        /// The player select the opponent in the single game.
        /// </summary>
        private void selectOpponentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MultiGameDelegate multiGame = new MultiGameDelegate(MultiGameStart);
            multiGame.BeginInvoke(null, null);
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
