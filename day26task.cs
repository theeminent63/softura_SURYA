using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace linq
{
    class day26task
    {
        public static void Main()
        {
            IList<Doctor> Docdata = new List<Doctor>()
            {
                new Doctor(){DoctorID=1,DoctorName="Dr. Ashish Sabharwal",DoctorAge=47,SpecialistID=1},
                new Doctor(){DoctorID=2,DoctorName="Dr. Surbhi Anand",DoctorAge=53,SpecialistID=2},
                new Doctor(){DoctorID=3,DoctorName="Dr. Sanjay Sachdeva",DoctorAge=35,SpecialistID=3},
                new Doctor(){DoctorID=4,DoctorName="Dr. Gagan Gautam",DoctorAge=30,SpecialistID=4},
                new Doctor(){DoctorID=3,DoctorName="Dr. SKS Marya",DoctorAge=35,SpecialistID=1},
                new Doctor(){DoctorID=4,DoctorName="Dr. Bipin S Walia",DoctorAge=30,SpecialistID=2},
                 new Doctor(){DoctorID=3,DoctorName="Dr. Sandeep Batra",DoctorAge=35,SpecialistID=3},
                new Doctor(){DoctorID=4,DoctorName="Dr. Aditya Gupta",DoctorAge=30,SpecialistID=4},
            };
            IList<Specialist> SpecData = new List<Specialist>()
            {
                new Specialist(){SpecialistID=1, SpecialistOf="Dermatology"},
                new Specialist(){SpecialistID=2, SpecialistOf="Anesthesiology"},
                new Specialist(){SpecialistID=3, SpecialistOf="Ophthalmology"},
                new Specialist(){SpecialistID=3, SpecialistOf="Psychiatry"}
            };
            var JoinData = Docdata.Join(
                SpecData,
                doc => doc.SpecialistID,
                spec => spec.SpecialistID,
                (doc, spec) => new
                {
                    DoctorName = doc.DoctorName,
                    Specialist = spec.SpecialistOf
                }
                );
            foreach (var v in JoinData)
            {
                Console.WriteLine(v.DoctorName + " specialis of  " + v.Specialist);
            }
        }
    }
    public class Doctor
    {
        public int DoctorID { get; set; }
        public string DoctorName { get; set; }
        public int DoctorAge { get; set; }

        public int SpecialistID { get; set; }

    }
    public class Specialist
    {
        public int SpecialistID { get; set; }
        public string SpecialistOf { get; set; }
    }

}