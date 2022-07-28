
namespace TrackerUI
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            this.teamNameValueTextBox = new System.Windows.Forms.TextBox();
            this.teamNameLbl = new System.Windows.Forms.Label();
            this.headerlbl = new System.Windows.Forms.Label();
            this.addTeamBtn = new System.Windows.Forms.Button();
            this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // teamNameValueTextBox
            // 
            this.teamNameValueTextBox.Location = new System.Drawing.Point(23, 139);
            this.teamNameValueTextBox.Name = "teamNameValueTextBox";
            this.teamNameValueTextBox.Size = new System.Drawing.Size(437, 43);
            this.teamNameValueTextBox.TabIndex = 13;
            // 
            // teamNameLbl
            // 
            this.teamNameLbl.AutoSize = true;
            this.teamNameLbl.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamNameLbl.Location = new System.Drawing.Point(15, 91);
            this.teamNameLbl.Name = "teamNameLbl";
            this.teamNameLbl.Size = new System.Drawing.Size(192, 45);
            this.teamNameLbl.TabIndex = 12;
            this.teamNameLbl.Text = "Team Name";
            // 
            // headerlbl
            // 
            this.headerlbl.AutoSize = true;
            this.headerlbl.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerlbl.Location = new System.Drawing.Point(12, 9);
            this.headerlbl.Name = "headerlbl";
            this.headerlbl.Size = new System.Drawing.Size(276, 65);
            this.headerlbl.TabIndex = 11;
            this.headerlbl.Text = "Create Team";
            // 
            // addTeamBtn
            // 
            this.addTeamBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addTeamBtn.Location = new System.Drawing.Point(23, 339);
            this.addTeamBtn.Name = "addTeamBtn";
            this.addTeamBtn.Size = new System.Drawing.Size(437, 53);
            this.addTeamBtn.TabIndex = 19;
            this.addTeamBtn.Text = "Add Team";
            this.addTeamBtn.UseVisualStyleBackColor = true;
            // 
            // selectTeamDropDown
            // 
            this.selectTeamDropDown.FormattingEnabled = true;
            this.selectTeamDropDown.Location = new System.Drawing.Point(23, 256);
            this.selectTeamDropDown.Name = "selectTeamDropDown";
            this.selectTeamDropDown.Size = new System.Drawing.Size(437, 45);
            this.selectTeamDropDown.TabIndex = 18;
            // 
            // selectTeamLbl
            // 
            this.selectTeamLbl.AutoSize = true;
            this.selectTeamLbl.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.selectTeamLbl.Location = new System.Drawing.Point(15, 208);
            this.selectTeamLbl.Name = "selectTeamLbl";
            this.selectTeamLbl.Size = new System.Drawing.Size(191, 45);
            this.selectTeamLbl.TabIndex = 17;
            this.selectTeamLbl.Text = "Select Team";
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 1041);
            this.Controls.Add(this.addTeamBtn);
            this.Controls.Add(this.selectTeamDropDown);
            this.Controls.Add(this.selectTeamLbl);
            this.Controls.Add(this.teamNameValueTextBox);
            this.Controls.Add(this.teamNameLbl);
            this.Controls.Add(this.headerlbl);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teamNameValueTextBox;
        private System.Windows.Forms.Label teamNameLbl;
        private System.Windows.Forms.Label headerlbl;
        private System.Windows.Forms.Button addTeamBtn;
        private System.Windows.Forms.ComboBox selectTeamDropDown;
        private System.Windows.Forms.Label selectTeamLbl;
    }
}