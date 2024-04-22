using System;
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
            comboBox2.Items.AddRange(fillForm.departments);
            comboBox3.Items.AddRange(fillForm.destinys);
            comboBox4.Items.AddRange(fillForm.actions);
            comboBox5.Items.AddRange(fillForm.statuses);

        }

        private void AddTokenButton_Click(object sender, EventArgs e)
        {
            Token token = new(lv.Items.Count, 
                comboBox2.SelectedItem.ToString(),
                comboBox3.SelectedItem.ToString(),
                comboBox4.SelectedItem.ToString(),
                textBox2.Text,
                textBox3.Text,
                textBox4.Text,
                comboBox5.SelectedItem.ToString(),
                dateTimePicker1.Value,
                dateTimePicker2.Value,
                0
                );
            User user = new(1,
                comboBox1.SelectedItem.ToString(),
                String.Empty,
                textBox1.Text
                );
            MainForm.FullTokens.Append(token, user);
            OnButtonClicked(EventArgs.Empty);
            this.Close();
        }

        protected void OnButtonClicked(EventArgs e)
        {
            var evt = ButtonClicked;
            if (evt != null) evt(this, e);
        }
    }
}
