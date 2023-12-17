using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CourseWork.Annotations.Validation;

namespace CourseWork.Model
{
    [StartTimeLessThanEndTimeAttributeForScheduleOfficeHour]
    public class ScheduleOfficeHour
    {
        [Key]
        [Required]
        [Display(Name = "Ідентифікатор")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        [Display(Name = "Опис")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "День Тижня")]
        [Range(1, 7)]
        [EnumDataType(typeof(DayOfWeek))]
        public int DayOfWeekNumber { get; set; }

        [Required]
        [Display(Name = "Лікар")]
        [ForeignKey("Doctor")]
        public Guid DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }

        [Required]
        [Display(Name = "Пацієнт")]
        [ForeignKey("Patient")]
        public Guid PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        [Required]
        [Display(Name = "Початок Прийому")]
        public DateTime StartTime { get; set; }
        [Required]
        [Display(Name = "Кінець Прийому")]
        public DateTime EndTime { get; set; }

        [Required]
        [Display(Name = "Статус Прийому")]
        [ForeignKey("ScheduleOfficeHourStatus")]
        public string ScheduleOfficeHourStatusStatusId { get; set; }
        public virtual ScheduleOfficeHourStatus ScheduleOfficeHourStatus { get; set; }
    }
}
