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
    public partial class Relations : Form
    {
        public Relations()
        {
            InitializeComponent();
        }

        string menustrip;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //მასწავლებელი - საგანი
            if (menustrip == "მასწავლებელი - საგანი")
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    item.Cells[0].Value = false;
                }

                if (comboBox1.SelectedValue != null)
                {
                    int teacher_id = int.Parse(comboBox1.SelectedValue.ToString());
                    if (teacher_id != 0)
                    {

                        List<int> subjectsList = DBConnector.GetSubjectByTeacherId(teacher_id);

                        foreach (DataGridViewRow item in dataGridView1.Rows)
                        {
                            try
                            {
                                int subject_id = int.Parse(item.Cells["subject_id"].Value.ToString());
                                if (subjectsList.Contains(subject_id))
                                    item.Cells[0].Value = true;
                            }
                            catch (Exception ex)
                            {
                                continue;
                            }
                        }
                    }
                }
            }
            //მასწავლებელი - კლასი
            if (menustrip == "მასწავლებელი - კლასი")
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    item.Cells[0].Value = false;
                }

                if (comboBox1.SelectedValue != null)
                {
                    int teacher_id = int.Parse(comboBox1.SelectedValue.ToString());
                    if (teacher_id != 0)
                    {

                        List<int> classList = DBConnector.GetClassByTeacherId(teacher_id);

                        foreach (DataGridViewRow item in dataGridView1.Rows)
                        {
                            try
                            {
                                int class_code = int.Parse(item.Cells["class_code"].Value.ToString());
                                if (classList.Contains(class_code))
                                    item.Cells[0].Value = true;
                            }
                            catch (Exception ex)
                            {
                                continue;
                            }
                        }
                    }
                }
            }
            //მოსწავლე - საგანი
            if (menustrip == "მოსწავლე - საგანი")
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    item.Cells[0].Value = false;
                }

                if (comboBox1.SelectedValue != null)
                {
                    int pupil_id = int.Parse(comboBox1.SelectedValue.ToString());
                    if (pupil_id != 0)
                    {

                        List<int> subjectList = DBConnector.GetSubjectByPupilId(pupil_id);

                        foreach (DataGridViewRow item in dataGridView1.Rows)
                        {
                            try
                            {
                                int subject_id = int.Parse(item.Cells["subject_id"].Value.ToString());
                                if (subjectList.Contains(subject_id))
                                    item.Cells[0].Value = true;
                            }
                            catch (Exception ex)
                            {
                                continue;
                            }
                        }
                    }
                }
            }
        }

        private void Relations_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
        }

        private void menustrip_teachersubject_Click(object sender, EventArgs e)
        {
            menustrip = (sender as ToolStripMenuItem).Text;

            groupBox1.Show();
            label1.Text = "მასწავლებელი";

            dataGridView1.DataSource = DBConnector.SelectSubjects();

            comboBox1.DisplayMember = "full_name";
            comboBox1.ValueMember = "teacher_id";
            comboBox1.DataSource = DBConnector.SelectTeacher();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedItem = null;
        }

        private void menustrip_teacherclass_Click(object sender, EventArgs e)
        {
            menustrip = (sender as ToolStripMenuItem).Text;

            groupBox1.Show();
            label1.Text = "მასწავლებელი";

            dataGridView1.DataSource = DBConnector.SelectClasses();


            comboBox1.DisplayMember = "full_name";
            comboBox1.ValueMember = "teacher_id";
            comboBox1.DataSource = DBConnector.SelectTeacher();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedItem = null;
        }

        private void menustrip_pupilsubject_Click(object sender, EventArgs e)
        {
            menustrip = (sender as ToolStripMenuItem).Text;

            groupBox1.Show();
            label1.Text = "მოსწავლე";

            dataGridView1.DataSource = DBConnector.SelectSubjects();

            comboBox1.DisplayMember = "full_name";
            comboBox1.ValueMember = "pupil_id";
            comboBox1.DataSource = DBConnector.SelectPupil();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedItem = null;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (menustrip == "მასწავლებელი - საგანი")
            {
                if (comboBox1.SelectedItem != null)
                {
                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
                        try
                        {
                            if (item.Cells[0].Value is true)
                            {
                                DBConnector.AddTeacherSubjectRelation(int.Parse(item.Cells[1].Value.ToString()), int.Parse(comboBox1.SelectedValue.ToString()));
                            }
                            else if (item.Cells[0].Value is false)
                            {
                                DBConnector.RemoveTeacherSubjectRelation(int.Parse(item.Cells[1].Value.ToString()), int.Parse(comboBox1.SelectedValue.ToString()));
                            }
                        }
                        catch (Exception ex)
                        {
                            if (ex.Message.Contains("UNIQUE"))
                                continue;

                            //MessageBox.Show(ex.Message);
                        }
                    }
                    MessageBox.Show("დამახსოვრებულია!");
                }
                else
                    MessageBox.Show("აირჩიეთ მასწავლებელი");
            }

            if (menustrip == "მასწავლებელი - კლასი")
            {
                if (comboBox1.SelectedItem != null)
                {
                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
                        try
                        {
                            if (item.Cells[0].Value is true)
                            {
                                DBConnector.AddTeacherClassRelation(int.Parse(item.Cells[1].Value.ToString()), int.Parse(comboBox1.SelectedValue.ToString()));
                            }
                            else if (item.Cells[0].Value is false)
                            {
                                DBConnector.RemoveTeacherClassRelation(int.Parse(item.Cells[1].Value.ToString()), int.Parse(comboBox1.SelectedValue.ToString()));
                            }
                        }
                        catch (Exception ex)
                        {
                            if (ex.Message.Contains("UNIQUE"))
                                continue;

                            //MessageBox.Show(ex.Message);
                        }
                    }
                    MessageBox.Show("დამახსოვრებულია!");
                }
                else
                    MessageBox.Show("აირჩიეთ მასწავლებელი");
            }

        }

        

      
    }
}
