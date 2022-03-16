using System;
using System.Collections.Generic;
using System.Text;

namespace Access_modifiers.Models
{
    internal class User
    {

        public string username;
        private int age
        {
            get
            {
                return age;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("0 ola bilmez");
                }
            }
        }
        public string password
        {
            get
            {
                if (password == "")  // || 
                {
                    Console.WriteLine("bosh ola bilmez");
                }

                if (password.Length < 8)
                {
                    Console.WriteLine("8-den kicik ola bilmez");
                }
                return password;
            }
            set
            {
                
                //if ()
                //{

                //}

            }

        }


        public User(string username, string password,int age)
        {
            username = username;
            age=age;
            password = password;
        }
    }
}

