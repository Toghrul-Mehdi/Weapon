
namespace Weapon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool f = false;
            bool b = false;
            

            int capacity;
            int bullet;
            string firemode;

            bool bool_capacity;

            do
            {
                Console.WriteLine("Capacity daxil et:");
                bool_capacity = int.TryParse(Console.ReadLine(), out capacity);

                if (capacity>0)
                {
                    bool_capacity=true;
                }
                else
                {
                    Console.WriteLine("Capacity 0dan boyuk olmalidir!");
                    bool_capacity=false;
                }
            } while (!bool_capacity);
            bool bool_bullet;
            do
            {
                Console.WriteLine("Mermi sayi daxil et:");
                bool_bullet = int.TryParse(Console.ReadLine(), out bullet);

                if (bullet <= capacity )
                {
                    bool_bullet=true;
                }
                else
                {
                    Console.WriteLine("Mermi sayi daraq ucun yeterli deyil!");
                    bool_bullet=false;
                }
            } while (!bool_bullet);
            Console.WriteLine("Atis modu daxil edin:auto ve ya single");
            firemode = Console.ReadLine();

            Weapon Ak47 = new Weapon(capacity, bullet, firemode);
            do
            {                
                Console.WriteLine("0.Information   1.FireMode    2.GetRemainBullet  3.Reload   4.ChangeFireMode   5.Quit");

                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "0":

                        Ak47.Information();
                        break;
                    case "1":
                        Ak47.Shoot();
                        break;

                    case "2":
                        Ak47.GetRemainBullet();
                        break;
                    case "3":
                        Ak47.Reload();
                        break;
                    case "4":
                        Ak47.ChangeFireMode();
                        break;                    
                    case "5":
                        f = true;
                        break;
                    default:
                        break;
                    
                        
                }

            } while (!f);

            

        }
    }
}