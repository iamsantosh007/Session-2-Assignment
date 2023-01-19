using System;

class ReturnArray
    {
        public int[] ReuturningArray(int requiredTable)
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = requiredTable * (i + 1);
            }
            return array;
        }
	static void Main(string[] args)
        {
            ReturnArray arrayObj = new ReturnArray();
            Console.WriteLine("Enter the number of which you want to see table:- ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] array = arrayObj.ReuturningArray(num);
            Console.WriteLine();
            Console.WriteLine($"The table of {num} is:-");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

           
        }
    }