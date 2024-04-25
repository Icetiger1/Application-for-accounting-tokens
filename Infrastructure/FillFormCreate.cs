using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Infrastructure
{
    public class FillFormCreate
    {
        public string[] types = new string[] 
        { 
            "ФЛ", 
            "ЮЛ", 
            "ДЛ" 
        };
        public string[] fios = new string[] 
        { 
            "ФИО_1", 
            "ФИО_2", 
            "ФИО_3" 
        };
        public string[] posts = new string[]
        {
            "Специалист_1",
            "Специалист_2",
            "Специалист_3"
        };
        public string[] departments = new string[] 
        { 
            "Отдел_1", 
            "Отдел_2", 
            "Отдел_3" 
        };
        public string[] destinys = new string[] 
        { 
            "Подсистема_1",
            "Подсистема_2",
            "Подсистема_3"
        };
        public string[] actions = new string[] 
        { 
            "Авторизация", 
            "Подпись" 
        };
        public string[] certCenters = new string[] 
        { 
            "УЦ ФНС", 
            "УЦ ФК" 
        };
        public string[] statuses = new string[] 
        { 
            "Выдан", 
            "Изъят"
        };

    }
}
