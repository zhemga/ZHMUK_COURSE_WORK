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
    /// Represents the single DoctorDegree object view model.
    /// </summary>
    public partial class DoctorDegreeViewModel : SingleObjectViewModel<DoctorDegree, string, IClinicDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of DoctorDegreeViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static DoctorDegreeViewModel Create(IUnitOfWorkFactory<IClinicDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new DoctorDegreeViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the DoctorDegreeViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the DoctorDegreeViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected DoctorDegreeViewModel(IUnitOfWorkFactory<IClinicDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.DoctorDegrees, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Doctors for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Doctor> LookUpDoctors {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (DoctorDegreeViewModel x) => x.LookUpDoctors,
                    getRepositoryFunc: x => x.Doctors);
            }
        }


        /// <summary>
        /// The view model for the DoctorDegreeDoctors detail collection.
        /// </summary>
        public CollectionViewModelBase<Doctor, Doctor, string, IClinicDbContextUnitOfWork> DoctorDegreeDoctorsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (DoctorDegreeViewModel x) => x.DoctorDegreeDoctorsDetails,
                    getRepositoryFunc: x => x.Doctors,
                    foreignKeyExpression: x => x.DoctorDegreeId,
                    navigationExpression: x => x.DoctorDegree);
            }
        }
    }
}
