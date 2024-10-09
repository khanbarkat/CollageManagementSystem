
namespace PresentationLayer
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.btnlogout = new FontAwesome.Sharp.IconButton();
            this.btnpenfee = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnexit = new FontAwesome.Sharp.IconButton();
            this.btnhome = new FontAwesome.Sharp.IconButton();
            this.btnadmission = new FontAwesome.Sharp.IconButton();
            this.btnteacherseacrh = new FontAwesome.Sharp.IconButton();
            this.btnsearch = new FontAwesome.Sharp.IconButton();
            this.btnupgrade = new FontAwesome.Sharp.IconButton();
            this.btnfee = new FontAwesome.Sharp.IconButton();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItem1.Text = "Search Teachers";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItem2.Text = "Add Teachers Info";
            // 
            // searchStudentsToolStripMenuItem
            // 
            this.searchStudentsToolStripMenuItem.Name = "searchStudentsToolStripMenuItem";
            this.searchStudentsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchStudentsToolStripMenuItem.Text = "Search Students";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(176)))), ((int)(((byte)(190)))));
            this.panel3.Controls.Add(this.btnpenfee);
            this.panel3.Controls.Add(this.iconButton1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.btnexit);
            this.panel3.Controls.Add(this.btnhome);
            this.panel3.Controls.Add(this.btnadmission);
            this.panel3.Controls.Add(this.btnteacherseacrh);
            this.panel3.Controls.Add(this.btnsearch);
            this.panel3.Controls.Add(this.btnupgrade);
            this.panel3.Controls.Add(this.btnfee);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 735);
            this.panel3.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(176)))), ((int)(((byte)(190)))));
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 55);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(240, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "COLLAGE MANAGEMENT SYSTEM";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = global::PresentationLayer.Properties.Resources.images__5_;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.lblwelcome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(220, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 680);
            this.panel2.TabIndex = 9;
            // 
            // lblwelcome
            // 
            this.lblwelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("Lucida Fax", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.ForeColor = System.Drawing.Color.Black;
            this.lblwelcome.Location = new System.Drawing.Point(301, 26);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(258, 54);
            this.lblwelcome.TabIndex = 1;
            this.lblwelcome.Text = "WELCOME";
            // 
            // iconButton3
            // 
            this.iconButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButton3.BackColor = System.Drawing.Color.Transparent;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.SchoolFlag;
            this.iconButton3.IconColor = System.Drawing.Color.Blue;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 40;
            this.iconButton3.Location = new System.Drawing.Point(165, 3);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(69, 35);
            this.iconButton3.TabIndex = 7;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // btnlogout
            // 
            this.btnlogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlogout.BackColor = System.Drawing.Color.Transparent;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnlogout.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btnlogout.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.btnlogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlogout.IconSize = 40;
            this.btnlogout.Location = new System.Drawing.Point(701, -3);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(124, 41);
            this.btnlogout.TabIndex = 13;
            this.btnlogout.Text = "LOGOUT";
            this.btnlogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnpenfee
            // 
            this.btnpenfee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnpenfee.BackColor = System.Drawing.Color.Transparent;
            this.btnpenfee.FlatAppearance.BorderSize = 0;
            this.btnpenfee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpenfee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpenfee.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnpenfee.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            this.btnpenfee.IconColor = System.Drawing.Color.Brown;
            this.btnpenfee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnpenfee.IconSize = 40;
            this.btnpenfee.Location = new System.Drawing.Point(17, 536);
            this.btnpenfee.Name = "btnpenfee";
            this.btnpenfee.Size = new System.Drawing.Size(200, 52);
            this.btnpenfee.TabIndex = 13;
            this.btnpenfee.Text = "PENDING FEE";
            this.btnpenfee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpenfee.UseVisualStyleBackColor = false;
            this.btnpenfee.Click += new System.EventHandler(this.btnpenfee_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            this.iconButton1.IconColor = System.Drawing.Color.Brown;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.Location = new System.Drawing.Point(15, 478);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(200, 52);
            this.iconButton1.TabIndex = 12;
            this.iconButton1.Text = "ATTENDANCE";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::PresentationLayer.Properties.Resources.colage2;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 119);
            this.panel4.TabIndex = 16;
            // 
            // btnexit
            // 
            this.btnexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnexit.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnexit.IconColor = System.Drawing.Color.Brown;
            this.btnexit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnexit.IconSize = 45;
            this.btnexit.Location = new System.Drawing.Point(17, 607);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(124, 50);
            this.btnexit.TabIndex = 13;
            this.btnexit.Text = "EXIT";
            this.btnexit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.Transparent;
            this.btnhome.FlatAppearance.BorderSize = 0;
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnhome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnhome.IconColor = System.Drawing.Color.Brown;
            this.btnhome.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnhome.IconSize = 45;
            this.btnhome.Location = new System.Drawing.Point(15, 125);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(157, 53);
            this.btnhome.TabIndex = 6;
            this.btnhome.Text = "HOME";
            this.btnhome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btnadmission
            // 
            this.btnadmission.BackColor = System.Drawing.Color.Transparent;
            this.btnadmission.FlatAppearance.BorderSize = 0;
            this.btnadmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadmission.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnadmission.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.btnadmission.IconColor = System.Drawing.Color.Brown;
            this.btnadmission.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnadmission.IconSize = 45;
            this.btnadmission.Location = new System.Drawing.Point(10, 184);
            this.btnadmission.Name = "btnadmission";
            this.btnadmission.Size = new System.Drawing.Size(206, 50);
            this.btnadmission.TabIndex = 7;
            this.btnadmission.Text = "ADMISSIONS";
            this.btnadmission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnadmission.UseVisualStyleBackColor = false;
            this.btnadmission.Click += new System.EventHandler(this.btnadmission_Click_1);
            // 
            // btnteacherseacrh
            // 
            this.btnteacherseacrh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnteacherseacrh.BackColor = System.Drawing.Color.Transparent;
            this.btnteacherseacrh.FlatAppearance.BorderSize = 0;
            this.btnteacherseacrh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnteacherseacrh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnteacherseacrh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnteacherseacrh.IconChar = FontAwesome.Sharp.IconChar.Display;
            this.btnteacherseacrh.IconColor = System.Drawing.Color.Brown;
            this.btnteacherseacrh.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.btnteacherseacrh.IconSize = 40;
            this.btnteacherseacrh.Location = new System.Drawing.Point(17, 420);
            this.btnteacherseacrh.Name = "btnteacherseacrh";
            this.btnteacherseacrh.Size = new System.Drawing.Size(200, 52);
            this.btnteacherseacrh.TabIndex = 11;
            this.btnteacherseacrh.Text = "TEACHER DETAILS";
            this.btnteacherseacrh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnteacherseacrh.UseVisualStyleBackColor = false;
            this.btnteacherseacrh.Click += new System.EventHandler(this.btnteacherseacrh_Click_1);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.Transparent;
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnsearch.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnsearch.IconColor = System.Drawing.Color.Brown;
            this.btnsearch.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.btnsearch.IconSize = 45;
            this.btnsearch.Location = new System.Drawing.Point(12, 248);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(168, 46);
            this.btnsearch.TabIndex = 9;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click_1);
            // 
            // btnupgrade
            // 
            this.btnupgrade.BackColor = System.Drawing.Color.Transparent;
            this.btnupgrade.FlatAppearance.BorderSize = 0;
            this.btnupgrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupgrade.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnupgrade.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnupgrade.IconColor = System.Drawing.Color.Brown;
            this.btnupgrade.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnupgrade.IconSize = 45;
            this.btnupgrade.Location = new System.Drawing.Point(12, 300);
            this.btnupgrade.Name = "btnupgrade";
            this.btnupgrade.Size = new System.Drawing.Size(182, 57);
            this.btnupgrade.TabIndex = 8;
            this.btnupgrade.Text = "UPGRADE";
            this.btnupgrade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnupgrade.UseVisualStyleBackColor = false;
            this.btnupgrade.Click += new System.EventHandler(this.btnupgrade_Click);
            // 
            // btnfee
            // 
            this.btnfee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnfee.BackColor = System.Drawing.Color.Transparent;
            this.btnfee.FlatAppearance.BorderSize = 0;
            this.btnfee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfee.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnfee.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.btnfee.IconColor = System.Drawing.Color.Brown;
            this.btnfee.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnfee.IconSize = 45;
            this.btnfee.Location = new System.Drawing.Point(10, 363);
            this.btnfee.Name = "btnfee";
            this.btnfee.Size = new System.Drawing.Size(127, 51);
            this.btnfee.TabIndex = 10;
            this.btnfee.Text = "FEE";
            this.btnfee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnfee.UseVisualStyleBackColor = false;
            this.btnfee.Click += new System.EventHandler(this.btnfee_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 735);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Collage_Management_System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem searchStudentsToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnexit;
        private FontAwesome.Sharp.IconButton btnteacherseacrh;
        private FontAwesome.Sharp.IconButton btnfee;
        private FontAwesome.Sharp.IconButton btnupgrade;
        private FontAwesome.Sharp.IconButton btnsearch;
        private FontAwesome.Sharp.IconButton btnadmission;
        private FontAwesome.Sharp.IconButton btnhome;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnlogout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblwelcome;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton btnpenfee;
    }
}