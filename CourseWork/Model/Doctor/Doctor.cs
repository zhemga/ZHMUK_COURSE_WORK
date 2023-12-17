using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CourseWork.Model
{
    [DisplayColumn("FullName")]
    public class Doctor
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
        [Display(Name = "Роки Стажу")]
        [Range(0, 100)]
        public int ExperienceInYearsNumber { get; set; }

        [Required]
        [Display(Name = "Профіль")]
        [ForeignKey("DoctorProfile")]
        public string DoctorProfileName { get; set; }
        public virtual DoctorProfile DoctorProfile { get; set; }

        [Required]
        [Display(Name = "Звання")]
        [ForeignKey("DoctorDegree")]
        public string DoctorDegreeName { get; set; }
        public virtual DoctorDegree DoctorDegree { get; set; }

        public virtual ICollection<ScheduleOfficeHour> ScheduleOfficeHours { get; set; }

        [NotMapped]
        [Display(Name = "Лікар")]
        public string FullName
        {
            get { return (Surname + " " + Name); }
        }

        [NotMapped]
        [Display(Name = "Популярність")]
        public int Popularity
        {
            get 
            {
                return ScheduleOfficeHours.Where((soh) => { return soh.Patient != null; }).ToList().Count;
            }
        }
    }
}
