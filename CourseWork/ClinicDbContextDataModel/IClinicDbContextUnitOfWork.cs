using CourseWork.Data;
using CourseWork.Model;
using DevExpress.Mvvm.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseWork.ClinicDbContextDataModel {

    /// <summary>
    /// IClinicDbContextUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IClinicDbContextUnitOfWork : IUnitOfWork {
        
        /// <summary>
        /// The DoctorDegree entities repository.
        /// </summary>
		IRepository<DoctorDegree, string> DoctorDegrees { get; }
        
        /// <summary>
        /// The Doctor entities repository.
        /// </summary>
		IRepository<Doctor, Guid> Doctors { get; }
        
        /// <summary>
        /// The DoctorProfile entities repository.
        /// </summary>
		IRepository<DoctorProfile, string> DoctorProfiles { get; }
        
        /// <summary>
        /// The ScheduleOfficeHour entities repository.
        /// </summary>
		IRepository<ScheduleOfficeHour, Guid> ScheduleOfficeHours { get; }
        
        /// <summary>
        /// The Patient entities repository.
        /// </summary>
		IRepository<Patient, Guid> Patients { get; }
        
        /// <summary>
        /// The ScheduleOfficeHourStatus entities repository.
        /// </summary>
		IRepository<ScheduleOfficeHourStatus, string> ScheduleOfficeHourStatuses { get; }
    }
}
