
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
            this.headerlbl = new System.Windows.Forms.Label();
            this.tournamentNameValueTextBox = new System.Windows.Forms.TextBox();
            this.tournamentNameLbl = new System.Windows.Forms.Label();
            this.entryFeeValueTextBox = new System.Windows.Forms.TextBox();
            this.entryFeeLbl = new System.Windows.Forms.Label();
            this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamLbl = new System.Windows.Forms.Label();
            this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.addTeamBtn = new System.Windows.Forms.Button();
            this.createPrizeBtn = new System.Windows.Forms.Button();
            this.tournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.tournamentPlayersLbl = new System.Windows.Forms.Label();
            this.deleteSelectedPlayerBtn = new System.Windows.Forms.Button();
            this.deleteSelectedPrizeBtn = new System.Windows.Forms.Button();
            this.prizesLbl = new System.Windows.Forms.Label();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.createTournamentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerlbl
            // 
            this.headerlbl.AutoSize = true;
            this.headerlbl.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerlbl.Location = new System.Drawing.Point(27, 31);
            this.headerlbl.Name = "headerlbl";
            this.headerlbl.Size = new System.Drawing.Size(411, 65);
            this.headerlbl.TabIndex = 1;
            this.headerlbl.Text = "Create Tournament";
            this.headerlbl.Click += new System.EventHandler(this.headerlbl_Click);
            // 
            // tournamentNameValueTextBox
            // 
            this.tournamentNameValueTextBox.Location = new System.Drawing.Point(38, 161);
            this.tournamentNameValueTextBox.Name = "tournamentNameValueTextBox";
            this.tournamentNameValueTextBox.Size = new System.Drawing.Size(437, 43);
            this.tournamentNameValueTextBox.TabIndex = 10;
            // 
            // tournamentNameLbl
            // 
            this.tournamentNameLbl.AutoSize = true;
            this.tournamentNameLbl.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tournamentNameLbl.Location = new System.Drawing.Point(30, 113);
            this.tournamentNameLbl.Name = "tournamentNameLbl";
            this.tournamentNameLbl.Size = new System.Drawing.Size(290, 45);
            this.tournamentNameLbl.TabIndex = 9;
            this.tournamentNameLbl.Text = "Tournament Name";
            // 
            // entryFeeValueTextBox
            // 
            this.entryFeeValueTextBox.Location = new System.Drawing.Point(189, 238);
            this.entryFeeValueTextBox.Name = "entryFeeValueTextBox";
            this.entryFeeValueTextBox.Size = new System.Drawing.Size(131, 43);
            this.entryFeeValueTextBox.TabIndex = 12;
            this.entryFeeValueTextBox.Text = "0";
            // 
            // entryFeeLbl
            // 
            this.entryFeeLbl.AutoSize = true;
            this.entryFeeLbl.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryFeeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.entryFeeLbl.Location = new System.Drawing.Point(30, 235);
            this.entryFeeLbl.Name = "entryFeeLbl";
            this.entryFeeLbl.Size = new System.Drawing.Size(153, 45);
            this.entryFeeLbl.TabIndex = 11;
            this.entryFeeLbl.Text = "Entry Fee";
            // 
            // selectTeamDropDown
            // 
            this.selectTeamDropDown.FormattingEnabled = true;
            this.selectTeamDropDown.Location = new System.Drawing.Point(38, 342);
            this.selectTeamDropDown.Name = "selectTeamDropDown";
            this.selectTeamDropDown.Size = new System.Drawing.Size(437, 45);
            this.selectTeamDropDown.TabIndex = 14;
            // 
            // selectTeamLbl
            // 
            this.selectTeamLbl.AutoSize = true;
            this.selectTeamLbl.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.selectTeamLbl.Location = new System.Drawing.Point(30, 294);
            this.selectTeamLbl.Name = "selectTeamLbl";
            this.selectTeamLbl.Size = new System.Drawing.Size(191, 45);
            this.selectTeamLbl.TabIndex = 13;
            this.selectTeamLbl.Text = "Select Team";
            // 
            // createNewTeamLink
            // 
            this.createNewTeamLink.AutoSize = true;
            this.createNewTeamLink.Location = new System.Drawing.Point(314, 300);
            this.createNewTeamLink.Name = "createNewTeamLink";
            this.createNewTeamLink.Size = new System.Drawing.Size(161, 38);
            this.createNewTeamLink.TabIndex = 15;
            this.createNewTeamLink.TabStop = true;
            this.createNewTeamLink.Text = "Create New";
            // 
            // addTeamBtn
            // 
            this.addTeamBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addTeamBtn.Location = new System.Drawing.Point(38, 425);
            this.addTeamBtn.Name = "addTeamBtn";
            this.addTeamBtn.Size = new System.Drawing.Size(437, 53);
            this.addTeamBtn.TabIndex = 16;
            this.addTeamBtn.Text = "Add Team";
            this.addTeamBtn.UseVisualStyleBackColor = true;
            this.addTeamBtn.Click += new System.EventHandler(this.addTeamBtn_Click);
            // 
            // createPrizeBtn
            // 
            this.createPrizeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createPrizeBtn.Location = new System.Drawing.Point(38, 504);
            this.createPrizeBtn.Name = "createPrizeBtn";
            this.createPrizeBtn.Size = new System.Drawing.Size(437, 53);
            this.createPrizeBtn.TabIndex = 17;
            this.createPrizeBtn.Text = "Create Prize";
            this.createPrizeBtn.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersListBox
            // 
            this.tournamentPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentPlayersListBox.FormattingEnabled = true;
            this.tournamentPlayersListBox.ItemHeight = 37;
            this.tournamentPlayersListBox.Location = new System.Drawing.Point(562, 161);
            this.tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            this.tournamentPlayersListBox.Size = new System.Drawing.Size(439, 187);
            this.tournamentPlayersListBox.TabIndex = 18;
            // 
            // tournamentPlayersLbl
            // 
            this.tournamentPlayersLbl.AutoSize = true;
            this.tournamentPlayersLbl.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentPlayersLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tournamentPlayersLbl.Location = new System.Drawing.Point(554, 113);
            this.tournamentPlayersLbl.Name = "tournamentPlayersLbl";
            this.tournamentPlayersLbl.Size = new System.Drawing.Size(224, 45);
            this.tournamentPlayersLbl.TabIndex = 19;
            this.tournamentPlayersLbl.Text = "Teams/Players";
            // 
            // deleteSelectedPlayerBtn
            // 
            this.deleteSelectedPlayerBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedPlayerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedPlayerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedPlayerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPlayerBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedPlayerBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteSelectedPlayerBtn.Location = new System.Drawing.Point(1025, 161);
            this.deleteSelectedPlayerBtn.Name = "deleteSelectedPlayerBtn";
            this.deleteSelectedPlayerBtn.Size = new System.Drawing.Size(200, 95);
            this.deleteSelectedPlayerBtn.TabIndex = 20;
            this.deleteSelectedPlayerBtn.Text = "Delete selected";
            this.deleteSelectedPlayerBtn.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizeBtn
            // 
            this.deleteSelectedPrizeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedPrizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedPrizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedPrizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPrizeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedPrizeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteSelectedPrizeBtn.Location = new System.Drawing.Point(1025, 435);
            this.deleteSelectedPrizeBtn.Name = "deleteSelectedPrizeBtn";
            this.deleteSelectedPrizeBtn.Size = new System.Drawing.Size(200, 92);
            this.deleteSelectedPrizeBtn.TabIndex = 23;
            this.deleteSelectedPrizeBtn.Text = "Delete selected";
            this.deleteSelectedPrizeBtn.UseVisualStyleBackColor = true;
            // 
            // prizesLbl
            // 
            this.prizesLbl.AutoSize = true;
            this.prizesLbl.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizesLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.prizesLbl.Location = new System.Drawing.Point(554, 387);
            this.prizesLbl.Name = "prizesLbl";
            this.prizesLbl.Size = new System.Drawing.Size(103, 45);
            this.prizesLbl.TabIndex = 22;
            this.prizesLbl.Text = "Prizes";
            // 
            // prizesListBox
            // 
            this.prizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 37;
            this.prizesListBox.Location = new System.Drawing.Point(562, 435);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(439, 187);
            this.prizesListBox.TabIndex = 21;
            // 
            // createTournamentBtn
            // 
            this.createTournamentBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTournamentBtn.Location = new System.Drawing.Point(394, 671);
            this.createTournamentBtn.Name = "createTournamentBtn";
            this.createTournamentBtn.Size = new System.Drawing.Size(437, 53);
            this.createTournamentBtn.TabIndex = 24;
            this.createTournamentBtn.Text = "Create Tournament";
            this.createTournamentBtn.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1270, 779);
            this.Controls.Add(this.createTournamentBtn);
            this.Controls.Add(this.deleteSelectedPrizeBtn);
            this.Controls.Add(this.prizesLbl);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.deleteSelectedPlayerBtn);
            this.Controls.Add(this.tournamentPlayersLbl);
            this.Controls.Add(this.tournamentPlayersListBox);
            this.Controls.Add(this.createPrizeBtn);
            this.Controls.Add(this.addTeamBtn);
            this.Controls.Add(this.createNewTeamLink);
            this.Controls.Add(this.selectTeamDropDown);
            this.Controls.Add(this.selectTeamLbl);
            this.Controls.Add(this.entryFeeValueTextBox);
            this.Controls.Add(this.entryFeeLbl);
            this.Controls.Add(this.tournamentNameValueTextBox);
            this.Controls.Add(this.tournamentNameLbl);
            this.Controls.Add(this.headerlbl);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerlbl;
        private System.Windows.Forms.TextBox tournamentNameValueTextBox;
        private System.Windows.Forms.Label tournamentNameLbl;
        private System.Windows.Forms.TextBox entryFeeValueTextBox;
        private System.Windows.Forms.Label entryFeeLbl;
        private System.Windows.Forms.ComboBox selectTeamDropDown;
        private System.Windows.Forms.Label selectTeamLbl;
        private System.Windows.Forms.LinkLabel createNewTeamLink;
        private System.Windows.Forms.Button addTeamBtn;
        private System.Windows.Forms.Button createPrizeBtn;
        private System.Windows.Forms.ListBox tournamentPlayersListBox;
        private System.Windows.Forms.Label tournamentPlayersLbl;
        private System.Windows.Forms.Button deleteSelectedPlayerBtn;
        private System.Windows.Forms.Button deleteSelectedPrizeBtn;
        private System.Windows.Forms.Label prizesLbl;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Button createTournamentBtn;
    }
}