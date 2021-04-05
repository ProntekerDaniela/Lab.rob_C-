using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsLab7_2
{
    class File
    {
        public int file_format;
        public int date_of_creation;
        public int duration;
        public int sampling_frequency;
        public int coding_depth;
        public int point;
        public int size;
        public int time;
        public File( int time, int coding_depth, int size)
        {
            
            this.time = time;
            this.coding_depth = coding_depth;
            this.size  = size;
         
            
        }
        public File(File file)
        {
           
            this.time = file.time;
            this.coding_depth = file.coding_depth;
            this.size = file.size;
            
            
        }
        public string file_age()
        {
            DateTime date_of_creation = new DateTime(2021, 3, 25);
            DateTime date1 = new DateTime(2021, 2, 25);
            return $"({date_of_creation.Subtract(date1)})";
        }
        public string number_of_save_points()
        {
            double point = (size / (coding_depth * time));
            return $"({point})";
        }
        public string file_size()
        {
            int sampling_frequency = 10;
            int size = (sampling_frequency * coding_depth * time);
            return $"({size})";
        }
    }
}
