namespace A16_Ex01_Stephan_321178253_Alex_323260620
{
    partial class FormEventsStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.chartEventsStatistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateTimePickerStatistics = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGoStatistics = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartEventsStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // chartEventsStatistics
            // 
            chartArea1.Name = "ChartArea1";
            this.chartEventsStatistics.ChartAreas.Add(chartArea1);
            this.chartEventsStatistics.Location = new System.Drawing.Point(5, 63);
            this.chartEventsStatistics.Name = "chartEventsStatistics";
            this.chartEventsStatistics.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.chartEventsStatistics.Size = new System.Drawing.Size(865, 280);
            this.chartEventsStatistics.TabIndex = 0;
            this.chartEventsStatistics.Text = "Events Statistics";
            // 
            // dateTimePickerStatistics
            // 
            this.dateTimePickerStatistics.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerStatistics.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStatistics.Location = new System.Drawing.Point(178, 12);
            this.dateTimePickerStatistics.Name = "dateTimePickerStatistics";
            this.dateTimePickerStatistics.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerStatistics.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select start date:";
            // 
            // buttonGoStatistics
            // 
            this.buttonGoStatistics.Location = new System.Drawing.Point(406, 12);
            this.buttonGoStatistics.Name = "buttonGoStatistics";
            this.buttonGoStatistics.Size = new System.Drawing.Size(103, 29);
            this.buttonGoStatistics.TabIndex = 3;
            this.buttonGoStatistics.Text = "GO";
            this.buttonGoStatistics.UseVisualStyleBackColor = true;
            this.buttonGoStatistics.Click += new System.EventHandler(this.buttonGoStatistics_Click);
            // 
            // FormEventsStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 53);
            this.Controls.Add(this.buttonGoStatistics);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerStatistics);
            this.Controls.Add(this.chartEventsStatistics);
            this.Name = "FormEventsStatistics";
            this.Text = "FormEventsStatistics";
            ((System.ComponentModel.ISupportInitialize)(this.chartEventsStatistics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartEventsStatistics;
        private System.Windows.Forms.DateTimePicker dateTimePickerStatistics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGoStatistics;
    }
}