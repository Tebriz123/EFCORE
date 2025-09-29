using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAndHomeTask
{
    internal class ManagmentAppilication
    {
        public void Run()
        {
            int num = 0;
            string str = null;
            bool result = false;

            Console.Clear();
            while (!(num == 0 && result))
            {
                Console.WriteLine("1.Register\n2.LogIn\n3.Exit");
                str = Console.ReadLine();
                Console.Clear();
                result = int.TryParse(str, out num);
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Vaxtim catmadi");
                        break;

                    case 2:
                        Console.WriteLine("Vaxtim catmadi");
                        break;
                    case 3:
                        if (result)
                        {
                            Console.WriteLine("Program finished");
                        }
                        else
                        {
                            Console.WriteLine("Wrong input");
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }


        }
    }
}
