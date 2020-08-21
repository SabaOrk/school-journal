namespace JournalForms
{
    partial class Subjects
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
            // btn_search_user
            // 
            this.btn_search_user.Size = new System.Drawing.Size(57, 29);
            this.btn_search_user.Click += new System.EventHandler(this.btn_search_user_Click_1);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(75, 165);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(91, 20);
            this.textBox_search.TabIndex = 5;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_search);
            this.Name = "Subjects";
            this.Text = "Subjects";
            this.Load += new System.EventHandler(this.Subjects_Load);
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