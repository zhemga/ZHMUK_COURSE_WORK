using CourseWork.Data;
using CourseWork.Model;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.EF6;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseWork.ClinicDbContextDataModel {

    /// <summary>
    /// A ClinicDbContextUnitOfWork instance that represents the run-time implementation of the IClinicDbContextUnitOfWork interface.
    /// </summary>
    public class ClinicDbContextUnitOfWork : DbUnitOfWork<ClinicDbContext>, IClinicDbContextUnitOfWork {

        public ClinicDbContextUnitOfWork(Func<ClinicDbContext> contextFactory)
            : base(contextFactory) {
        }

        IRepository<DoctorDegree, string> IClinicDbContextUnitOfWork.DoctorDegrees {
            get { return GetRepository(x => x.Set<DoctorDegree>(), (DoctorDegree x) => x.Name); }
        }

        IRepository<Doctor, Guid> IClinicDbContextUnitOfWork.Doctors {
            get { return GetRepository(x => x.Set<Doctor>(), (Doctor x) => x.Id); }
        }

        IRepository<DoctorProfile, string> IClinicDbContextUnitOfWork.DoctorProfiles {
            get { return GetRepository(x => x.Set<DoctorProfile>(), (DoctorProfile x) => x.Name); }
        }

        IRepository<ScheduleOfficeHour, Guid> IClinicDbContextUnitOfWork.ScheduleOfficeHours {
            get { return GetRepository(x => x.Set<ScheduleOfficeHour>(), (ScheduleOfficeHour x) => x.Id); }
        }

        IRepository<Patient, Guid> IClinicDbContextUnitOfWork.Patients {
            get { return GetRepository(x => x.Set<Patient>(), (Patient x) => x.Id); }
        }

        IRepository<ScheduleOfficeHourStatus, string> IClinicDbContextUnitOfWork.ScheduleOfficeHourStatuses {
            get { return GetRepository(x => x.Set<ScheduleOfficeHourStatus>(), (ScheduleOfficeHourStatus x) => x.Name); }
        }
    }
}
