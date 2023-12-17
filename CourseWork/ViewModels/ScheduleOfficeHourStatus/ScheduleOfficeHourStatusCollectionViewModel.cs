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
    /// Represents the ScheduleOfficeHourStatuses collection view model.
    /// </summary>
    public partial class ScheduleOfficeHourStatusCollectionViewModel : CollectionViewModel<ScheduleOfficeHourStatus, string, IClinicDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ScheduleOfficeHourStatusCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ScheduleOfficeHourStatusCollectionViewModel Create(IUnitOfWorkFactory<IClinicDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ScheduleOfficeHourStatusCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ScheduleOfficeHourStatusCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ScheduleOfficeHourStatusCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ScheduleOfficeHourStatusCollectionViewModel(IUnitOfWorkFactory<IClinicDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.ScheduleOfficeHourStatuses) {
        }
    }
}