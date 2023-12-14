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
    /// Represents the single Patient object view model.
    /// </summary>
    public partial class PatientViewModel : SingleObjectViewModel<Patient, string, IClinicDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of PatientViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static PatientViewModel Create(IUnitOfWorkFactory<IClinicDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new PatientViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the PatientViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the PatientViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected PatientViewModel(IUnitOfWorkFactory<IClinicDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Patients, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of ScheduleOfficeHours for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<ScheduleOfficeHour> LookUpScheduleOfficeHours {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PatientViewModel x) => x.LookUpScheduleOfficeHours,
                    getRepositoryFunc: x => x.ScheduleOfficeHours);
            }
        }


        /// <summary>
        /// The view model for the PatientScheduleOfficeHours detail collection.
        /// </summary>
        public CollectionViewModelBase<ScheduleOfficeHour, ScheduleOfficeHour, string, IClinicDbContextUnitOfWork> PatientScheduleOfficeHoursDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (PatientViewModel x) => x.PatientScheduleOfficeHoursDetails,
                    getRepositoryFunc: x => x.ScheduleOfficeHours,
                    foreignKeyExpression: x => x.PatientId,
                    navigationExpression: x => x.Patient);
            }
        }
    }
}
