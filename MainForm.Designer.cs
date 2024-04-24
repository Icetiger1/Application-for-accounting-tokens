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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStrip1 = new ToolStrip();
            OpenAddTokenFormButton = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            DeleteTokenButton = new ToolStripButton();
            RefreshButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripComboBox1 = new ToolStripLabel();
            statusComboBox = new ToolStripComboBox();
            toolStripSplitButton1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripSeparator6 = new ToolStripSeparator();
            toolStripTextBox1 = new ToolStripTextBox();
            SearchButton = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            listViewTokens = new ListView();
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
            toolStrip2 = new ToolStrip();
            toolStripSplitButton2 = new ToolStripSplitButton();
            загрузитьСписокПользователейActiveDirectoryToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripButton2 = new ToolStripButton();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            contextMenuStrip1 = new ContextMenuStrip(components);
            редактироватьToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            toolStrip2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            toolStrip1.AutoSize = false;
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(18, 18);
            toolStrip1.Items.AddRange(new ToolStripItem[] { OpenAddTokenFormButton, toolStripButton3, DeleteTokenButton, RefreshButton, toolStripSeparator1, toolStripSeparator5, toolStripComboBox1, statusComboBox, toolStripSplitButton1, toolStripSeparator2, toolStripSeparator6, toolStripTextBox1, SearchButton, toolStripSeparator4 });
            toolStrip1.Location = new Point(0, 25);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1192, 37);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // OpenAddTokenFormButton
            // 
            OpenAddTokenFormButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            OpenAddTokenFormButton.Image = Properties.Resources.add;
            OpenAddTokenFormButton.ImageTransparentColor = Color.Magenta;
            OpenAddTokenFormButton.Name = "OpenAddTokenFormButton";
            OpenAddTokenFormButton.Size = new Size(23, 34);
            OpenAddTokenFormButton.Text = "toolStripButton1";
            OpenAddTokenFormButton.Click += OpenAddTokenFormButton_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 34);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // DeleteTokenButton
            // 
            DeleteTokenButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            DeleteTokenButton.Image = Properties.Resources.del;
            DeleteTokenButton.ImageTransparentColor = Color.Magenta;
            DeleteTokenButton.Name = "DeleteTokenButton";
            DeleteTokenButton.Size = new Size(23, 34);
            DeleteTokenButton.Text = "toolStripButton2";
            DeleteTokenButton.Click += DeleteTokenButton_Click;
            // 
            // RefreshButton
            // 
            RefreshButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            RefreshButton.Image = (Image)resources.GetObject("RefreshButton.Image");
            RefreshButton.ImageTransparentColor = Color.Magenta;
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(65, 34);
            RefreshButton.Text = "Обновить";
            RefreshButton.Click += RefreshButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 37);
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 37);
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(46, 34);
            toolStripComboBox1.Text = "Статус:";
            // 
            // statusComboBox
            // 
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(121, 37);
            statusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(6, 37);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 37);
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 37);
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.AutoSize = false;
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(300, 37);
            // 
            // SearchButton
            // 
            SearchButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            SearchButton.Image = (Image)resources.GetObject("SearchButton.Image");
            SearchButton.ImageTransparentColor = Color.Magenta;
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(46, 34);
            SearchButton.Text = "Поиск";
            SearchButton.Click += SearchButton_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 37);
            // 
            // listViewTokens
            // 
            listViewTokens.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewTokens.Columns.AddRange(new ColumnHeader[] { ID, Type, FIO, Department, Destiny, Action, SerialNumber, InterCertCenter, RootCertCenter, Status, DateStart, DateEnd });
            listViewTokens.FullRowSelect = true;
            listViewTokens.HideSelection = true;
            listViewTokens.Location = new Point(12, 65);
            listViewTokens.MultiSelect = false;
            listViewTokens.Name = "listViewTokens";
            listViewTokens.Size = new Size(1168, 474);
            listViewTokens.TabIndex = 1;
            listViewTokens.UseCompatibleStateImageBehavior = false;
            listViewTokens.View = View.Details;
            listViewTokens.MouseClick += listViewTokens_MouseClick;
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
            // toolStrip2
            // 
            toolStrip2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            toolStrip2.Dock = DockStyle.None;
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripSplitButton2, toolStripButton2, toolStripDropDownButton1 });
            toolStrip2.Location = new Point(0, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(286, 25);
            toolStrip2.TabIndex = 2;
            toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSplitButton2
            // 
            toolStripSplitButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripSplitButton2.DropDownItems.AddRange(new ToolStripItem[] { загрузитьСписокПользователейActiveDirectoryToolStripMenuItem1 });
            toolStripSplitButton2.Image = (Image)resources.GetObject("toolStripSplitButton2.Image");
            toolStripSplitButton2.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton2.Name = "toolStripSplitButton2";
            toolStripSplitButton2.Size = new Size(138, 22);
            toolStripSplitButton2.Text = "Для администратора";
            // 
            // загрузитьСписокПользователейActiveDirectoryToolStripMenuItem1
            // 
            загрузитьСписокПользователейActiveDirectoryToolStripMenuItem1.Name = "загрузитьСписокПользователейActiveDirectoryToolStripMenuItem1";
            загрузитьСписокПользователейActiveDirectoryToolStripMenuItem1.Size = new Size(350, 22);
            загрузитьСписокПользователейActiveDirectoryToolStripMenuItem1.Text = "Загрузить список пользователей (Active Directory)";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(107, 22);
            toolStripButton2.Text = "Выгрузить в Excel";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(29, 22);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { редактироватьToolStripMenuItem, удалитьToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(155, 48);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // редактироватьToolStripMenuItem
            // 
            редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            редактироватьToolStripMenuItem.Size = new Size(154, 22);
            редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(154, 22);
            удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 551);
            Controls.Add(toolStrip2);
            Controls.Add(listViewTokens);
            Controls.Add(toolStrip1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
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
        private ToolStripComboBox statusComboBox;
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
        public ListView listViewTokens;
        private ToolStrip toolStrip2;
        private ToolStripSplitButton toolStripSplitButton2;
        private ToolStripMenuItem загрузитьСписокПользователейActiveDirectoryToolStripMenuItem1;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem редактироватьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton toolStripButton3;
    }
}