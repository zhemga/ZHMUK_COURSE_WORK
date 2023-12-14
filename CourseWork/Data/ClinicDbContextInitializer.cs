﻿using CourseWork.Model;
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

            // Seed DoctorProfiles
            var doctorProfiles = new List<DoctorProfile>
            {
                new DoctorProfile { Id = Guid.NewGuid().ToString(), Name = "Cardiologist" },
                new DoctorProfile { Id = Guid.NewGuid().ToString(), Name = "Dermatologist" },
                new DoctorProfile { Id = Guid.NewGuid().ToString(), Name = "Pediatrician" },
                new DoctorProfile { Id = Guid.NewGuid().ToString(), Name = "Orthopedic Surgeon" },
                new DoctorProfile { Id = Guid.NewGuid().ToString(), Name = "Neurologist" },
                new DoctorProfile { Id = Guid.NewGuid().ToString(), Name = "Gastroenterologist" },
                new DoctorProfile { Id = Guid.NewGuid().ToString(), Name = "Ophthalmologist" },
                new DoctorProfile { Id = Guid.NewGuid().ToString(), Name = "Endocrinologist" },
                new DoctorProfile { Id = Guid.NewGuid().ToString(), Name = "Obstetrician-Gynecologist" },
                new DoctorProfile { Id = Guid.NewGuid().ToString(), Name = "Urologist" },
                new DoctorProfile { Id = Guid.NewGuid().ToString(), Name = "Psychiatrist" },
                new DoctorProfile { Id = Guid.NewGuid().ToString(), Name = "Pulmonologist" },
                new DoctorProfile { Id = Guid.NewGuid().ToString(), Name = "Rheumatologist" },
                new DoctorProfile { Id = Guid.NewGuid().ToString(), Name = "Oncologist" },
                new DoctorProfile { Id = Guid.NewGuid().ToString(), Name = "Allergist" },
                new DoctorProfile { Id = Guid.NewGuid().ToString(), Name = "Hematologist" },
                new DoctorProfile { Id = Guid.NewGuid().ToString(), Name = "Nephrologist" },
                new DoctorProfile { Id = Guid.NewGuid().ToString(), Name = "Dental Surgeon" },
                new DoctorProfile { Id = Guid.NewGuid().ToString(), Name = "Plastic Surgeon" },
                new DoctorProfile { Id = Guid.NewGuid().ToString(), Name = "Infectious Disease Specialist" },
            };

            context.DoctorProfiles.AddRange(doctorProfiles);

            // Seed DoctorDegrees
            var doctorDegrees = new List<DoctorDegree>
            {
                new DoctorDegree { Id = Guid.NewGuid().ToString(), Name = "Doctor of Medicine (MD)" },
                new DoctorDegree { Id = Guid.NewGuid().ToString(), Name = "Doctor of Osteopathic Medicine (DO)" },
                new DoctorDegree { Id = Guid.NewGuid().ToString(), Name = "Doctor of Dental Medicine (DMD)" },
                new DoctorDegree { Id = Guid.NewGuid().ToString(), Name = "Doctor of Dental Surgery (DDS)" },
                new DoctorDegree { Id = Guid.NewGuid().ToString(), Name = "Doctor of Pharmacy (PharmD)" },
                new DoctorDegree { Id = Guid.NewGuid().ToString(), Name = "Doctor of Veterinary Medicine (DVM)" },
                new DoctorDegree { Id = Guid.NewGuid().ToString(), Name = "Doctor of Optometry (OD)" },
                new DoctorDegree { Id = Guid.NewGuid().ToString(), Name = "Doctor of Physical Therapy (DPT)" },
                new DoctorDegree { Id = Guid.NewGuid().ToString(), Name = "Doctor of Nursing Practice (DNP)" },
                new DoctorDegree { Id = Guid.NewGuid().ToString(), Name = "Doctor of Psychology (PsyD)" },
                new DoctorDegree { Id = Guid.NewGuid().ToString(), Name = "Doctor of Chiropractic (DC)" },
                new DoctorDegree { Id = Guid.NewGuid().ToString(), Name = "Doctor of Occupational Therapy (OTD)" },
                new DoctorDegree { Id = Guid.NewGuid().ToString(), Name = "Doctor of Public Health (DrPH)" },
                new DoctorDegree { Id = Guid.NewGuid().ToString(), Name = "Doctor of Science in Dentistry (DScD)" },
                new DoctorDegree { Id = Guid.NewGuid().ToString(), Name = "Doctor of Science in Veterinary Medicine (DVSc)" },
                new DoctorDegree { Id = Guid.NewGuid().ToString(), Name = "Doctor of Audiology (AuD)" },
                new DoctorDegree { Id = Guid.NewGuid().ToString(), Name = "Doctor of Podiatric Medicine (DPM)" },
                new DoctorDegree { Id = Guid.NewGuid().ToString(), Name = "Doctor of Science in Medicine (DScM)" },
                new DoctorDegree { Id = Guid.NewGuid().ToString(), Name = "Doctor of Health Administration (DHA)" },
                new DoctorDegree { Id = Guid.NewGuid().ToString(), Name = "Doctor of Medical Science (DMSc)" },
            };

            context.DoctorDegrees.AddRange(doctorDegrees);

			// Seed Doctors
			var doctors = new List<Doctor> {
	new Doctor {
		Id = "0D7540AA-602D-A660-B0E9-B2CA06CAB7EF",
		Name = "Colin",
		Surname = "Greer",
		ExperienceInYearsNumber = 23,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "2CB7608D-7875-CEE6-4AC5-D9D41101C52D",
		Name = "Noelle",
		Surname = "Marquez",
		ExperienceInYearsNumber = 19,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "7407175D-5EE7-DEE8-9BE9-32ACAA18488E",
		Name = "Rooney",
		Surname = "Bennett",
		ExperienceInYearsNumber = 0,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "EA643116-7E6D-A2B2-2EC6-976627D63CCE",
		Name = "Andrew",
		Surname = "Pope",
		ExperienceInYearsNumber = 42,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "3C52CD49-6F76-C160-FD7A-211B0575ACA4",
		Name = "April",
		Surname = "Dotson",
		ExperienceInYearsNumber = 24,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "6AB4238C-557A-84E8-7881-B89E19995F28",
		Name = "Juliet",
		Surname = "Franco",
		ExperienceInYearsNumber = 24,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "A17F4C45-DB5B-6C57-3CBF-ADBE2849EEA3",
		Name = "Shellie",
		Surname = "Butler",
		ExperienceInYearsNumber = 23,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "9ADBE9B7-CCA3-28DE-BDA5-2B1B32B25C96",
		Name = "Abel",
		Surname = "Carroll",
		ExperienceInYearsNumber = 39,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "3BB8CD7C-DE12-FAD3-4D53-16ECC96F82B4",
		Name = "Jillian",
		Surname = "Zamora",
		ExperienceInYearsNumber = 37,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "5E37360B-9572-1C39-98EF-C75E09916CCC",
		Name = "Lyle",
		Surname = "Greene",
		ExperienceInYearsNumber = 49,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "CFC5C2C8-42C3-223C-D53E-A587A79C8E97",
		Name = "Ahmed",
		Surname = "Bentley",
		ExperienceInYearsNumber = 7,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "C1DDA81C-D9B3-19AC-73BD-CE62AE29F00D",
		Name = "Winter",
		Surname = "Russo",
		ExperienceInYearsNumber = 5,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "DCFA7557-EB19-2C46-A31E-3105B986A78F",
		Name = "Nero",
		Surname = "Kelly",
		ExperienceInYearsNumber = 21,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "BEA1FEDA-5574-6748-2BFA-0D1E2CB9553A",
		Name = "Mariko",
		Surname = "Howe",
		ExperienceInYearsNumber = 4,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "19D6D4E7-1158-DBF3-524A-DE4678534C20",
		Name = "Ingrid",
		Surname = "Harrell",
		ExperienceInYearsNumber = 30,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "1955271E-69FB-B444-56E9-5518BF6B0596",
		Name = "Dawn",
		Surname = "Parsons",
		ExperienceInYearsNumber = 43,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "A03E3A14-C94A-8487-9C81-6799497A3F9B",
		Name = "Shelly",
		Surname = "Hopkins",
		ExperienceInYearsNumber = 43,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "4B724401-92EE-7116-EBF1-57C697A90682",
		Name = "Fleur",
		Surname = "Lott",
		ExperienceInYearsNumber = 32,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "F231020E-AB2A-C51E-6D75-D5EACF1EE732",
		Name = "Venus",
		Surname = "Simmons",
		ExperienceInYearsNumber = 25,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "4DC51661-DDBD-B05F-080D-41AB3505C7D3",
		Name = "Vivian",
		Surname = "Stephenson",
		ExperienceInYearsNumber = 30,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "941336E9-2132-55B8-BD8C-8A48737DECBE",
		Name = "Vernon",
		Surname = "Stokes",
		ExperienceInYearsNumber = 13,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "E77B16E7-8492-E4EB-CF5A-AD67DD2226D2",
		Name = "Nathan",
		Surname = "Chandler",
		ExperienceInYearsNumber = 48,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "680BA4C5-C4CD-14D7-9A60-942D6A6135E4",
		Name = "India",
		Surname = "Woodward",
		ExperienceInYearsNumber = 4,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "43376C8B-4682-C118-9933-6D498D47ABBC",
		Name = "Brendan",
		Surname = "Merrill",
		ExperienceInYearsNumber = 3,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "609577AB-B699-4230-AB20-F2D42E5D78F5",
		Name = "Yolanda",
		Surname = "Bradshaw",
		ExperienceInYearsNumber = 34,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "30E19A93-5485-E9C3-2272-37FFB02EEBAE",
		Name = "Nelle",
		Surname = "Boyle",
		ExperienceInYearsNumber = 35,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "436529B1-3C8B-9C24-24F2-38C6903B8B3A",
		Name = "Castor",
		Surname = "Poole",
		ExperienceInYearsNumber = 4,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "82B8BC2B-43ED-C3D3-95DA-77A39BC21BD5",
		Name = "Jescie",
		Surname = "Payne",
		ExperienceInYearsNumber = 23,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "5BEEBEFE-581F-68E8-E113-5DF7FEE2FC8F",
		Name = "Eagan",
		Surname = "Merrill",
		ExperienceInYearsNumber = 33,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "8E1B89DD-683E-5911-DE21-C3838D4D25D2",
		Name = "Deirdre",
		Surname = "Barber",
		ExperienceInYearsNumber = 6,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "49D6E179-A294-098B-13C1-0E122D34B4A4",
		Name = "Sigourney",
		Surname = "Mcintosh",
		ExperienceInYearsNumber = 6,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "77122EDB-BE1E-70DB-2FC8-2A2A4287BC23",
		Name = "Molly",
		Surname = "Curtis",
		ExperienceInYearsNumber = 7,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "6FABCBAF-6D6E-C162-F9A6-DD112F4A83F7",
		Name = "Derek",
		Surname = "Ryan",
		ExperienceInYearsNumber = 14,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "D2703841-A857-C56E-733D-7CB1690C5B84",
		Name = "Duncan",
		Surname = "Vasquez",
		ExperienceInYearsNumber = 48,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "C2391684-7D91-DAA3-A31C-E1579E46BCC2",
		Name = "Stone",
		Surname = "Lang",
		ExperienceInYearsNumber = 11,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "485E454B-3AB8-93AB-07E0-956A6907546E",
		Name = "Trevor",
		Surname = "Ochoa",
		ExperienceInYearsNumber = 28,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "1868B432-843C-ED5B-BCB6-40139BC9D8A5",
		Name = "Nehru",
		Surname = "Kirk",
		ExperienceInYearsNumber = 35,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "9C5ACE9C-89DA-A53A-E20E-8EC54CF207E2",
		Name = "Macon",
		Surname = "Zamora",
		ExperienceInYearsNumber = 20,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "420A2E6D-68BA-1C6C-4ED4-BC9271BF37A7",
		Name = "Carlos",
		Surname = "Hickman",
		ExperienceInYearsNumber = 16,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "AB90DBCD-A3DE-51CE-DD85-C5588B4E310E",
		Name = "Paula",
		Surname = "Landry",
		ExperienceInYearsNumber = 25,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "F56178CA-4712-1E5F-16AD-7D15D407FE5D",
		Name = "Dora",
		Surname = "Chavez",
		ExperienceInYearsNumber = 10,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "21C112D5-046D-E742-02FD-B29D3A8621BC",
		Name = "Armand",
		Surname = "Burch",
		ExperienceInYearsNumber = 23,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "66888E99-1C7C-201E-EA3C-791CC8156831",
		Name = "Coby",
		Surname = "Hurst",
		ExperienceInYearsNumber = 16,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "447F14C2-828B-C311-13C5-16873E0477A8",
		Name = "William",
		Surname = "Lewis",
		ExperienceInYearsNumber = 23,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "18FB401A-0EC2-9819-3BE9-E8840056B091",
		Name = "Georgia",
		Surname = "Nichols",
		ExperienceInYearsNumber = 22,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "AE6C6BCC-26D8-DD81-2647-85F2C245BB67",
		Name = "MacKensie",
		Surname = "Gallegos",
		ExperienceInYearsNumber = 50,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "89E1E2D3-E70B-DB69-D659-D4B620B55253",
		Name = "Ivor",
		Surname = "Steele",
		ExperienceInYearsNumber = 32,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "21A6A2C6-868B-8420-1D82-234811C51B9E",
		Name = "Vincent",
		Surname = "Saunders",
		ExperienceInYearsNumber = 8,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "C2EE6C9A-9497-1FD5-DED3-22E1CBD12CE0",
		Name = "Thomas",
		Surname = "Benton",
		ExperienceInYearsNumber = 25,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "95353631-2975-2E7A-A7FF-2976BEFC2DB9",
		Name = "Jaime",
		Surname = "Mercer",
		ExperienceInYearsNumber = 33,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "82A126AC-731B-34F9-E42E-5682B2A5CD74",
		Name = "Montana",
		Surname = "Suarez",
		ExperienceInYearsNumber = 19,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "223A7726-3153-D952-5BDE-1A652E6C2B24",
		Name = "Sharon",
		Surname = "Sampson",
		ExperienceInYearsNumber = 11,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "B8134E69-EA9F-E96F-758D-DCE4D89B4259",
		Name = "Tatyana",
		Surname = "Watkins",
		ExperienceInYearsNumber = 16,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "4747A77D-6C1E-2A62-2D7A-17B847D57F59",
		Name = "Phoebe",
		Surname = "Curry",
		ExperienceInYearsNumber = 31,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "A3965275-3942-16A3-5D30-4FB128975CD6",
		Name = "Chava",
		Surname = "Walter",
		ExperienceInYearsNumber = 47,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "CF59BFCC-434B-E436-1489-353491E6DD4C",
		Name = "Griffin",
		Surname = "Dixon",
		ExperienceInYearsNumber = 47,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "6BB9B1A4-EED8-EA9B-5A5A-995842C5264B",
		Name = "Nicholas",
		Surname = "Fulton",
		ExperienceInYearsNumber = 23,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "AC974D13-9C6E-6159-BEFB-296C529763E9",
		Name = "Bert",
		Surname = "Rodriquez",
		ExperienceInYearsNumber = 26,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "3994823D-CDAD-E8C0-357A-B5CD94EAA23D",
		Name = "Nomlanga",
		Surname = "Potter",
		ExperienceInYearsNumber = 21,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "3C84CC2F-B9B3-7A1F-6019-39EE2829C3B8",
		Name = "Alec",
		Surname = "Berry",
		ExperienceInYearsNumber = 41,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "C82A179C-46B1-DE6D-7842-29AA34163F45",
		Name = "Hector",
		Surname = "Knowles",
		ExperienceInYearsNumber = 11,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "C9D3A5A3-F58B-9A28-C683-E20467D5F541",
		Name = "Glenna",
		Surname = "Holman",
		ExperienceInYearsNumber = 4,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "2BC77230-C5DD-F396-4F84-6A32859FE45D",
		Name = "Sopoline",
		Surname = "King",
		ExperienceInYearsNumber = 17,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "8586C319-E7E3-5492-9518-113B39EBA1A8",
		Name = "Autumn",
		Surname = "Yates",
		ExperienceInYearsNumber = 8,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "DF3B2E37-7798-597A-3B5D-17CEEC00A8A8",
		Name = "Leo",
		Surname = "May",
		ExperienceInYearsNumber = 38,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "76C9EC59-1A41-DF67-D38B-44A52D58ECCE",
		Name = "Kasimir",
		Surname = "Rich",
		ExperienceInYearsNumber = 20,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "0142FCC0-09EF-FEA9-D6D8-6DE0269037B4",
		Name = "Shana",
		Surname = "Petersen",
		ExperienceInYearsNumber = 25,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "1A4AE2CC-2C71-5CC7-FE54-63F3A8739771",
		Name = "Perry",
		Surname = "Petty",
		ExperienceInYearsNumber = 19,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "E708E2A1-B44A-DF09-FAB6-95B6ACA21CEC",
		Name = "Rae",
		Surname = "Haley",
		ExperienceInYearsNumber = 8,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "44D77D25-5174-0534-56DF-C845C44098A3",
		Name = "Cairo",
		Surname = "Wilkins",
		ExperienceInYearsNumber = 37,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "8A62D485-F464-1A9C-3B4A-CE58A585C145",
		Name = "Aquila",
		Surname = "Floyd",
		ExperienceInYearsNumber = 17,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "636702E1-3944-561E-2A48-79E87DC7BA72",
		Name = "Anthony",
		Surname = "Wade",
		ExperienceInYearsNumber = 35,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "6394592E-628B-6C24-7433-07E128E855CD",
		Name = "Kenyon",
		Surname = "Henderson",
		ExperienceInYearsNumber = 35,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "DB968CAC-BD0D-C1E1-8499-675AB9113DB2",
		Name = "Tarik",
		Surname = "Morris",
		ExperienceInYearsNumber = 32,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "F6C2A93E-AB7B-93DE-DF3C-31F4CA1D38DA",
		Name = "Yoshio",
		Surname = "Wilson",
		ExperienceInYearsNumber = 38,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "12B74BD3-FD36-5533-EB91-1951B9873D91",
		Name = "Tobias",
		Surname = "Cruz",
		ExperienceInYearsNumber = 17,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "6B387597-6AD8-63DA-0465-A18113DB2A13",
		Name = "Cadman",
		Surname = "Kelley",
		ExperienceInYearsNumber = 38,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "C5A5EC6E-7A89-6116-6391-E4987E78D8C6",
		Name = "Thane",
		Surname = "Poole",
		ExperienceInYearsNumber = 14,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "3C99BBED-7C9B-83CA-8742-E59723582239",
		Name = "Baxter",
		Surname = "Larsen",
		ExperienceInYearsNumber = 1,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "62DCAF74-B026-D6FB-4E3A-07E789DF4B07",
		Name = "Charity",
		Surname = "Wagner",
		ExperienceInYearsNumber = 29,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "9F7ED300-15A7-9DC8-12AC-B2CD5527CCE2",
		Name = "Briar",
		Surname = "Sweet",
		ExperienceInYearsNumber = 33,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "74E7319C-E01F-71B6-2DAD-9D85E9BE92CD",
		Name = "Yuri",
		Surname = "Torres",
		ExperienceInYearsNumber = 3,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "BE98DA65-A58E-DD23-2921-10AE98B67117",
		Name = "Yuli",
		Surname = "Velez",
		ExperienceInYearsNumber = 50,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "39A03858-C5FB-B0E5-52B7-2EAFB3D1131E",
		Name = "Latifah",
		Surname = "Washington",
		ExperienceInYearsNumber = 1,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "657A4825-7A7B-E4AB-FFCE-185FFEDBBB74",
		Name = "Jayme",
		Surname = "Dale",
		ExperienceInYearsNumber = 43,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "13295E1A-7DDF-C6ED-9652-E53A872CD4C7",
		Name = "Ursula",
		Surname = "Adkins",
		ExperienceInYearsNumber = 49,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "4572FC07-DC61-5D6C-7AD3-714E82C9DA71",
		Name = "Elijah",
		Surname = "Dalton",
		ExperienceInYearsNumber = 48,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "C96E958C-35A1-9088-9EA7-6ED5B844EA6A",
		Name = "Cathleen",
		Surname = "Phelps",
		ExperienceInYearsNumber = 18,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "38CC9213-1467-7AC8-DD4C-E685D5F665A3",
		Name = "Griffith",
		Surname = "Owen",
		ExperienceInYearsNumber = 1,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "9F7A8D53-8EDB-2A56-B645-47B3DA596E59",
		Name = "Ocean",
		Surname = "Weeks",
		ExperienceInYearsNumber = 34,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "2B4B54CD-1485-399A-72B4-5DD8D0C2BCE9",
		Name = "Macon",
		Surname = "Frazier",
		ExperienceInYearsNumber = 13,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "B5B31231-3253-4EBF-9D3B-424DBCE7B31A",
		Name = "Breanna",
		Surname = "Rollins",
		ExperienceInYearsNumber = 47,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "13924151-312D-6188-11AD-5A4D4E96E88F",
		Name = "Tana",
		Surname = "Shannon",
		ExperienceInYearsNumber = 35,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "E62A9A2B-AB7A-AE15-EDEC-86D14D17F61E",
		Name = "Porter",
		Surname = "Warner",
		ExperienceInYearsNumber = 28,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "B5D724AD-9DE8-988B-9D49-8AB9CA915085",
		Name = "Lana",
		Surname = "Soto",
		ExperienceInYearsNumber = 6,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "AE6363E1-1A83-E279-3726-4EC7DD683AB5",
		Name = "Carly",
		Surname = "Hutchinson",
		ExperienceInYearsNumber = 34,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "38F30A54-446E-AC6A-34A4-5A74C9169007",
		Name = "Daria",
		Surname = "Jarvis",
		ExperienceInYearsNumber = 49,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "DFCCF92C-2A96-BA93-4C0F-3BE6C4E12048",
		Name = "Allegra",
		Surname = "Santana",
		ExperienceInYearsNumber = 27,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "5B5BA291-ADBE-4B74-B344-D791623E4B40",
		Name = "Finn",
		Surname = "Townsend",
		ExperienceInYearsNumber = 44,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	},
	new Doctor {
		Id = "5C532225-D511-B1E2-D607-1263D88E5EB2",
		Name = "Blaze",
		Surname = "Becker",
		ExperienceInYearsNumber = 38,
		DoctorProfileId = doctorProfiles[random.Next(0, doctorProfiles.Count)].Id,
		DoctorDegreeId = doctorDegrees[random.Next(0, doctorDegrees.Count)].Id,
	}
};

			context.Doctors.AddRange(doctors);

            context.SaveChanges();
        }
    }
}
