namespace WinFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStrip1 = new ToolStrip();
            OpenAddTokenFormButton = new ToolStripButton();
            DeleteTokenButton = new ToolStripButton();
            RefreshButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripComboBox1 = new ToolStripLabel();
            toolStripComboBox2 = new ToolStripComboBox();
            toolStripSplitButton1 = new ToolStripSeparator();
            toolStripTextBox1 = new ToolStripTextBox();
            SearchButton = new ToolStripButton();
            listView1 = new ListView();
            ID = new ColumnHeader();
            Type = new ColumnHeader();
            FIO = new ColumnHeader();
            Department = new ColumnHeader();
            Destiny = new ColumnHeader();
            Action = new ColumnHeader();
            SerialNumber = new ColumnHeader();
            InterCertCenter = new ColumnHeader();
            RootCertCenter = new ColumnHeader();
            Status = new ColumnHeader();
            DateStart = new ColumnHeader();
            DateEnd = new ColumnHeader();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(18, 18);
            toolStrip1.Items.AddRange(new ToolStripItem[] { OpenAddTokenFormButton, DeleteTokenButton, RefreshButton, toolStripSeparator1, toolStripComboBox1, toolStripComboBox2, toolStripSplitButton1, toolStripTextBox1, SearchButton });
            toolStrip1.Location = new Point(12, 8);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(485, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // OpenAddTokenFormButton
            // 
            OpenAddTokenFormButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            OpenAddTokenFormButton.Image = Properties.Resources.add;
            OpenAddTokenFormButton.ImageTransparentColor = Color.Magenta;
            OpenAddTokenFormButton.Name = "OpenAddTokenFormButton";
            OpenAddTokenFormButton.Size = new Size(23, 22);
            OpenAddTokenFormButton.Text = "toolStripButton1";
            OpenAddTokenFormButton.Click += OpenAddTokenFormButton_Click;
            // 
            // DeleteTokenButton
            // 
            DeleteTokenButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            DeleteTokenButton.Image = Properties.Resources.del;
            DeleteTokenButton.ImageTransparentColor = Color.Magenta;
            DeleteTokenButton.Name = "DeleteTokenButton";
            DeleteTokenButton.Size = new Size(23, 22);
            DeleteTokenButton.Text = "toolStripButton2";
            DeleteTokenButton.Click += DeleteTokenButton_Click;
            // 
            // RefreshButton
            // 
            RefreshButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            RefreshButton.Image = (Image)resources.GetObject("RefreshButton.Image");
            RefreshButton.ImageTransparentColor = Color.Magenta;
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(65, 22);
            RefreshButton.Text = "Обновить";
            RefreshButton.Click += RefreshButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(51, 22);
            toolStripComboBox1.Text = "Фильтр:";
            // 
            // toolStripComboBox2
            // 
            toolStripComboBox2.Name = "toolStripComboBox2";
            toolStripComboBox2.Size = new Size(121, 25);
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 25);
            // 
            // SearchButton
            // 
            SearchButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            SearchButton.Image = (Image)resources.GetObject("SearchButton.Image");
            SearchButton.ImageTransparentColor = Color.Magenta;
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(46, 22);
            SearchButton.Text = "Поиск";
            SearchButton.Click += SearchButton_Click;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { ID, Type, FIO, Department, Destiny, Action, SerialNumber, InterCertCenter, RootCertCenter, Status, DateStart, DateEnd });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(12, 34);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(1168, 404);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "№";
            ID.Width = 40;
            // 
            // Type
            // 
            Type.Text = "Тип";
            // 
            // FIO
            // 
            FIO.Text = "ФИО";
            FIO.Width = 100;
            // 
            // Department
            // 
            Department.Text = "Отдел";
            Department.Width = 80;
            // 
            // Destiny
            // 
            Destiny.Text = "Назначение";
            Destiny.Width = 100;
            // 
            // Action
            // 
            Action.Text = "Действия";
            Action.Width = 80;
            // 
            // SerialNumber
            // 
            SerialNumber.Text = "Серийный номер";
            SerialNumber.Width = 150;
            // 
            // InterCertCenter
            // 
            InterCertCenter.Text = "Промежуточный УЦ";
            InterCertCenter.Width = 100;
            // 
            // RootCertCenter
            // 
            RootCertCenter.Text = "Корневой УЦ";
            RootCertCenter.Width = 100;
            // 
            // Status
            // 
            Status.Text = "Статус";
            // 
            // DateStart
            // 
            DateStart.Text = "Дата начала";
            DateStart.Width = 120;
            // 
            // DateEnd
            // 
            DateEnd.Text = "Дата окончания";
            DateEnd.Width = 120;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 450);
            Controls.Add(listView1);
            Controls.Add(toolStrip1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton OpenAddTokenFormButton;
        private ToolStripButton DeleteTokenButton;
        private ToolStripButton RefreshButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripComboBox1;
        private ToolStripComboBox toolStripComboBox2;
        private ToolStripSeparator toolStripSplitButton1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripButton SearchButton;
        private ColumnHeader ID;
        private ColumnHeader Type;
        private ColumnHeader FIO;
        private ColumnHeader Department;
        private ColumnHeader Destiny;
        private ColumnHeader Action;
        private ColumnHeader SerialNumber;
        private ColumnHeader InterCertCenter;
        private ColumnHeader RootCertCenter;
        private ColumnHeader Status;
        private ColumnHeader DateStart;
        private ColumnHeader DateEnd;
        public ListView listView1;
    }
}