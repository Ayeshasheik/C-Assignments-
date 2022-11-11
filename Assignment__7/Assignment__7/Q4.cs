using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using static Assignment__7.Q4;

namespace Assignment__7
{
    internal class Q4
    {
        static void Main()
        {
            SerializeManager manager = new SerializeManager();
           // manager.Manager_serialize();
            manager.DeSerializeManager();
        }


        public class SerializeManager
        {
            public void Manager_serialize()
            {
                ManagerEntities CustomerDetail = new ManagerEntities();
                Console.Write("Please Enter Manager Id:");
                CustomerDetail.Id = int.Parse(Console.ReadLine());

                Console.Write("Please Enter Manager Name:");
                CustomerDetail.Name = Console.ReadLine();

                Console.Write("Please Enter Manager Basic Salary:");
                CustomerDetail.BasicSalary = Console.ReadLine();

                FileStream fileStream = new FileStream(@"C:\Ayesha\Training\Assignment__7\Assignment__7\Q4.txt", FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, CustomerDetail);
                Console.ReadKey();
            }

            public void DeSerializeManager()
            {
                FileStream fileStream = new FileStream(@"C:\Ayesha\Training\Assignment__7\Assignment__7\Q4.txt ", FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                ManagerEntities deserializedValues = (ManagerEntities)formatter.Deserialize(fileStream);
                Console.WriteLine($"Manager Id:  {deserializedValues.Id} --- Manager Name: {deserializedValues.Name} --- Manager Basic Salary: {deserializedValues.BasicSalary}");
                Console.ReadKey();
            }
        }

        [Serializable]

        public class ManagerEntities
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string BasicSalary { get; set; }
        }
    }
}


