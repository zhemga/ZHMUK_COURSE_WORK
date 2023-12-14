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
    /// Represents the single Doctor object view model.
    /// </summary>
    public partial class DoctorViewModel : SingleObjectViewModel<Doctor, string, IClinicDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of DoctorViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static DoctorViewModel Create(IUnitOfWorkFactory<IClinicDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new DoctorViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the DoctorViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the DoctorViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected DoctorViewModel(IUnitOfWorkFactory<IClinicDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Doctors, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of DoctorDegrees for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<DoctorDegree> LookUpDoctorDegrees {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (DoctorViewModel x) => x.LookUpDoctorDegrees,
                    getRepositoryFunc: x => x.DoctorDegrees);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of DoctorProfiles for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<DoctorProfile> LookUpDoctorProfiles {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (DoctorViewModel x) => x.LookUpDoctorProfiles,
                    getRepositoryFunc: x => x.DoctorProfiles);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of ScheduleOfficeHours for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<ScheduleOfficeHour> LookUpScheduleOfficeHours {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (DoctorViewModel x) => x.LookUpScheduleOfficeHours,
                    getRepositoryFunc: x => x.ScheduleOfficeHours);
            }
        }


        /// <summary>
        /// The view model for the DoctorScheduleOfficeHours detail collection.
        /// </summary>
        public CollectionViewModelBase<ScheduleOfficeHour, ScheduleOfficeHour, string, IClinicDbContextUnitOfWork> DoctorScheduleOfficeHoursDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (DoctorViewModel x) => x.DoctorScheduleOfficeHoursDetails,
                    getRepositoryFunc: x => x.ScheduleOfficeHours,
                    foreignKeyExpression: x => x.DoctorId,
                    navigationExpression: x => x.Doctor);
            }
        }
    }
}
