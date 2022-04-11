using System;
using System.Collections.Generic;
using System.Text;

namespace usernametask
{
    class userdata
    {
        private string _user;
        private string _password;

        public string Password {
            get
            {
                return _password;
            }
            set
            {
                int count = 0;
                int count1 = 0;
                int count2 = 0;
                if (value.Length >=8)
                {
                    foreach (char item in value)
                    {
                        if (char.IsUpper(item))
                        {
                            count++;
                        }
                        else if(char.IsDigit(item))
                        {
                            count1++;
                        }
                       else if (char.IsLetter(item))
                        {
                            count2++;
                        }
                    }
                  
                }
                else
                {
                    Console.WriteLine("parol 8 den cox olmalidir");
                }
                if (count > 0 && count1 > 0 && count2 > 0)
                {
                    _password = Password;
                }
                else if(count==0)
                {
                    Console.WriteLine("boyuk herif yoxdur");
                }
                else if (count1 == 0)
                {
                    Console.WriteLine("reqem yoxdur");
                }
                else if (count2 == 0)
                {
                    Console.WriteLine("balaca herif yoxdur");
                }
            }
        }
        public string User
        {
            get
            {
                return _user;
            }
            set
            {
               
                if (value.Length > 8)
                {
                    _user = User;

                }
                else
                {
                    Console.WriteLine("istifadeci adi 8 den cox olmalidir");
                }

            }
        }
    }
    
}
