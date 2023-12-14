
namespace CourseWork
{
    partial class MainView
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
            this.components = new System.ComponentModel.Container();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.clinicDbContextView1 = new CourseWork.Views.ClinicDbContextView.ClinicDbContextView();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            this.SuspendLayout();
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            // 
            // clinicDbContextView1
            // 
            this.clinicDbContextView1.Appearance.BackColor = System.Drawing.Color.White;
            this.clinicDbContextView1.Appearance.Options.UseBackColor = true;
            this.clinicDbContextView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clinicDbContextView1.Location = new System.Drawing.Point(0, 0);
            this.clinicDbContextView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clinicDbContextView1.Name = "clinicDbContextView1";
            this.clinicDbContextView1.Size = new System.Drawing.Size(737, 342);
            this.clinicDbContextView1.TabIndex = 0;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 342);
            this.Controls.Add(this.clinicDbContextView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainView";
            this.Text = "MainView";
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private Views.ClinicDbContextView.ClinicDbContextView clinicDbContextView1;
    }
}

