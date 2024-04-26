using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Infrastructure;
using WinFormsApp1.Model;
using WinFormsApp1.ViewModel;

namespace WinFormsApp1
{
    public partial class AddTokenForm : Form
    {
        public ListView lv = new();
        public EventHandler ButtonClicked;

        public AddTokenForm()
        {
            InitializeComponent();

            FillFormCreate fillForm = new();
            comboBox1.Items.AddRange(fillForm.types);
            comboBox6.Items.AddRange(fillForm.departments);
            comboBox3.Items.AddRange(fillForm.destinys);
            comboBox4.Items.AddRange(fillForm.actions);
            comboBox5.Items.AddRange(fillForm.statuses);
            comboBox2.Items.AddRange(MainForm.FullTokens.Tokens.Select(x => x.Value.Post).Distinct().ToArray());
        }

        public void AddTokenButton_Click(object sender, EventArgs e)
        {
            Token token = new(
                lv.Items.Count,
                comboBox1.GetItemText(comboBox1.SelectedItem),
                comboBox3.GetItemText(comboBox3.SelectedItem),
                comboBox4.GetItemText(comboBox4.SelectedItem),
                textBox2.Text,
                textBox3.Text,
                textBox4.Text,
                comboBox5.GetItemText(comboBox5.SelectedItem),
                dateTimePicker1.Value,
                dateTimePicker2.Value,
                0
                );

            User user = new(
                1,
                textBox1.Text,
                comboBox2.GetItemText(comboBox2.SelectedItem),
                comboBox2.GetItemText(comboBox6.SelectedItem)
                );

            (bool, string) turpleToken = token.IsNotNullOrEmpty();
            (bool, string) turpleUser = user.IsNotNullOrEmpty();
            if (turpleToken.Item1 == true)
            {
                if (turpleUser.Item1 == true)
                {
                    MainForm.FullTokens.Append(token, user);
                    OnButtonClicked(EventArgs.Empty);
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Не заполнены сведения о пользователе, поле {turpleUser.Item2}");
                }
            }
            else
            {
                MessageBox.Show($"Не заполнены сведения о токене или сертификате, поле {turpleToken.Item2}");
            }
        }

        protected void OnButtonClicked(EventArgs e)
        {
            var evt = ButtonClicked;
            if (evt != null) evt(this, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
