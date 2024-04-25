using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Model;

namespace WinFormsApp1.Infrastructure
{
    public class TokensCreator
    {
        private static int globalId;

        static TokensCreator()
        {
            globalId = 1;
        }

        private readonly string[] types = new string[] 
        {
            "ФЛ", 
            "ЮЛ", 
            "ДЛ"
        };
        private readonly string[] destinys = new string[] 
        {
            "Подсистема_1",
            "Подсистема_2",
            "Подсистема_3"
        };
        private readonly string[] actions = new string[] 
        {
            "Авторизация", 
            "Подпись" 
        };
        private readonly string[] certCenters = new string[] 
        { 
            "УЦ ФНС", 
            "УЦ ФК"
        };
        private readonly string[] statuses = new string[] 
        {
            "Выдан" , 
            "Изъят"
        };

        public Token GetToken()
        {
            string type = this.types[Random.Shared.Next(this.types.Length)]; ;
            string destiny = this.destinys[Random.Shared.Next(this.destinys.Length)];
            string action = this.actions[Random.Shared.Next(this.actions.Length)];
            string certCenter = this.certCenters[Random.Shared.Next(this.certCenters.Length)];
            string status = this.statuses[Random.Shared.Next(this.statuses.Length)];

            Token token = new()
            {
                Id = globalId++,
                Type = type,
                Destiny = destiny,
                Action = action,
                SerialNumber = " ",
                InterCertCenter = certCenter,
                RootCertCenter = certCenter,
                Status = status,
                DateStart = GetRandomDate(),
                DateEnd = GetRandomDate()
            };

            return token;
        }

        public static DateTime GetRandomDate()
        {
            Random random = new();
            DateTime start = new(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(random.Next(range));
        }
    }
}
