using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JournalLibrary;

namespace JournalForms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string hash = Helper.CalculateMD5(textBoxPassword.Text);
            if (DBConnector.GetUser(textBoxUser.Text,hash) && DBConnector.GetRoleID(textBoxUser.Text) == 0)
            {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
            else if(DBConnector.GetUser(textBoxUser.Text, hash) && DBConnector.GetRoleID(textBoxUser.Text) == 2)
            {
                TeacherMenu teacherMenu = new TeacherMenu(DBConnector.GetTeacherIdByUserID(textBoxUser.Text));
                teacherMenu.Show();
                this.Hide();
            }
            else if (DBConnector.GetUser(textBoxUser.Text, hash) && DBConnector.GetRoleID(textBoxUser.Text) == 4)
            {
                PupilMenu pupilForm = new PupilMenu(textBoxUser.Text);
                pupilForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ასეთი იუზერი არ არის დარეგისტრირებული");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBoxUser.Text = "01017986770";
        }

       

    }
}
