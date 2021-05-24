using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSimulation
{
    
    class PC
    {
        
        public string theme { get; set; }
        public string forum_content { get; set; }

        private double _date_publication;
        public double date_publication
        {
            get
            {
                return _date_publication;
            }
            set
            {
                if (value >= 0)
                    _date_publication = value;
                else
                    throw new Exception("Дата публікації не може бути відємною");
            }
        }

        private double _number_of_discussions;
        public double number_of_discussions
        {
            get
            {
                return _number_of_discussions;
            }
            set
            {
                if (value >= 0)
                    _number_of_discussions = value;
                else
                    throw new Exception("Кількість обговорень не може бути відємним");
            }
        }



        public PC(string theme, string forum_content, double date_publication, double number_of_discussions)
        {
            this.theme = theme;
            this.forum_content = forum_content;
            this.date_publication = date_publication;
            this.number_of_discussions = number_of_discussions;

        }

    }
}
