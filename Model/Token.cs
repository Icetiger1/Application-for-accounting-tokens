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
                DateTime.MaxValue)
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
            DateTime dateEnd
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
        }
    }
}
