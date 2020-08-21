namespace JournalForms
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btn_add_user = new System.Windows.Forms.Button();
            this.btn_remove_user = new System.Windows.Forms.Button();
            this.btn_edit_user = new System.Windows.Forms.Button();
            this.btn_search_user = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(172, 13);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(619, 325);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // btn_add_user
            // 
            this.btn_add_user.Location = new System.Drawing.Point(13, 13);
            this.btn_add_user.Name = "btn_add_user";
            this.btn_add_user.Size = new System.Drawing.Size(153, 43);
            this.btn_add_user.TabIndex = 1;
            this.btn_add_user.Text = "დამატება";
            this.btn_add_user.UseVisualStyleBackColor = true;
            this.btn_add_user.Click += new System.EventHandler(this.btn_add_user_Click);
            // 
            // btn_remove_user
            // 
            this.btn_remove_user.Location = new System.Drawing.Point(13, 62);
            this.btn_remove_user.Name = "btn_remove_user";
            this.btn_remove_user.Size = new System.Drawing.Size(153, 43);
            this.btn_remove_user.TabIndex = 2;
            this.btn_remove_user.Text = "წაშლა";
            this.btn_remove_user.UseVisualStyleBackColor = true;
            this.btn_remove_user.Click += new System.EventHandler(this.btn_remove_user_Click);
            // 
            // btn_edit_user
            // 
            this.btn_edit_user.Location = new System.Drawing.Point(13, 111);
            this.btn_edit_user.Name = "btn_edit_user";
            this.btn_edit_user.Size = new System.Drawing.Size(153, 43);
            this.btn_edit_user.TabIndex = 3;
            this.btn_edit_user.Text = "რედაქტირება";
            this.btn_edit_user.UseVisualStyleBackColor = true;
            this.btn_edit_user.Click += new System.EventHandler(this.btn_edit_user_Click);
            // 
            // btn_search_user
            // 
            this.btn_search_user.Location = new System.Drawing.Point(12, 160);
            this.btn_search_user.Name = "btn_search_user";
            this.btn_search_user.Size = new System.Drawing.Size(153, 43);
            this.btn_search_user.TabIndex = 4;
            this.btn_search_user.Text = "ძიება";
            this.btn_search_user.UseVisualStyleBackColor = true;
            this.btn_search_user.Click += new System.EventHandler(this.btn_search_user_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(803, 350);
            this.Controls.Add(this.btn_search_user);
            this.Controls.Add(this.btn_edit_user);
            this.Controls.Add(this.btn_remove_user);
            this.Controls.Add(this.btn_add_user);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView;
        public System.Windows.Forms.Button btn_add_user;
        public System.Windows.Forms.Button btn_remove_user;
        public System.Windows.Forms.Button btn_edit_user;
        public System.Windows.Forms.Button btn_search_user;
    }
}