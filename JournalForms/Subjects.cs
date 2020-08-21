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
    public partial class Subjects : BaseForm
    {
        public Subjects()
        {
            InitializeComponent();
        }

        private void Subjects_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = JournalLibrary.DBConnector.SelectSubjects();
        }

        private void btn_search_user_Click_1(object sender, EventArgs e)
        {
            if (textBox_search.Text != String.Empty)
            {
                dataGridView.DataSource = JournalLibrary.DBConnector.SelectSubject(Convert.ToInt32(textBox_search.Text));
                textBox_search.Text = String.Empty;
            }
            else
                dataGridView.DataSource = JournalLibrary.DBConnector.SelectSubjects();
        }
    }
}
