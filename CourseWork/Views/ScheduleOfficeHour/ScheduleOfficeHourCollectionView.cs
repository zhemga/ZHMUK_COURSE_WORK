using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraBars;

namespace CourseWork.Views.ScheduleOfficeHourCollectionView
{
    public partial class ScheduleOfficeHourCollectionView : XtraUserControl
    {
        public ScheduleOfficeHourCollectionView()
        {
            InitializeComponent();

            if (!mvvmContext.IsDesignMode)
                InitBindings();
        }
        void InitBindings()
        {
            this.gridColumn3.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom;

            var fluentAPI = mvvmContext.OfType<CourseWork.ViewModels.ScheduleOfficeHourCollectionViewModel>();
            fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            // We want to show the Entities collection in grid and react on this collection external changes (Reload, server-side Filtering)
            fluentAPI.SetBinding(gridControl, gControl => gControl.DataSource, x => x.Entities);
            // We want to show loading-indicator when data is loading asynchronously
            fluentAPI.SetBinding(gridView, gView => gView.LoadingPanelVisible, x => x.IsLoading);
            // We want to proceed the Edit command when row double-clicked
            fluentAPI.WithEvent<RowClickEventArgs>(gridView, "RowClick").EventToCommand(
                    x => x.Edit(null),
                    x => x.SelectedEntity,
                    args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
            // We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(gridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.SelectedEntity,
                    args => args.Row as CourseWork.Model.ScheduleOfficeHour,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            //We want to show ribbon print preview when bbiPrintPreview clicked
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanel.Buttons[0]), x => x.New());
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanel.Buttons[1]), (x, p) => x.Edit(p), x => x.SelectedEntity);
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanel.Buttons[2]), (x, p) => x.Delete(p), x => x.SelectedEntity);
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanel.Buttons[3]), x => x.Refresh());
            ((DevExpress.XtraBars.Docking2010.WindowsUIButton)windowsUIButtonPanel.Buttons[5]).Click += (s, e) => { gridControl.ShowRibbonPrintPreview(); };
        }

        private void selectAvailableHoursButton_Click(object sender, EventArgs e)
        {
            DefaultGridViewState();

            this.gridColumn3.Group();
            this.gridColumn3.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            this.gridColumn8.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            this.gridView.ActiveFilterString = "IsNullOrEmpty([Patient.FullName])";
        }

        private void selectPatientsForDoctorButton_Click(object sender, EventArgs e)
        {
            DefaultGridViewState();

            this.gridView.ActiveFilterString = "[Patient.FullName] IS NOT NULL";
            this.gridColumn3.Group();
            this.gridColumn3.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            this.gridColumn8.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            this.gridView.ShowFilterPopup(this.gridColumn5);
        }

        private void selectDoctorsForUserButton_Click(object sender, EventArgs e)
        {
            DefaultGridViewState();

            this.gridColumn3.Group();
            this.gridColumn3.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            this.gridColumn8.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            this.gridView.ShowFilterPopup(this.gridColumn7);
        }

        private void attendanceReportButton_Click(object sender, EventArgs e)
        {
            DefaultGridViewState();
        }

        private void DefaultGridViewState()
        {
            this.gridView.ActiveFilterString = "";
            this.gridView.GroupCount = 0;
            this.gridColumn3.SortOrder = DevExpress.Data.ColumnSortOrder.None;
            this.gridColumn8.SortOrder = DevExpress.Data.ColumnSortOrder.None;
        }

        private void gridView_CustomColumnSort(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnSortEventArgs e)
        {
            // Assuming e.Value1 and e.Value2 are of type DayOfWeek
            DayOfWeek day1 = (DayOfWeek)e.Value1;
            DayOfWeek day2 = (DayOfWeek)e.Value2;

            // Compare the enum values directly
            e.Result = day1.CompareTo(day2);

            // If you want to sort in descending order, you can use the following line instead
            // e.Result = day2.CompareTo(day1);

            // Mark the comparison as handled
            e.Handled = true;
        }
    }
}
