using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList seatingChart = new ArrayList();
            seatingChart.Add(new SeatingAssignment(0, 0, "Mary"));
            seatingChart.Add(new SeatingAssignment(0, 1, "Jim"));
            seatingChart.Add(new SeatingAssignment(1, 0, "Bob"));
            seatingChart.Add(new SeatingAssignment(1, 1, "Jane"));

            seatingChart.Add(new SeatingAssignment(2, 0, "Bill"));
            seatingChart.Add(new SeatingAssignment(2, 1, "Judy"));

            foreach (SeatingAssignment sa in seatingChart)
            {
                Console.WriteLine("Row: {0} Seat: {1} Student: {2}",
                    (sa.Row + 1), (sa.Seat + 1), sa.Student);
            }
            Console.ReadLine();

            //string[,] seatingChart = new string[2, 2];
            //seatingChart[0, 0] = "Mary";
            //seatingChart[0, 1] = "Jim";
            //seatingChart[1, 0] = "Bob";
            //seatingChart[1, 1] = "Jane";
            //for (int row = 0; row < 2; row++)
            //{
            //    for (int seat = 0; seat < 2; seat++)
            //    {
            //        Console.WriteLine("Row: {0} Seat: {1} Student: {2}",
            //            (row + 1), (seat + 1), seatingChart[row, seat]);
            //    }
            //}
            //Console.ReadLine();

            //Console.WriteLine("parameter count = {0}", args.Length);
            //for (int i = 0; i < args.Length; i++)
            //{
            //    Console.WriteLine("Arg[{0}] = [{1}]", i, args[i]);
            //}
            //Array.Clear(args, 1, 1);
            //args[3] = "great";
            //for (int i = 0; i < args.Length; i++)
            //{
            //    Console.WriteLine("Arg[{0}] = [{1}]", i, args[i]);
            //}
            //Console.ReadLine();
        }
    }
}
