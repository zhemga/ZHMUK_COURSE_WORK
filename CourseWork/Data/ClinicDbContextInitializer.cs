using CourseWork.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;

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
      new DoctorProfile { Id = Guid.NewGuid(), Name = "Кардіолог" },
      new DoctorProfile { Id = Guid.NewGuid(), Name = "Дерматолог" },
      new DoctorProfile { Id = Guid.NewGuid(), Name = "Педіатр" },
      new DoctorProfile { Id = Guid.NewGuid(), Name = "Ортопед-хірург" },
      new DoctorProfile { Id = Guid.NewGuid(), Name = "Невролог" },
      new DoctorProfile { Id = Guid.NewGuid(), Name = "Гастроентеролог" },
      new DoctorProfile { Id = Guid.NewGuid(), Name = "Офтальмолог" },
      new DoctorProfile { Id = Guid.NewGuid(), Name = "Ендокринолог" },
      new DoctorProfile { Id = Guid.NewGuid(), Name = "Акушер-гінеколог" },
      new DoctorProfile { Id = Guid.NewGuid(), Name = "Уролог" },
      new DoctorProfile { Id = Guid.NewGuid(), Name = "Психіатр" },
      new DoctorProfile { Id = Guid.NewGuid(), Name = "Пульмонолог" },
      new DoctorProfile { Id = Guid.NewGuid(), Name = "Ревматолог" },
      new DoctorProfile { Id = Guid.NewGuid(), Name = "Онколог" },
      new DoctorProfile { Id = Guid.NewGuid(), Name = "Алерголог" },
      new DoctorProfile { Id = Guid.NewGuid(), Name = "Гематолог" },
      new DoctorProfile { Id = Guid.NewGuid(), Name = "Нефролог" },
      new DoctorProfile { Id = Guid.NewGuid(), Name = "Стоматолог-хірург" },
      new DoctorProfile { Id = Guid.NewGuid(), Name = "Пластичний хірург" },
      new DoctorProfile { Id = Guid.NewGuid(), Name = "Спеціаліст з інфекційних захворювань" },
  };

            context.DoctorProfiles.AddRange(doctorProfiles);

            // Посіяти дані професійних ступенів лікарів
            var doctorDegrees = new List<DoctorDegree>
  {
      new DoctorDegree { Id = Guid.NewGuid(), Name = "Лікар медицини (МД)" },
      new DoctorDegree { Id = Guid.NewGuid(), Name = "Лікар остеопатії (ДО)" },
      new DoctorDegree { Id = Guid.NewGuid(), Name = "Лікар стоматології (ДМД)" },
      new DoctorDegree { Id = Guid.NewGuid(), Name = "Лікар стоматології (ДДС)" },
      new DoctorDegree { Id = Guid.NewGuid(), Name = "Лікар фармації (ФармД)" },
      new DoctorDegree { Id = Guid.NewGuid(), Name = "Лікар ветеринарної медицини (ДВМ)" },
      new DoctorDegree { Id = Guid.NewGuid(), Name = "Лікар офтальмології (ОД)" },
      new DoctorDegree { Id = Guid.NewGuid(), Name = "Лікар фізичної терапії (ДПТ)" },
      new DoctorDegree { Id = Guid.NewGuid(), Name = "Лікарська практика (ДНП)" },
      new DoctorDegree { Id = Guid.NewGuid(), Name = "Лікар психології (ПсД)" },
      new DoctorDegree { Id = Guid.NewGuid(), Name = "Лікар хіропрактики (ДС)" },
      new DoctorDegree { Id = Guid.NewGuid(), Name = "Лікар окупаційної терапії (ОТД)" },
      new DoctorDegree { Id = Guid.NewGuid(), Name = "Лікарська адміністрація (ДрФА)" },
      new DoctorDegree { Id = Guid.NewGuid(), Name = "Лікар наук зі стоматології (ДСкД)" },
      new DoctorDegree { Id = Guid.NewGuid(), Name = "Лікар наук з ветеринарної медицини (ДВН)" },
      new DoctorDegree { Id = Guid.NewGuid(), Name = "Лікар аудіології (АuD)" },
      new DoctorDegree { Id = Guid.NewGuid(), Name = "Лікар педіатричної медицини (ДПМ)" },
      new DoctorDegree { Id = Guid.NewGuid(), Name = "Лікар наук з медицини (ДНМ)" },
      new DoctorDegree { Id = Guid.NewGuid(), Name = "Лікар з охорони здоров'я (ДОЗ)" },
      new DoctorDegree { Id = Guid.NewGuid(), Name = "Лікар медичних наук (ДМН)" },
  };


            context.DoctorDegrees.AddRange(doctorDegrees);

            // Посіяти лікарів
            var doctors = new List<Doctor> {
   new Doctor {
    Id = Guid.NewGuid(),
    Name = "Колін",
    Surname = "Ґрір",
    ExperienceInYearsNumber = 23,
    DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
    DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Ноель",
    Surname = "Маркес",
    ExperienceInYearsNumber = 19,
    DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
    DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Руні",
    Surname = "Беннетт",
    ExperienceInYearsNumber = 0,
    DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
    DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Ендрю",
    Surname = "Поуп",
    ExperienceInYearsNumber = 42,
    DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
    DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Ейпріл",
    Surname = "Дотсон",
    ExperienceInYearsNumber = 24,
    DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
    DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Джульєт",
    Surname = "Франко",
    ExperienceInYearsNumber = 24,
    DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
    DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Шеллі",
    Surname = "Батлер",
    ExperienceInYearsNumber = 23,
    DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
    DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Абель",
    Surname = "Керролл",
    ExperienceInYearsNumber = 39,
    DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
    DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Джілліан",
    Surname = "Замора",
    ExperienceInYearsNumber = 37,
    DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
    DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Лайл",
    Surname = "Грін",
    ExperienceInYearsNumber = 49,
    DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
    DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Ахмед",
    Surname = "Бентлі",
    ExperienceInYearsNumber = 7,
    DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
    DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Вінтер",
    Surname = "Руссо",
    ExperienceInYearsNumber = 5,
    DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
    DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Неро",
    Surname = "Келлі",
    ExperienceInYearsNumber = 21,
    DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
    DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Маріко",
    Surname = "Хоу",
    ExperienceInYearsNumber = 4,
    DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
    DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Інгрід",
    Surname = "Гаррелл",
    ExperienceInYearsNumber = 30,
    DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
    DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Дон",
    Surname = "Парсонс",
    ExperienceInYearsNumber = 43,
    DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
    DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Шеллі",
    Surname = "Хопкінс",
    ExperienceInYearsNumber = 43,
    DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
    DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Флер",
    Surname = "Лотт",
    ExperienceInYearsNumber = 32,
    DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
    DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
},

new Doctor {
    Id = Guid.NewGuid(),
    Name = "Вінус",
    Surname = "Сіммонс",
    ExperienceInYearsNumber = 25,
    DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
    DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Вівіан",
    Surname = "Стівенсон",
    ExperienceInYearsNumber = 30,
    DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
    DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Вернон",
    Surname = "Стокс",
    ExperienceInYearsNumber = 13,
    DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
    DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Натан",
    Surname = "Чендлер",
    ExperienceInYearsNumber = 48,
    DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
    DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Індія",
    Surname = "Вудвард",
    ExperienceInYearsNumber = 4,
    DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
    DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Брендан",
    Surname = "Меррілл",
    ExperienceInYearsNumber = 3,
    DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
    DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Йоланда",
    Surname = "Бредшоу",
    ExperienceInYearsNumber = 34,
    DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
    DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Нель",
    Surname = "Бойл",
    ExperienceInYearsNumber = 35,
    DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
    DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Кастор",
    Surname = "Пул",
    ExperienceInYearsNumber = 4,
    DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
    DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Джесі",
    Surname = "Пейн",
    ExperienceInYearsNumber = 23,
    DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
    DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Іган",
    Surname = "Меррілл",
    ExperienceInYearsNumber = 33,
    DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
    DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
},
new Doctor {
    Id = Guid.NewGuid(),
    Name = "Дірдрі",
    Surname = "Барбер",
    ExperienceInYearsNumber = 6,
    DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
    DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
},
};

            context.Doctors.AddRange(doctors);

            context.SaveChanges();
        }
    }
}
