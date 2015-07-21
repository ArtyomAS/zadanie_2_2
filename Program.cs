using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<Box> boxList = new List<Box>
            {
                new Box("Параллелепипед A") { Area = random.Next(12, 78), Volume = random.Next(4523, 9453), Diagonal = random.Next(146, 274)},
                new Box("Параллелепипед B") { Area = random.Next(12, 78), Volume = random.Next(4523, 9453), Diagonal = random.Next(146, 274)},
                new Box("Параллелепипед C") { Area = random.Next(12, 78), Volume = random.Next(4523, 9453), Diagonal = random.Next(146, 274)},
                new Box("Параллелепипед D") { Area = random.Next(12, 78), Volume = random.Next(4523, 9453), Diagonal = random.Next(146, 274)},
                new Box("Параллелепипед E") { Area = random.Next(12, 78), Volume = random.Next(4523, 9453), Diagonal = random.Next(146, 274)}
            };
            Console.WriteLine("Список:");
            StaticBox.PrintList(boxList);            
            Console.WriteLine("\nСписок в обратном порядке:");
            boxList.Reverse();
            StaticBox.PrintList(boxList);
            Console.WriteLine("\nСписок по объёму: ");
            StaticBox.PrintList(boxList.OrderBy(b => b.Volume).ToList());
            boxList.Add(new Box("Параллелепипед F") { Area = random.Next(12, 78), Volume = random.Next(4523, 9453), Diagonal = random.Next(146, 274) });
            Console.WriteLine("\nСписок с добавленным элементом");
            StaticBox.PrintList(boxList);
            boxList.Insert(3, new Box("Параллелепипед G") { Area = random.Next(12, 78), Volume = random.Next(4523, 9453), Diagonal = random.Next(146, 274) });
            Console.WriteLine("\nСписок со вставленным элементом");
            StaticBox.PrintList(boxList);
            boxList.RemoveAt(3);
            Console.WriteLine("\nСписок с удалённым вставленным элементом");
            StaticBox.PrintList(boxList);
            int index = boxList.FindIndex(b => b.Name == "Параллелепипед C");
            Console.WriteLine("\nНайденный элемент списка");
            boxList[index].Print();
            boxList.Clear();
            Console.WriteLine("\nПустой список");
            StaticBox.PrintList(boxList);
            Console.ReadKey();
        }
    }
}
