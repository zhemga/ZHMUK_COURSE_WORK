using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWork.Model
{
    [DisplayColumn("FullName")]
    public class Patient
    {
        [Key]
        [Required]
        [Display(Name = "Ідентифікатор")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        [Display(Name = "Ім'я")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Прізвище")]
        public string Surname { get; set; }
        [Required]
        [Display(Name = "Вік")]
        [Range(0, 200)]
        public int Age { get; set; }
        [Required]
        [Display(Name = "Чи чоловіча стать? (Інакше жіноча)")]
        [Range(0, 200)]
        public bool IsMaleOrElseFemaleSex { get; set; }

        [Display(Name = "Стать")]
        [NotMapped]
        public string Sex
        {
            get { return IsMaleOrElseFemaleSex ? "Чоловік" : "Жінка"; }
        }

        [NotMapped]
        [Display(Name = "Паіцієнт")]
        public string FullName
        {
            get { return (Surname + " " + Name); }
        }

        public virtual ICollection<ScheduleOfficeHour> ScheduleOfficeHours { get; set; }
    }
}
