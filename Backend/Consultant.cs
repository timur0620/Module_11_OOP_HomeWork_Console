using Bogus.DataSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_11_OOP_HomeWork_Console.Backend
{
     class Consultant : BaseData
    {
        public string id { get; private set; }
        public string lastName { get; private set; }
        public string name { get; private set; }
        public string surname { get; private set; }
        public string phoneNumber { get; private set; }
        public string seriesPassportNumber { get { return "*********"; } 
                                             private set{ passportNumber = value;}}
        public string passportNumber;
        public List<Consultant> consList { get; private set; }
        public Consultant this[int index]
        {
            get { return this.consList[index]; }
        }
        public Consultant() : this("", "", "", "", "", "")
        {

        }
        public Consultant(string id, string lastName, string name, string surname,
                          string phoneNumber, string seriesPassportNumber)
        {
            this.id = id;
            this.lastName = lastName;
            this.name = name;
            this.surname = surname;
            this.phoneNumber = phoneNumber;
            this.passportNumber = seriesPassportNumber;
        }
        public List<Consultant> TransformDB(List<string> allClientDB)
        {
            int index = 0;
            List<Consultant> consList = new List<Consultant>();

            foreach (string item in allClientDB)
            {   
                Consultant cons = new Consultant();
                string[] tempMassive  = new string[item.Split('|').Length];
                tempMassive = item.Split("|");

                cons.id = tempMassive[0];
                cons.lastName = tempMassive[1];
                cons.name = tempMassive[2];
                cons.surname = tempMassive[3];
                cons.phoneNumber = tempMassive[4];
                cons.seriesPassportNumber = tempMassive[5];

                consList.Add(cons);

                index++;                
            }
            return consList;
        }
        public List<Consultant> UpdatePhoneNumber(string newNumber, string id)
        {
            List <Consultant> consList = TransformDB(GetAllClientInDB());
            foreach (Consultant item in consList)
            {
                if (item.id.Equals(id))
                {
                    item.phoneNumber = newNumber;

                    RecordInFile(consList);

                    break;
                }
            }
            return consList;
        }
        private void RecordInFile(List<Consultant> allClient)
        {   
            BaseData baseData = new BaseData();
            using (StreamWriter sw = new StreamWriter(baseData.GetPath()))
            {
                for (int i = 0; i < allClient.Count; i++)
                {
                    sw.WriteLine($"{allClient[i].id}|" +
                                $"{allClient[i].lastName}|" +
                                $"{allClient[i].name}|" +
                                $"{allClient[i].surname}|" +
                                $"{allClient[i].phoneNumber}|" +
                                $"{allClient[i].passportNumber}|");
                
                    
                }
            }
        }
        public override string ToString()
        {
            return $"{id} {lastName} {name} {surname} {phoneNumber} {seriesPassportNumber}";
        }
    }
}
