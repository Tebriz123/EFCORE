using LabAndHomeTask.DAL;
using LabAndHomeTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAndHomeTask.Services
{
    internal class UserService
    {

        public void Create(User user)
        {
            using (var context = new AppDbContex())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public List<User> GetAll()
        {
            using (var context = new AppDbContex())
            {
                return context.Users.ToList();
            }

        }
        public List<User> GetById(int id)
        {
            using (var context = new AppDbContex())
            {
                return context.Users
                    .Where(p => p.Id == id)
                    .ToList();
            }
        }
        public void Update(User user)
        {
            using (var context = new AppDbContex())
            {
                User userr = context.Users.FirstOrDefault(p => p.Id == user.Id);

                if (userr != null)
                {
                    context.Users.Update(user);
                }
                else
                {
                    Console.WriteLine("Bele User movcud deyil");
                }


            }
        }
        public void Delete(int userId)
        {
            using (var context = new AppDbContex())
            {
                User use = context.Users.FirstOrDefault(u => u.Id == userId);

                if (use != null)
                {
                    context.Users.Remove(use);
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
