using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Infrastructure;
using WinFormsApp1.Model;
using User = WinFormsApp1.Model.User;

namespace WinFormsApp1.ViewModel
{
    public class TokensViewModel : IEnumerable
    {
        public Dictionary<Token, User> Tokens { get; set; }

        public TokensViewModel()
        {
            this.Tokens = new Dictionary<Token, User>();
        }

        public TokensViewModel(Dictionary<Token, User> tokens)
        {
            this.Tokens = tokens;
        }

        public void Append(Token token, User user)
        {
            this.Tokens.Add(token, user);
        }

        public Dictionary<Token, User> GetAll()
        {
            return this.Tokens;
        }

        public KeyValuePair<Token, User>? Get(int id)
        {
            return this.Tokens.FirstOrDefault(x => x.Key.Id == id);
        }

        public void Update(int id, Token token, User user)
        {
            var item = this.Tokens.FirstOrDefault(x => x.Key.Id == id);
            if (!item.Equals(null))
            {
                item = new KeyValuePair<Token, User>(token, user);
            }
        }

        public void Delete(int id)
        {
            var item = this.Tokens.FirstOrDefault(x => x.Key.Id == id);
            if (!item.Equals(null))
            {
                this.Tokens.Remove(item.Key);
            }            
        }

        public Dictionary<Token, User> FilterStatusList(string status)
        {
            if (status == "Все" || string.IsNullOrEmpty(status))
                return this.Tokens;
            else
                return this.Tokens
                    .Where(x => x.Key.Status == status)
                    .ToDictionary(x => x.Key, x => x.Value);
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)this.Tokens).GetEnumerator();
        }
    }
}
