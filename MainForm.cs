using System.Collections.Generic;
using WinFormsApp1.Infrastructure;
using WinFormsApp1.Model;
using WinFormsApp1.ViewModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public static TokensViewModel FullTokens = new();
        public static TokensViewModel Filtr;


        public MainForm()
        {
            InitializeComponent();

            //Заменить на получение данных из БД
            TokensCreator tokenCreator = new();
            for (int i = 0; i < 5; i++)
            {
                FullTokens.Append((Token)tokenCreator.GetContact());
            }

            FillListView(FullTokens);
            FillComboBoxStatuses();
        }

        private void OpenAddTokenFormButton_Click(object sender, EventArgs e)
        {
            AddTokenForm f2 = new()
            {
                lv = listViewTokens
            };
            f2.ButtonClicked += RefreshButton_Click;
            f2.Show();
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

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Заполнение listViewTokens
        /// </summary>
        /// <param name="tokens"></param>
        private void FillListView(TokensViewModel tokens)
        {
            foreach (Token token in tokens)
            {
                ListViewItem item = token.AddToListViewItem();
                listViewTokens.Items.Add(item);
            }
        }
        /// <summary>
        /// Заполнение toolStripComboBox2 для дальнейшей фильтрации по статусу токена
        /// </summary>
        private void FillComboBoxStatuses()
        {
            toolStripComboBox2.Items.Add("Все");

            foreach (string status in (HashSet<string>)GetStatusList())
            {
                toolStripComboBox2.Items.Add(status);
            }
        }

        private HashSet<string> GetStatusList()
        {
            HashSet<string> statusList = new HashSet<string>();
            foreach (Token token in FullTokens)
            {
                statusList.Add(token.Status);
            }
            return statusList;
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewTokens.Items.Clear();

            string selectStatus = toolStripComboBox2.SelectedItem.ToString();

            FillListView(new((List<Token>)FullTokens.FilterStatusList(selectStatus)));
        }
    }
}