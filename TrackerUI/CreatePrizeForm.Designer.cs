namespace TrackerUI
{
    partial class CreatePrizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
            headerLabel = new Label();
            placeNumberValue = new TextBox();
            placeNumberLabel = new Label();
            placeNameValue = new TextBox();
            placeNameLabel = new Label();
            prizeAmountValue = new TextBox();
            prizeAmountLabel = new Label();
            prizePercentageValue = new TextBox();
            prizePercentageLabel = new Label();
            createPrizeButton = new Button();
            orLabel = new Label();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(21, 19);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(209, 50);
            headerLabel.TabIndex = 24;
            headerLabel.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            placeNumberValue.Location = new Point(267, 99);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(161, 35);
            placeNumberValue.TabIndex = 26;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            placeNumberLabel.ForeColor = SystemColors.MenuHighlight;
            placeNumberLabel.Location = new Point(45, 96);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(189, 37);
            placeNumberLabel.TabIndex = 25;
            placeNumberLabel.Text = "Place Number:";
            // 
            // placeNameValue
            // 
            placeNameValue.Location = new Point(267, 154);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(161, 35);
            placeNameValue.TabIndex = 28;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            placeNameLabel.ForeColor = SystemColors.MenuHighlight;
            placeNameLabel.Location = new Point(45, 151);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(163, 37);
            placeNameLabel.TabIndex = 27;
            placeNameLabel.Text = "Place Name:";
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.Location = new Point(267, 209);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(161, 35);
            prizeAmountValue.TabIndex = 30;
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prizeAmountLabel.ForeColor = SystemColors.MenuHighlight;
            prizeAmountLabel.Location = new Point(45, 206);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(182, 37);
            prizeAmountLabel.TabIndex = 29;
            prizeAmountLabel.Text = "Prize Amount:";
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.Location = new Point(267, 303);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(161, 35);
            prizePercentageValue.TabIndex = 32;
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prizePercentageLabel.ForeColor = SystemColors.MenuHighlight;
            prizePercentageLabel.Location = new Point(45, 300);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(218, 37);
            prizePercentageLabel.TabIndex = 31;
            prizePercentageLabel.Text = "Prize Percentage:";
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createPrizeButton.ForeColor = SystemColors.MenuHighlight;
            createPrizeButton.Location = new Point(21, 372);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(407, 75);
            createPrizeButton.TabIndex = 39;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orLabel.ForeColor = SystemColors.MenuHighlight;
            orLabel.Location = new Point(45, 253);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(64, 37);
            orLabel.TabIndex = 40;
            orLabel.Text = "-or-";
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(469, 472);
            Controls.Add(orLabel);
            Controls.Add(createPrizeButton);
            Controls.Add(prizePercentageValue);
            Controls.Add(prizePercentageLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(prizeAmountLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox placeNumberValue;
        private Label placeNumberLabel;
        private TextBox placeNameValue;
        private Label placeNameLabel;
        private TextBox prizeAmountValue;
        private Label prizeAmountLabel;
        private TextBox prizePercentageValue;
        private Label prizePercentageLabel;
        private Button createPrizeButton;
        private Label orLabel;
    }
}