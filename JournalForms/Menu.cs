using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JournalForms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        

        private void btn_users_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.ShowDialog();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_users_MouseHover(object sender, EventArgs e)
        {         
            btn_users.BackColor = Color.Green;
        }

        private void btn_users_MouseLeave(object sender, EventArgs e)
        {
            btn_users.BackColor = Color.WhiteSmoke;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            btn_users.BackColor = Color.WhiteSmoke;
            btn_teachers.BackColor = Color.WhiteSmoke;
            btn_subjects.BackColor = Color.WhiteSmoke;
            btn_classes.BackColor = Color.WhiteSmoke;
            btn_pupils.BackColor = Color.WhiteSmoke;
        }

        private void btn_teachers_MouseHover(object sender, EventArgs e)
        {
            btn_teachers.BackColor = Color.Green;
        }

        private void btn_teachers_MouseLeave(object sender, EventArgs e)
        {
            btn_teachers.BackColor = Color.WhiteSmoke;

        }

        private void btn_pupils_MouseHover(object sender, EventArgs e)
        {
            btn_pupils.BackColor = Color.Green;

        }

        private void btn_subjects_MouseHover(object sender, EventArgs e)
        {
            btn_subjects.BackColor = Color.Green;

        }

        private void btn_classes_Click(object sender, EventArgs e)
        {

        }

        private void btn_classes_MouseHover(object sender, EventArgs e)
        {
            btn_classes.BackColor = Color.Green;

        }

        private void btn_pupils_MouseLeave(object sender, EventArgs e)
        {
            btn_pupils.BackColor = Color.WhiteSmoke;

        }

        private void btn_subjects_MouseLeave(object sender, EventArgs e)
        {
            btn_subjects.BackColor = Color.WhiteSmoke;

        }

        private void btn_classes_MouseCaptureChanged(object sender, EventArgs e)
        {
            

        }

        private void btn_classes_MouseLeave(object sender, EventArgs e)
        {
            btn_classes.BackColor = Color.WhiteSmoke;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btn_teachers_Click(object sender, EventArgs e)
        {
            Teachers teachers = new Teachers();
            teachers.Show();
        }

        private void btn_subjects_Click(object sender, EventArgs e)
        {
            Subjects subjects = new Subjects();
            subjects.Show();
        }

        private void btn_pupils_Click(object sender, EventArgs e)
        {
            Pupils pupils = new Pupils();
            pupils.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Relations relations = new Relations();
            relations.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            REPORTS rEPORTS = new REPORTS();
            rEPORTS.Show();
        }
    }
}
