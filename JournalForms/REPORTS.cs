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
    public partial class REPORTS : Form
    {
        public REPORTS()
        {
            InitializeComponent();
        }

        private void REPORTS_Load(object sender, EventArgs e)
        {
            comboBox_pupils.DisplayMember = "full_name";
            comboBox_pupils.ValueMember = "pupil_id";
            comboBox_pupils.DataSource = DBConnector.GetPupilsList();
            comboBox_pupils.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_pupils.SelectedItem = null;

        }

        private void comboBox_pupils_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_pupils.SelectedItem != null)
            {
                dataGridView1.DataSource = DBConnector.GetAllAcademicYearByPupilID(int.Parse(comboBox_pupils.SelectedValue.ToString()));
            }
        }
    }
}
