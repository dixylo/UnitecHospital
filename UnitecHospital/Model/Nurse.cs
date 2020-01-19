using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitecHospital
{
    [Serializable()]
    class Nurse : Person
    {
        private Rank rank;

        public Nurse(string firstName, string lastName, Rank rank)
        {
            ID = count;
            this.firstName = firstName;
            this.lastName = lastName;
            this.rank = rank;
            personType = PersonType.Nurse;
        }

        public Rank getRank()
        {
            return rank;
        }

        public void setRank(Rank rank)
        {
            this.rank = rank;
        }
    }
}
