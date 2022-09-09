using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.Net.Mime.MediaTypeNames;

namespace HW_Participants {
    internal class Participants {
        public Participants() {
            Console.WriteLine("Default values:");
            _id = 0;
            _name = "Undefined";
            _age = 0;   
        }
        public Participants(int id, string name, int age)  {
            _id = id;
            _name = name;
            _age = age;
        }
        public Participants(int id) {
            _id = id;
            _name = enterString("Enter the name of the participant: ");
            _age = enterNumber("Enter the age of the participant: ");
        }

        string enterString(string txt) {
            Console.Write(txt);
            return Console.ReadLine();
        }

        int enterNumber(string txt) {
            try {
                Console.Write(txt);
                return int.Parse(Console.ReadLine());
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                Console.WriteLine("Error! You need to enter a number.");
                return enterNumber(txt);

            }
        }




        private int _id;
        private string _name;
        private int _age;

        public int id { get { return _id; } set { _id = value; } }  
        public string name { get { return _name; } set { _name = value; } }
        public int age { get { return _age; } set { _age = value; } }

        public override string ToString() {
            return $"ID: {id}\nName: {name}\nAge: {age}";
                }

    }
}
