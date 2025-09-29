using LabAndHomeTask.DAL;
using LabAndHomeTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAndHomeTask.Services
{
    internal class CompanyService
    {

        public void Create(Company company)
        {
            using (var context = new AppDbContex())
            {
                context.Companies.Add(company);
                context.SaveChanges();
            }
        }

        public List<Company> GetAll()
        {
            using (var context = new AppDbContex())
            {
                return context.Companies.ToList();
            }

        }

         public List<Company> GetById(int id)
        {
            using (var context = new AppDbContex())
            {
                return context.Companies
                    .Where(p => p.Id == id)
                    .ToList();
            }
        }
        public void Update(Company company)
        {
            using (var context = new AppDbContex())
            {
                Company com = context.Companies.FirstOrDefault(p => p.Id == company.Id);
                if (com != null)
                {
                    context.Companies.Update(company);
                }
                else
                {
                    Console.WriteLine("Bele company movcud deyil");
                }
                
                
            }
        }
        public void Delete(int companyId)
        {
            using (var context = new AppDbContex())
            {
                Company com = context.Companies.FirstOrDefault(c => c.Id == companyId);

                if (com != null)
                {
                    context.Companies.Remove(com);
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("company duzgun deyil");
                }



            }
        }
    }
}
