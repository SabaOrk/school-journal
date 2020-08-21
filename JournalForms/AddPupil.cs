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
    public partial class AddPupil : Form
    {
        bool isNew = false;
        public int pupil_id;
        public int address_code;

        public AddPupil(DataRow dr)
        {
            
            isNew = dr == null;
            InitializeComponent();
            
            pupil_id = (int)dr["pupil_id"];
            address_code = (int)dr["address_code"];

            if (!isNew)
            {

                textBox_fisrtname.Text = (string)dr["first_name"];
                textBox_lastname.Text = (string)dr["last_name"];
                textBox_birthdate.Text = (Convert.ToDateTime(dr["birth_date"])).ToString();
                textBox_personalid.Text = (string)dr["personal_id"];
                textBox_city.Text = (string)dr["city"];
                textBox_country.Text = (string)dr["country"];
                textBox_street.Text = (string)dr["street"];
                textBox_contactnumber.Text = (string)dr["contact_number"];
                textBox_postalcode.Text = ((int)dr["postal_code"]).ToString();
                comboBox_classcode.SelectedItem = dr["class_code"].ToString();
            }
            btn_addpupil.Visible = isNew;
            btn_editpupil.Visible = !isNew;
            
        }

        private void btn_addpupil_Click(object sender, EventArgs e)
        {
            if (textBox_fisrtname.Text != string.Empty  && textBox_lastname.Text != string.Empty && textBox_birthdate.Text != string.Empty && textBox_contactnumber.Text != string.Empty && textBox_personalid.Text != String.Empty && textBox_country.Text != string.Empty && textBox_city.Text != String.Empty && textBox_street.Text != String.Empty && textBox_postalcode.Text != string.Empty)
            {
                JournalLibrary.DBConnector.AddPupil(textBox_fisrtname.Text, textBox_lastname.Text, Convert.ToDateTime(textBox_birthdate.Text), textBox_personalid.Text, textBox_contactnumber.Text, Convert.ToInt32(comboBox_classcode.SelectedValue), textBox_country.Text, textBox_city.Text, textBox_street.Text, Convert.ToInt32(textBox_postalcode.Text));
                this.Close();
            }
            else
            {
                MessageBox.Show("მიუთითეთ ყველაფერი");
            }
        }

        private void AddPupil_Load(object sender, EventArgs e)
        {
            comboBox_classcode.DataSource = JournalLibrary.DBConnector.SelectPupils();
            comboBox_classcode.DisplayMember = "class_name";
            comboBox_classcode.ValueMember = "class_code";
            comboBox_classcode.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btn_editpupil_Click(object sender, EventArgs e)
        {

            JournalLibrary.DBConnector.UpdatePupil(pupil_id,textBox_fisrtname.Text, textBox_lastname.Text, Convert.ToDateTime(textBox_birthdate.Text), textBox_personalid.Text, textBox_contactnumber.Text, Convert.ToInt32(comboBox_classcode.SelectedValue),address_code, textBox_country.Text, textBox_city.Text, textBox_street.Text, Convert.ToInt32(textBox_postalcode.Text));
            this.Close();
        }
    }
}
