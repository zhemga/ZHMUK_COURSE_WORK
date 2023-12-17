using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWork.Model
{
    [DisplayColumn("Name")]
    public class ScheduleOfficeHourStatus
    {
        [Key]
        [Required]
        [Display(Name = "Статус Прийому")]
        public string Name { get; set; }

        public virtual ICollection<ScheduleOfficeHour> ScheduleOfficeHours { get; set; }
    }
}
