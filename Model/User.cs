using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    public class User
    {
        public int Id { get; set; }
        public string? FIO { get; set; }
        public string? Post {  get; set; }
        public string? Department { get; set; }

        public User() { }

        public User(int id) :
            this(
                id,
                String.Empty,
                String.Empty,
                String.Empty)
        { }

        public User(int id, string? fio, string? post, string? department)
        {
            this.Id = id;
            this.FIO = fio;
            this.Post = post;
            this.Department = department;
        }

        public (bool, string) IsNotNullOrEmpty()
        {
            if (string.IsNullOrEmpty(this.FIO))
                return (false, nameof(this.FIO));
            else if (string.IsNullOrEmpty(this.Post))
                return (false, nameof(this.Post));
            else if (string.IsNullOrEmpty(this.Department))
                return (false, nameof(this.Department));
            else
                return (true, ""); 
        }
    }
}
