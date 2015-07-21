using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2_2
{
    class Box
    {
        private float _area = 0;
        private float _diagonal = 0;
        private float _volume = 0;
        private string _name = "";

        public Box(string name)
        {
            if (name.Length > 0)
            {
                _name = name;
            }
            else
                _name = "NoName";
        }
        static Box()
        { }
        public void Print()
        {
            Console.WriteLine("{0}: Площадь - {1} см^2, Объём - {2} см^3, Диагональ - {3} см", _name, _area, _volume, _diagonal);
        }
        public string Name
        {
            set { _name = Convert.ToString(value); }
            get { return _name; }
        }
        public float Area
        {
            set { _area = Math.Abs(value); }
            get { return _area; }
        }
        public float Diagonal
        {
            set { _diagonal = Math.Abs(value); }
            get { return _diagonal; }
        }
        public float Volume
        { 
            set{ _volume = Math.Abs(value);}
            get{ return _volume;}
        }
        ~Box()
        {
            Console.WriteLine("Объект удалён");
        }
    }
}
