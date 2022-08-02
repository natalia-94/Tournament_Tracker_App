
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
            this.addTeamMemberBtn = new System.Windows.Forms.Button();
            this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLbl = new System.Windows.Forms.Label();
            this.addNewMemberBox = new System.Windows.Forms.GroupBox();
            this.firstNameValueTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.lastNameValueTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.emailValueTextBox = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.cellphoneValueTextBox = new System.Windows.Forms.TextBox();
            this.cellphoneLbl = new System.Windows.Forms.Label();
            this.createMemberBtn = new System.Windows.Forms.Button();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedMemberBtn = new System.Windows.Forms.Button();
            this.createTeamBtn = new System.Windows.Forms.Button();
            this.addNewMemberBox.SuspendLayout();
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
            // addTeamMemberBtn
            // 
            this.addTeamMemberBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamMemberBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamMemberBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamMemberBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamMemberBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addTeamMemberBtn.Location = new System.Drawing.Point(93, 332);
            this.addTeamMemberBtn.Name = "addTeamMemberBtn";
            this.addTeamMemberBtn.Size = new System.Drawing.Size(294, 53);
            this.addTeamMemberBtn.TabIndex = 19;
            this.addTeamMemberBtn.Text = "Add Member";
            this.addTeamMemberBtn.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberDropDown
            // 
            this.selectTeamMemberDropDown.FormattingEnabled = true;
            this.selectTeamMemberDropDown.Location = new System.Drawing.Point(23, 256);
            this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            this.selectTeamMemberDropDown.Size = new System.Drawing.Size(437, 45);
            this.selectTeamMemberDropDown.TabIndex = 18;
            // 
            // selectTeamMemberLbl
            // 
            this.selectTeamMemberLbl.AutoSize = true;
            this.selectTeamMemberLbl.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamMemberLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.selectTeamMemberLbl.Location = new System.Drawing.Point(15, 208);
            this.selectTeamMemberLbl.Name = "selectTeamMemberLbl";
            this.selectTeamMemberLbl.Size = new System.Drawing.Size(322, 45);
            this.selectTeamMemberLbl.TabIndex = 17;
            this.selectTeamMemberLbl.Text = "Select Team Member";
            // 
            // addNewMemberBox
            // 
            this.addNewMemberBox.Controls.Add(this.createMemberBtn);
            this.addNewMemberBox.Controls.Add(this.cellphoneValueTextBox);
            this.addNewMemberBox.Controls.Add(this.cellphoneLbl);
            this.addNewMemberBox.Controls.Add(this.emailValueTextBox);
            this.addNewMemberBox.Controls.Add(this.emailLbl);
            this.addNewMemberBox.Controls.Add(this.lastNameValueTextBox);
            this.addNewMemberBox.Controls.Add(this.lastNameLbl);
            this.addNewMemberBox.Controls.Add(this.firstNameValueTextBox);
            this.addNewMemberBox.Controls.Add(this.firstNameLbl);
            this.addNewMemberBox.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewMemberBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addNewMemberBox.Location = new System.Drawing.Point(23, 429);
            this.addNewMemberBox.Name = "addNewMemberBox";
            this.addNewMemberBox.Size = new System.Drawing.Size(437, 461);
            this.addNewMemberBox.TabIndex = 20;
            this.addNewMemberBox.TabStop = false;
            this.addNewMemberBox.Text = "Add New Member";
            // 
            // firstNameValueTextBox
            // 
            this.firstNameValueTextBox.Location = new System.Drawing.Point(192, 88);
            this.firstNameValueTextBox.Name = "firstNameValueTextBox";
            this.firstNameValueTextBox.Size = new System.Drawing.Size(225, 51);
            this.firstNameValueTextBox.TabIndex = 14;
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.firstNameLbl.Location = new System.Drawing.Point(17, 88);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(176, 45);
            this.firstNameLbl.TabIndex = 13;
            this.firstNameLbl.Text = "First Name";
            // 
            // lastNameValueTextBox
            // 
            this.lastNameValueTextBox.Location = new System.Drawing.Point(192, 155);
            this.lastNameValueTextBox.Name = "lastNameValueTextBox";
            this.lastNameValueTextBox.Size = new System.Drawing.Size(225, 51);
            this.lastNameValueTextBox.TabIndex = 16;
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lastNameLbl.Location = new System.Drawing.Point(17, 155);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(174, 45);
            this.lastNameLbl.TabIndex = 15;
            this.lastNameLbl.Text = "Last Name";
            // 
            // emailValueTextBox
            // 
            this.emailValueTextBox.Location = new System.Drawing.Point(192, 223);
            this.emailValueTextBox.Name = "emailValueTextBox";
            this.emailValueTextBox.Size = new System.Drawing.Size(225, 51);
            this.emailValueTextBox.TabIndex = 18;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.emailLbl.Location = new System.Drawing.Point(17, 223);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(98, 45);
            this.emailLbl.TabIndex = 17;
            this.emailLbl.Text = "Email";
            // 
            // cellphoneValueTextBox
            // 
            this.cellphoneValueTextBox.Location = new System.Drawing.Point(192, 284);
            this.cellphoneValueTextBox.Name = "cellphoneValueTextBox";
            this.cellphoneValueTextBox.Size = new System.Drawing.Size(225, 51);
            this.cellphoneValueTextBox.TabIndex = 20;
            // 
            // cellphoneLbl
            // 
            this.cellphoneLbl.AutoSize = true;
            this.cellphoneLbl.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellphoneLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.cellphoneLbl.Location = new System.Drawing.Point(17, 281);
            this.cellphoneLbl.Name = "cellphoneLbl";
            this.cellphoneLbl.Size = new System.Drawing.Size(166, 45);
            this.cellphoneLbl.TabIndex = 19;
            this.cellphoneLbl.Text = "Cellphone";
            // 
            // createMemberBtn
            // 
            this.createMemberBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMemberBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createMemberBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createMemberBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createMemberBtn.Location = new System.Drawing.Point(70, 364);
            this.createMemberBtn.Name = "createMemberBtn";
            this.createMemberBtn.Size = new System.Drawing.Size(294, 53);
            this.createMemberBtn.TabIndex = 21;
            this.createMemberBtn.Text = "Create Member";
            this.createMemberBtn.UseVisualStyleBackColor = true;
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 37;
            this.teamMembersListBox.Location = new System.Drawing.Point(533, 139);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(471, 742);
            this.teamMembersListBox.TabIndex = 21;
            // 
            // deleteSelectedMemberBtn
            // 
            this.deleteSelectedMemberBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedMemberBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedMemberBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedMemberBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedMemberBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteSelectedMemberBtn.Location = new System.Drawing.Point(1057, 139);
            this.deleteSelectedMemberBtn.Name = "deleteSelectedMemberBtn";
            this.deleteSelectedMemberBtn.Size = new System.Drawing.Size(200, 95);
            this.deleteSelectedMemberBtn.TabIndex = 22;
            this.deleteSelectedMemberBtn.Text = "Delete selected";
            this.deleteSelectedMemberBtn.UseVisualStyleBackColor = true;
            // 
            // createTeamBtn
            // 
            this.createTeamBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeamBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTeamBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTeamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTeamBtn.Location = new System.Drawing.Point(435, 931);
            this.createTeamBtn.Name = "createTeamBtn";
            this.createTeamBtn.Size = new System.Drawing.Size(437, 53);
            this.createTeamBtn.TabIndex = 25;
            this.createTeamBtn.Text = "Create Team";
            this.createTeamBtn.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1301, 1041);
            this.Controls.Add(this.createTeamBtn);
            this.Controls.Add(this.deleteSelectedMemberBtn);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.addNewMemberBox);
            this.Controls.Add(this.addTeamMemberBtn);
            this.Controls.Add(this.selectTeamMemberDropDown);
            this.Controls.Add(this.selectTeamMemberLbl);
            this.Controls.Add(this.teamNameValueTextBox);
            this.Controls.Add(this.teamNameLbl);
            this.Controls.Add(this.headerlbl);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.addNewMemberBox.ResumeLayout(false);
            this.addNewMemberBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teamNameValueTextBox;
        private System.Windows.Forms.Label teamNameLbl;
        private System.Windows.Forms.Label headerlbl;
        private System.Windows.Forms.Button addTeamMemberBtn;
        private System.Windows.Forms.ComboBox selectTeamMemberDropDown;
        private System.Windows.Forms.Label selectTeamMemberLbl;
        private System.Windows.Forms.GroupBox addNewMemberBox;
        private System.Windows.Forms.TextBox firstNameValueTextBox;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Button createMemberBtn;
        private System.Windows.Forms.TextBox cellphoneValueTextBox;
        private System.Windows.Forms.Label cellphoneLbl;
        private System.Windows.Forms.TextBox emailValueTextBox;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox lastNameValueTextBox;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.ListBox teamMembersListBox;
        private System.Windows.Forms.Button deleteSelectedMemberBtn;
        private System.Windows.Forms.Button createTeamBtn;
    }
}