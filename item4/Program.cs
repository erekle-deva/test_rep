using System;


namespace item4
{
    class Program
    {
        static void Main(string[] args)
        {


            double num1 = 3.14;

            int num2 = Convert.ToInt32(num1);

            Console.WriteLine(num2);
            Console.WriteLine(num1);


            Console.WriteLine(num1.GetType());

            Console.WriteLine(num2.GetType());




            string name = "erekle";
            bool tf = false;
            char single = 'g';
            int num = 60;



            Console.WriteLine(name.GetType());
            Console.WriteLine(tf.GetType());
            Console.WriteLine(single.GetType());
            Console.WriteLine(num.GetType());













        }
    }
}