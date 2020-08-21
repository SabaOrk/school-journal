namespace JournalForms
{
    partial class AddNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNote));
            this.label_pupilName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_subjectAttributes = new System.Windows.Forms.ComboBox();
            this.label_subjectattribute = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_rate = new System.Windows.Forms.TextBox();
            this.button_addnote = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_pupilName
            // 
            this.label_pupilName.AutoSize = true;
            this.label_pupilName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pupilName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_pupilName.Location = new System.Drawing.Point(12, 29);
            this.label_pupilName.Name = "label_pupilName";
            this.label_pupilName.Size = new System.Drawing.Size(92, 20);
            this.label_pupilName.TabIndex = 0;
            this.label_pupilName.Text = "მოსწავლე:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "მოსწავლე:";
            // 
            // comboBox_subjectAttributes
            // 
            this.comboBox_subjectAttributes.FormattingEnabled = true;
            this.comboBox_subjectAttributes.Location = new System.Drawing.Point(117, 35);
            this.comboBox_subjectAttributes.Name = "comboBox_subjectAttributes";
            this.comboBox_subjectAttributes.Size = new System.Drawing.Size(121, 28);
            this.comboBox_subjectAttributes.TabIndex = 2;
            // 
            // label_subjectattribute
            // 
            this.label_subjectattribute.AutoSize = true;
            this.label_subjectattribute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_subjectattribute.Location = new System.Drawing.Point(16, 33);
            this.label_subjectattribute.Name = "label_subjectattribute";
            this.label_subjectattribute.Size = new System.Drawing.Size(95, 20);
            this.label_subjectattribute.TabIndex = 3;
            this.label_subjectattribute.Text = "ატრიბუტი:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "შეფასება:";
            // 
            // textBox_rate
            // 
            this.textBox_rate.Location = new System.Drawing.Point(117, 104);
            this.textBox_rate.Multiline = true;
            this.textBox_rate.Name = "textBox_rate";
            this.textBox_rate.Size = new System.Drawing.Size(121, 74);
            this.textBox_rate.TabIndex = 5;
            // 
            // button_addnote
            // 
            this.button_addnote.Location = new System.Drawing.Point(12, 167);
            this.button_addnote.Name = "button_addnote";
            this.button_addnote.Size = new System.Drawing.Size(75, 23);
            this.button_addnote.TabIndex = 6;
            this.button_addnote.Text = "გაგზავნა";
            this.button_addnote.UseVisualStyleBackColor = true;
            this.button_addnote.Click += new System.EventHandler(this.button_addnote_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "შეფასება:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(104, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_rate);
            this.groupBox1.Controls.Add(this.comboBox_subjectAttributes);
            this.groupBox1.Controls.Add(this.label_subjectattribute);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(265, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 206);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ატრიბუტები";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(12, 110);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(200, 24);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "ატრიბუტის დამატება";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // AddNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(534, 228);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_addnote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_pupilName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNote";
            this.Text = "AddNote";
            this.Load += new System.EventHandler(this.AddNote_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_pupilName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_subjectAttributes;
        private System.Windows.Forms.Label label_subjectattribute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_rate;
        private System.Windows.Forms.Button button_addnote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}