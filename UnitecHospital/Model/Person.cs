using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitecHospital
{
    enum PersonType
    {
        Patient, Doctor, Nurse
    }

    enum Specialty
    {
        Cardiology, Dermatology, Gastroenterology, Immunology, Nephrology, Neurology, Ophthalmology, Otorhinolaryngology, Pulmonology
    }

    enum Rank
    {
        Certified, Licensed, Registered
    }

    enum State
    {
        Undiagosed, Diagosed, Cared, Recovered
    }

    [Serializable()]
    class Person
    {
        protected int ID;
        protected static int count;
        protected string firstName, lastName;
        protected PersonType personType;

        public Person()
        {
            count++;
        }

        public int getID()
        {
            return ID;
        }

        public string getFirstName()
        {
            return firstName;
        }

        public string getLastName()
        {
            return lastName;
        }

        public string getFullName()
        {
            string fullName = firstName + " " + lastName;
            return fullName;
        }

        public PersonType getPersonType()
        {
            return personType;
        }

        public static void setCount(int newStart)
        {
            count = newStart;
        }

        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public void setPersonType(PersonType personType)
        {
            this.personType = personType;
        }
    }
}
