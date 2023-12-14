using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CourseWork.Model
{
    public class ScheduleOfficeHourStatus
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ScheduleOfficeHour> ScheduleOfficeHours { get; set; }
    }
}
