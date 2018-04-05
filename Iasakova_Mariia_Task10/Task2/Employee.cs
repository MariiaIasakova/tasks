
using System;

namespace Task2
{
    class Employee : User, IEquatable<Employee>
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

        public bool Equals(Employee other)
        {
            if (other == null)
            {
                return false;
            }

            return (experience == other.experience) && (position == other.position);
        }

        //public static bool operator ==(Employee a, Employee b)
        //{
        //    if (ReferenceEquals(a, b))
        //    {
        //        return true;
        //    }

        //    if (((object)a == null) || ((object)b == null))
        //    {
        //        return false;
        //    }

        //    return a.experience == b.experience && a.position == b.position;
        //}

        //public static bool operator !=(Employee a, Employee b)
        //{
        //    return !(a == b);
        //}
    }
}
