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
        /// ������ �������� ����� ���������� ������ ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// ������� ���������� ������ � ������� listViewTokens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            listViewTokens.Items.Clear();
            FillListView(FullTokens);
        }

        /// <summary>
        /// �������� ���������� �������� �� ������� FullTokens
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
        /// ������ ������, ��� �� �����������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// ���������� listViewTokens
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
        /// ���������� toolStripComboBox2 3 � ... ��� ���������� ���������� �� ������� ������
        /// </summary>
        private void FillComboBox()
        {
            statusComboBox.Items.Add("���");
            statusComboBox.Items.Add("��������� ����������");
            statusComboBox.Items.Add("���� �����");

            foreach (string status in (HashSet<string>)FullTokens.GetStatusList())
            {
                statusComboBox.Items.Add(status);
            }
        }

        /// <summary>
        /// ������� ��������� ��� ��������� �������� � ������ ������ �������
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
        /// ���������� ListView �� ������� �����
        /// </summary>
        /// <param name="token">�������� ��������� ���� ������ � ������������</param>
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
        /// ������� ����� ������� ���� �� ������� listViewTokens, ����������, 
        /// ����� ��� ����� ������ ������� ���� �� ������ ���������� ����������� ����
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
                else
                {
                    listViewTokens.SelectedItems.Clear();
                    listViewTokens.FocusedItem = null;
                    listViewTokens.Refresh();
                }
            }
        }

        /// <summary>
        /// �������, ���������� ��� �������� ������������ ����.
        /// ���� �� ���� ������ listViewTokens �� �������� �� ���� �� ����������
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
    }
}