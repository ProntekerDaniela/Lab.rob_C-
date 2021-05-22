using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSimulation
{
    class PC
    {
        
        public string name_surname { get; set; }
        public string work { get; set; }

        private double _phone_number;
        public double phone_number
        {
            get
            {
                return _phone_number;
            }
            set
            {
                if (value >= 0)
                    _phone_number = value;
                else
                    throw new Exception("Номер телефону не може бути відємним");
            }
        }

        private double _home_phone_number;
        public double home_phone_number
        {
            get
            {
                return _home_phone_number;
            }
            set
            {
                if (value >= 0)
                    _home_phone_number = value;
                else
                    throw new Exception("Домашній номер телефону не може бути відємним");
            }
        }

      

        public PC(string name_surname, string work, double phone_number, double home_phone_number)
        {
            this.name_surname = name_surname;
            this.work = work;
            this.phone_number = phone_number;
            this.home_phone_number = home_phone_number;

        }

    }
}
