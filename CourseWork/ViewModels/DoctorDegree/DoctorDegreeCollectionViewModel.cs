using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using CourseWork.ClinicDbContextDataModel;
using CourseWork.Common;
using CourseWork.Model;

namespace CourseWork.ViewModels {

    /// <summary>
    /// Represents the DoctorDegrees collection view model.
    /// </summary>
    public partial class DoctorDegreeCollectionViewModel : CollectionViewModel<DoctorDegree, string, IClinicDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of DoctorDegreeCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static DoctorDegreeCollectionViewModel Create(IUnitOfWorkFactory<IClinicDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new DoctorDegreeCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the DoctorDegreeCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the DoctorDegreeCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected DoctorDegreeCollectionViewModel(IUnitOfWorkFactory<IClinicDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.DoctorDegrees) {
        }
    }
}