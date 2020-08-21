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
    public partial class AddNote : Form
    {
        int subject_id;
        int class_code;
        int pupil_id;
        int teacher_id;

        int addcount = 0;


        public AddNote(int Subject_id,int Class_code,int Pupil_id,int Teacher_id)
        {
            subject_id = Subject_id;
            class_code = Class_code;
            pupil_id = Pupil_id;
            teacher_id = Teacher_id;
            InitializeComponent();
        }

        private void AddNote_Load(object sender, EventArgs e)
        {
            this.Size = new Size(257, 267);
            DataRow dr = DBConnector.SelectPupilss(pupil_id);
            string pupilName = dr["first_name"].ToString() + " " + dr["last_name"].ToString();
            label_pupilName.Text = pupilName;

            comboBox_subjectAttributes.DataSource = DBConnector.SelectSubjectAttributes(subject_id);
            comboBox_subjectAttributes.DisplayMember = "atrib_code";
            comboBox_subjectAttributes.ValueMember = "atrib_code";
            comboBox_subjectAttributes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_subjectAttributes.SelectedItem = null;

            groupBox1.Hide();

        }

        private void button_addnote_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && !checkBox1.Checked)
            {
                //აკადემიური წელი

                if (addcount == 0)
                {
                    //პირველად
                    DBConnector.AddAcademicYear(subject_id, class_code, pupil_id, teacher_id, int.Parse(comboBox1.SelectedItem.ToString()));
                    MessageBox.Show("წარმატებით დაემატა ნიშანი");
                }
                if (addcount > 0)
                {
                    if (MessageBox.Show("გინდათ რომ ნიშანი მეორეჯერ დაემატოს?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DBConnector.AddAcademicYear(subject_id, class_code, pupil_id, teacher_id, int.Parse(comboBox1.SelectedItem.ToString()));
                        MessageBox.Show("წარმატებით დაემატა ნიშანი");
                    }
                    else
                    {

                    }
                }
                addcount += 1;
            }
            else if (comboBox1.SelectedItem != null && checkBox1.Checked)
            {

                if (comboBox_subjectAttributes.SelectedItem != null && textBox_rate.Text != string.Empty && !DBConnector.GetIfNoteAdded(pupil_id,subject_id,DateTime.Today))  
                {
                    //ატრიბუტი და აკადემიური წელი
                    DBConnector.AddAcademicYear(subject_id, class_code, pupil_id, teacher_id, int.Parse(comboBox1.SelectedText));
                    DBConnector.AddSubjectAtributeValue(comboBox_subjectAttributes.SelectedValue.ToString(), textBox_rate.Text);
                    MessageBox.Show("წარმატებით დაემატა ატრიბუტი და ნიშანი");

                }
                else if (comboBox_subjectAttributes.SelectedItem != null && textBox_rate.Text != string.Empty && DBConnector.GetIfNoteAdded(pupil_id, subject_id, DateTime.Today) && addcount>0)
                {
                    //ბოლოჯერ ფორმის გახსნის დროს
                    //როცა აკადემიური წელი უკვე დამატებულია მაგრამ ატრიბუტი ემატება
                    DBConnector.AddSubjectAtributeValue(comboBox_subjectAttributes.SelectedValue.ToString(), textBox_rate.Text);
                    MessageBox.Show("დაემატა ატრიბუტი");
                }
                else if (comboBox_subjectAttributes.SelectedItem != null && textBox_rate.Text != string.Empty && DBConnector.GetIfNoteAdded(pupil_id, subject_id, DateTime.Today) && addcount == 0)
                {
                    //იგივე აკადემიური წელი მეორეჯერ + ატრიბუტი
                    DBConnector.AddAcademicYear(subject_id, class_code, pupil_id, teacher_id, int.Parse(comboBox1.SelectedText));
                    DBConnector.AddSubjectAtributeValue(comboBox_subjectAttributes.SelectedValue.ToString(), textBox_rate.Text);
                    MessageBox.Show("წარმატებით დაემატა ატრიბუტი და ნიშანი");
                }
                else

                    MessageBox.Show("მიუთითეთ ატრიბუტი და შეფასება");
            }
            else if (comboBox1.SelectedItem  == null && checkBox1.Checked)
            {
                if (comboBox_subjectAttributes.SelectedItem != null && textBox_rate.Text != string.Empty)
                {
                    //მარტო ატრიბუტი
                    DBConnector.AddSubjectAtributeValue(comboBox_subjectAttributes.SelectedValue.ToString(), textBox_rate.Text);
                    MessageBox.Show("წარმატებით დაემატა ატრიბუტი");
                }
                else
                    MessageBox.Show("მიუთითეთ ატრიბუტი და შეფასება");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.Size = new Size(543, 267);
                groupBox1.Show();
            }
            else
            {
                this.Size = new Size(257, 267);
                groupBox1.Hide();
            }
        }
    }
}
