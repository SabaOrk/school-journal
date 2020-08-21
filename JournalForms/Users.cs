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
    public partial class Users : BaseForm
    {
        public Users()
        {
            InitializeComponent();
        }



        private void Users_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = DBConnector.SelectUsers();
        }

        private void btn_add_user_Click_1(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser(null);
            addUser.Show();
            
        }

        private void btn_remove_user_Click_1(object sender, EventArgs e)
        {
            var res = MessageBox.Show("გსურთ წაშალოთ იუზერი?", "", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                DataRow dr = GetCurrentRow();
                string CurrUserID = (string)dr["user_id"];
                JournalLibrary.DBConnector.RemoveUser(CurrUserID);
                dataGridView.DataSource = JournalLibrary.DBConnector.SelectUsers();
            }
            
        }

        private void btn_edit_user_Click_1(object sender, EventArgs e)
        {
            DataRow dr = GetCurrentRow();
            
            (new AddUser(DBConnector.SelectUserAll((string)dr["user_id"]))).ShowDialog(this);
        }

        private void btn_search_user_Click_1(object sender, EventArgs e)
        {
            if (textBox_search.Text != string.Empty)
            {
                dataGridView.DataSource = JournalLibrary.DBConnector.SelectUser(textBox_search.Text);
                textBox_search.Text = String.Empty;
            }
            else
            {
                dataGridView.DataSource = JournalLibrary.DBConnector.SelectUsers();
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = JournalLibrary.DBConnector.SelectUsers();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
