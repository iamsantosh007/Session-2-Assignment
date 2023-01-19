using System;
class MethodOverLoad
    {
        public int amount(int integerValue)
        {
            return integerValue;
        }

        public int amount(string stringValue)
        {

            return Convert.ToInt32(stringValue);
        }

        public int amount(int salary, int pf)
        {
            return salary + pf;
        }

	public static void Main(string[] args)
        {

            MethodOverLoad m = new MethodOverLoad();
            int a = m.amount(10);
            int b = m.amount(1, 2);
            int c = m.amount("56");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            
        }
    }