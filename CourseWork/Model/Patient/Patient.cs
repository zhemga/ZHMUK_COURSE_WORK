using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWork.Model
{
    public class Patient
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }

        public int Age { get; set; }
        public bool IsMaleOrElseFemaleSex { get; set; }

        public virtual ICollection<ScheduleOfficeHour> ScheduleOfficeHours { get; set; }
    }
}
