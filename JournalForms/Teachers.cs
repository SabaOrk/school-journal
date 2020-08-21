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
    public partial class Teachers : BaseForm
    {
        public Teachers()
        {
            InitializeComponent();
        }

        private void Teachers_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = JournalLibrary.DBConnector.SelectTeachers();
        }

        private void btn_add_user_Click_1(object sender, EventArgs e)
        {
            AddTeacher addTeacher = new AddTeacher();
            addTeacher.ShowDialog();
        }

        private void btn_remove_user_Click_1(object sender, EventArgs e)
        {
            DataRow dr = GetCurrentRow();
            int CurrTeacherId = Convert.ToInt32(dr["teacher_id"]);
            var res = MessageBox.Show("გსურთ წაშალოთ მასწავლებელი?", "", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                JournalLibrary.DBConnector.RemoveTeacher(CurrTeacherId);
                dataGridView.DataSource = JournalLibrary.DBConnector.SelectTeachers();
            }
        }

        private void btn_search_user_Click_1(object sender, EventArgs e)
        {
            if (textBox_search.Text == String.Empty)
            {
                dataGridView.DataSource = JournalLibrary.DBConnector.SelectTeachers();
            }
            else
            {
                dataGridView.DataSource = JournalLibrary.DBConnector.SelectTeacher(Convert.ToInt32(textBox_search.Text));
            }

            textBox_search.Text = String.Empty;
        }
    }
}
