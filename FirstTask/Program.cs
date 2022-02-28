using System;
using FirstLibrary;
using ThirdTask;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////Первое задние///////
            ArrayWorker arWor = new ArrayWorker();
            
            int[] stockArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            foreach (var element in stockArray)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
           
            arWor.firstMetod(stockArray);
            
            foreach (var element in stockArray)
            {
                Console.Write($"{element} ");
            }
            
            Console.WriteLine();
            /////////Второе задние///////
            ArrayWorker arWor2 = new ArrayWorker();
            
            int[] stockArray2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            arWor2.source = stockArray2;
            Console.Write("Введите индекс элемента который будем заменять(от 0 до 8): ");
            arWor2.index = int.Parse(Console.ReadLine());
            Console.Write("Введите значение на которое будет заменено: ");
            arWor2.newValue = int.Parse(Console.ReadLine());

            foreach (var element in stockArray2)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();

          
            foreach (var element in arWor.SecondMetod(arWor2.source, arWor2.index, arWor2.newValue))
            {
                Console.Write($"{element} ");                
            }
            Console.WriteLine();
            ///////////Третье задание////
            Console.Write("Введите радиус конуса:");
            double r = double.Parse(Console.ReadLine());
            Console.Write("Введите высоту конуса:");
            double h = double.Parse(Console.ReadLine());
            Cone cone = new Cone(r,h);
            cone.Result();
            

        }
    }
}
