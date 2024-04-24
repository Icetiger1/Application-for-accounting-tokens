using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    public class Token
    {
        public int Id { get; set; }
        public string? Type { get; set; }
        public string? Destiny { get; set; }
        public string? Action { get; set; }
        public string? SerialNumber { get; set; }
        public string? InterCertCenter { get; set; }
        public string? RootCertCenter { get; set; }
        public string? Status { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public int UserId { get; set; }


        public Token() :
            this(Int32.MinValue,
                String.Empty,
                String.Empty,
                String.Empty,
                String.Empty,
                String.Empty,
                String.Empty,
                String.Empty,
                DateTime.MinValue,
                DateTime.MaxValue,
                Int32.MinValue)
        { }
        public Token(
            int id, 
            string? type, 
            string? destiny, 
            string? action, 
            string? serialNumber,
            string? interCertCenter,
            string? rootCertCenter,
            string? status,
            DateTime dateStart,
            DateTime dateEnd,
            int userId
            )
        {
            this.Id = id;
            this.Type = type;
            this.Destiny = destiny;
            this.Action = action;
            this.SerialNumber = serialNumber;
            this.InterCertCenter = interCertCenter;
            this.RootCertCenter = rootCertCenter;
            this.Status = status;
            this.DateStart = dateStart;
            this.DateEnd = dateEnd;
            this.UserId = userId;
        }

        public override string ToString()
        {
            return Id.ToString();
        }

        public (bool, string) IsNotNullOrEmpty()
        {
            if (string.IsNullOrEmpty(this.Type))
            {
                return (false, nameof(this.Type));
            }
            else if (string.IsNullOrEmpty(this.Destiny))
            {
                return (false, nameof(this.Destiny));
            }
            else if (string.IsNullOrEmpty(this.Action))
            {
                return (false, nameof(this.Action));
            }
            else if (string.IsNullOrEmpty(this.SerialNumber))
            {
                return (false, nameof(this.SerialNumber));
            }
            else if (string.IsNullOrEmpty(this.InterCertCenter))
            {
                return (false, nameof(this.InterCertCenter));
            }
            else if (string.IsNullOrEmpty(this.RootCertCenter))
            {
                return (false, nameof(this.RootCertCenter));
            }
            else if (string.IsNullOrEmpty(this.Status))
            {
                return (false, nameof(this.Status));
            }
            else if (this.DateStart == default)
            {
                return (false, nameof(this.DateStart));
            }
            else if (this.DateEnd == default)
            {
                return (false, nameof(this.DateEnd));
            }
            //else if(this.UserId != Int32.MinValue)
            else
            {
                return (true, "");
            }
        }
    }
}
