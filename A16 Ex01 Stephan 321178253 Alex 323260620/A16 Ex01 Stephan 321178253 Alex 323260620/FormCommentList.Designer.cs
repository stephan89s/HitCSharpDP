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
            this.buttonCloseComment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComments)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewComments
            // 
            this.dataGridViewComments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewComments.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComments.Location = new System.Drawing.Point(0, 13);
            this.dataGridViewComments.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewComments.MultiSelect = false;
            this.dataGridViewComments.Name = "dataGridViewComments";
            this.dataGridViewComments.RowHeadersVisible = false;
            this.dataGridViewComments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewComments.Size = new System.Drawing.Size(701, 291);
            this.dataGridViewComments.TabIndex = 29;
            // 
            // buttonCloseComment
            // 
            this.buttonCloseComment.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonCloseComment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonCloseComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseComment.Location = new System.Drawing.Point(0, 313);
            this.buttonCloseComment.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCloseComment.Name = "buttonCloseComment";
            this.buttonCloseComment.Size = new System.Drawing.Size(701, 60);
            this.buttonCloseComment.TabIndex = 30;
            this.buttonCloseComment.Text = "CLOSE";
            this.buttonCloseComment.UseVisualStyleBackColor = false;
            this.buttonCloseComment.Click += new System.EventHandler(this.buttonCloseComment_Click);
            // 
            // FormCommentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 373);
            this.Controls.Add(this.buttonCloseComment);
            this.Controls.Add(this.dataGridViewComments);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCommentList";
            this.Text = "Comments";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewComments;
        private System.Windows.Forms.Button buttonCloseComment;
    }
}