using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace CourseWork.Views.ScheduleOfficeHourView{
    public partial class ScheduleOfficeHourView : XtraUserControl {
        public ScheduleOfficeHourView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<CourseWork.ViewModels.ScheduleOfficeHourViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                scheduleOfficeHourViewBindingSource, x => x.Entity, x => x.Update());
									// Binding for Doctor LookUp editor
			fluentAPI.SetBinding(DoctorLookUpEdit.Properties, p => p.DataSource, x => x.LookUpDoctors.Entities);
						// Binding for Patient LookUp editor
			fluentAPI.SetBinding(PatientLookUpEdit.Properties, p => p.DataSource, x => x.LookUpPatients.Entities);
						// Binding for ScheduleOfficeHourStatus LookUp editor
			fluentAPI.SetBinding(ScheduleOfficeHourStatusLookUpEdit.Properties, p => p.DataSource, x => x.LookUpScheduleOfficeHourStatuses.Entities);
									fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[0]), x => x.Save());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[1]), x => x.SaveAndClose());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[2]), x => x.SaveAndNew());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[3]), x => x.Reset());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[4]), x => x.Delete());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelCloseButton.Buttons[0]), x => x.Close());	
       }
    }
}
