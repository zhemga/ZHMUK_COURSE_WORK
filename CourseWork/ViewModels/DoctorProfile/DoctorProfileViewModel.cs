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
    /// Represents the single DoctorProfile object view model.
    /// </summary>
    public partial class DoctorProfileViewModel : SingleObjectViewModel<DoctorProfile, string, IClinicDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of DoctorProfileViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static DoctorProfileViewModel Create(IUnitOfWorkFactory<IClinicDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new DoctorProfileViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the DoctorProfileViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the DoctorProfileViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected DoctorProfileViewModel(IUnitOfWorkFactory<IClinicDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.DoctorProfiles, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Doctors for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Doctor> LookUpDoctors {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (DoctorProfileViewModel x) => x.LookUpDoctors,
                    getRepositoryFunc: x => x.Doctors);
            }
        }


        /// <summary>
        /// The view model for the DoctorProfileDoctors detail collection.
        /// </summary>
        public CollectionViewModelBase<Doctor, Doctor, Guid, IClinicDbContextUnitOfWork> DoctorProfileDoctorsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (DoctorProfileViewModel x) => x.DoctorProfileDoctorsDetails,
                    getRepositoryFunc: x => x.Doctors,
                    foreignKeyExpression: x => x.DoctorProfileName,
                    navigationExpression: x => x.DoctorProfile);
            }
        }
    }
}
