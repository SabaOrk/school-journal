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
    public partial class Pupils : BaseForm
    {
        public Pupils()
        {
            InitializeComponent();
        }

        private void Pupils_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = JournalLibrary.DBConnector.SelectPupils(0);
        }

        private void btn_remove_user_Click_1(object sender, EventArgs e)
        {
            var res = MessageBox.Show("გსურთ წაშალოთ მოსწავლე?", "", MessageBoxButtons.YesNo);

           if (res == DialogResult.Yes)
            {
                DataRow dr = GetCurrentRow();

                int cuttPupil_id = (int)dr["pupil_id"];
                JournalLibrary.DBConnector.RemovePupil(cuttPupil_id);
                dataGridView.DataSource = JournalLibrary.DBConnector.SelectPupils(0);
            }
        }

        private void btn_search_user_Click_1(object sender, EventArgs e)
        {
            if (textBox_search.Text == string.Empty)
            {
               dataGridView.DataSource = JournalLibrary.DBConnector.SelectPupils(0);
            }
            else
            {
               dataGridView.DataSource = JournalLibrary.DBConnector.SelectPupils(Convert.ToInt32(textBox_search.Text));
                textBox_search.Text = String.Empty;
            }
           
        }

        private void btn_add_user_Click_1(object sender, EventArgs e)
        {
            AddPupil addPupil = new AddPupil(null);
            addPupil.Show();
        }

        private void btn_edit_user_Click_1(object sender, EventArgs e)
        {
            DataRow dr = GetCurrentRow();

            (new AddPupil(DBConnector.SelectPupilss((int)dr["pupil_id"]))).ShowDialog(this);
        }
    }
}
