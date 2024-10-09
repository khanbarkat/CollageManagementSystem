using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class MyMessageBox : Form
    {
       
        public MyMessageBox()
        {
            InitializeComponent();
            this.Show();
        }
       public enum MessageBoxButton
        {
            OK=0,YesNo=1
        };
        public enum MessageBoxIcon
        {
            informative=0,warning=1,Question=2
        }
      public DialogResult show(string msg,string title,MessageBoxButton button,MessageBoxIcon icon)
        {
            lblheadermsg.Text = "";
            lblmsg.Text = "";
            lblmsg.Text = msg;
            lblheadermsg.Text = title;
            picbxmbx.Visible = true;
          
            if (MessageBoxButton.OK == button)
            {
                btnyes.Visible = false;
                btnno.Visible = false;
                btnok.Visible = true;
                
            }
            else if (MessageBoxButton.YesNo == button)
            {
                btnok.Visible = false;
                btnyes.Visible = true;
                btnno.Visible = true;

            }
            if (MessageBoxIcon.informative == icon)
            {
                picbxmbx.Image = Image.FromFile(@"E:\5th semster\infor.png");
            }
           else if (MessageBoxIcon.warning == icon)
            {
                picbxmbx.Image = Image.FromFile(@"E:\5th semster\information.jpg");
            }
            else if (MessageBoxIcon.Question == icon)
            {
                picbxmbx.Image = Image.FromFile(@"E:\5th semster\qes.png");
            }
            
            return DialogResult ;
        }

        private void btnyes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
