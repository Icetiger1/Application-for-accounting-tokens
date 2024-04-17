using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    public class User
    {
        public string? FIO { get; set; }
        public string? Post {  get; set; }
        public string? Department { get; set; }

        public User() :
            this(
                String.Empty,
                String.Empty,
                String.Empty)
        { }

        public User(string? fio, string? post, string? department)
        {
            this.FIO = fio;
            this.Post = post;
            this.Department = department;
        }
    }
}
