using LabAndHomeTask.DAL;
using LabAndHomeTask.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAndHomeTask.Services
{
    internal class AppProductService
    {
        public void Create(AppProduct appProduct)
        {
            using (var context = new AppDbContex())
            {
                context.AppProducts.Add(appProduct);
                context.SaveChanges();
            }
        }

        public void Update(AppProduct product)
        {
            using (var context = new AppDbContex())
            {
                AppProduct appProduct = context.AppProducts.FirstOrDefault(p => p.Id == product.Id);

                if (appProduct != null)
                {
                    context.AppProducts.Update(product);
                }
                else
                {
                    Console.WriteLine("Bele product movcud deyil");
                }


            }
        }
        public void Delete(int appProductId)
        {
            using (var context = new AppDbContex())
            {
                AppProduct appProduct = context.AppProducts.FirstOrDefault(p => p.Id == appProductId);

                if (appProduct != null)
                {
                    context.AppProducts.Remove(appProduct);
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Product movcud deyil");
                }



            }
        }
        public List<AppProduct> GetAll()
        {
            using (var context = new AppDbContex())
            {
                return context.AppProducts.AsNoTracking().ToList();
            }
        }

        public List<AppProduct> GetById(int id)
        {
            using (var context = new AppDbContex())
            {
                return context.AppProducts
                    .Where(p => p.Id == id)
                    .ToList();
            }
        }
        public List<AppProduct> GetAppProductsByUserId(int userId)
        {
            using (var context = new AppDbContex())
            {
                return context.Orders
                    .Include(o => o.AppProduct)
                    .Where(o => o.IsSuccessful && o.UserId == userId)
                    .Select(o => o.AppProduct)
                    .ToList();

            }
        }
    }
}
