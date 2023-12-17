using CourseWork.Model;
using System;
using System.ComponentModel.DataAnnotations;

namespace CourseWork.Annotations.Validation
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class StartTimeLessThanEndTimeAttributeForScheduleOfficeHour : ValidationAttribute
    {
        private const string DefaultErrorMessage = "Start time must be less than end time.";

        public StartTimeLessThanEndTimeAttributeForScheduleOfficeHour() : base(DefaultErrorMessage)
        {
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var model = (ScheduleOfficeHour)validationContext.ObjectInstance;

            if (model.StartTime >= model.EndTime)
            {
                return new ValidationResult(ErrorMessage);
            }

            return ValidationResult.Success;
        }
    }
}
