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
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void AddTeacher_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_addteacher_Click(object sender, EventArgs e)
        {
            if (textBox_firstname.Text != string.Empty && textBox_lastname.Text != string.Empty && textBox_personal_id.Text != string.Empty && textBox_birthdate.Text != string.Empty && textBox_cuntact_number.Text != string.Empty && textBox_job_start_date.Text != string.Empty)
            {
                JournalLibrary.DBConnector.AddTeacher(textBox_firstname.Text, textBox_lastname.Text, textBox_personal_id.Text, Convert.ToDateTime(textBox_birthdate.Text), textBox_cuntact_number.Text, Convert.ToDateTime(textBox_job_start_date.Text));
                this.Close();
            }
            else
            {
                MessageBox.Show("მიუთითეთ ყველაფერი");
            }
        }
    }
}
