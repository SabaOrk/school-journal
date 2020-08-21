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
    public partial class PupilMenu : Form
    {
        int pupil_id;

        public PupilMenu(string _PID)
        {
            pupil_id = int.Parse(DBConnector.SelectPupilByPID(_PID));
            InitializeComponent();
        }

        private void PupilForm_Load(object sender, EventArgs e)
        {
            comboBox_subjects.DisplayMember = "subject_name";
            comboBox_subjects.ValueMember = "subject_id";
            comboBox_subjects.DataSource = DBConnector.GetSubjectsByPupilId(pupil_id);
            comboBox_subjects.DropDownStyle = ComboBoxStyle.DropDownList;


            dateTimePicker1.Value = DateTime.Today;
            label2.Text = DBConnector.SelectPupilss(pupil_id)["first_name"].ToString() + " " + DBConnector.SelectPupilss(pupil_id)["last_name"].ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox_subjects.SelectedItem != null)
            {
                dataGridView1.DataSource = DBConnector.GetAcademicYearByPupilID(pupil_id, int.Parse(comboBox_subjects.SelectedValue.ToString()), dateTimePicker1.Value);
            }
        }

        private void comboBox_subjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker1_ValueChanged(sender, e);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
    }
}
