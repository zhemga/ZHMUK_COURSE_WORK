using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWork.Model
{
    public class ScheduleOfficeHour
    {
        [Key]
        public string Id { get; set; }
        public string Description { get; set; }
        public int DayOfWeekNumber { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public string DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }

        public string PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        [ForeignKey("ScheduleOfficeHourStatus")]
        public string ScheduleOfficeHourStatusStatusId { get; set; }
        public virtual ScheduleOfficeHourStatus ScheduleOfficeHourStatus { get; set; }
    }
}
