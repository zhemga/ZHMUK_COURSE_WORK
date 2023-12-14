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
    /// Represents the single ScheduleOfficeHourStatus object view model.
    /// </summary>
    public partial class ScheduleOfficeHourStatusViewModel : SingleObjectViewModel<ScheduleOfficeHourStatus, string, IClinicDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ScheduleOfficeHourStatusViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ScheduleOfficeHourStatusViewModel Create(IUnitOfWorkFactory<IClinicDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ScheduleOfficeHourStatusViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ScheduleOfficeHourStatusViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ScheduleOfficeHourStatusViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ScheduleOfficeHourStatusViewModel(IUnitOfWorkFactory<IClinicDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.ScheduleOfficeHourStatuses, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of ScheduleOfficeHours for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<ScheduleOfficeHour> LookUpScheduleOfficeHours {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ScheduleOfficeHourStatusViewModel x) => x.LookUpScheduleOfficeHours,
                    getRepositoryFunc: x => x.ScheduleOfficeHours);
            }
        }


        /// <summary>
        /// The view model for the ScheduleOfficeHourStatusScheduleOfficeHours detail collection.
        /// </summary>
        public CollectionViewModelBase<ScheduleOfficeHour, ScheduleOfficeHour, string, IClinicDbContextUnitOfWork> ScheduleOfficeHourStatusScheduleOfficeHoursDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ScheduleOfficeHourStatusViewModel x) => x.ScheduleOfficeHourStatusScheduleOfficeHoursDetails,
                    getRepositoryFunc: x => x.ScheduleOfficeHours,
                    foreignKeyExpression: x => x.ScheduleOfficeHourStatusStatusId,
                    navigationExpression: x => x.ScheduleOfficeHourStatus);
            }
        }
    }
}
