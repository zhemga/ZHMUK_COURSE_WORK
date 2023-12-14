using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace CourseWork.Views.DoctorView{
    public partial class DoctorView : XtraUserControl {
        public DoctorView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<CourseWork.ViewModels.DoctorViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                doctorViewBindingSource, x => x.Entity, x => x.Update());
						#region ScheduleOfficeHours Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(ScheduleOfficeHoursGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.DoctorScheduleOfficeHoursDetails.SelectedEntity,
                    args => args.Row as CourseWork.Model.ScheduleOfficeHour,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(ScheduleOfficeHoursGridView, "RowClick")
						 .EventToCommand(
						     x => x.DoctorScheduleOfficeHoursDetails.Edit(null), x => x.DoctorScheduleOfficeHoursDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			ScheduleOfficeHoursGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    ScheduleOfficeHoursPopUpMenu.ShowPopup(ScheduleOfficeHoursGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the DoctorScheduleOfficeHoursDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(ScheduleOfficeHoursGridControl, g => g.DataSource, x => x.DoctorScheduleOfficeHoursDetails.Entities);
			
														fluentAPI.BindCommand(bbiScheduleOfficeHoursNew, x => x.DoctorScheduleOfficeHoursDetails.New());
																													fluentAPI.BindCommand(bbiScheduleOfficeHoursEdit,x => x.DoctorScheduleOfficeHoursDetails.Edit(null), x=>x.DoctorScheduleOfficeHoursDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiScheduleOfficeHoursDelete,x => x.DoctorScheduleOfficeHoursDetails.Delete(null), x=>x.DoctorScheduleOfficeHoursDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiScheduleOfficeHoursRefresh, x => x.DoctorScheduleOfficeHoursDetails.Refresh());
																	#endregion
									// Binding for DoctorDegree LookUp editor
			fluentAPI.SetBinding(DoctorDegreeLookUpEdit.Properties, p => p.DataSource, x => x.LookUpDoctorDegrees.Entities);
						// Binding for DoctorProfile LookUp editor
			fluentAPI.SetBinding(DoctorProfileLookUpEdit.Properties, p => p.DataSource, x => x.LookUpDoctorProfiles.Entities);
									fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[0]), x => x.Save());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[1]), x => x.SaveAndClose());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[2]), x => x.SaveAndNew());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[3]), x => x.Reset());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[4]), x => x.Delete());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelCloseButton.Buttons[0]), x => x.Close());	
       }
    }
}
