using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitecHospital
{
    class ViewController
    {
        private ArrayList persons;       
        private BinaryFormatter binFor;

        private static ViewController _instance;
        public static ViewController GetInstance()
        {
            if (_instance == null)
                _instance = new ViewController();
            return _instance;
        }

        public ViewController()
        {
            persons = new ArrayList();
            binFor = new BinaryFormatter();           
        }
        
        public void loadList()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Data File | *.dat";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                persons.Clear();

                FileInfo finfo = new FileInfo(ofd.FileName);
                Stream stream = finfo.Open(FileMode.Open);

                while (stream.Position != stream.Length)
                {
                    persons.Add(binFor.Deserialize(stream));
                }
                stream.Close();
            }

            int maxID = 0;
            foreach(Person person in persons)
            {
                int ID = person.getID();
                if (maxID < ID)
                {
                    maxID = ID;
                }
            }
            Person.setCount(maxID);
        }

        public void saveList()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Data File | *.dat";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(sfd.FileName);
                Stream stream;
                stream = fileInfo.Open(FileMode.Create, FileAccess.ReadWrite);
                foreach (Person person in persons)
                {
                    binFor.Serialize(stream, person);
                }
                stream.Close();
            }
        }

        public void addPatient(string firstName, string lastName, string doctorName, string nurseName)
        {
            Patient newPatient = new Patient(firstName, lastName, doctorName, nurseName);
            persons.Add(newPatient);
        }

        public void addDoctor(string firstName, string lastName, Specialty specialty)
        {
            Doctor newDoctor = new Doctor(firstName, lastName, specialty);
            persons.Add(newDoctor);
        }

        public void addNurse(string firstName, string lastName, Rank rank)
        {
            Nurse newNurse = new Nurse(firstName, lastName, rank);
            persons.Add(newNurse);
        }

        public void modifyPatient(int selectedIndex, string firstName, string lastName, string doctorName, string nurseName)
        {
            Patient patient = (Patient)persons[selectedIndex];
            patient.setFirstName(firstName);
            patient.setLastName(lastName);
            patient.setDoctorName(doctorName);
            patient.setNurseName(nurseName);
        }

        public void updatePatientState(int selectedIndex, State state)
        {
            Patient patient = (Patient)persons[selectedIndex];
            patient.setState(state);
        }

        public void modifyDoctor(int selectedIndex, string firstName, string lastName, Specialty specialty)
        {
            Doctor doctor = (Doctor)persons[selectedIndex];
            doctor.setFirstName(firstName);
            doctor.setLastName(lastName);
            doctor.setSpecialty(specialty);

        }

        public void modifyNurse(int selectedIndex, string firstName, string lastName, Rank rank)
        {
            Nurse nurse = (Nurse)persons[selectedIndex];
            nurse.setFirstName(firstName);
            nurse.setLastName(lastName);
            nurse.setRank(rank);
        }

        public bool removePerson(int selectedIndex)
        {
            string name = ((Person)persons[selectedIndex]).getFullName();
            string[,] table = this.getList();
            int count = getCount();
            for (int i = 0; i < count; i++)
            {
                if (name == table[i, 4] || name == table[i, 5])
                {
                    return false;
                }
            }

            persons.RemoveAt(selectedIndex);
            return true;
        }

        public bool isDuplicate(string firstName, string lastName, PersonType personType)
        {
            foreach (Person person in persons)
            {
                if (person.getFullName() == firstName + " " + lastName && person.getPersonType() == personType)
                {
                    return true;
                }
            }
            return false;
        }

        public int getCount()
        {
            return persons.Count;
        }

        public string[,] getList()
        {
            string[,] table = new string[persons.Count, 7];

            for (int i = 0; i < persons.Count; i++)
            {

                table[i, 0] = ((Person)persons[i]).getID().ToString();
                table[i, 1] = ((Person)persons[i]).getPersonType().ToString();
                table[i, 2] = ((Person)persons[i]).getFullName();

                PersonType personType = ((Person)persons[i]).getPersonType();

                switch (personType)
                {
                    case PersonType.Doctor:
                        table[i, 3] = ((Doctor)persons[i]).getSpecialty().ToString();
                        table[i, 4] = "";
                        table[i, 5] = "";
                        table[i, 6] = @"..\..\assets\doctor.png";
                        break;
                    case PersonType.Nurse:
                        table[i, 3] = ((Nurse)persons[i]).getRank().ToString();
                        table[i, 4] = "";
                        table[i, 5] = "";
                        table[i, 6] = @"..\..\assets\nurse.png";
                        break;
                    case PersonType.Patient:
                        table[i, 3] = ((Patient)persons[i]).getState().ToString();
                        table[i, 4] = ((Patient)persons[i]).getDoctorName().ToString();
                        table[i, 5] = ((Patient)persons[i]).getNurseName().ToString();
                        switch (getPatientState(i))
                        {
                            case State.Undiagosed:
                                table[i, 6] = @"..\..\assets\patient.png";
                                break;
                            case State.Diagosed:
                                table[i, 6] = @"..\..\assets\diagnosed.png";
                                break;
                            case State.Cared:
                                table[i, 6] = @"..\..\assets\cared.png";
                                break;
                            case State.Recovered:
                                table[i, 6] = @"..\..\assets\recovered.png";
                                break;
                        }
                        break;
                }                
            }

            return table;
        }

        public string[,] getPatientList()
        {
            ArrayList patients = new ArrayList();
            foreach (var person in persons)
            {
                if (person.GetType().Equals(typeof(Patient)))
                {
                    patients.Add(person);
                }
            }

            string[,] table = new string[patients.Count, 7];

            for (int i = 0; i < patients.Count; i++)
            {
                Patient patient = (Patient)patients[i];

                table[i, 0] = patient.getID().ToString();
                table[i, 1] = patient.getPersonType().ToString();
                table[i, 2] = patient.getFullName();
                table[i, 3] = patient.getState().ToString();
                table[i, 4] = patient.getDoctorName().ToString();
                table[i, 5] = patient.getNurseName().ToString();
                switch (patient.getState())
                {
                    case State.Undiagosed:
                        table[i, 6] = @"..\..\assets\patient.png";
                        break;
                    case State.Diagosed:
                        table[i, 6] = @"..\..\assets\diagnosed.png";
                        break;
                    case State.Cared:
                        table[i, 6] = @"..\..\assets\cared.png";
                        break;
                    case State.Recovered:
                        table[i, 6] = @"..\..\assets\recovered.png";
                        break;
                }
            }

            return table;
        }

        public string[,] getDoctorList()
        {
            ArrayList doctors = new ArrayList();
            foreach (var person in persons)
            {
                if (person.GetType().Equals(typeof(Doctor)))
                {
                    doctors.Add(person);
                }
            }

            string[,] table = new string[doctors.Count, 7];

            for (int i = 0; i < doctors.Count; i++)
            {
                Doctor doctor = (Doctor)doctors[i];
                table[i, 0] = doctor.getID().ToString();
                table[i, 1] = doctor.getPersonType().ToString();
                table[i, 2] = doctor.getFullName();
                table[i, 3] = doctor.getSpecialty().ToString();
                table[i, 4] = "";
                table[i, 5] = "";
                table[i, 6] = @"..\..\assets\doctor.png";
            }

            return table;
        }

        public string[,] getNurseList()
        {
            ArrayList nurses = new ArrayList();
            foreach (var person in persons)
            {
                if (person.GetType().Equals(typeof(Nurse)))
                {
                    nurses.Add(person);
                }
            }

            string[,] table = new string[nurses.Count, 7];

            for (int i = 0; i < nurses.Count; i++)
            {
                Nurse nurse = (Nurse)nurses[i];
                table[i, 0] = nurse.getID().ToString();
                table[i, 1] = nurse.getPersonType().ToString();
                table[i, 2] = nurse.getFullName();
                table[i, 3] = nurse.getRank().ToString();
                table[i, 4] = "";
                table[i, 5] = "";
                table[i, 6] = @"..\..\assets\nurse.png";
            }

            return table;
        }

        public State getPatientState(int selectedIndex)
        {
            Patient patient = (Patient)persons[selectedIndex];
            State state = patient.getState();
            return state;
        }

        public ArrayList getDoctorNames()
        {
            ArrayList doctorNames = new ArrayList();
            foreach(Person person in persons)
            {
                if(person.getPersonType() == PersonType.Doctor)
                {
                    doctorNames.Add(person.getFullName());
                }
            }
            return doctorNames;
        }

        public ArrayList getNurseNames()
        {
            ArrayList nurseNames = new ArrayList();
            foreach (Person person in persons)
            {
                if (person.getPersonType() == PersonType.Nurse)
                {
                    nurseNames.Add(person.getFullName());
                }
            }
            return nurseNames;
        }
    }
}
