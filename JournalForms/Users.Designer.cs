namespace JournalForms
{
    partial class Users
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
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_add_user
            // 
            this.btn_add_user.Click += new System.EventHandler(this.btn_add_user_Click_1);
            // 
            // btn_remove_user
            // 
            this.btn_remove_user.Click += new System.EventHandler(this.btn_remove_user_Click_1);
            // 
            // btn_edit_user
            // 
            this.btn_edit_user.Click += new System.EventHandler(this.btn_edit_user_Click_1);
            // 
            // btn_search_user
            // 
            this.btn_search_user.Size = new System.Drawing.Size(58, 30);
            this.btn_search_user.Click += new System.EventHandler(this.btn_search_user_Click_1);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(76, 166);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(90, 20);
            this.textBox_search.TabIndex = 11;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 348);
            this.Controls.Add(this.textBox_search);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.Controls.SetChildIndex(this.btn_add_user, 0);
            this.Controls.SetChildIndex(this.btn_remove_user, 0);
            this.Controls.SetChildIndex(this.btn_edit_user, 0);
            this.Controls.SetChildIndex(this.btn_search_user, 0);
            this.Controls.SetChildIndex(this.textBox_search, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_search;
    }
}