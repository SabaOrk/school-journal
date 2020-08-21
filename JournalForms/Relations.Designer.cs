namespace JournalForms
{
    partial class Relations
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menustrip_teachersubject = new System.Windows.Forms.ToolStripMenuItem();
            this.menustrip_teacherclass = new System.Windows.Forms.ToolStripMenuItem();
            this.menustrip_pupilsubject = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CheckColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menustrip_teachersubject,
            this.menustrip_teacherclass,
            this.menustrip_pupilsubject});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menustrip_teachersubject
            // 
            this.menustrip_teachersubject.Name = "menustrip_teachersubject";
            this.menustrip_teachersubject.Size = new System.Drawing.Size(162, 20);
            this.menustrip_teachersubject.Text = "მასწავლებელი - საგანი";
            this.menustrip_teachersubject.Click += new System.EventHandler(this.menustrip_teachersubject_Click);
            // 
            // menustrip_teacherclass
            // 
            this.menustrip_teacherclass.Name = "menustrip_teacherclass";
            this.menustrip_teacherclass.Size = new System.Drawing.Size(161, 20);
            this.menustrip_teacherclass.Text = "მასწავლებელი - კლასი";
            this.menustrip_teacherclass.Click += new System.EventHandler(this.menustrip_teacherclass_Click);
            // 
            // menustrip_pupilsubject
            // 
            this.menustrip_pupilsubject.Name = "menustrip_pupilsubject";
            this.menustrip_pupilsubject.Size = new System.Drawing.Size(132, 20);
            this.menustrip_pupilsubject.Text = "მოსწავლე - საგანი";
            this.menustrip_pupilsubject.Click += new System.EventHandler(this.menustrip_pupilsubject_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_add);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(100, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 396);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "კავშირები";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(463, 25);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(135, 28);
            this.button_add.TabIndex = 3;
            this.button_add.Text = "დამახსოვრება";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(260, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckColumn});
            this.dataGridView1.Location = new System.Drawing.Point(6, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 314);
            this.dataGridView1.TabIndex = 0;
            // 
            // CheckColumn
            // 
            this.CheckColumn.HeaderText = "მონიშნეთ";
            this.CheckColumn.Name = "CheckColumn";
            // 
            // Relations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Relations";
            this.Text = "Relations";
            this.Load += new System.EventHandler(this.Relations_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menustrip_teachersubject;
        private System.Windows.Forms.ToolStripMenuItem menustrip_teacherclass;
        private System.Windows.Forms.ToolStripMenuItem menustrip_pupilsubject;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckColumn;
    }
}