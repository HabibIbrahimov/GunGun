using System;

namespace GunGun
{
    class Program
    {
        static void Main(string[] args)
        {
            Gunshoot AKM47 = new Gunshoot();
            AKM47.Gun(100);
            AKM47.Shoot();
            AKM47.Reload();
            Console.WriteLine(AKM47.Ammocount);
           
        }
    }
}
