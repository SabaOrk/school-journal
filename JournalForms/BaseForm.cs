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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        public virtual void BaseForm_Load(object sender, EventArgs e)
        {
           
        }

        public virtual void btn_add_user_Click(object sender, EventArgs e)
        {

        }

        public virtual void btn_remove_user_Click(object sender, EventArgs e)
        {

        }

        public virtual void btn_edit_user_Click(object sender, EventArgs e)
        {

        }

        public virtual void btn_search_user_Click(object sender, EventArgs e)
        {

        }

        internal DataRow GetCurrentRow()
        {
            DataRow dr = null;
            dr = ((DataRowView)dataGridView.CurrentRow.DataBoundItem).Row;

            return dr;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
