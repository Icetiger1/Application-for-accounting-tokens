using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Model;

namespace WinFormsApp1.Infrastructure
{
    internal class UsersCreator
    {
        private readonly string[] fios = new string[] 
        { 
            "ФИО_1", 
            "ФИО_2", 
            "ФИО_3" 
        };
        private readonly string[] posts = new string[] 
        { 
            "Специалист_1", 
            "Специалист_2", 
            "Специалист_3" 
        };
        private readonly string[] departments = new string[] 
        { 
            "Отдел_1", 
            "Отдел2", 
            "Отдел3" 
        };

        public User GetUser()
        {
            string fio = this.fios[Random.Shared.Next(this.fios.Length)];
            string post = this.posts[Random.Shared.Next(this.fios.Length)];
            string department = this.departments[Random.Shared.Next(this.departments.Length)];

            User user = new()
            {
                FIO = fio,
                Post = post,
                Department = department
            };

            return user;
        }
    }
}
