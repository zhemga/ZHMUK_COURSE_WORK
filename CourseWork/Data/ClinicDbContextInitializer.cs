using CourseWork.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Text;

namespace CourseWork.Data
{
    public class ClinicDbContextInitializer : DropCreateDatabaseIfModelChanges<ClinicDbContext>
    {
        protected override void Seed(ClinicDbContext context)
        {
            var random = new Random();

            // Посіяти дані профілів лікарів
            var doctorProfiles = new List<DoctorProfile>
  {
      new DoctorProfile { Name = "Кардіолог" },
      new DoctorProfile { Name = "Дерматолог" },
      new DoctorProfile { Name = "Педіатр" },
      new DoctorProfile { Name = "Ортопед-хірург" },
      new DoctorProfile { Name = "Невролог" },
      new DoctorProfile { Name = "Гастроентеролог" },
      new DoctorProfile { Name = "Офтальмолог" },
      new DoctorProfile { Name = "Ендокринолог" },
      new DoctorProfile { Name = "Акушер-гінеколог" },
      new DoctorProfile { Name = "Уролог" },
      new DoctorProfile { Name = "Психіатр" },
      new DoctorProfile { Name = "Пульмонолог" },
      new DoctorProfile { Name = "Ревматолог" },
      new DoctorProfile { Name = "Онколог" },
      new DoctorProfile { Name = "Алерголог" },
      new DoctorProfile { Name = "Гематолог" },
      new DoctorProfile { Name = "Нефролог" },
      new DoctorProfile { Name = "Стоматолог-хірург" },
      new DoctorProfile { Name = "Пластичний хірург" },
      new DoctorProfile { Name = "Спеціаліст з інфекційних захворювань" },
  };

            context.DoctorProfiles.AddRange(doctorProfiles);

            // Посіяти дані професійних ступенів лікарів
            var doctorDegrees = new List<DoctorDegree>
  {
      new DoctorDegree { Name = "Лікар медицини (МД)" },
      new DoctorDegree { Name = "Лікар остеопатії (ДО)" },
      new DoctorDegree { Name = "Лікар стоматології (ДМД)" },
      new DoctorDegree { Name = "Лікар стоматології (ДДС)" },
      new DoctorDegree { Name = "Лікар фармації (ФармД)" },
      new DoctorDegree { Name = "Лікар ветеринарної медицини (ДВМ)" },
      new DoctorDegree { Name = "Лікар офтальмології (ОД)" },
      new DoctorDegree { Name = "Лікар фізичної терапії (ДПТ)" },
      new DoctorDegree { Name = "Лікарська практика (ДНП)" },
      new DoctorDegree { Name = "Лікар психології (ПсД)" },
      new DoctorDegree { Name = "Лікар хіропрактики (ДС)" },
      new DoctorDegree { Name = "Лікар окупаційної терапії (ОТД)" },
      new DoctorDegree { Name = "Лікарська адміністрація (ДрФА)" },
      new DoctorDegree { Name = "Лікар наук зі стоматології (ДСкД)" },
      new DoctorDegree { Name = "Лікар наук з ветеринарної медицини (ДВН)" },
      new DoctorDegree { Name = "Лікар аудіології (АuD)" },
      new DoctorDegree { Name = "Лікар педіатричної медицини (ДПМ)" },
      new DoctorDegree { Name = "Лікар наук з медицини (ДНМ)" },
      new DoctorDegree { Name = "Лікар з охорони здоров'я (ДОЗ)" },
      new DoctorDegree { Name = "Лікар медичних наук (ДМН)" },
  };

            context.DoctorDegrees.AddRange(doctorDegrees);

            // Посіяти лікарів
            var doctors = new List<Doctor> {
   new Doctor {
    Id = Guid.NewGuid(),
    Name = "Колін",
    Surname = "Ґрір",
    ExperienceInYearsNumber = 23,
    DoctorProfileName = doctorProfiles[random.Next(0, doctorProfiles.Count)].Name,
    DoctorDegreeName = doctorDegrees[random.Next(0, doctorDegrees.Count)].Name,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Ноель",
    Surname = "Маркес",
    ExperienceInYearsNumber = 19,
    DoctorProfileName = doctorProfiles[random.Next(0, doctorProfiles.Count)].Name,
    DoctorDegreeName = doctorDegrees[random.Next(0, doctorDegrees.Count)].Name,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Руні",
    Surname = "Беннетт",
    ExperienceInYearsNumber = 0,
    DoctorProfileName = doctorProfiles[random.Next(0, doctorProfiles.Count)].Name,
    DoctorDegreeName = doctorDegrees[random.Next(0, doctorDegrees.Count)].Name,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Ендрю",
    Surname = "Поуп",
    ExperienceInYearsNumber = 42,
    DoctorProfileName = doctorProfiles[random.Next(0, doctorProfiles.Count)].Name,
    DoctorDegreeName = doctorDegrees[random.Next(0, doctorDegrees.Count)].Name,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Ейпріл",
    Surname = "Дотсон",
    ExperienceInYearsNumber = 24,
    DoctorProfileName = doctorProfiles[random.Next(0, doctorProfiles.Count)].Name,
    DoctorDegreeName = doctorDegrees[random.Next(0, doctorDegrees.Count)].Name,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Джульєт",
    Surname = "Франко",
    ExperienceInYearsNumber = 24,
    DoctorProfileName = doctorProfiles[random.Next(0, doctorProfiles.Count)].Name,
    DoctorDegreeName = doctorDegrees[random.Next(0, doctorDegrees.Count)].Name,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Шеллі",
    Surname = "Батлер",
    ExperienceInYearsNumber = 23,
    DoctorProfileName = doctorProfiles[random.Next(0, doctorProfiles.Count)].Name,
    DoctorDegreeName = doctorDegrees[random.Next(0, doctorDegrees.Count)].Name,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Абель",
    Surname = "Керролл",
    ExperienceInYearsNumber = 39,
    DoctorProfileName = doctorProfiles[random.Next(0, doctorProfiles.Count)].Name,
    DoctorDegreeName = doctorDegrees[random.Next(0, doctorDegrees.Count)].Name,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Джілліан",
    Surname = "Замора",
    ExperienceInYearsNumber = 37,
    DoctorProfileName = doctorProfiles[random.Next(0, doctorProfiles.Count)].Name,
    DoctorDegreeName = doctorDegrees[random.Next(0, doctorDegrees.Count)].Name,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Лайл",
    Surname = "Грін",
    ExperienceInYearsNumber = 49,
    DoctorProfileName = doctorProfiles[random.Next(0, doctorProfiles.Count)].Name,
    DoctorDegreeName = doctorDegrees[random.Next(0, doctorDegrees.Count)].Name,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Ахмед",
    Surname = "Бентлі",
    ExperienceInYearsNumber = 7,
    DoctorProfileName = doctorProfiles[random.Next(0, doctorProfiles.Count)].Name,
    DoctorDegreeName = doctorDegrees[random.Next(0, doctorDegrees.Count)].Name,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Вінтер",
    Surname = "Руссо",
    ExperienceInYearsNumber = 5,
    DoctorProfileName = doctorProfiles[random.Next(0, doctorProfiles.Count)].Name,
    DoctorDegreeName = doctorDegrees[random.Next(0, doctorDegrees.Count)].Name,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Неро",
    Surname = "Келлі",
    ExperienceInYearsNumber = 21,
    DoctorProfileName = doctorProfiles[random.Next(0, doctorProfiles.Count)].Name,
    DoctorDegreeName = doctorDegrees[random.Next(0, doctorDegrees.Count)].Name,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Маріко",
    Surname = "Хоу",
    ExperienceInYearsNumber = 4,
    DoctorProfileName = doctorProfiles[random.Next(0, doctorProfiles.Count)].Name,
    DoctorDegreeName = doctorDegrees[random.Next(0, doctorDegrees.Count)].Name,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Інгрід",
    Surname = "Гаррелл",
    ExperienceInYearsNumber = 30,
    DoctorProfileName = doctorProfiles[random.Next(0, doctorProfiles.Count)].Name,
    DoctorDegreeName = doctorDegrees[random.Next(0, doctorDegrees.Count)].Name,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Дон",
    Surname = "Парсонс",
    ExperienceInYearsNumber = 43,
    DoctorProfileName = doctorProfiles[random.Next(0, doctorProfiles.Count)].Name,
    DoctorDegreeName = doctorDegrees[random.Next(0, doctorDegrees.Count)].Name,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Шеллі",
    Surname = "Хопкінс",
    ExperienceInYearsNumber = 43,
    DoctorProfileName = doctorProfiles[random.Next(0, doctorProfiles.Count)].Name,
    DoctorDegreeName = doctorDegrees[random.Next(0, doctorDegrees.Count)].Name,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Флер",
    Surname = "Лотт",
    ExperienceInYearsNumber = 32,
    DoctorProfileName = doctorProfiles[random.Next(0, doctorProfiles.Count)].Name,
    DoctorDegreeName = doctorDegrees[random.Next(0, doctorDegrees.Count)].Name,
},

new Doctor {
    Id = Guid.NewGuid(),
    Name = "Вінус",
    Surname = "Сіммонс",
    ExperienceInYearsNumber = 25,
    DoctorProfileName = doctorProfiles[random.Next(0, doctorProfiles.Count)].Name,
    DoctorDegreeName = doctorDegrees[random.Next(0, doctorDegrees.Count)].Name,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Вівіан",
    Surname = "Стівенсон",
    ExperienceInYearsNumber = 30,
    DoctorProfileName = doctorProfiles[random.Next(0, doctorProfiles.Count)].Name,
    DoctorDegreeName = doctorDegrees[random.Next(0, doctorDegrees.Count)].Name,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Вернон",
    Surname = "Стокс",
    ExperienceInYearsNumber = 13,
    DoctorProfileName = doctorProfiles[random.Next(0, doctorProfiles.Count)].Name,
    DoctorDegreeName = doctorDegrees[random.Next(0, doctorDegrees.Count)].Name,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Натан",
    Surname = "Чендлер",
    ExperienceInYearsNumber = 48,
    DoctorProfileName = doctorProfiles[random.Next(0, doctorProfiles.Count)].Name,
    DoctorDegreeName = doctorDegrees[random.Next(0, doctorDegrees.Count)].Name,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Індія",
    Surname = "Вудвард",
    ExperienceInYearsNumber = 4,
    DoctorProfileName = doctorProfiles[random.Next(0, doctorProfiles.Count)].Name,
    DoctorDegreeName = doctorDegrees[random.Next(0, doctorDegrees.Count)].Name,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Брендан",
    Surname = "Меррілл",
    ExperienceInYearsNumber = 3,
    DoctorProfileName = doctorProfiles[random.Next(0, doctorProfiles.Count)].Name,
    DoctorDegreeName = doctorDegrees[random.Next(0, doctorDegrees.Count)].Name,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Йоланда",
    Surname = "Бредшоу",
    ExperienceInYearsNumber = 34,
    DoctorProfileName = doctorProfiles[random.Next(0, doctorProfiles.Count)].Name,
    DoctorDegreeName = doctorDegrees[random.Next(0, doctorDegrees.Count)].Name,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Нель",
    Surname = "Бойл",
    ExperienceInYearsNumber = 35,
    DoctorProfileName = doctorProfiles[random.Next(0, doctorProfiles.Count)].Name,
    DoctorDegreeName = doctorDegrees[random.Next(0, doctorDegrees.Count)].Name,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Кастор",
    Surname = "Пул",
    ExperienceInYearsNumber = 4,
    DoctorProfileName = doctorProfiles[random.Next(0, doctorProfiles.Count)].Name,
    DoctorDegreeName = doctorDegrees[random.Next(0, doctorDegrees.Count)].Name,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Джесі",
    Surname = "Пейн",
    ExperienceInYearsNumber = 23,
    DoctorProfileName = doctorProfiles[random.Next(0, doctorProfiles.Count)].Name,
    DoctorDegreeName = doctorDegrees[random.Next(0, doctorDegrees.Count)].Name,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Іган",
    Surname = "Меррілл",
    ExperienceInYearsNumber = 33,
    DoctorProfileName = doctorProfiles[random.Next(0, doctorProfiles.Count)].Name,
    DoctorDegreeName = doctorDegrees[random.Next(0, doctorDegrees.Count)].Name,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Дірдрі",
    Surname = "Барбер",
    ExperienceInYearsNumber = 6,
    DoctorProfileName = doctorProfiles[random.Next(0, doctorProfiles.Count)].Name,
    DoctorDegreeName = doctorDegrees[random.Next(0, doctorDegrees.Count)].Name
},
};

            context.Doctors.AddRange(doctors);

            var patients = new List<Patient> {
    new Patient {
        Id = Guid.NewGuid(),
        Name = "Перрі",
        Surname = "Лав",
        Age = 54,
        IsMaleOrElseFemaleSex = false
    },
    new Patient {
        Id = Guid.NewGuid(),
        Name = "Томас",
        Surname = "Сампсон",
        Age = 36,
        IsMaleOrElseFemaleSex = true
    },
    new Patient {
        Id = Guid.NewGuid(),
        Name = "Вікторія",
        Surname = "Бін",
        Age = 72,
        IsMaleOrElseFemaleSex = false
    },
    new Patient {
        Id = Guid.NewGuid(),
        Name = "Деметріус",
        Surname = "Хендрикс",
        Age = 76,
        IsMaleOrElseFemaleSex = true
    },
    new Patient {
        Id = Guid.NewGuid(),
        Name = "Келлі",
        Surname = "Даффі",
        Age = 33,
        IsMaleOrElseFemaleSex = true
    },
    new Patient {
        Id = Guid.NewGuid(),
        Name = "Кілі",
        Surname = "Стентон",
        Age = 79,
        IsMaleOrElseFemaleSex = true
    },
    new Patient {
        Id = Guid.NewGuid(),
        Name = "Ленс",
        Surname = "Барнс",
        Age = 42,
        IsMaleOrElseFemaleSex = true
    },
    new Patient {
        Id = Guid.NewGuid(),
        Name = "Куамар",
        Surname = "Кросс",
        Age = 24,
        IsMaleOrElseFemaleSex = false
    },
    new Patient {
        Id = Guid.NewGuid(),
        Name = "Шейн",
        Surname = "Монтойя",
        Age = 49,
        IsMaleOrElseFemaleSex = true
    },
    new Patient {
        Id = Guid.NewGuid(),
        Name = "Челсі",
        Surname = "Едкінс",
        Age = 56,
        IsMaleOrElseFemaleSex = false
    },
    new Patient {
        Id = Guid.NewGuid(),
        Name = "Філан",
        Surname = "Петерсен",
        Age = 53,
        IsMaleOrElseFemaleSex = true
    },
    new Patient {
        Id = Guid.NewGuid(),
        Name = "Бевіс",
        Surname = "Вайатт",
        Age = 38,
        IsMaleOrElseFemaleSex = false
    },
    new Patient {
        Id = Guid.NewGuid(),
        Name = "Меррілл",
        Surname = "Бентон",
        Age = 7,
        IsMaleOrElseFemaleSex = false
    },
    new Patient {
        Id = Guid.NewGuid(),
        Name = "Каїро",
        Surname = "Калгун",
        Age = 70,
        IsMaleOrElseFemaleSex = true
    },
    new Patient {
        Id = Guid.NewGuid(),
        Name = "Джеймс",
        Surname = "Баркс",
        Age = 32,
        IsMaleOrElseFemaleSex = true
    },
    new Patient {
        Id = Guid.NewGuid(),
        Name = "Ксандра",
        Surname = "Ретліфф",
        Age = 20,
        IsMaleOrElseFemaleSex = true
    },
    new Patient {
        Id = Guid.NewGuid(),
        Name = "Аштон",
        Surname = "Макданіел",
        Age = 14,
        IsMaleOrElseFemaleSex = true
    },
    new Patient {
        Id = Guid.NewGuid(),
        Name = "Лунея",
        Surname = "Девіс",
        Age = 31,
        IsMaleOrElseFemaleSex = true
    },
    new Patient {
        Id = Guid.NewGuid(),
        Name = "Вівіан",
        Surname = "Ноель",
        Age = 39,
        IsMaleOrElseFemaleSex = true
    },
    new Patient {
        Id = Guid.NewGuid(),
        Name = "Гілліан",
        Surname = "Даунс",
        Age = 18,
        IsMaleOrElseFemaleSex = true
    },
    new Patient {
        Id = Guid.NewGuid(),
        Name = "Афіна",
        Surname = "Кобб",
        Age = 55,
        IsMaleOrElseFemaleSex = false
    },
    new Patient {
        Id = Guid.NewGuid(),
        Name = "Пенелопа",
        Surname = "Вітт",
        Age = 6,
        IsMaleOrElseFemaleSex = false
    },
    new Patient {
        Id = Guid.NewGuid(),
        Name = "Кадман",
        Surname = "Орр",
        Age = 23,
        IsMaleOrElseFemaleSex = true
    },
    new Patient {
        Id = Guid.NewGuid(),
        Name = "Честіті",
        Surname = "Келлі",
        Age = 49,
        IsMaleOrElseFemaleSex = false
    },
    new Patient {
        Id = Guid.NewGuid(),
        Name = "Алекса",
        Surname = "Шелтон",
        Age = 18,
        IsMaleOrElseFemaleSex = false
    },
    new Patient {
        Id = Guid.NewGuid(),
        Name = "Барретт",
        Surname = "Саммерс",
        Age = 37,
        IsMaleOrElseFemaleSex = true
    },
    new Patient {
        Id = Guid.NewGuid(),
        Name = "Джудіт",
        Surname = "Уоттс",
        Age = 29,
        IsMaleOrElseFemaleSex = true
    },
    new Patient {
        Id = Guid.NewGuid(),
        Name = "Рендолл",
        Surname = "Мозес",
        Age = 22,
        IsMaleOrElseFemaleSex = true
    },
    new Patient {
        Id = Guid.NewGuid(),
        Name = "Хашім",
        Surname = "Філдс",
        Age = 23,
        IsMaleOrElseFemaleSex = false
    },
    new Patient {
        Id = Guid.NewGuid(),
        Name = "Ірма",
        Surname = "Фултон",
        Age = 30,
        IsMaleOrElseFemaleSex = true
    }
};

            context.Patients.AddRange(patients);

            var scheduleOfficeHourStatuses = new List<ScheduleOfficeHourStatus>
            { 
                new ScheduleOfficeHourStatus { Name = "В очікуванні" },
                new ScheduleOfficeHourStatus { Name = "Закінчено" },
                new ScheduleOfficeHourStatus { Name = "Відмінено" },
            };

            context.ScheduleOfficeHourStatuses.AddRange(scheduleOfficeHourStatuses);

            var scheduleOfficeHoursStartTime = DateTime.Now;

            var scheduleOfficeHours = new List<ScheduleOfficeHour>
            {
                new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
                           new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },
               new ScheduleOfficeHour
                {
                    Id = Guid.NewGuid(),
                    Description = "Перевірка здоров'я",
                    DayOfWeekNumber = random.Next(1, 8),
                    DoctorId = doctors[random.Next(0, doctors.Count)].Id,
                    PatientId = patients[random.Next(0, patients.Count)].Id,
                    StartTime = scheduleOfficeHoursStartTime.AddHours(random.Next(0, 3)),
                    EndTime = scheduleOfficeHoursStartTime.AddHours(random.Next(3, 7)),
                    ScheduleOfficeHourStatusStatusName = scheduleOfficeHourStatuses[random.Next(0, scheduleOfficeHourStatuses.Count)].Name
                },

            };

            context.ScheduleOfficeHours.AddRange(scheduleOfficeHours);

            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                StringBuilder stringBuilder = new StringBuilder();

                foreach (var eve in e.EntityValidationErrors)
                {
                    stringBuilder.AppendLine($"Entity of type \"{eve.Entry.Entity.GetType().Name}\" in state \"{eve.Entry.State}\" has the following validation errors:");

                    foreach (var ve in eve.ValidationErrors)
                    {
                        stringBuilder.AppendLine($"- Property: \"{ve.PropertyName}\", Error: \"{ve.ErrorMessage}\"");
                    }
                }

                string resultString = stringBuilder.ToString();

                throw;
            }
        }
    }
}
