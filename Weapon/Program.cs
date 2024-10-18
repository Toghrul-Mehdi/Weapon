
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

                if (capacity > 0)
                {
                    bool_capacity = true;
                }
                else
                {
                    Console.WriteLine("Capacity 0dan boyuk olmalidir!");
                    bool_capacity = false;
                }
            } while (!bool_capacity);
            bool bool_bullet;
            do
            {
                Console.WriteLine("Mermi sayi daxil et:");
                bool_bullet = int.TryParse(Console.ReadLine(), out bullet);

                if (bullet <= capacity)
                {
                    bool_bullet = true;
                }
                else
                {
                    Console.WriteLine("Mermi sayi daraq ucun yeterli deyil!");
                    bool_bullet = false;
                }
            } while (!bool_bullet);
            Console.WriteLine("Atis modu daxil edin:auto ve ya single");
            firemode = Console.ReadLine();

            Weapon Ak47 = new Weapon(capacity, bullet, firemode);
            do
            {
                Console.WriteLine("0.Info 1.FireMode 2.GetRemainBullet  3.Reload 4.ChangeFireMode 5.Quit 6.Edit");

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


                    case "6":
                        while (true)
                        {
                            Console.WriteLine("\nYeni menu:");
                            Console.WriteLine("7 - Tutumu deyisin");
                            Console.WriteLine("8 - Gullə sayi dəyisin");
                            Console.WriteLine("9 - Geri menuya qayit");
                            Console.Write("Bir operation seçin: ");
                            string editChoice = Console.ReadLine();

                            if (editChoice == "9") break;

                            switch (editChoice)
                            {
                                case "7":
                                    Console.Write("Yeni tutumu daxil edin: ");
                                    int newCapacity;
                                    if (int.TryParse(Console.ReadLine(), out newCapacity) && newCapacity > 0)
                                    {

                                        Ak47.ChangeCap(newCapacity);
                                        Console.WriteLine($"Yeni tutum: {newCapacity}");

                                    }
                                    else
                                    {
                                        Console.WriteLine("Yanlıs tutum dəyəri.");
                                    }
                                    break;

                                case "8":
                                    Console.Write("Yeni gulle sayını daxil edin: ");
                                    int newBulletCount;
                                    if (int.TryParse(Console.ReadLine(), out newBulletCount) && newBulletCount >= 0)
                                    {
                                        if (newBulletCount <= Ak47.Capacity)
                                        {
                                            Ak47.ChangeBullet(newBulletCount);
                                            Console.WriteLine($"Yeni gulle sayı: {newBulletCount}");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Yanlish gulle  sayı və ya tutum aşılır.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Yanlish gulle sayı.");
                                    }
                                    break;

                                default:
                                    Console.WriteLine("Yanlish secim.");
                                    break;
                            }
                        }
                        break;



                }

            } while (!f);



        }
    }
}