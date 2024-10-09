
namespace PresentationLayer
{
    partial class Teacher_Details
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvteacher = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsearchteacher = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnteacherdelete = new FontAwesome.Sharp.IconButton();
            this.btnaddteacher = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvteacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvteacher
            // 
            this.dgvteacher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvteacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvteacher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvteacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvteacher.Location = new System.Drawing.Point(25, 278);
            this.dgvteacher.Name = "dgvteacher";
            this.dgvteacher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvteacher.Size = new System.Drawing.Size(776, 370);
            this.dgvteacher.TabIndex = 27;
            this.dgvteacher.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvteacher_CellDoubleClick);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(344, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 31);
            this.label4.TabIndex = 26;
            this.label4.Text = "Teacher Details";
            // 
            // txtsearchteacher
            // 
            this.txtsearchteacher.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtsearchteacher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsearchteacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchteacher.Location = new System.Drawing.Point(333, 116);
            this.txtsearchteacher.Multiline = true;
            this.txtsearchteacher.Name = "txtsearchteacher";
            this.txtsearchteacher.Size = new System.Drawing.Size(231, 28);
            this.txtsearchteacher.TabIndex = 1;
            this.txtsearchteacher.TextChanged += new System.EventHandler(this.txtsearchteacher_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Search By Name:";
            // 
            // btnteacherdelete
            // 
            this.btnteacherdelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnteacherdelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnteacherdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnteacherdelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnteacherdelete.IconColor = System.Drawing.Color.SaddleBrown;
            this.btnteacherdelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnteacherdelete.IconSize = 30;
            this.btnteacherdelete.Location = new System.Drawing.Point(629, 230);
            this.btnteacherdelete.Name = "btnteacherdelete";
            this.btnteacherdelete.Size = new System.Drawing.Size(172, 42);
            this.btnteacherdelete.TabIndex = 31;
            this.btnteacherdelete.Text = "Delete";
            this.btnteacherdelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnteacherdelete.UseVisualStyleBackColor = false;
            this.btnteacherdelete.Click += new System.EventHandler(this.btnteacherdelete_Click);
            // 
            // btnaddteacher
            // 
            this.btnaddteacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaddteacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddteacher.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnaddteacher.IconColor = System.Drawing.Color.SaddleBrown;
            this.btnaddteacher.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnaddteacher.IconSize = 30;
            this.btnaddteacher.Location = new System.Drawing.Point(440, 230);
            this.btnaddteacher.Name = "btnaddteacher";
            this.btnaddteacher.Size = new System.Drawing.Size(172, 42);
            this.btnaddteacher.TabIndex = 30;
            this.btnaddteacher.Text = "Add Teacher";
            this.btnaddteacher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaddteacher.UseVisualStyleBackColor = true;
            this.btnaddteacher.Click += new System.EventHandler(this.btnaddteacher_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::PresentationLayer.Properties.Resources.ee9b705677466e520fdbd5892bba8a191;
            this.pictureBox2.Location = new System.Drawing.Point(675, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 151);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PresentationLayer.Properties.Resources.search_flat;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // Teacher_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(839, 697);
            this.Controls.Add(this.txtsearchteacher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnteacherdelete);
            this.Controls.Add(this.btnaddteacher);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvteacher);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Teacher_Details";
            this.Text = "Teacher_Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Teacher_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvteacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton btnaddteacher;
        private FontAwesome.Sharp.IconButton btnteacherdelete;
        private System.Windows.Forms.TextBox txtsearchteacher;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dgvteacher;
    }
}