using LabAndHomeTask.DAL;
using LabAndHomeTask.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAndHomeTask.Services
{
    internal class OrderService
    {
        public void Create(Order order)
        {
            using (var context = new AppDbContex())
            {
                User? user = context.Users.FirstOrDefault(u => u.Id == order.UserId);
                AppProduct product = context.AppProducts.FirstOrDefault(p => p.Id == order.AppProductId);
                if (product == null)
                {
                    Console.WriteLine("Bele product yoxdur");
                }
                if(user == null)
                {
                    Console.WriteLine("User not found");
                }
                if (user.Balance >= product.Price)
                {
                    order.IsSuccessful = true;
                    user.Balance -= product.Price;
                }
                else
                {
                    order.IsSuccessful= false;
                    Console.WriteLine("Pulun yoxdu ay kasibb");
                }
               
            }
        }

        public List<Order> GetAll()
        {
            using (var context = new AppDbContex())
            {
                return context.Orders.AsNoTracking().ToList();
            }
        }


        public void Delete(int orderId)
        {
            using (var context = new AppDbContex())
            {
                Order order = context.Orders.FirstOrDefault(p => p.Id == orderId);

                if (order != null)
                {
                    context.Orders.Remove(order);
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Product movcud deyil");
                }



            }
        }



    }
}
