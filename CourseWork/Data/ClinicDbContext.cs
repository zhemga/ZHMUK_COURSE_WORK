using CourseWork.Model;
using System.Data.Entity;

namespace CourseWork.Data
{
    public class ClinicDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorDegree> DoctorDegrees { get; set; }
        public DbSet<DoctorProfile> DoctorProfiles { get; set; }
        public DbSet<ScheduleOfficeHour> ScheduleOfficeHours { get; set; }
        public DbSet<ScheduleOfficeHourStatus> ScheduleOfficeHourStatuses { get; set; }
        public DbSet<Patient> Patients { get; set; }

        public ClinicDbContext() : base("name=ClinicDB_ConnectionString")
        {
            Database.SetInitializer(new ClinicDbContextInitializer());
        }
    }
}
