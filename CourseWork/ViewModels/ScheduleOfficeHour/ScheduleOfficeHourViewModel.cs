using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using CourseWork.ClinicDbContextDataModel;
using CourseWork.Common;
using CourseWork.Model;

namespace CourseWork.ViewModels {

    /// <summary>
    /// Represents the single ScheduleOfficeHour object view model.
    /// </summary>
    public partial class ScheduleOfficeHourViewModel : SingleObjectViewModel<ScheduleOfficeHour, string, IClinicDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ScheduleOfficeHourViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ScheduleOfficeHourViewModel Create(IUnitOfWorkFactory<IClinicDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ScheduleOfficeHourViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ScheduleOfficeHourViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ScheduleOfficeHourViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ScheduleOfficeHourViewModel(IUnitOfWorkFactory<IClinicDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.ScheduleOfficeHours, x => x.Description) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Doctors for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Doctor> LookUpDoctors {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ScheduleOfficeHourViewModel x) => x.LookUpDoctors,
                    getRepositoryFunc: x => x.Doctors);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Patients for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Patient> LookUpPatients {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ScheduleOfficeHourViewModel x) => x.LookUpPatients,
                    getRepositoryFunc: x => x.Patients);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of ScheduleOfficeHourStatuses for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<ScheduleOfficeHourStatus> LookUpScheduleOfficeHourStatuses {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ScheduleOfficeHourViewModel x) => x.LookUpScheduleOfficeHourStatuses,
                    getRepositoryFunc: x => x.ScheduleOfficeHourStatuses);
            }
        }

    }
}
