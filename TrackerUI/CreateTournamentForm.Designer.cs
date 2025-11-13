namespace TrackerUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            addTeamButton = new Button();
            tournamentNameValue = new TextBox();
            tournamentNameLabel = new Label();
            tournamentPlayerListBox = new ListBox();
            selectTeamDropDown = new ComboBox();
            selectTeamLabel = new Label();
            headerLabel = new Label();
            entryFeeValue = new TextBox();
            entryFeeLabel = new Label();
            createNewTeamLink = new LinkLabel();
            createPrizeButton = new Button();
            tournamentPlayersLabel = new Label();
            deleteSelectedPlayerButton = new Button();
            deleteSelectedPrizeButton = new Button();
            prizesLabel = new Label();
            prizesListBox = new ListBox();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addTeamButton.ForeColor = SystemColors.MenuHighlight;
            addTeamButton.Location = new Point(41, 378);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(154, 46);
            addTeamButton.TabIndex = 27;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.Location = new Point(41, 153);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(236, 35);
            tournamentNameValue.TabIndex = 22;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tournamentNameLabel.ForeColor = SystemColors.MenuHighlight;
            tournamentNameLabel.Location = new Point(35, 104);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(242, 37);
            tournamentNameLabel.TabIndex = 21;
            tournamentNameLabel.Text = "Tournament Name:";
            // 
            // tournamentPlayerListBox
            // 
            tournamentPlayerListBox.BorderStyle = BorderStyle.FixedSingle;
            tournamentPlayerListBox.FormattingEnabled = true;
            tournamentPlayerListBox.ItemHeight = 30;
            tournamentPlayerListBox.Location = new Point(471, 132);
            tournamentPlayerListBox.Name = "tournamentPlayerListBox";
            tournamentPlayerListBox.Size = new Size(302, 152);
            tournamentPlayerListBox.TabIndex = 19;
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(41, 318);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(236, 38);
            selectTeamDropDown.TabIndex = 17;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectTeamLabel.ForeColor = SystemColors.MenuHighlight;
            selectTeamLabel.Location = new Point(35, 265);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(162, 37);
            selectTeamLabel.TabIndex = 16;
            selectTeamLabel.Text = "Select Team:";
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(24, 25);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(317, 50);
            headerLabel.TabIndex = 14;
            headerLabel.Text = "Create Tournament";
            // 
            // entryFeeValue
            // 
            entryFeeValue.Location = new Point(172, 212);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(105, 35);
            entryFeeValue.TabIndex = 29;
            entryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entryFeeLabel.ForeColor = SystemColors.MenuHighlight;
            entryFeeLabel.Location = new Point(35, 209);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(131, 37);
            entryFeeLabel.TabIndex = 28;
            entryFeeLabel.Text = "Entry Fee:";
            // 
            // createNewTeamLink
            // 
            createNewTeamLink.AutoSize = true;
            createNewTeamLink.Location = new Point(203, 272);
            createNewTeamLink.Name = "createNewTeamLink";
            createNewTeamLink.Size = new Size(114, 30);
            createNewTeamLink.TabIndex = 30;
            createNewTeamLink.TabStop = true;
            createNewTeamLink.Text = "create new";
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createPrizeButton.ForeColor = SystemColors.MenuHighlight;
            createPrizeButton.Location = new Point(41, 444);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(154, 46);
            createPrizeButton.TabIndex = 31;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersLabel
            // 
            tournamentPlayersLabel.AutoSize = true;
            tournamentPlayersLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tournamentPlayersLabel.ForeColor = SystemColors.MenuHighlight;
            tournamentPlayersLabel.Location = new Point(391, 79);
            tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            tournamentPlayersLabel.Size = new Size(198, 37);
            tournamentPlayersLabel.TabIndex = 32;
            tournamentPlayersLabel.Text = "Teams / Players";
            // 
            // deleteSelectedPlayerButton
            // 
            deleteSelectedPlayerButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPlayerButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedPlayerButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedPlayerButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPlayerButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteSelectedPlayerButton.ForeColor = SystemColors.MenuHighlight;
            deleteSelectedPlayerButton.Location = new Point(595, 77);
            deleteSelectedPlayerButton.Name = "deleteSelectedPlayerButton";
            deleteSelectedPlayerButton.Size = new Size(178, 46);
            deleteSelectedPlayerButton.TabIndex = 33;
            deleteSelectedPlayerButton.Text = "Delete Selected";
            deleteSelectedPlayerButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizeButton
            // 
            deleteSelectedPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteSelectedPrizeButton.ForeColor = SystemColors.MenuHighlight;
            deleteSelectedPrizeButton.Location = new Point(595, 464);
            deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            deleteSelectedPrizeButton.Size = new Size(178, 46);
            deleteSelectedPrizeButton.TabIndex = 36;
            deleteSelectedPrizeButton.Text = "Delete Selected";
            deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prizesLabel.ForeColor = SystemColors.MenuHighlight;
            prizesLabel.Location = new Point(457, 466);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(132, 37);
            prizesLabel.TabIndex = 35;
            prizesLabel.Text = "Prizes List";
            // 
            // prizesListBox
            // 
            prizesListBox.BorderStyle = BorderStyle.FixedSingle;
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 30;
            prizesListBox.Location = new Point(471, 304);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(302, 152);
            prizesListBox.TabIndex = 34;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createTournamentButton.ForeColor = SystemColors.MenuHighlight;
            createTournamentButton.Location = new Point(299, 556);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(222, 75);
            createTournamentButton.TabIndex = 37;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(823, 658);
            Controls.Add(createTournamentButton);
            Controls.Add(deleteSelectedPrizeButton);
            Controls.Add(prizesLabel);
            Controls.Add(prizesListBox);
            Controls.Add(deleteSelectedPlayerButton);
            Controls.Add(tournamentPlayersLabel);
            Controls.Add(createPrizeButton);
            Controls.Add(createNewTeamLink);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(addTeamButton);
            Controls.Add(tournamentNameValue);
            Controls.Add(tournamentNameLabel);
            Controls.Add(tournamentPlayerListBox);
            Controls.Add(selectTeamDropDown);
            Controls.Add(selectTeamLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addTeamButton;
        private TextBox tournamentNameValue;
        private Label tournamentNameLabel;
        private ListBox tournamentPlayerListBox;
        private ComboBox selectTeamDropDown;
        private Label selectTeamLabel;
        private Label headerLabel;
        private TextBox entryFeeValue;
        private Label entryFeeLabel;
        private LinkLabel createNewTeamLink;
        private Button createPrizeButton;
        private Label tournamentPlayersLabel;
        private Button deleteSelectedPlayerButton;
        private Button deleteSelectedPrizeButton;
        private Label prizesLabel;
        private ListBox prizesListBox;
        private Button createTournamentButton;
    }
}