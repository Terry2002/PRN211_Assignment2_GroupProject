namespace SalesWinApp
{
    partial class frmMain
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
            this.lbWelcome = new System.Windows.Forms.Label();
            this.btnMembersManagement = new System.Windows.Forms.Button();
            this.btnProductManagement = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbWelcome.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbWelcome.Location = new System.Drawing.Point(224, 40);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(353, 54);
            this.lbWelcome.TabIndex = 0;
            this.lbWelcome.Text = "Welcome to Fstore";
            // 
            // btnMembersManagement
            // 
            this.btnMembersManagement.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMembersManagement.Location = new System.Drawing.Point(50, 234);
            this.btnMembersManagement.Name = "btnMembersManagement";
            this.btnMembersManagement.Size = new System.Drawing.Size(171, 23);
            this.btnMembersManagement.TabIndex = 1;
            this.btnMembersManagement.Text = "Menber Management";
            this.btnMembersManagement.UseVisualStyleBackColor = false;
            // 
            // btnProductManagement
            // 
            this.btnProductManagement.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnProductManagement.Location = new System.Drawing.Point(316, 234);
            this.btnProductManagement.Name = "btnProductManagement";
            this.btnProductManagement.Size = new System.Drawing.Size(171, 23);
            this.btnProductManagement.TabIndex = 2;
            this.btnProductManagement.Text = "Product Management";
            this.btnProductManagement.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Location = new System.Drawing.Point(579, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Menber Management";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLogOut.Location = new System.Drawing.Point(361, 304);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(72, 24);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 364);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnProductManagement);
            this.Controls.Add(this.btnMembersManagement);
            this.Controls.Add(this.lbWelcome);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbWelcome;
        private Button btnMembersManagement;
        private Button btnProductManagement;
        private Button button2;
        private Button btnLogOut;
    }
}