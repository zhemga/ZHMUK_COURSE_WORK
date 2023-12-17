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
    /// Represents the ScheduleOfficeHours collection view model.
    /// </summary>
    public partial class ScheduleOfficeHourCollectionViewModel : CollectionViewModel<ScheduleOfficeHour, Guid, IClinicDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ScheduleOfficeHourCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ScheduleOfficeHourCollectionViewModel Create(IUnitOfWorkFactory<IClinicDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ScheduleOfficeHourCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ScheduleOfficeHourCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ScheduleOfficeHourCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ScheduleOfficeHourCollectionViewModel(IUnitOfWorkFactory<IClinicDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.ScheduleOfficeHours) {
        }
    }
}