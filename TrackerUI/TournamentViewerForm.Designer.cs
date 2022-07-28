
namespace TrackerUI
{
    partial class TournamentViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            this.headerlbl = new System.Windows.Forms.Label();
            this.tournamentNameLbl = new System.Windows.Forms.Label();
            this.roundLbl = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.unplayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.teamOneNameLbl = new System.Windows.Forms.Label();
            this.teamOneScoreLbl = new System.Windows.Forms.Label();
            this.teamOneScoreValueTextBox = new System.Windows.Forms.TextBox();
            this.teamTwoScoreValueTextBox = new System.Windows.Forms.TextBox();
            this.teamTwoScoreLbl = new System.Windows.Forms.Label();
            this.teamTwoNameLbl = new System.Windows.Forms.Label();
            this.versusLbl = new System.Windows.Forms.Label();
            this.scoreBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerlbl
            // 
            this.headerlbl.AutoSize = true;
            this.headerlbl.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerlbl.Location = new System.Drawing.Point(12, 9);
            this.headerlbl.Name = "headerlbl";
            this.headerlbl.Size = new System.Drawing.Size(278, 65);
            this.headerlbl.TabIndex = 0;
            this.headerlbl.Text = "Tournament:";
            // 
            // tournamentNameLbl
            // 
            this.tournamentNameLbl.AutoSize = true;
            this.tournamentNameLbl.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tournamentNameLbl.Location = new System.Drawing.Point(269, 9);
            this.tournamentNameLbl.Name = "tournamentNameLbl";
            this.tournamentNameLbl.Size = new System.Drawing.Size(201, 65);
            this.tournamentNameLbl.TabIndex = 1;
            this.tournamentNameLbl.Text = "<None>";
            // 
            // roundLbl
            // 
            this.roundLbl.AutoSize = true;
            this.roundLbl.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.roundLbl.Location = new System.Drawing.Point(23, 91);
            this.roundLbl.Name = "roundLbl";
            this.roundLbl.Size = new System.Drawing.Size(115, 45);
            this.roundLbl.TabIndex = 2;
            this.roundLbl.Text = "Round";
            // 
            // roundDropDown
            // 
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(146, 91);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(302, 45);
            this.roundDropDown.TabIndex = 3;
            // 
            // unplayedOnlyCheckBox
            // 
            this.unplayedOnlyCheckBox.AutoSize = true;
            this.unplayedOnlyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unplayedOnlyCheckBox.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unplayedOnlyCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.unplayedOnlyCheckBox.Location = new System.Drawing.Point(146, 142);
            this.unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            this.unplayedOnlyCheckBox.Size = new System.Drawing.Size(253, 49);
            this.unplayedOnlyCheckBox.TabIndex = 4;
            this.unplayedOnlyCheckBox.Text = "Unplayed Only";
            this.unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 37;
            this.matchupListBox.Location = new System.Drawing.Point(31, 207);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(439, 298);
            this.matchupListBox.TabIndex = 5;
            // 
            // teamOneNameLbl
            // 
            this.teamOneNameLbl.AutoSize = true;
            this.teamOneNameLbl.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamOneNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamOneNameLbl.Location = new System.Drawing.Point(487, 207);
            this.teamOneNameLbl.Name = "teamOneNameLbl";
            this.teamOneNameLbl.Size = new System.Drawing.Size(203, 45);
            this.teamOneNameLbl.TabIndex = 6;
            this.teamOneNameLbl.Text = "<team one>";
            // 
            // teamOneScoreLbl
            // 
            this.teamOneScoreLbl.AutoSize = true;
            this.teamOneScoreLbl.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamOneScoreLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamOneScoreLbl.Location = new System.Drawing.Point(488, 265);
            this.teamOneScoreLbl.Name = "teamOneScoreLbl";
            this.teamOneScoreLbl.Size = new System.Drawing.Size(100, 45);
            this.teamOneScoreLbl.TabIndex = 7;
            this.teamOneScoreLbl.Text = "Score";
            // 
            // teamOneScoreValueTextBox
            // 
            this.teamOneScoreValueTextBox.Location = new System.Drawing.Point(590, 265);
            this.teamOneScoreValueTextBox.Name = "teamOneScoreValueTextBox";
            this.teamOneScoreValueTextBox.Size = new System.Drawing.Size(100, 43);
            this.teamOneScoreValueTextBox.TabIndex = 8;
            // 
            // teamTwoScoreValueTextBox
            // 
            this.teamTwoScoreValueTextBox.Location = new System.Drawing.Point(590, 449);
            this.teamTwoScoreValueTextBox.Name = "teamTwoScoreValueTextBox";
            this.teamTwoScoreValueTextBox.Size = new System.Drawing.Size(100, 43);
            this.teamTwoScoreValueTextBox.TabIndex = 11;
            // 
            // teamTwoScoreLbl
            // 
            this.teamTwoScoreLbl.AutoSize = true;
            this.teamTwoScoreLbl.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamTwoScoreLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamTwoScoreLbl.Location = new System.Drawing.Point(488, 449);
            this.teamTwoScoreLbl.Name = "teamTwoScoreLbl";
            this.teamTwoScoreLbl.Size = new System.Drawing.Size(100, 45);
            this.teamTwoScoreLbl.TabIndex = 10;
            this.teamTwoScoreLbl.Text = "Score";
            // 
            // teamTwoNameLbl
            // 
            this.teamTwoNameLbl.AutoSize = true;
            this.teamTwoNameLbl.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamTwoNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamTwoNameLbl.Location = new System.Drawing.Point(488, 392);
            this.teamTwoNameLbl.Name = "teamTwoNameLbl";
            this.teamTwoNameLbl.Size = new System.Drawing.Size(202, 45);
            this.teamTwoNameLbl.TabIndex = 9;
            this.teamTwoNameLbl.Text = "<team two>";
            // 
            // versusLbl
            // 
            this.versusLbl.AutoSize = true;
            this.versusLbl.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versusLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.versusLbl.Location = new System.Drawing.Point(573, 331);
            this.versusLbl.Name = "versusLbl";
            this.versusLbl.Size = new System.Drawing.Size(85, 45);
            this.versusLbl.TabIndex = 12;
            this.versusLbl.Text = "-VS-";
            this.versusLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // scoreBtn
            // 
            this.scoreBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.scoreBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scoreBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.scoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.scoreBtn.Location = new System.Drawing.Point(734, 332);
            this.scoreBtn.Name = "scoreBtn";
            this.scoreBtn.Size = new System.Drawing.Size(140, 53);
            this.scoreBtn.TabIndex = 13;
            this.scoreBtn.Text = "Score";
            this.scoreBtn.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 534);
            this.Controls.Add(this.scoreBtn);
            this.Controls.Add(this.versusLbl);
            this.Controls.Add(this.teamTwoScoreValueTextBox);
            this.Controls.Add(this.teamTwoScoreLbl);
            this.Controls.Add(this.teamTwoNameLbl);
            this.Controls.Add(this.teamOneScoreValueTextBox);
            this.Controls.Add(this.teamOneScoreLbl);
            this.Controls.Add(this.teamOneNameLbl);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.unplayedOnlyCheckBox);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.roundLbl);
            this.Controls.Add(this.tournamentNameLbl);
            this.Controls.Add(this.headerlbl);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerlbl;
        private System.Windows.Forms.Label tournamentNameLbl;
        private System.Windows.Forms.Label roundLbl;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.CheckBox unplayedOnlyCheckBox;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.Label teamOneNameLbl;
        private System.Windows.Forms.Label teamOneScoreLbl;
        private System.Windows.Forms.TextBox teamOneScoreValueTextBox;
        private System.Windows.Forms.TextBox teamTwoScoreValueTextBox;
        private System.Windows.Forms.Label teamTwoScoreLbl;
        private System.Windows.Forms.Label teamTwoNameLbl;
        private System.Windows.Forms.Label versusLbl;
        private System.Windows.Forms.Button scoreBtn;
    }
}

