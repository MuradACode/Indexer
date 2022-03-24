using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer.Models
{
    class Person
    {
        private int _id = 0;
        private string _name;
        private string _surName;
        private string _age;
        private string[] _info = new string[4];

        public string this[int index] 
        {
            get { return _info[index]; }
            set { _info[index] = value; }
        }
        public string ID { get; set; }
        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surName; set => _surName = value; }
        public int Age { get { return Convert.ToInt32(_age); } set { if (Age > 0 && Age < 150) _age = value.ToString(); } }
        public Person(string name, string surname, int age)
        {
            _id++;
            ID = _id.ToString();
            Name = name;
            Surname = surname;
            Age = age;
            _info[0] = ID;
            _info[1] = _name;
            _info[2] = _surName;
            _info[3] = _age;
        }
        /// <summary>
        /// Getting info about person
        /// </summary>
        public void GetInfo()
        {
            Console.Write("ID: ");
            foreach (string item in _info)
            {
                Console.WriteLine(item);
            }
        }
    }
}
