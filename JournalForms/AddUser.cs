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
    public partial class AddUser : Form
    {
        bool _IsNew = false;


        public AddUser(DataRow dr)
        {
            _IsNew = dr == null ;
            InitializeComponent();
            if (!_IsNew)
            {
                txtUserID.Text = (string)dr["user_id"];
                //txtPassword.Text = (string)dr["password"];
                txtTeacherID.Text = ((int)dr["teacher_id"]).ToString();
                comboBox1.SelectedValue = ((int)dr["role_id"]);
                
                txtPassword.Hide();
                label2.Hide();
                txtTeacherID.Location = new Point(138, 77);
                label3.Location = new Point(19, 75);
                comboBox1.Location = new Point(138, 114);
                label4.Location = new Point(19, 112);
            }
            butAdd.Visible = _IsNew;
            butEdit.Visible = !_IsNew;
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = JournalLibrary.DBConnector.SelectRoles();
            comboBox1.DisplayMember = "role_name";
            comboBox1.ValueMember = "role_id";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text != string.Empty && txtPassword.Text != String.Empty && txtTeacherID.Text != string.Empty && comboBox1.Text != string.Empty)
            {
                JournalLibrary.DBConnector.AddUser(txtUserID.Text, JournalLibrary.Helper.CalculateMD5(txtPassword.Text), Convert.ToInt32(txtTeacherID.Text), Convert.ToInt32(comboBox1.SelectedValue));
                this.Close();
            }
            else
                MessageBox.Show("მიუთითეთ ყველაფერი");
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("გსურთ დაარედაქტიროთ იუზერი?", "", MessageBoxButtons.YesNo);
            if (txtUserID.Text != string.Empty && txtTeacherID.Text != string.Empty && comboBox1.Text != string.Empty && res == DialogResult.Yes)
            {
                JournalLibrary.DBConnector.UpdateUser(txtUserID.Text, Convert.ToInt32(txtTeacherID.Text), Convert.ToInt32(comboBox1.SelectedValue));
                this.Close();
                
            }
            else
                MessageBox.Show("მიუთითეთ ყველაფერი");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btn_editpupil_Click(object sender, EventArgs e)
        {

        }
    }
}
