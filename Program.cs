using Module_11_OOP_HomeWork_Console.Backend;

namespace Module_11_OOP_HomeWork_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseData baseData = new BaseData();
            Consultant consultant = new Consultant();
            Manager manager = new Manager();
            //baseData.AddFakeClient(100);
            //foreach (var item in baseData.GetAllClientInDB())
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine( baseData.GetOneClientInDB("320136097_49309"));

            //Console.WriteLine(baseData.GetCurrentIdInDB());

            //List<string> allClient = consultant.GetAllClientInDB();
            //List<Consultant> consultants = new List<Consultant>();
            //consultants = consultant.TransformDB(allClient);
            //Console.WriteLine(consultants[50]);


            //List<Consultant> allClient = consultant.UpdatePhoneNumber("(905) ", "1");
            //Console.WriteLine(allClient[0]);
            //Console.WriteLine(allClient[1]);

            List<Manager> allClient = new List<Manager>();
            List<string> clientNames = manager.GetAllClientInDB(());
            


        }
    }
}
