
namespace CourseWork.Views.Tasks
{
    partial class ScheduleAttendanceReportView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewUnfulfilledApplications = new System.Windows.Forms.DataGridView();
            this.dataGridViewAttendance = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnfulfilledApplications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.dataGridViewUnfulfilledApplications);
            this.groupBox1.Controls.Add(this.dataGridViewAttendance);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(20);
            this.groupBox1.Size = new System.Drawing.Size(1026, 454);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dataGridViewUnfulfilledApplications
            // 
            this.dataGridViewUnfulfilledApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnfulfilledApplications.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewUnfulfilledApplications.Location = new System.Drawing.Point(20, 36);
            this.dataGridViewUnfulfilledApplications.Margin = new System.Windows.Forms.Padding(20);
            this.dataGridViewUnfulfilledApplications.Name = "dataGridViewUnfulfilledApplications";
            this.dataGridViewUnfulfilledApplications.RowHeadersWidth = 51;
            this.dataGridViewUnfulfilledApplications.RowTemplate.Height = 24;
            this.dataGridViewUnfulfilledApplications.Size = new System.Drawing.Size(450, 398);
            this.dataGridViewUnfulfilledApplications.TabIndex = 7;
            // 
            // dataGridViewAttendance
            // 
            this.dataGridViewAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAttendance.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewAttendance.Location = new System.Drawing.Point(536, 36);
            this.dataGridViewAttendance.Margin = new System.Windows.Forms.Padding(20);
            this.dataGridViewAttendance.Name = "dataGridViewAttendance";
            this.dataGridViewAttendance.RowHeadersWidth = 51;
            this.dataGridViewAttendance.RowTemplate.Height = 24;
            this.dataGridViewAttendance.Size = new System.Drawing.Size(470, 398);
            this.dataGridViewAttendance.TabIndex = 6;
            // 
            // ScheduleAttendanceReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ScheduleAttendanceReportView";
            this.Size = new System.Drawing.Size(1026, 491);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnfulfilledApplications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewUnfulfilledApplications;
        private System.Windows.Forms.DataGridView dataGridViewAttendance;
    }
}
