using LabAndHomeTask.Models;
using LabAndHomeTask.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAndHomeTask
{
    internal class ManagmentAppilication
    {
        private readonly UserService _userService;
        private readonly OrderService _orderService;
        private readonly CompanyService _companyService;
        private readonly AppProductService _productService;
        private readonly User _user;

        public ManagmentAppilication()
        {
        }

        public ManagmentAppilication(AppProductService productService, CompanyService companyService, OrderService orderService, UserService userService)
        {
            _productService = productService;
            _companyService = companyService;
            _orderService = orderService;
            _userService = userService;
        }

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
                        Console.WriteLine("Please enter username: ");
                        string username = Console.ReadLine().Trim();
                        //Console.Clear();
                        if (username.Length <= 1)
                        {
                            Console.WriteLine("please enter right name:");
                            return;
                        }
                        Console.WriteLine("Please enter password: ");
                         string password = Console.ReadLine().Trim();
                        //Console.Clear();
                        if (password.Length >= 8)
                        {
                              _userService.Create(username, password);
                            Console.WriteLine("Successfully");
                        }
                        else
                        {
                            Console.WriteLine("password duzgun deyil");
                        }
                            break;

                    case 2:
                        Console.WriteLine("Please enter username: ");
                        string username2 = Console.ReadLine().Trim();
                        Console.Clear();
                        if (username2 == _user.UserName)
                        {
                            Console.WriteLine("Please enter password: ");
                            string password2 = Console.ReadLine().Trim();
                            if (password2 == _user.Password)
                            {
                                Console.WriteLine("Ugurlu giris");


                            }
                        }
                      
                       
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
