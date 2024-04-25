using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public TokensViewModel(SqlDataReader readerTokens)
        {
            this.Tokens = new Dictionary<Token, User>();

            if (readerTokens.HasRows)
            {
                while (readerTokens.Read())
                {
                    Token token = new Token
                        (
                            Convert.ToInt32(readerTokens.GetValue(0)),
                            readerTokens.GetValue(1).ToString(),
                            readerTokens.GetValue(2).ToString(),
                            readerTokens.GetValue(3).ToString(),
                            readerTokens.GetValue(4).ToString(),
                            readerTokens.GetValue(5).ToString(),
                            readerTokens.GetValue(6).ToString(),
                            readerTokens.GetValue(7).ToString(),
                            Convert.ToDateTime(readerTokens.GetValue(8)),
                            Convert.ToDateTime(readerTokens.GetValue(9)),
                            Convert.ToInt32(readerTokens.GetValue(10))
                        );
                    User user = new User
                        (
                            Convert.ToInt32(readerTokens.GetValue(10)),
                            readerTokens.GetValue(11).ToString(),
                            readerTokens.GetValue(12).ToString(),
                            readerTokens.GetValue(13).ToString()
                        );

                    this.Tokens.Add(token, user);
                }
            }
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

            else if (status == "Требуется перевыпуск")
                return this.Tokens
                    .Where(x => (
                    x.Key.DateEnd - DateTime.UtcNow).Days < 10 && 
                    (x.Key.DateEnd - DateTime.UtcNow).Days > 0
                    )
                    .ToDictionary(x => x.Key, x => x.Value);

            else if (status == "Срок истек")
                return this.Tokens
                    .Where(x => x.Key.DateEnd < DateTime.UtcNow)
                    .ToDictionary(x => x.Key, x => x.Value);

            else
                return this.Tokens
                    .Where(x => x.Key.Status == status)
                    .ToDictionary(x => x.Key, x => x.Value);
        }

        public HashSet<string> GetStatusList()
        {
            HashSet<string> statusList = new();
            foreach (KeyValuePair<Token, User> token in Tokens)
            {
                statusList.Add(token.Key.Status);
            }
            return statusList;
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)this.Tokens).GetEnumerator();
        }
    }
}
