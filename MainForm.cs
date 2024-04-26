using System.Reflection;
using System.Windows.Forms;
using WinFormsApp1.Infrastructure;
using WinFormsApp1.Model;
using WinFormsApp1.ViewModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        internal static TokensViewModel FullTokens;

        public MainForm()
        {
            InitializeComponent();

            TokensCreator tokenCreator = new();
            UsersCreator usersCreator = new();
            FullTokens = new();

            for (int i = 0; i < 20; i++)
            {
                FullTokens.Append((Token)tokenCreator.GetToken(), (User)usersCreator.GetUser());
            }

            //CRUDRepository<Token> tokenRepository = new CRUDRepository<Token>();
            //FullTokens = new();

            FillListView(FullTokens);
            FillComboBox();
        }

        /// <summary>
        /// Кнопка открытия формы добавления нового токена
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenAddTokenFormButton_Click(object sender, EventArgs e)
        {
            AddTokenForm form = new()
            {
                lv = listViewTokens
            };

            form.ButtonClicked += RefreshButton_Click;
            form.Show();
        }

        /// <summary>
        /// Кнопка открытия формы редактирование выбранного токена токена
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenEditeTokenFormButton_Click(object sender, EventArgs e)
        {
            if (listViewTokens.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewTokens.SelectedItems[0];
                EditeTokenForm form = new()
                {
                    lv = listViewTokens,
                };

                form.comboBox1.Text = selectedItem.SubItems[1].Text;
                form.textBox1.Text = selectedItem.SubItems[2].Text;
                form.comboBox6.Text = selectedItem.SubItems[3].Text;
                form.comboBox3.Text = selectedItem.SubItems[4].Text;
                form.comboBox4.Text = selectedItem.SubItems[5].Text;
                form.textBox2.Text = selectedItem.SubItems[6].Text;
                form.textBox3.Text = selectedItem.SubItems[7].Text;
                form.textBox4.Text = selectedItem.SubItems[8].Text;
                form.comboBox5.Text = selectedItem.SubItems[9].Text;
                form.dateTimePicker1.Text = selectedItem.SubItems[10].Text;
                form.dateTimePicker2.Text = selectedItem.SubItems[11].Text;

                form.groupBox1.Text += $"№{selectedItem.SubItems[0].Text}";
                form.ButtonClicked += RefreshButton_Click;
                form.Show();
            }
        }

        /// <summary>
        /// Событие обновления данных в таблице listViewTokens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            listViewTokens.Items.Clear();
            FillListView(FullTokens);
        }

        /// <summary>
        /// Удаление выбранного элемента из объекта FullTokens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteTokenButton_Click(object sender, EventArgs e)
        {
            int index = listViewTokens.SelectedIndices[0];
            FullTokens.Delete(int.Parse(listViewTokens.Items[index].SubItems[0].Text));

            listViewTokens.Items.Clear();
            FillListView(FullTokens);
        }


        /// <summary>
        /// Заполнение listViewTokens
        /// </summary>
        /// <param name="tokens"></param>
        private void FillListView(TokensViewModel tokens)
        {
            foreach (KeyValuePair<Token, User> token in tokens)
            {
                ListViewItem item = AddToListViewItem(token);
                listViewTokens.Items.Add(item);
            }
        }

        /// <summary>
        /// Заполнение toolStripComboBox2 3 и ... для дальнейшей фильтрации по статусу токена
        /// </summary>
        private void FillComboBox()
        {
            statusComboBox.Items.Add("Все");
            statusComboBox.Items.Add("Требуется перевыпуск");
            statusComboBox.Items.Add("Срок истек");

            foreach (string status in (HashSet<string>)FullTokens.GetStatusList())
            {
                statusComboBox.Items.Add(status);
            }
        }

        /// <summary>
        /// Событие проиходит при изменении значения в списке выбора статуса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewTokens.Items.Clear();

            string? selectStatus = statusComboBox.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(selectStatus))
            {
                FillListView(new((Dictionary<Token, User>)FullTokens.FilterStatusList(selectStatus)));
            }
        }

        /// <summary>
        /// Заполнение ListView на главной форме
        /// </summary>
        /// <param name="token">передаем экземпляр пары токена и пользователя</param>
        /// <returns></returns>
        private ListViewItem AddToListViewItem(KeyValuePair<Token, User> token)
        {
            ListViewItem item = new(token.Key.Id.ToString());

            ListViewItem.ListViewSubItem sub1 = new();
            ListViewItem.ListViewSubItem sub2 = new();
            ListViewItem.ListViewSubItem sub3 = new();
            ListViewItem.ListViewSubItem sub4 = new();
            ListViewItem.ListViewSubItem sub5 = new();
            ListViewItem.ListViewSubItem sub6 = new();
            ListViewItem.ListViewSubItem sub7 = new();
            ListViewItem.ListViewSubItem sub8 = new();
            ListViewItem.ListViewSubItem sub9 = new();
            ListViewItem.ListViewSubItem sub10 = new();
            ListViewItem.ListViewSubItem sub11 = new();

            sub1.Text = token.Key.Type;
            sub2.Text = token.Value.FIO;
            sub3.Text = token.Value.Department;
            sub4.Text = token.Key.Destiny;
            sub5.Text = token.Key.Action;
            sub6.Text = token.Key.SerialNumber;
            sub7.Text = token.Key.InterCertCenter;
            sub8.Text = token.Key.RootCertCenter;
            sub9.Text = token.Key.Status;
            sub10.Text = token.Key.DateStart.ToString();
            sub11.Text = token.Key.DateEnd.ToString();

            item.SubItems.AddRange(new[]
            {
                sub1,
                sub2,
                sub3,
                sub4,
                sub5,
                sub6,
                sub7,
                sub8,
                sub9,
                sub10,
                sub11,
            });

            return item;
        }

        /// <summary>
        /// Событие клика кнопкой мыши по объекту listViewTokens, необходимо, 
        /// чтобы при клике правой кнопкой мыши по строке вызывалось контекстное меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewTokens_MouseClick(object sender, MouseEventArgs e)
        {
            listViewTokens.ContextMenuStrip = null;
            ListViewHitTestInfo info = listViewTokens.HitTest(e.X, e.Y);
            var selectedItem = listViewTokens.SelectedItems[0];
            var focusedItem = listViewTokens.FocusedItem;

            if (info.Item != null)
            {
                if (focusedItem != null && focusedItem.Bounds.Y == selectedItem.Position.Y)
                {
                    if (e.Button == MouseButtons.Right)
                    {

                        listViewTokens.ContextMenuStrip = contextMenuStrip1;
                        listViewTokens.ContextMenuStrip.Show(listViewTokens, new Point(e.X, e.Y));
                    }
                }
            }
        }

        /// <summary>
        /// Событие, вызываемой при открытии контекстного меню.
        /// Если ни одна строка listViewTokens не выделена то меню не вызывается
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (listViewTokens.SelectedItems.Count <= 0 || listViewTokens.ContextMenuStrip != null)
            {
                listViewTokens.ContextMenuStrip = null;
            }
        }

        /// <summary>
        /// Кнопка вызова окна "Справка" со сведениями о программе и краткой справки
        /// еще не реализована
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HelpDropDownButton_Click(object sender, EventArgs e)
        {

        }
        
        /// <summary>
        /// Кнопка поиска, еще не реализована
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

    }
}