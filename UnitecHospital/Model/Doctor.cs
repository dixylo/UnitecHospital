using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitecHospital
{
    [Serializable()]
    class Doctor : Person
    {
        private Specialty specialty;
        
        public Doctor(string firstName, string lastName, Specialty specialty)
        {
            ID = count;
            this.firstName = firstName;
            this.lastName = lastName;
            this.specialty = specialty;
            personType = PersonType.Doctor;
        }

        public Specialty getSpecialty()
        {
            return specialty;
        }

        public void setSpecialty(Specialty specialty)
        {
            this.specialty = specialty;
        }
    }
}
