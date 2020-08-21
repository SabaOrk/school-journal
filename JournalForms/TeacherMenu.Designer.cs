namespace JournalForms
{
    partial class TeacherMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherMenu));
            this.comboBox_subjects = new System.Windows.Forms.ComboBox();
            this.comboBox_classes = new System.Windows.Forms.ComboBox();
            this.label_subjects = new System.Windows.Forms.Label();
            this.label_classes = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.note = new System.Windows.Forms.DataGridViewButtonColumn();
            this.notes = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label_teachername = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label_tname = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_subjects
            // 
            this.comboBox_subjects.FormattingEnabled = true;
            this.comboBox_subjects.Location = new System.Drawing.Point(595, 14);
            this.comboBox_subjects.Name = "comboBox_subjects";
            this.comboBox_subjects.Size = new System.Drawing.Size(121, 21);
            this.comboBox_subjects.TabIndex = 0;
            this.comboBox_subjects.SelectedIndexChanged += new System.EventHandler(this.comboBox_subjects_SelectedIndexChanged);
            // 
            // comboBox_classes
            // 
            this.comboBox_classes.FormattingEnabled = true;
            this.comboBox_classes.Location = new System.Drawing.Point(397, 14);
            this.comboBox_classes.Name = "comboBox_classes";
            this.comboBox_classes.Size = new System.Drawing.Size(121, 21);
            this.comboBox_classes.TabIndex = 1;
            this.comboBox_classes.SelectedIndexChanged += new System.EventHandler(this.comboBox_classes_SelectedIndexChanged);
            // 
            // label_subjects
            // 
            this.label_subjects.AutoSize = true;
            this.label_subjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_subjects.Location = new System.Drawing.Point(524, 12);
            this.label_subjects.Name = "label_subjects";
            this.label_subjects.Size = new System.Drawing.Size(65, 20);
            this.label_subjects.TabIndex = 2;
            this.label_subjects.Text = "საგანი:";
            // 
            // label_classes
            // 
            this.label_classes.AutoSize = true;
            this.label_classes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_classes.Location = new System.Drawing.Point(330, 12);
            this.label_classes.Name = "label_classes";
            this.label_classes.Size = new System.Drawing.Size(61, 20);
            this.label_classes.TabIndex = 3;
            this.label_classes.Text = "კლასი:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.note,
            this.notes});
            this.dataGridView1.Location = new System.Drawing.Point(12, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(927, 285);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // note
            // 
            this.note.HeaderText = "ნიშნის დამატება";
            this.note.Name = "note";
            this.note.Text = "დამატება";
            this.note.UseColumnTextForButtonValue = true;
            // 
            // notes
            // 
            this.notes.HeaderText = "ნიშნები";
            this.notes.Name = "notes";
            this.notes.Text = "ნახვა";
            this.notes.UseColumnTextForButtonValue = true;
            // 
            // label_teachername
            // 
            this.label_teachername.AutoSize = true;
            this.label_teachername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_teachername.Location = new System.Drawing.Point(23, 12);
            this.label_teachername.Name = "label_teachername";
            this.label_teachername.Size = new System.Drawing.Size(144, 20);
            this.label_teachername.TabIndex = 5;
            this.label_teachername.Text = "მასწავლებელი:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label_tname
            // 
            this.label_tname.AutoSize = true;
            this.label_tname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tname.Location = new System.Drawing.Point(162, 12);
            this.label_tname.Name = "label_tname";
            this.label_tname.Size = new System.Drawing.Size(131, 20);
            this.label_tname.TabIndex = 7;
            this.label_tname.Text = "მასწავლებელი:";
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(864, 344);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 8;
            this.btn_logout.Text = "გამოსვლა";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(739, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Value = new System.DateTime(2019, 2, 5, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 344);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 12;
            this.btn_back.Text = "უკან";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // TeacherMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(955, 379);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.label_tname);
            this.Controls.Add(this.label_teachername);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_classes);
            this.Controls.Add(this.label_subjects);
            this.Controls.Add(this.comboBox_classes);
            this.Controls.Add(this.comboBox_subjects);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeacherMenu";
            this.Text = "TeacherMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeacherMenu_FormClosed);
            this.Load += new System.EventHandler(this.TeacherMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_subjects;
        private System.Windows.Forms.ComboBox comboBox_classes;
        private System.Windows.Forms.Label label_subjects;
        private System.Windows.Forms.Label label_classes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_teachername;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label_tname;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridViewButtonColumn note;
        private System.Windows.Forms.DataGridViewButtonColumn notes;
    }
}