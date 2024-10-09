using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;
namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadCra();
        }
        void Save()
        {
            if (chkbxrembrme.Checked == true)
            {
                Properties.Settings.Default.Username = txtusername.Text;
                Properties.Settings.Default.Password = txtpassword.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }
        }
        void LoadCra()
        {
            if(Properties.Settings.Default.Username != string.Empty)
            {
                txtusername.Text = Properties.Settings.Default.Username;
                txtpassword.Text = Properties.Settings.Default.Password;
                chkbxrembrme.Checked = true;
            }
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            EmployeeRegistration er = new EmployeeRegistration();
            er.Show();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

       

        private void btnlogin_Click(object sender, EventArgs e)
        {
           
            Employee em = new Employee();
            em.username = txtusername.Text;
            em.password = txtpassword.Text;
            if (em.ValidUser() == false)
            {
                MessageBox.Show("Invalid User","Alert",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
             Save();
                    Home h = new Home();
                    h.Show();
                    this.Hide();
                
            }
        }
    }
}
