using System.ComponentModel;

namespace HW_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string password = "userlogin";
            do
            {
                Console.WriteLine("Hi, enter your password plese: ");
                string answer = Console.ReadLine();
                if(answer == "administrator")
                {
                    Console.WriteLine("You are autorization like Administrator");
                    break;
                }
                else if(answer == password)
                {
                    Console.WriteLine("You are autorization like User");
                    break;
                }
                else
                {
                    Console.WriteLine("password is incorrect");
                }
            }while(true);
        }
    }
}