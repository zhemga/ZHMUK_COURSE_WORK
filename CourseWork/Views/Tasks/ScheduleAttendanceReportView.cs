using CourseWork.Data;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork.Views.Tasks
{
    public partial class ScheduleAttendanceReportView : DevExpress.XtraEditors.XtraUserControl
    {
        private ClinicDbContext dbContext = new ClinicDbContext();

        public ScheduleAttendanceReportView()
        {
            InitializeComponent();
            LoadData(); // Load data when the form is initialized
        }

        private void LoadData()
        {
            // Load data for attendance report
            // You may want to customize this based on your actual requirements
            var attendanceReportData = dbContext.ScheduleOfficeHours
                .Include("Doctor") // Include Doctor information
                .Include("Patient") // Include Patient information
                .Include("ScheduleOfficeHourStatus") // Include Status information
                .ToList();

            // Display the data in a DataGridView or any other control of your choice
            dataGridViewAttendance.DataSource = attendanceReportData;

            // Load data for unfulfilled applications
            // You may want to customize this based on your actual requirements
            var unfulfilledApplicationsData = dbContext.ScheduleOfficeHours
                .Where(soh => soh.ScheduleOfficeHourStatusStatusId == "Unfulfilled") // Assuming "Unfulfilled" is the status for unfulfilled applications
                .Include("Doctor")
                .Include("Patient")
                .ToList();

            // Display the data in another DataGridView or control
            dataGridViewUnfulfilledApplications.DataSource = unfulfilledApplicationsData;
        }
    }
}
