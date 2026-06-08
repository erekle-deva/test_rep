using System;

namespace Item_11
{
    class Program
    {
        static void Main(string[] args)
        {

            string fullname = "erekle devidze";
            string jobtitle = "IT ENGINEER";
            string phonenum = "123-456-7890";
            string alterphonenum = "592-77-23-35";




            fullname = fullname.ToUpper();
            Console.WriteLine(fullname);

            jobtitle = jobtitle.ToLower();
            Console.WriteLine(jobtitle);

            phonenum = phonenum.Replace("-", "/");
            Console.WriteLine(phonenum);

            alterphonenum = alterphonenum.Replace("-", "");
            Console.WriteLine(alterphonenum);


            string username = fullname.Insert(0, "@mr.");
            Console.WriteLine(username);

            Console.WriteLine(fullname.Length);



            string firstName = fullname.Substring(0, 6);
            Console.WriteLine(firstName);


            string lastName = fullname.Substring(7, 7);
            Console.WriteLine(lastName);








        }
    }
}