using System;

namespace usernametask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asagidaki member-lerden ibaret User class-i yaradin:
            //UserName - istifadeci adini ifade edir
            //Password - istifadeci sifresini ifade edir
            //UserName deyeri teyin olunmamis User obyekti yaradila bilinmemelidir.UserName deyerinin uzunlugu minimum 8 olmalidr.
            //Password deyerinin uzunlugu minimum 8 olmalidir ve icinde
            //en az 1 boyuk herf,1 kicik herf ve 1 reqem olmalidir.Eks
            //teqdirde password deyeri set oluna bilinmemelidir.
            //Layihe run olduqda console penceresinden isitfadeciden username
            //daxil etmesi istenilmelidir.Eger daxil edilen username UserName memberinin
            //sertlerini odemirse istifadeciden yeniden username daxil etmesi istenilmelidir
            //(duz yazanadek bu proses davam etmelidir). Daha sonra console penceresinden password deyerini daxil etmesi istenilmelidir.
            //Eger daxil edilen deyer Password memberinin sertlerini odemirse yeniden daxil edilmesi istenilmelidir ta ki duz yazana qeder.
            //Her iki deyer duz olduqdan sonra User obyekti yaradilir. (Encapsulatin tetqibi mutleqdir !)
            Console.WriteLine("istifadeci adin daxil edin");
            string username = Console.ReadLine();
            Console.WriteLine("password daxil edin");
            string password = Console.ReadLine();
            userdata userpaschech = new userdata();
            userpaschech.User = username;
            userpaschech.Password = password;
           
            
        }
    }
}
