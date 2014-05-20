namespace TicTacTheory
{
    partial class TicTacTheory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacTheory));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.singleGamePage = new System.Windows.Forms.TabPage();
            this.controlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.messageLabel = new System.Windows.Forms.Label();
            this.singleGameButton = new System.Windows.Forms.Button();
            this.settingGamePanel = new System.Windows.Forms.TableLayoutPanel();
            this.selectOpponentLabel = new System.Windows.Forms.Label();
            this.selectOpponentBox = new System.Windows.Forms.ComboBox();
            this.firtToMoveLabel = new System.Windows.Forms.Label();
            this.firstToMoveBox = new System.Windows.Forms.ComboBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.gameBoardPanel = new System.Windows.Forms.TableLayoutPanel();
            this.square8 = new System.Windows.Forms.Label();
            this.square7 = new System.Windows.Forms.Label();
            this.square6 = new System.Windows.Forms.Label();
            this.square5 = new System.Windows.Forms.Label();
            this.square4 = new System.Windows.Forms.Label();
            this.square3 = new System.Windows.Forms.Label();
            this.square2 = new System.Windows.Forms.Label();
            this.square1 = new System.Windows.Forms.Label();
            this.square0 = new System.Windows.Forms.Label();
            this.testAIPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.progressDraws = new System.Windows.Forms.ProgressBar();
            this.player2Box = new System.Windows.Forms.ComboBox();
            this.explainMultiGameBox = new System.Windows.Forms.RichTextBox();
            this.player1Label = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.player1Box = new System.Windows.Forms.ComboBox();
            this.numberOfMatchesBox = new System.Windows.Forms.NumericUpDown();
            this.multiGameButton = new System.Windows.Forms.Button();
            this.totalGameProgress = new System.Windows.Forms.ProgressBar();
            this.labelTotalProgress = new System.Windows.Forms.Label();
            this.labelP1Victories = new System.Windows.Forms.Label();
            this.labelP2Victories = new System.Windows.Forms.Label();
            this.labelDraws = new System.Windows.Forms.Label();
            this.progressP1 = new System.Windows.Forms.ProgressBar();
            this.progressP2 = new System.Windows.Forms.ProgressBar();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.messageTestsLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.singleGamePage.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.settingGamePanel.SuspendLayout();
            this.gameBoardPanel.SuspendLayout();
            this.testAIPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfMatchesBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl.Controls.Add(this.singleGamePage);
            this.tabControl.Controls.Add(this.testAIPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(340, 568);
            this.tabControl.TabIndex = 0;
            // 
            // singleGamePage
            // 
            this.singleGamePage.BackColor = System.Drawing.Color.SteelBlue;
            this.singleGamePage.Controls.Add(this.controlPanel);
            this.singleGamePage.Controls.Add(this.settingGamePanel);
            this.singleGamePage.Controls.Add(this.gameBoardPanel);
            this.singleGamePage.Location = new System.Drawing.Point(4, 25);
            this.singleGamePage.Name = "singleGamePage";
            this.singleGamePage.Padding = new System.Windows.Forms.Padding(3);
            this.singleGamePage.Size = new System.Drawing.Size(332, 539);
            this.singleGamePage.TabIndex = 0;
            this.singleGamePage.Text = "The Game";
            // 
            // controlPanel
            // 
            this.controlPanel.ColumnCount = 2;
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlPanel.Controls.Add(this.messageLabel, 0, 0);
            this.controlPanel.Controls.Add(this.singleGameButton, 0, 1);
            this.controlPanel.Location = new System.Drawing.Point(11, 448);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.RowCount = 2;
            this.controlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlPanel.Size = new System.Drawing.Size(308, 85);
            this.controlPanel.TabIndex = 1;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.controlPanel.SetColumnSpan(this.messageLabel, 2);
            this.messageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.messageLabel.Location = new System.Drawing.Point(3, 5);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(302, 32);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // singleGameButton
            // 
            this.singleGameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.controlPanel.SetColumnSpan(this.singleGameButton, 2);
            this.singleGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleGameButton.Location = new System.Drawing.Point(80, 45);
            this.singleGameButton.Name = "singleGameButton";
            this.singleGameButton.Size = new System.Drawing.Size(148, 37);
            this.singleGameButton.TabIndex = 1;
            this.singleGameButton.Text = "Start";
            this.singleGameButton.UseVisualStyleBackColor = true;
            this.singleGameButton.Click += new System.EventHandler(this.singleGameButton_Click);
            // 
            // settingGamePanel
            // 
            this.settingGamePanel.ColumnCount = 3;
            this.settingGamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.settingGamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.settingGamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.settingGamePanel.Controls.Add(this.selectOpponentLabel, 0, 0);
            this.settingGamePanel.Controls.Add(this.selectOpponentBox, 2, 0);
            this.settingGamePanel.Controls.Add(this.firtToMoveLabel, 0, 1);
            this.settingGamePanel.Controls.Add(this.firstToMoveBox, 2, 1);
            this.settingGamePanel.Controls.Add(this.descriptionLabel, 0, 2);
            this.settingGamePanel.Location = new System.Drawing.Point(11, 6);
            this.settingGamePanel.Name = "settingGamePanel";
            this.settingGamePanel.RowCount = 3;
            this.settingGamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.settingGamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.settingGamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settingGamePanel.Size = new System.Drawing.Size(308, 120);
            this.settingGamePanel.TabIndex = 1;
            // 
            // selectOpponentLabel
            // 
            this.selectOpponentLabel.AutoSize = true;
            this.settingGamePanel.SetColumnSpan(this.selectOpponentLabel, 2);
            this.selectOpponentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectOpponentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectOpponentLabel.Location = new System.Drawing.Point(3, 0);
            this.selectOpponentLabel.Name = "selectOpponentLabel";
            this.selectOpponentLabel.Size = new System.Drawing.Size(194, 24);
            this.selectOpponentLabel.TabIndex = 0;
            this.selectOpponentLabel.Text = "Select your opponent: ";
            this.selectOpponentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // selectOpponentBox
            // 
            this.selectOpponentBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectOpponentBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectOpponentBox.FormattingEnabled = true;
            this.selectOpponentBox.Items.AddRange(new object[] {
            "Manual",
            "Sheldon",
            "Penny",
            "Stuart"});
            this.selectOpponentBox.Location = new System.Drawing.Point(203, 3);
            this.selectOpponentBox.Name = "selectOpponentBox";
            this.selectOpponentBox.Size = new System.Drawing.Size(102, 21);
            this.selectOpponentBox.TabIndex = 1;
            this.selectOpponentBox.SelectedIndexChanged += new System.EventHandler(this.selectOpponentBox_SelectedIndexChanged);
            // 
            // firtToMoveLabel
            // 
            this.firtToMoveLabel.AutoSize = true;
            this.settingGamePanel.SetColumnSpan(this.firtToMoveLabel, 2);
            this.firtToMoveLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firtToMoveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firtToMoveLabel.Location = new System.Drawing.Point(3, 24);
            this.firtToMoveLabel.Name = "firtToMoveLabel";
            this.firtToMoveLabel.Size = new System.Drawing.Size(194, 24);
            this.firtToMoveLabel.TabIndex = 2;
            this.firtToMoveLabel.Text = "Who move first?";
            this.firtToMoveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // firstToMoveBox
            // 
            this.firstToMoveBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstToMoveBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.firstToMoveBox.FormattingEnabled = true;
            this.firstToMoveBox.Items.AddRange(new object[] {
            "Me",
            "Opponent"});
            this.firstToMoveBox.Location = new System.Drawing.Point(203, 27);
            this.firstToMoveBox.Name = "firstToMoveBox";
            this.firstToMoveBox.Size = new System.Drawing.Size(102, 21);
            this.firstToMoveBox.TabIndex = 3;
            this.firstToMoveBox.SelectedIndexChanged += new System.EventHandler(this.firstToMoveBox_SelectedIndexChanged);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.BackColor = System.Drawing.Color.White;
            this.descriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.settingGamePanel.SetColumnSpan(this.descriptionLabel, 3);
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(3, 54);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(302, 63);
            this.descriptionLabel.TabIndex = 4;
            // 
            // gameBoardPanel
            // 
            this.gameBoardPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.gameBoardPanel.ColumnCount = 3;
            this.gameBoardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.gameBoardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.gameBoardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.gameBoardPanel.Controls.Add(this.square8, 2, 2);
            this.gameBoardPanel.Controls.Add(this.square7, 1, 2);
            this.gameBoardPanel.Controls.Add(this.square6, 0, 2);
            this.gameBoardPanel.Controls.Add(this.square5, 2, 1);
            this.gameBoardPanel.Controls.Add(this.square4, 1, 1);
            this.gameBoardPanel.Controls.Add(this.square3, 0, 1);
            this.gameBoardPanel.Controls.Add(this.square2, 2, 0);
            this.gameBoardPanel.Controls.Add(this.square1, 1, 0);
            this.gameBoardPanel.Controls.Add(this.square0, 0, 0);
            this.gameBoardPanel.Location = new System.Drawing.Point(8, 133);
            this.gameBoardPanel.Name = "gameBoardPanel";
            this.gameBoardPanel.RowCount = 3;
            this.gameBoardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.gameBoardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.gameBoardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.gameBoardPanel.Size = new System.Drawing.Size(316, 312);
            this.gameBoardPanel.TabIndex = 0;
            // 
            // square8
            // 
            this.square8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.square8.Enabled = false;
            this.square8.Font = new System.Drawing.Font("Verdana", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.square8.Location = new System.Drawing.Point(212, 209);
            this.square8.Name = "square8";
            this.square8.Size = new System.Drawing.Size(112, 100);
            this.square8.TabIndex = 8;
            this.square8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.square8.Click += new System.EventHandler(this.square_Click);
            // 
            // square7
            // 
            this.square7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.square7.Enabled = false;
            this.square7.Font = new System.Drawing.Font("Verdana", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.square7.Location = new System.Drawing.Point(109, 209);
            this.square7.Name = "square7";
            this.square7.Size = new System.Drawing.Size(94, 100);
            this.square7.TabIndex = 7;
            this.square7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.square7.Click += new System.EventHandler(this.square_Click);
            // 
            // square6
            // 
            this.square6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.square6.Enabled = false;
            this.square6.Font = new System.Drawing.Font("Verdana", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.square6.Location = new System.Drawing.Point(6, 209);
            this.square6.Name = "square6";
            this.square6.Size = new System.Drawing.Size(94, 100);
            this.square6.TabIndex = 6;
            this.square6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.square6.Click += new System.EventHandler(this.square_Click);
            // 
            // square5
            // 
            this.square5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.square5.Enabled = false;
            this.square5.Font = new System.Drawing.Font("Verdana", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.square5.Location = new System.Drawing.Point(212, 106);
            this.square5.Name = "square5";
            this.square5.Size = new System.Drawing.Size(112, 100);
            this.square5.TabIndex = 5;
            this.square5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.square5.Click += new System.EventHandler(this.square_Click);
            // 
            // square4
            // 
            this.square4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.square4.Enabled = false;
            this.square4.Font = new System.Drawing.Font("Verdana", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.square4.Location = new System.Drawing.Point(109, 106);
            this.square4.Name = "square4";
            this.square4.Size = new System.Drawing.Size(94, 100);
            this.square4.TabIndex = 4;
            this.square4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.square4.Click += new System.EventHandler(this.square_Click);
            // 
            // square3
            // 
            this.square3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.square3.Enabled = false;
            this.square3.Font = new System.Drawing.Font("Verdana", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.square3.Location = new System.Drawing.Point(6, 106);
            this.square3.Name = "square3";
            this.square3.Size = new System.Drawing.Size(94, 100);
            this.square3.TabIndex = 3;
            this.square3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.square3.Click += new System.EventHandler(this.square_Click);
            // 
            // square2
            // 
            this.square2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.square2.Enabled = false;
            this.square2.Font = new System.Drawing.Font("Verdana", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.square2.Location = new System.Drawing.Point(212, 3);
            this.square2.Name = "square2";
            this.square2.Size = new System.Drawing.Size(112, 100);
            this.square2.TabIndex = 2;
            this.square2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.square2.Click += new System.EventHandler(this.square_Click);
            // 
            // square1
            // 
            this.square1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.square1.Enabled = false;
            this.square1.Font = new System.Drawing.Font("Verdana", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.square1.Location = new System.Drawing.Point(109, 3);
            this.square1.Name = "square1";
            this.square1.Size = new System.Drawing.Size(94, 100);
            this.square1.TabIndex = 1;
            this.square1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.square1.Click += new System.EventHandler(this.square_Click);
            // 
            // square0
            // 
            this.square0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.square0.Enabled = false;
            this.square0.Font = new System.Drawing.Font("Verdana", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.square0.Location = new System.Drawing.Point(6, 3);
            this.square0.Name = "square0";
            this.square0.Size = new System.Drawing.Size(94, 100);
            this.square0.TabIndex = 0;
            this.square0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.square0.Click += new System.EventHandler(this.square_Click);
            // 
            // testAIPage
            // 
            this.testAIPage.BackColor = System.Drawing.Color.SteelBlue;
            this.testAIPage.Controls.Add(this.tableLayoutPanel1);
            this.testAIPage.Location = new System.Drawing.Point(4, 25);
            this.testAIPage.Name = "testAIPage";
            this.testAIPage.Padding = new System.Windows.Forms.Padding(3);
            this.testAIPage.Size = new System.Drawing.Size(332, 539);
            this.testAIPage.TabIndex = 1;
            this.testAIPage.Text = "Test AI";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.Controls.Add(this.progressDraws, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.player2Box, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.explainMultiGameBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.player1Label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.player2Label, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.player1Box, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.numberOfMatchesBox, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.multiGameButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.totalGameProgress, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelTotalProgress, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelP1Victories, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelP2Victories, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.labelDraws, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.progressP1, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.progressP2, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.chart, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.messageTestsLabel, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(318, 525);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // progressDraws
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.progressDraws, 2);
            this.progressDraws.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressDraws.Location = new System.Drawing.Point(109, 343);
            this.progressDraws.Name = "progressDraws";
            this.progressDraws.Size = new System.Drawing.Size(206, 14);
            this.progressDraws.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressDraws.TabIndex = 15;
            // 
            // player2Box
            // 
            this.player2Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player2Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.player2Box.FormattingEnabled = true;
            this.player2Box.Items.AddRange(new object[] {
            "Sheldon",
            "Penny",
            "Stuart"});
            this.player2Box.Location = new System.Drawing.Point(215, 153);
            this.player2Box.Name = "player2Box";
            this.player2Box.Size = new System.Drawing.Size(100, 21);
            this.player2Box.TabIndex = 5;
            this.player2Box.SelectedIndexChanged += new System.EventHandler(this.player2Box_SelectedIndexChanged);
            // 
            // explainMultiGameBox
            // 
            this.explainMultiGameBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.explainMultiGameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.explainMultiGameBox, 3);
            this.explainMultiGameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explainMultiGameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explainMultiGameBox.Location = new System.Drawing.Point(3, 3);
            this.explainMultiGameBox.Name = "explainMultiGameBox";
            this.explainMultiGameBox.ReadOnly = true;
            this.explainMultiGameBox.Size = new System.Drawing.Size(312, 114);
            this.explainMultiGameBox.TabIndex = 0;
            this.explainMultiGameBox.Text = resources.GetString("explainMultiGameBox.Text");
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.player1Label, 2);
            this.player1Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Label.Location = new System.Drawing.Point(3, 125);
            this.player1Label.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(206, 25);
            this.player1Label.TabIndex = 1;
            this.player1Label.Text = "Select AI player 1 (first to play)";
            this.player1Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.player2Label, 2);
            this.player2Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Label.Location = new System.Drawing.Point(3, 150);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(206, 25);
            this.player2Label.TabIndex = 2;
            this.player2Label.Text = "Select AI player 2 (second)";
            this.player2Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type the number of matches";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // player1Box
            // 
            this.player1Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player1Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.player1Box.FormattingEnabled = true;
            this.player1Box.Items.AddRange(new object[] {
            "Sheldon",
            "Penny",
            "Stuart"});
            this.player1Box.Location = new System.Drawing.Point(215, 128);
            this.player1Box.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.player1Box.Name = "player1Box";
            this.player1Box.Size = new System.Drawing.Size(100, 21);
            this.player1Box.TabIndex = 4;
            this.player1Box.SelectedIndexChanged += new System.EventHandler(this.player1Box_SelectedIndexChanged);
            // 
            // numberOfMatchesBox
            // 
            this.numberOfMatchesBox.Location = new System.Drawing.Point(215, 178);
            this.numberOfMatchesBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numberOfMatchesBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfMatchesBox.Name = "numberOfMatchesBox";
            this.numberOfMatchesBox.Size = new System.Drawing.Size(100, 20);
            this.numberOfMatchesBox.TabIndex = 6;
            this.numberOfMatchesBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfMatchesBox.ValueChanged += new System.EventHandler(this.numberOfMatchesBox_ValueChanged);
            // 
            // multiGameButton
            // 
            this.multiGameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.multiGameButton, 3);
            this.multiGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiGameButton.Location = new System.Drawing.Point(89, 209);
            this.multiGameButton.Name = "multiGameButton";
            this.multiGameButton.Size = new System.Drawing.Size(140, 37);
            this.multiGameButton.TabIndex = 7;
            this.multiGameButton.Text = "Start";
            this.multiGameButton.UseVisualStyleBackColor = true;
            this.multiGameButton.Click += new System.EventHandler(this.multiGameButton_Click);
            // 
            // totalGameProgress
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.totalGameProgress, 2);
            this.totalGameProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalGameProgress.Location = new System.Drawing.Point(109, 283);
            this.totalGameProgress.Name = "totalGameProgress";
            this.totalGameProgress.Size = new System.Drawing.Size(206, 14);
            this.totalGameProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.totalGameProgress.TabIndex = 8;
            // 
            // labelTotalProgress
            // 
            this.labelTotalProgress.AutoSize = true;
            this.labelTotalProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotalProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalProgress.Location = new System.Drawing.Point(3, 280);
            this.labelTotalProgress.Name = "labelTotalProgress";
            this.labelTotalProgress.Size = new System.Drawing.Size(100, 20);
            this.labelTotalProgress.TabIndex = 9;
            this.labelTotalProgress.Text = "# Matches";
            // 
            // labelP1Victories
            // 
            this.labelP1Victories.AutoSize = true;
            this.labelP1Victories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelP1Victories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP1Victories.Location = new System.Drawing.Point(3, 300);
            this.labelP1Victories.Name = "labelP1Victories";
            this.labelP1Victories.Size = new System.Drawing.Size(100, 20);
            this.labelP1Victories.TabIndex = 10;
            this.labelP1Victories.Text = "# P1 Victories";
            // 
            // labelP2Victories
            // 
            this.labelP2Victories.AutoSize = true;
            this.labelP2Victories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelP2Victories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP2Victories.Location = new System.Drawing.Point(3, 320);
            this.labelP2Victories.Name = "labelP2Victories";
            this.labelP2Victories.Size = new System.Drawing.Size(100, 20);
            this.labelP2Victories.TabIndex = 11;
            this.labelP2Victories.Text = "# P2 Victories";
            // 
            // labelDraws
            // 
            this.labelDraws.AutoSize = true;
            this.labelDraws.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDraws.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDraws.Location = new System.Drawing.Point(3, 340);
            this.labelDraws.Name = "labelDraws";
            this.labelDraws.Size = new System.Drawing.Size(100, 20);
            this.labelDraws.TabIndex = 12;
            this.labelDraws.Text = "# Draws";
            // 
            // progressP1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.progressP1, 2);
            this.progressP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressP1.Location = new System.Drawing.Point(109, 303);
            this.progressP1.Name = "progressP1";
            this.progressP1.Size = new System.Drawing.Size(206, 14);
            this.progressP1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressP1.TabIndex = 13;
            // 
            // progressP2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.progressP2, 2);
            this.progressP2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressP2.Location = new System.Drawing.Point(109, 323);
            this.progressP2.Name = "progressP2";
            this.progressP2.Size = new System.Drawing.Size(206, 14);
            this.progressP2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressP2.TabIndex = 14;
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.tableLayoutPanel1.SetColumnSpan(this.chart, 3);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(3, 363);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(312, 169);
            this.chart.TabIndex = 16;
            this.chart.Text = "chart1";
            // 
            // messageTestsLabel
            // 
            this.messageTestsLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.messageTestsLabel, 3);
            this.messageTestsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageTestsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageTestsLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.messageTestsLabel.Location = new System.Drawing.Point(3, 250);
            this.messageTestsLabel.Name = "messageTestsLabel";
            this.messageTestsLabel.Size = new System.Drawing.Size(312, 30);
            this.messageTestsLabel.TabIndex = 17;
            this.messageTestsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TicTacTheory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(340, 568);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(350, 600);
            this.MinimumSize = new System.Drawing.Size(350, 600);
            this.Name = "TicTacTheory";
            this.Text = "TicTacTheory";
            this.tabControl.ResumeLayout(false);
            this.singleGamePage.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.settingGamePanel.ResumeLayout(false);
            this.settingGamePanel.PerformLayout();
            this.gameBoardPanel.ResumeLayout(false);
            this.testAIPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfMatchesBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage singleGamePage;
        private System.Windows.Forms.TabPage testAIPage;
        private System.Windows.Forms.TableLayoutPanel gameBoardPanel;
        private System.Windows.Forms.TableLayoutPanel settingGamePanel;
        private System.Windows.Forms.TableLayoutPanel controlPanel;
        private System.Windows.Forms.Label selectOpponentLabel;
        private System.Windows.Forms.ComboBox selectOpponentBox;
        private System.Windows.Forms.Label firtToMoveLabel;
        private System.Windows.Forms.ComboBox firstToMoveBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button singleGameButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox explainMultiGameBox;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox player2Box;
        private System.Windows.Forms.ComboBox player1Box;
        private System.Windows.Forms.NumericUpDown numberOfMatchesBox;
        private System.Windows.Forms.Button multiGameButton;
        private System.Windows.Forms.ProgressBar totalGameProgress;
        private System.Windows.Forms.Label labelTotalProgress;
        private System.Windows.Forms.ProgressBar progressDraws;
        private System.Windows.Forms.Label labelP1Victories;
        private System.Windows.Forms.Label labelP2Victories;
        private System.Windows.Forms.Label labelDraws;
        private System.Windows.Forms.ProgressBar progressP1;
        private System.Windows.Forms.ProgressBar progressP2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label square0;
        private System.Windows.Forms.Label square2;
        private System.Windows.Forms.Label square1;
        private System.Windows.Forms.Label square8;
        private System.Windows.Forms.Label square7;
        private System.Windows.Forms.Label square6;
        private System.Windows.Forms.Label square5;
        private System.Windows.Forms.Label square4;
        private System.Windows.Forms.Label square3;
        private System.Windows.Forms.Label messageTestsLabel;
    }
}

