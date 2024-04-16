using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Infrastructure;
using WinFormsApp1.Model;

namespace WinFormsApp1.ViewModel
{
    public class TokensViewModel : IEnumerable
    {
        public List<Token> Tokens { get; set; }

        public TokensViewModel()
        {
            this.Tokens = new List<Token>();
        }

        public TokensViewModel(List<Token> tokens)
        {
            this.Tokens = tokens;
        }

        public void Append(Token token)
        {
            this.Tokens.Add(token);
        }

        public List<Token> GetAll()
        {
            return this.Tokens.ToList();
        }

        public Token? Get(int id)
        {
            return this.Tokens.FirstOrDefault(x => x.Id == id) ?? null;
        }

        public void Update(int id, Token token)
        {
            var item = this.Tokens.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                item = token;
            }
        }

        public void Delete(int id)
        {
            var item = this.Tokens.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                this.Tokens.Remove(item);
            }            
        }

        public List<Token> FilterStatusList(string status)
        {
            if (status == "Все" || string.IsNullOrEmpty(status))
                return this.Tokens;
            else
                return this.Tokens.Where(x => x.Status == status).ToList();
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)this.Tokens).GetEnumerator();
        }
    }
}
