using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;
using CourseWork.ClinicDbContextDataModel;

namespace CourseWork.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the ClinicDbContext data model.
    /// </summary>
    public partial class ClinicDbContextViewModel : DocumentsViewModel<ClinicDbContextModuleDescription, IClinicDbContextUnitOfWork> {

		const string TablesGroup = "Tables";

		const string ViewsGroup = "Views";
		INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }
	
        /// <summary>
        /// Creates a new instance of ClinicDbContextViewModel as a POCO view model.
        /// </summary>
        public static ClinicDbContextViewModel Create() {
            return ViewModelSource.Create(() => new ClinicDbContextViewModel());
        }

		
        /// <summary>
        /// Initializes a new instance of the ClinicDbContextViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ClinicDbContextViewModel type without the POCO proxy factory.
        /// </summary>
        protected ClinicDbContextViewModel()
		    : base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }

        protected override ClinicDbContextModuleDescription[] CreateModules() {
			return new ClinicDbContextModuleDescription[] {
                new ClinicDbContextModuleDescription( "Doctor Degrees", "DoctorDegreeCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.DoctorDegrees)),
                new ClinicDbContextModuleDescription( "Doctors", "DoctorCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Doctors)),
                new ClinicDbContextModuleDescription( "Doctor Profiles", "DoctorProfileCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.DoctorProfiles)),
                new ClinicDbContextModuleDescription( "Schedule Office Hours", "ScheduleOfficeHourCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.ScheduleOfficeHours)),
                new ClinicDbContextModuleDescription( "Patients", "PatientCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Patients)),
                new ClinicDbContextModuleDescription( "Schedule Office Hour Statuses", "ScheduleOfficeHourStatusCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.ScheduleOfficeHourStatuses)),
			};
        }
                		protected override void OnActiveModuleChanged(ClinicDbContextModuleDescription oldModule) {
            if(ActiveModule != null && NavigationService != null) {
                NavigationService.ClearNavigationHistory();
            }
            base.OnActiveModuleChanged(oldModule);
        }
	}

    public partial class ClinicDbContextModuleDescription : ModuleDescription<ClinicDbContextModuleDescription> {
        public ClinicDbContextModuleDescription(string title, string documentType, string group, Func<ClinicDbContextModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }
    }
}