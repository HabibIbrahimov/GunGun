using System;
using System.Collections.Generic;
using System.Text;

namespace GunGun
{
    class Gunshoot
    {
        public int Ammocount;
        public int Personammo;
        public int Magazinelimit; 
        public string Firemode;

        public void Gun(int personammo)
        {
            Ammocount = 30;
            Personammo = personammo;
            Magazinelimit = 30;
            

            
            
        }
        public void Shoot()
        {
            if (Firemode=="one click")
            {
                if (Ammocount>0)
                {
                    Ammocount -= 1;
                }
                else
                {
                    Console.WriteLine("Don't shoot");
                }
            }
            if (Firemode=="Automatic")
            {
                if (Ammocount>0)
                {
                    Ammocount = 0;
                }
            }
        }

        public void Reload()
        {
            if (Ammocount==0)
            {
               Ammocount = Magazinelimit;
               Personammo -=Magazinelimit;
            }
            else
            {
                Console.WriteLine("Wait until the comb is empty");
            }

        }
       
        
       
    }

    
        
       

}
