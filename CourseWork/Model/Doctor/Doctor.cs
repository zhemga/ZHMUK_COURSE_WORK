using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWork.Model
{
    public class Doctor
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int ExperienceInYearsNumber { get; set; }

        [ForeignKey("DoctorProfile")]
        public string DoctorProfileId { get; set; }
        public virtual DoctorProfile DoctorProfile { get; set; }

        [ForeignKey("DoctorDegree")]
        public string DoctorDegreeId { get; set; }
        public virtual DoctorDegree DoctorDegree { get; set; }

        public virtual ICollection<ScheduleOfficeHour> ScheduleOfficeHours { get; set; }
    }
}
