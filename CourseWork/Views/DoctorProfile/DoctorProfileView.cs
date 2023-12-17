using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace CourseWork.Views.DoctorProfileView{
    public partial class DoctorProfileView : XtraUserControl {
        public DoctorProfileView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<CourseWork.ViewModels.DoctorProfileViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                doctorProfileViewBindingSource, x => x.Entity, x => x.Update());
						#region Doctors Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(DoctorsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.DoctorProfileDoctorsDetails.SelectedEntity,
                    args => args.Row as CourseWork.Model.Doctor,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(DoctorsGridView, "RowClick")
						 .EventToCommand(
						     x => x.DoctorProfileDoctorsDetails.Edit(null), x => x.DoctorProfileDoctorsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			DoctorsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    DoctorsPopUpMenu.ShowPopup(DoctorsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the DoctorProfileDoctorsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(DoctorsGridControl, g => g.DataSource, x => x.DoctorProfileDoctorsDetails.Entities);
			
														fluentAPI.BindCommand(bbiDoctorsNew, x => x.DoctorProfileDoctorsDetails.New());
																													fluentAPI.BindCommand(bbiDoctorsEdit,x => x.DoctorProfileDoctorsDetails.Edit(null), x=>x.DoctorProfileDoctorsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiDoctorsDelete,x => x.DoctorProfileDoctorsDetails.Delete(null), x=>x.DoctorProfileDoctorsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiDoctorsRefresh, x => x.DoctorProfileDoctorsDetails.Refresh());
																	#endregion
												fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[0]), x => x.Save());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[1]), x => x.SaveAndClose());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[2]), x => x.SaveAndNew());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[3]), x => x.Reset());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[4]), x => x.Delete());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelCloseButton.Buttons[0]), x => x.Close());	
       }
    }
}
