using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_11_OOP_HomeWork_Console.Backend
{
    class Manager : Consultant
    {
        public new string id { get; set; }
        public new string lastName { get; set; }
        public new string name { get; set; }
        public new string surname { get; set; }
        public new string phoneNumber { get; set; }
        public new string seriesPassportNumber { get; set; }
        public List<Manager> manList { get; private set; }
        public Manager this[int index]
        {
            get { return this.manList[index]; }
        }
        public Manager(string id, string lastName, string name, string surname,
                       string phoneNumber, string seriesPassportNumber)
        {
            this.id = id;
            this.lastName = lastName;
            this.name = name;
            this.surname = surname;
            this.phoneNumber = phoneNumber;
            this.seriesPassportNumber = seriesPassportNumber;
        }
        public Manager() : this("", "", "", "", "", "")
        {

        }
        public void GreatClient(string client)
        {
            string[] cl = client.Split(' ');
        }
        public override string ToString()
        {
            return $"{id} {lastName} {name} {surname} {phoneNumber} {seriesPassportNumber}";
        }
    }
}
