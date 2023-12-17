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
        [EnumDataType(typeof(CourseWork.Enum.DayOfWeek))]
        [Range(1, 8)]
        public int DayOfWeekNumber { get; set; }

        [Required]
        [Display(Name = "Лікар")]
        [ForeignKey("Doctor")]
        public Guid DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }

        // NOT REQUIRED
        [Display(Name = "Пацієнт")]
        [ForeignKey("Patient")]
        public Guid PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        [Required]
        [Display(Name = "Початок Прийому")]
        [DisplayFormat(DataFormatString = "t")]
        public DateTime StartTime { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "t")]
        [Display(Name = "Кінець Прийому")]
        public DateTime EndTime { get; set; }

        [Required]
        [Display(Name = "Статус Прийому")]
        [ForeignKey("ScheduleOfficeHourStatus")]
        public string ScheduleOfficeHourStatusStatusName { get; set; }
        public virtual ScheduleOfficeHourStatus ScheduleOfficeHourStatus { get; set; }
    }
}
