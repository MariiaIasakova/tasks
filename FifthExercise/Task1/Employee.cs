using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Employee : User
    {
        private string position;
        private double experience;

        public Employee(double experience, string position) : base(name, family, patronymic, datebth) 
        {
            Experience = experience;
            Position = position;
        }

        public double Experience { get; set; }

        public string Position
        {
            get
            {
                return position;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    position = value;
                }
                else
                {
                    throw new ArgumentException("position cannot be empty");
                }
            }
        }
    }
}
