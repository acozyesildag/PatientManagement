using PatientManagement.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement.Views
{
    public partial class PatientsForm : Form
    {
        public PatientsForm(string username)
        {
            InitializeComponent();
            lblUsername.Text = username;
        }
    }
}
