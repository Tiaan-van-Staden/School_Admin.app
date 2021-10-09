
namespace PRG282_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnViewCreate = new System.Windows.Forms.Button();
            this.btnViewDB = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.ucDatabase1 = new PRG282_Project.ucDatabase();
            this.ucCreate1 = new PRG282_Project.ucCreate();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(252)))));
            this.pnlTop.Controls.Add(this.imgLogo);
            this.pnlTop.Controls.Add(this.lblWelcome);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1017, 107);
            this.pnlTop.TabIndex = 0;
            // 
            // imgLogo
            // 
            this.imgLogo.BackgroundImage = global::PRG282_Project.Properties.Resources.BC_Logo;
            this.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.imgLogo.Location = new System.Drawing.Point(613, 0);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(404, 107);
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWelcome.Location = new System.Drawing.Point(12, 54);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(336, 38);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, Username";
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(207)))));
            this.pnlLeft.Controls.Add(this.btnViewCreate);
            this.pnlLeft.Controls.Add(this.btnViewDB);
            this.pnlLeft.Controls.Add(this.btnExit);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlLeft.Location = new System.Drawing.Point(0, 107);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(169, 494);
            this.pnlLeft.TabIndex = 1;
            // 
            // btnViewCreate
            // 
            this.btnViewCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(207)))));
            this.btnViewCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewCreate.FlatAppearance.BorderSize = 0;
            this.btnViewCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCreate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(161)))));
            this.btnViewCreate.Location = new System.Drawing.Point(0, 45);
            this.btnViewCreate.Name = "btnViewCreate";
            this.btnViewCreate.Size = new System.Drawing.Size(169, 45);
            this.btnViewCreate.TabIndex = 2;
            this.btnViewCreate.Text = "New Entry";
            this.btnViewCreate.UseVisualStyleBackColor = false;
            this.btnViewCreate.Click += new System.EventHandler(this.btnViewCreate_Click);
            // 
            // btnViewDB
            // 
            this.btnViewDB.BackColor = System.Drawing.SystemColors.Control;
            this.btnViewDB.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewDB.FlatAppearance.BorderSize = 0;
            this.btnViewDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDB.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(161)))));
            this.btnViewDB.Location = new System.Drawing.Point(0, 0);
            this.btnViewDB.Name = "btnViewDB";
            this.btnViewDB.Size = new System.Drawing.Size(169, 45);
            this.btnViewDB.TabIndex = 1;
            this.btnViewDB.Text = "Database";
            this.btnViewDB.UseVisualStyleBackColor = false;
            this.btnViewDB.Click += new System.EventHandler(this.btnViewDB_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(161)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(0, 449);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(169, 45);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ucDatabase1
            // 
            this.ucDatabase1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDatabase1.Location = new System.Drawing.Point(169, 107);
            this.ucDatabase1.Name = "ucDatabase1";
            this.ucDatabase1.Size = new System.Drawing.Size(848, 494);
            this.ucDatabase1.TabIndex = 3;
            // 
            // ucCreate1
            // 
            this.ucCreate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCreate1.Location = new System.Drawing.Point(169, 107);
            this.ucCreate1.Name = "ucCreate1";
            this.ucCreate1.Size = new System.Drawing.Size(848, 494);
            this.ucCreate1.TabIndex = 2;
            this.ucCreate1.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 601);
            this.Controls.Add(this.ucDatabase1);
            this.Controls.Add(this.ucCreate1);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Belgium Campus Student Database";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnViewCreate;
        private System.Windows.Forms.Button btnViewDB;
        private ucCreate ucCreate1;
        private ucDatabase ucDatabase1;
    }
}