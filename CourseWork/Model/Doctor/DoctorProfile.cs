using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CourseWork.Model
{
    public class DoctorProfile
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}
