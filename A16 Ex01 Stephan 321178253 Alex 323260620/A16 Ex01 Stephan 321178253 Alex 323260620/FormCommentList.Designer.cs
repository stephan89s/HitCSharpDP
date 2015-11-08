namespace A16_Ex01_Stephan_321178253_Alex_323260620
{
    partial class FormCommentList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCommentList));
            this.dataGridViewComments = new System.Windows.Forms.DataGridView();
            this.CommentFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.labelContentFilter = new System.Windows.Forms.Label();
            this.labelNameFilter = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComments)).BeginInit();
            this.CommentFilterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewComments
            // 
            this.dataGridViewComments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewComments.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComments.Location = new System.Drawing.Point(13, 101);
            this.dataGridViewComments.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewComments.MultiSelect = false;
            this.dataGridViewComments.Name = "dataGridViewComments";
            this.dataGridViewComments.RowHeadersVisible = false;
            this.dataGridViewComments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewComments.Size = new System.Drawing.Size(675, 220);
            this.dataGridViewComments.TabIndex = 29;
            // 
            // CommentFilterGroupBox
            // 
            this.CommentFilterGroupBox.Controls.Add(this.labelContentFilter);
            this.CommentFilterGroupBox.Controls.Add(this.labelNameFilter);
            this.CommentFilterGroupBox.Controls.Add(this.textBox2);
            this.CommentFilterGroupBox.Controls.Add(this.textBox1);
            this.CommentFilterGroupBox.Location = new System.Drawing.Point(13, 13);
            this.CommentFilterGroupBox.Name = "CommentFilterGroupBox";
            this.CommentFilterGroupBox.Size = new System.Drawing.Size(675, 81);
            this.CommentFilterGroupBox.TabIndex = 30;
            this.CommentFilterGroupBox.TabStop = false;
            this.CommentFilterGroupBox.Text = "CommentFilterGroupBox";
            // 
            // labelContentFilter
            // 
            this.labelContentFilter.AutoSize = true;
            this.labelContentFilter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContentFilter.Location = new System.Drawing.Point(9, 44);
            this.labelContentFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContentFilter.Name = "labelContentFilter";
            this.labelContentFilter.Size = new System.Drawing.Size(64, 17);
            this.labelContentFilter.TabIndex = 7;
            this.labelContentFilter.Text = "Message:";
            // 
            // labelNameFilter
            // 
            this.labelNameFilter.AutoSize = true;
            this.labelNameFilter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameFilter.Location = new System.Drawing.Point(273, 42);
            this.labelNameFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameFilter.Name = "labelNameFilter";
            this.labelNameFilter.Size = new System.Drawing.Size(45, 17);
            this.labelNameFilter.TabIndex = 6;
            this.labelNameFilter.Text = "From:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 36);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(326, 37);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 22);
            this.textBox1.TabIndex = 4;
            // 
            // FormCommentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 334);
            this.Controls.Add(this.CommentFilterGroupBox);
            this.Controls.Add(this.dataGridViewComments);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCommentList";
            this.Text = "Comments";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComments)).EndInit();
            this.CommentFilterGroupBox.ResumeLayout(false);
            this.CommentFilterGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewComments;
        private System.Windows.Forms.GroupBox CommentFilterGroupBox;
        private System.Windows.Forms.Label labelContentFilter;
        private System.Windows.Forms.Label labelNameFilter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}