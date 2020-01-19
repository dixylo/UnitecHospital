using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitecHospital
{
    [Serializable()]
    class Patient : Person
    {
        private State state;
        private string doctorName;
        private string nurseName;

        public Patient(string firstName, string lastName, string doctorName, string nurseName)
        {
            ID = count;
            this.firstName = firstName;
            this.lastName = lastName;
            state = State.Undiagosed;
            this.doctorName = doctorName;
            this.nurseName = nurseName;
            personType = PersonType.Patient;
        }

        public State getState()
        {
            return state;
        }

        public string getDoctorName()
        {
            return doctorName;
        }

        public string getNurseName()
        {
            return nurseName;
        }

        public void setState(State state)
        {
            this.state = state;
        }

        public void setDoctorName(string doctorName)
        {
            this.doctorName = doctorName;
        }

        public void setNurseName(string nurseName)
        {
            this.nurseName = nurseName;
        }
    }
}
