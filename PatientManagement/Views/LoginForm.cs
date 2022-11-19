using PatientManagement.DataAccess;
using PatientManagement.Models;
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
    public partial class LoginForm : Form
    {
        PatientManagementDBEntities dataAccsess;
        public LoginForm()
        {
            InitializeComponent();
            dataAccsess = new PatientManagementDBEntities();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginModel loginmodel = new LoginModel
            {
                Password = txtPassword.Text,
                UsercountryId = txtCountryid.Text
            };

            if (loginmodel.UsercountryId == Constant.Admincountryid && loginmodel.Password == Constant.Adminpassword)
            {
                this.Hide();
                RuntimeUser.Username = Constant.Adminname;
                PatientsForm patientsForm = new PatientsForm(Constant.Adminname);
                patientsForm.ShowDialog();
                this.Close();
            }
            else
            {
                List<tblUser> users = new List<tblUser>();
                users = dataAccsess.tblUser.ToList();
                foreach (tblUser user in users)
                {
                    if (loginmodel.UsercountryId == user.Countryid && loginmodel.Password == user.PasswordHash)
                    {
                        this.Hide();
                        RuntimeUser.Username = user.Name + " " + user.Surname;
                        PatientsForm patientsForm = new PatientsForm(user.Name + " " + user.Surname);
                        patientsForm.ShowDialog();
                        this.Close();
                    }
                }
            }
            MessageBox.Show("Hatalı Giriş Yaptınız", "Hatalı Giriş",MessageBoxButtons.OK,  MessageBoxIcon.Error);
        }
    }
}
