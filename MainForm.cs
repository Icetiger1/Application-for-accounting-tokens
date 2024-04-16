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
                lv = listView1
            };
            f2.ButtonClicked += Form2ButtonClicked;
            f2.Show();
        }

        private void Form2ButtonClicked(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            FillListView(FullTokens);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            FillListView(FullTokens);
        }

        private void DeleteTokenButton_Click(object sender, EventArgs e)
        {
            int index = listView1.SelectedIndices[0];
            FullTokens.Delete(int.Parse(listView1.Items[index].SubItems[0].Text));

            listView1.Items.Clear();
            FillListView(FullTokens);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void FillListView(TokensViewModel tokens)
        {
            foreach (Token token in tokens)
            {
                ListViewItem item = token.AddToListViewItem();
                listView1.Items.Add(item);
            }
        }

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
            listView1.Items.Clear();

            string selectStatus = toolStripComboBox2.SelectedItem.ToString();

            List<Token> filtr_Tokens = FullTokens.FilterStatusList(selectStatus);
            Filtr = new(filtr_Tokens);
            FillListView(Filtr);
        }
    }
}