using System;

namespace mart29
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("UserName ni daxil edin");
                string username = Console.ReadLine();

                Console.WriteLine("Passwordu daxil edin");
                string password = Console.ReadLine();


                User user1 = new User(username)
                {
                    Password = password

                };
                user1.GetInfo();


            }
        }
    }
}
