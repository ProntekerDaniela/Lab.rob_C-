using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLab9_2
{
    /*Створити клас TGoods, який характеризує деякий товар на складі.Клас повинен
містити поля: назва товару, одиниці виміру, кількість, ціна однієї одиниці.Реалізувати
методи визначення сумарної вартості товару та методи збільшення/зменшення кількості
товару.*/
    class TGoods
    {
        private string name; 
        private string amount; 
        private int unit; 
        private double price;
        
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        public string Amount
        {
            get { return amount; }
            set
            {
                amount = value;
            }
        }
        public int Unit
        {
            get { return unit; }
            set
            {
                if (value > 0)unit = value;
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0) price = value;
            }
        }
        
        public TGoods(string name, string amount , int unit,double price)
        {
            this.name = name;
            this.amount = amount;
            this.unit = unit;
            this.price = price;
            
        }

        

        public string input_and_output()
        {
            return $"Назва товару:{name},Одиниця виміру:{amount},Кількість:{unit},Ціна:{price}";
        }
        public string cost()
        {
            return $" {unit * price}";
        }

        public string UnitToBigger(int newUnit)
        {
            
            return $" {unit += newUnit}";
        }

        public string UnitToLower(int newUnit)
        {
            return $" {unit -= newUnit}";
        }
        public string input_and_output_2()
        {
            return $"Назва товару:{name},Одиниця виміру:{amount},Кількість:{unit},Ціна:{price}";
        }

    }

    
   



}

