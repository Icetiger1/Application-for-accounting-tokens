using WinFormsApp1.Infrastructure;
using WinFormsApp1.Model;
using WinFormsApp1.ViewModel;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public static TokensViewModel Tokens = new();

        public MainForm()
        {
            InitializeComponent();

            TokensCreator tokenCreator = new();
            for (int i = 0; i < 5; i++)
            {
                Tokens.Append((Token)tokenCreator.GetContact());
            }

            AddToListView();
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
            AddToListView();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            AddToListView();
        }

        private void DeleteTokenButton_Click(object sender, EventArgs e)
        {
            int index = listView1.SelectedIndices[0];
            Tokens.Delete(int.Parse(listView1.Items[index].SubItems[0].Text));

            listView1.Items.Clear();
            AddToListView();
        }

        private void AddToListView()
        {
            foreach (Token token in Tokens)
            {
                ListViewItem item = token.AddToListViewItem();
                listView1.Items.Add(item);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }
    }
}