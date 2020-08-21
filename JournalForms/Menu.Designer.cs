namespace JournalForms
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btn_users = new System.Windows.Forms.Button();
            this.btn_teachers = new System.Windows.Forms.Button();
            this.btn_pupils = new System.Windows.Forms.Button();
            this.btn_subjects = new System.Windows.Forms.Button();
            this.btn_classes = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.button_relations = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_users
            // 
            this.btn_users.Location = new System.Drawing.Point(22, 23);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(110, 45);
            this.btn_users.TabIndex = 0;
            this.btn_users.Text = "USERS";
            this.btn_users.UseVisualStyleBackColor = true;
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            this.btn_users.MouseLeave += new System.EventHandler(this.btn_users_MouseLeave);
            this.btn_users.MouseHover += new System.EventHandler(this.btn_users_MouseHover);
            // 
            // btn_teachers
            // 
            this.btn_teachers.Location = new System.Drawing.Point(151, 23);
            this.btn_teachers.Name = "btn_teachers";
            this.btn_teachers.Size = new System.Drawing.Size(110, 45);
            this.btn_teachers.TabIndex = 1;
            this.btn_teachers.Text = "TEACHERS";
            this.btn_teachers.UseVisualStyleBackColor = true;
            this.btn_teachers.Click += new System.EventHandler(this.btn_teachers_Click);
            this.btn_teachers.MouseLeave += new System.EventHandler(this.btn_teachers_MouseLeave);
            this.btn_teachers.MouseHover += new System.EventHandler(this.btn_teachers_MouseHover);
            // 
            // btn_pupils
            // 
            this.btn_pupils.Location = new System.Drawing.Point(278, 23);
            this.btn_pupils.Name = "btn_pupils";
            this.btn_pupils.Size = new System.Drawing.Size(110, 45);
            this.btn_pupils.TabIndex = 2;
            this.btn_pupils.Text = "PUPILS";
            this.btn_pupils.UseVisualStyleBackColor = true;
            this.btn_pupils.Click += new System.EventHandler(this.btn_pupils_Click);
            this.btn_pupils.MouseLeave += new System.EventHandler(this.btn_pupils_MouseLeave);
            this.btn_pupils.MouseHover += new System.EventHandler(this.btn_pupils_MouseHover);
            // 
            // btn_subjects
            // 
            this.btn_subjects.Location = new System.Drawing.Point(408, 23);
            this.btn_subjects.Name = "btn_subjects";
            this.btn_subjects.Size = new System.Drawing.Size(110, 45);
            this.btn_subjects.TabIndex = 3;
            this.btn_subjects.Text = "SUBJECTS";
            this.btn_subjects.UseVisualStyleBackColor = true;
            this.btn_subjects.Click += new System.EventHandler(this.btn_subjects_Click);
            this.btn_subjects.MouseLeave += new System.EventHandler(this.btn_subjects_MouseLeave);
            this.btn_subjects.MouseHover += new System.EventHandler(this.btn_subjects_MouseHover);
            // 
            // btn_classes
            // 
            this.btn_classes.Location = new System.Drawing.Point(538, 23);
            this.btn_classes.Name = "btn_classes";
            this.btn_classes.Size = new System.Drawing.Size(110, 45);
            this.btn_classes.TabIndex = 4;
            this.btn_classes.Text = "CLASSES";
            this.btn_classes.UseVisualStyleBackColor = true;
            this.btn_classes.Click += new System.EventHandler(this.btn_classes_Click);
            this.btn_classes.MouseCaptureChanged += new System.EventHandler(this.btn_classes_MouseCaptureChanged);
            this.btn_classes.MouseLeave += new System.EventHandler(this.btn_classes_MouseLeave);
            this.btn_classes.MouseHover += new System.EventHandler(this.btn_classes_MouseHover);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(713, 415);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // button_relations
            // 
            this.button_relations.Location = new System.Drawing.Point(666, 23);
            this.button_relations.Name = "button_relations";
            this.button_relations.Size = new System.Drawing.Size(110, 45);
            this.button_relations.TabIndex = 6;
            this.button_relations.Text = "RELATIONS";
            this.button_relations.UseVisualStyleBackColor = true;
            this.button_relations.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(666, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "REPORTS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_relations);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_classes);
            this.Controls.Add(this.btn_subjects);
            this.Controls.Add(this.btn_pupils);
            this.Controls.Add(this.btn_teachers);
            this.Controls.Add(this.btn_users);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_users;
        private System.Windows.Forms.Button btn_teachers;
        private System.Windows.Forms.Button btn_pupils;
        private System.Windows.Forms.Button btn_subjects;
        private System.Windows.Forms.Button btn_classes;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button button_relations;
        private System.Windows.Forms.Button button1;
    }
}