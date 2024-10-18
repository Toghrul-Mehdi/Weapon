using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Weapon
{
    internal class Weapon
    {
        public int Capacity;
        public int Bullet;
        public string FireMode;


        private int _capacity;

        public int BulletCapacity
        {
            get { return _capacity; }

            set
            {
                if (value > 0)
                {
                    _capacity = value;

                }
                
            }
        }

        private static int _bullets;

        public static int Bullets
        {
            get { return _bullets; }

            set
            {
                if (value > 0)
                {
                    _bullets = value;
                }
            }
        }

        public Weapon(int capacity, int bullet, string firemode)
        {
            _bullets--;
            Capacity = capacity;
            Bullet = bullet;
            FireMode = firemode;
        }

        public void Shoot()
        {
            if (FireMode == "auto" && Bullet > 0)
            {
                Console.WriteLine("Evvelki Mermi:" + Bullet);
                Bullet = 0;
                Console.WriteLine("Indiki Mermi:" + Bullet);
            }
            else if (FireMode == "single" && Bullet > 0)
            {

                Bullet--;
                Console.WriteLine("Indiki Mermi:" + Bullet);
            }
            else
            {
                Console.WriteLine("Mellim zehmet olmasa Partdatmaga calismayin)");
            }

        }

        public void Information()
        {
            Console.WriteLine("Capacity:" + Capacity);
            Console.WriteLine("Mermi sayi:" + Bullet);
            if (FireMode == "auto")
            {
                Console.WriteLine("FireMode:Auto");
            }
            else if (FireMode == "single")
            {
                Console.WriteLine("FireMode:Single");
            }
        }
        public void GetRemainBullet()
        {
            if (Capacity >= Bullet)
            {
                int QalanMermi = Capacity - Bullet;
                Console.WriteLine(QalanMermi + " lazimdiki tam olsun");
            }
            else
            {
                Console.WriteLine("Proqrami partdatmaq istedin? Alinmadi))");
            }
        }

        public void Reload()
        {
            if (Capacity >= Bullet)
            {
                Bullet = Capacity;
                Console.WriteLine("Mermi sayi:" + Bullet);
            }
            else
            {
                Console.WriteLine("Proqrami partdatmaq istedin? Alinmadi))");
            }

        }
        public void ChangeFireMode()
        {

            if (FireMode == "auto")
            {
                FireMode = "single";
                Console.WriteLine("Single Mode kecid edildi");
            }
            else if (FireMode == "single")
            {
                FireMode = "auto";
                Console.WriteLine("Auto Mode kecid edildi");
            }
            else
            {
                Console.WriteLine("Proqrami partdatmaq istedin? Alinmadi))");
            }
        }

        



    }
}