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
    public partial class Upgrade_Student_Standard : Form
    {
        public Upgrade_Student_Standard()
        {
            InitializeComponent();
        }

        private void btnupgrade_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.cmbxfrom = cmbxfrom.Text;
            s.cmbxto = cmbxto.Text;
            s.UpgradeStudent();
            MessageBox.Show("All Student Which are in '" + cmbxfrom.Text + "' are Enter into smester/class '" + cmbxto.Text + "' Successfully..");
        }
    }
}
