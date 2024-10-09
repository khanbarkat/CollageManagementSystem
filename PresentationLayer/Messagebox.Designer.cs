
namespace PresentationLayer
{
    partial class MyMessageBox
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
            this.lblheadermsg = new System.Windows.Forms.Label();
            this.lblmsg = new System.Windows.Forms.Label();
            this.picbxmbx = new System.Windows.Forms.PictureBox();
            this.btnyes = new System.Windows.Forms.Button();
            this.btnno = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.picbxmbx)).BeginInit();
            this.SuspendLayout();
            // 
            // lblheadermsg
            // 
            this.lblheadermsg.AutoSize = true;
            this.lblheadermsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheadermsg.Location = new System.Drawing.Point(262, 9);
            this.lblheadermsg.Name = "lblheadermsg";
            this.lblheadermsg.Size = new System.Drawing.Size(34, 25);
            this.lblheadermsg.TabIndex = 0;
            this.lblheadermsg.Text = "lbl";
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg.Location = new System.Drawing.Point(120, 100);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(60, 24);
            this.lblmsg.TabIndex = 1;
            this.lblmsg.Text = "label2";
            // 
            // picbxmbx
            // 
            this.picbxmbx.Location = new System.Drawing.Point(28, 85);
            this.picbxmbx.Name = "picbxmbx";
            this.picbxmbx.Size = new System.Drawing.Size(71, 55);
            this.picbxmbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbxmbx.TabIndex = 2;
            this.picbxmbx.TabStop = false;
            // 
            // btnyes
            // 
            this.btnyes.BackColor = System.Drawing.Color.Gray;
            this.btnyes.Location = new System.Drawing.Point(371, 201);
            this.btnyes.Name = "btnyes";
            this.btnyes.Size = new System.Drawing.Size(90, 28);
            this.btnyes.TabIndex = 3;
            this.btnyes.Text = "Yes";
            this.btnyes.UseVisualStyleBackColor = false;
            this.btnyes.Click += new System.EventHandler(this.btnyes_Click);
            // 
            // btnno
            // 
            this.btnno.BackColor = System.Drawing.Color.Gray;
            this.btnno.Location = new System.Drawing.Point(478, 201);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(90, 28);
            this.btnno.TabIndex = 4;
            this.btnno.Text = "No";
            this.btnno.UseVisualStyleBackColor = false;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.Color.Gray;
            this.btnok.Location = new System.Drawing.Point(478, 201);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(90, 28);
            this.btnok.TabIndex = 5;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Navy;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.XmarkSquare;
            this.iconButton1.IconColor = System.Drawing.Color.DarkRed;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(531, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(48, 34);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // MyMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(579, 246);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btnyes);
            this.Controls.Add(this.picbxmbx);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.lblheadermsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyMessageBox";
            ((System.ComponentModel.ISupportInitialize)(this.picbxmbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblheadermsg;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.PictureBox picbxmbx;
        private System.Windows.Forms.Button btnyes;
        private System.Windows.Forms.Button btnno;
        private System.Windows.Forms.Button btnok;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}