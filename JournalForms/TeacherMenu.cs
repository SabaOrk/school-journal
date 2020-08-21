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
    public partial class TeacherMenu : Form
    {
        int teacher_id = 0;
        int pupil_id;

        public TeacherMenu(int Teacher_id)
        {
            teacher_id = Teacher_id;
            InitializeComponent();
        }

        private void TeacherMenu_Load(object sender, EventArgs e)
        {
            DataRow tName = DBConnector.SelectTeacher(teacher_id).Rows[0];

            btn_back.Hide();

            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.Hide();
            dataGridView1.AllowUserToAddRows = false;

            label_tname.Text = tName["first_name"].ToString() + " " + tName["last_name"].ToString();

            comboBox_classes.DataSource = DBConnector.GetClassesByTeacherID(teacher_id);
            comboBox_classes.DisplayMember = "class_name";
            comboBox_classes.ValueMember = "class_code";
            comboBox_classes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_classes.SelectedItem = null;

            comboBox_subjects.DataSource = DBConnector.GetSubjectsByTeacherID(teacher_id);
            comboBox_subjects.DisplayMember = "subject_name";
            comboBox_subjects.ValueMember = "subject_id";
            comboBox_subjects.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_subjects.SelectedItem = null;

        }

        private void comboBox_classes_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_subjects_SelectedIndexChanged(sender, e);
        }

        private void comboBox_subjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns["note"].Visible = false;
            dataGridView1.Columns["notes"].Visible = false;

            if (comboBox_subjects.SelectedItem != null && comboBox_classes.SelectedItem != null && btn_back.Visible == false)
            {
                dataGridView1.Columns["note"].Visible = true;
                dataGridView1.Columns["notes"].Visible = true;

                dataGridView1.DataSource = DBConnector.GetPupilsBySubjectIdAndClassCode(int.Parse(comboBox_subjects.SelectedValue.ToString()), int.Parse(comboBox_classes.SelectedValue.ToString()));

                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if (DBConnector.GetIfNoteAdded(int.Parse(item.Cells["pupil_id"].Value.ToString()), int.Parse(comboBox_subjects.SelectedValue.ToString()), DateTime.Today))
                    {
                        item.DefaultCellStyle.BackColor = Color.Green;
                    }
                }
            }
            else if (comboBox_subjects.SelectedItem != null && comboBox_classes.SelectedItem != null && btn_back.Visible == true)
            {
                dataGridView1.DataSource = DBConnector.GetAcademicYearBySubjectIdAndClassCode(pupil_id, int.Parse(comboBox_subjects.SelectedValue.ToString()), int.Parse(comboBox_classes.SelectedValue.ToString()), teacher_id,dateTimePicker1.Value);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0 && comboBox_classes.SelectedItem != null || comboBox_subjects.SelectedItem != null)
            {
                pupil_id = int.Parse(dataGridView1.CurrentRow.Cells["pupil_id"].Value.ToString());

                if (e.ColumnIndex == dataGridView1.Columns["note"].Index)
                {
                    AddNote addNote = new AddNote(int.Parse(comboBox_subjects.SelectedValue.ToString()),
                                            int.Parse(comboBox_classes.SelectedValue.ToString()),
                                            pupil_id,
                                            teacher_id);

                    var dialogRes = addNote.ShowDialog();
                    comboBox_subjects_SelectedIndexChanged(sender, e);

                    if (DBConnector.GetIfNoteAdded(pupil_id, int.Parse(comboBox_subjects.SelectedValue.ToString()), DateTime.Today))
                    {
                        dataGridView1.CurrentRow.DefaultCellStyle.BackColor = Color.Green;
                    }
                }
                else if (e.ColumnIndex == dataGridView1.Columns["notes"].Index)
                {
                    DataRow pupilname = DBConnector.SelectPupilss(pupil_id);

                    btn_back.Show();

                    comboBox_classes.Hide();
                    label_classes.Hide();

                    dateTimePicker1.Show();

                    label_teachername.Text = "მოსწავლე: ";
                    label_tname.Location = new Point(120, 12);
                    label_tname.Text = pupilname["first_name"].ToString() + " " + pupilname["last_name"].ToString();

                    dataGridView1.Columns["note"].Visible = false;
                    dataGridView1.Columns["notes"].Visible = false;

                    dataGridView1.DataSource = DBConnector.GetAcademicYearBySubjectIdAndClassCode(pupil_id, int.Parse(comboBox_subjects.SelectedValue.ToString()), int.Parse(comboBox_classes.SelectedValue.ToString()), teacher_id,dateTimePicker1.Value);
                }
                else
                {
                    MessageBox.Show("აირჩიეთ მოსწავლე");
                }
            }
           
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            comboBox_subjects_SelectedIndexChanged(sender, e);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            btn_back.Hide();
            dateTimePicker1.Hide();
            comboBox_classes.Show();
            label_classes.Show();

            DataRow tName = DBConnector.SelectTeacher(teacher_id).Rows[0];
            label_teachername.Text = "მასწავლებელი: ";
            label_tname.Location = new Point(162, 12);
            label_tname.Text = tName["first_name"].ToString() + " " + tName["last_name"].ToString();

            comboBox_subjects_SelectedIndexChanged(sender, e);

        }

        private void TeacherMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            btn_back_Click(sender, e);
        }
    }
}
