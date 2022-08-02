
namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            this.headerlbl = new System.Windows.Forms.Label();
            this.loadExistingTournamentDropDown = new System.Windows.Forms.ComboBox();
            this.loadExistingTournamentLbl = new System.Windows.Forms.Label();
            this.loadTournamentBtn = new System.Windows.Forms.Button();
            this.createTournamentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerlbl
            // 
            this.headerlbl.AutoSize = true;
            this.headerlbl.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerlbl.Location = new System.Drawing.Point(173, 54);
            this.headerlbl.Name = "headerlbl";
            this.headerlbl.Size = new System.Drawing.Size(501, 65);
            this.headerlbl.TabIndex = 13;
            this.headerlbl.Text = "Tournament Dashboard";
            // 
            // loadExistingTournamentDropDown
            // 
            this.loadExistingTournamentDropDown.FormattingEnabled = true;
            this.loadExistingTournamentDropDown.Location = new System.Drawing.Point(191, 227);
            this.loadExistingTournamentDropDown.Name = "loadExistingTournamentDropDown";
            this.loadExistingTournamentDropDown.Size = new System.Drawing.Size(490, 45);
            this.loadExistingTournamentDropDown.TabIndex = 20;
            // 
            // loadExistingTournamentLbl
            // 
            this.loadExistingTournamentLbl.AutoSize = true;
            this.loadExistingTournamentLbl.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadExistingTournamentLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.loadExistingTournamentLbl.Location = new System.Drawing.Point(233, 179);
            this.loadExistingTournamentLbl.Name = "loadExistingTournamentLbl";
            this.loadExistingTournamentLbl.Size = new System.Drawing.Size(394, 45);
            this.loadExistingTournamentLbl.TabIndex = 19;
            this.loadExistingTournamentLbl.Text = "Load Existing Tournament";
            // 
            // loadTournamentBtn
            // 
            this.loadTournamentBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.loadTournamentBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.loadTournamentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.loadTournamentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTournamentBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadTournamentBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.loadTournamentBtn.Location = new System.Drawing.Point(284, 306);
            this.loadTournamentBtn.Name = "loadTournamentBtn";
            this.loadTournamentBtn.Size = new System.Drawing.Size(294, 53);
            this.loadTournamentBtn.TabIndex = 21;
            this.loadTournamentBtn.Text = "Load Tournament";
            this.loadTournamentBtn.UseVisualStyleBackColor = true;
            // 
            // createTournamentBtn
            // 
            this.createTournamentBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTournamentBtn.Location = new System.Drawing.Point(205, 453);
            this.createTournamentBtn.Name = "createTournamentBtn";
            this.createTournamentBtn.Size = new System.Drawing.Size(437, 53);
            this.createTournamentBtn.TabIndex = 26;
            this.createTournamentBtn.Text = "Create Tournament";
            this.createTournamentBtn.UseVisualStyleBackColor = true;
            // 
            // TorunamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 564);
            this.Controls.Add(this.createTournamentBtn);
            this.Controls.Add(this.loadTournamentBtn);
            this.Controls.Add(this.loadExistingTournamentDropDown);
            this.Controls.Add(this.loadExistingTournamentLbl);
            this.Controls.Add(this.headerlbl);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TorunamentDashboardForm";
            this.Text = "Torunament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerlbl;
        private System.Windows.Forms.ComboBox loadExistingTournamentDropDown;
        private System.Windows.Forms.Label loadExistingTournamentLbl;
        private System.Windows.Forms.Button loadTournamentBtn;
        private System.Windows.Forms.Button createTournamentBtn;
    }
}