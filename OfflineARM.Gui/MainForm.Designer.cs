namespace OfflineARM.Gui
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mMenu = new System.Windows.Forms.MenuStrip();
            this.tsmMain = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChangeUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProgramExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTasks = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспозицияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProxy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUpdateDictionaries = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHelpGuide = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.slCurrentUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbLoadDictionary = new System.Windows.Forms.ToolStripProgressBar();
            this.slLoadDictionary = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.scButtonContainer = new System.Windows.Forms.SplitContainer();
            this.btnExpo = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scButtonContainer)).BeginInit();
            this.scButtonContainer.Panel1.SuspendLayout();
            this.scButtonContainer.Panel2.SuspendLayout();
            this.scButtonContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mMenu
            // 
            this.mMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMain,
            this.tsmTasks,
            this.tsmSettings,
            this.tsmHelp});
            this.mMenu.Location = new System.Drawing.Point(0, 0);
            this.mMenu.Name = "mMenu";
            this.mMenu.Size = new System.Drawing.Size(686, 24);
            this.mMenu.TabIndex = 0;
            this.mMenu.Text = "Главное меню";
            // 
            // tsmMain
            // 
            this.tsmMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmChangeUser,
            this.tsmProgramExit});
            this.tsmMain.Name = "tsmMain";
            this.tsmMain.Size = new System.Drawing.Size(64, 20);
            this.tsmMain.Text = "Главное";
            // 
            // tsmChangeUser
            // 
            this.tsmChangeUser.Name = "tsmChangeUser";
            this.tsmChangeUser.Size = new System.Drawing.Size(200, 22);
            this.tsmChangeUser.Text = "Сменить пользователя";
            this.tsmChangeUser.Click += new System.EventHandler(this.tsmChangeUser_Click);
            // 
            // tsmProgramExit
            // 
            this.tsmProgramExit.Name = "tsmProgramExit";
            this.tsmProgramExit.Size = new System.Drawing.Size(200, 22);
            this.tsmProgramExit.Text = "Выход";
            // 
            // tsmTasks
            // 
            this.tsmTasks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заказыToolStripMenuItem,
            this.экспозицияToolStripMenuItem});
            this.tsmTasks.Name = "tsmTasks";
            this.tsmTasks.Size = new System.Drawing.Size(58, 20);
            this.tsmTasks.Text = "Задачи";
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.просмотрToolStripMenuItem});
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.заказыToolStripMenuItem.Text = "Заказы";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // экспозицияToolStripMenuItem
            // 
            this.экспозицияToolStripMenuItem.Name = "экспозицияToolStripMenuItem";
            this.экспозицияToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.экспозицияToolStripMenuItem.Text = "Экспозиция";
            // 
            // tsmSettings
            // 
            this.tsmSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmProxy,
            this.tsmUpdateDictionaries});
            this.tsmSettings.Name = "tsmSettings";
            this.tsmSettings.Size = new System.Drawing.Size(79, 20);
            this.tsmSettings.Text = "Настройки";
            // 
            // tsmProxy
            // 
            this.tsmProxy.Name = "tsmProxy";
            this.tsmProxy.Size = new System.Drawing.Size(204, 22);
            this.tsmProxy.Text = "Прокси";
            this.tsmProxy.Click += new System.EventHandler(this.tsmProxy_Click);
            // 
            // tsmUpdateDictionaries
            // 
            this.tsmUpdateDictionaries.Name = "tsmUpdateDictionaries";
            this.tsmUpdateDictionaries.Size = new System.Drawing.Size(204, 22);
            this.tsmUpdateDictionaries.Text = "Обновить справочники";
            this.tsmUpdateDictionaries.Click += new System.EventHandler(this.tsmUpdateDictionaries_Click);
            // 
            // tsmHelp
            // 
            this.tsmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmHelpGuide,
            this.tsmAboutProgram});
            this.tsmHelp.Name = "tsmHelp";
            this.tsmHelp.Size = new System.Drawing.Size(68, 20);
            this.tsmHelp.Text = "Помощь";
            // 
            // tsmHelpGuide
            // 
            this.tsmHelpGuide.Name = "tsmHelpGuide";
            this.tsmHelpGuide.Size = new System.Drawing.Size(149, 22);
            this.tsmHelpGuide.Text = "Руководство";
            // 
            // tsmAboutProgram
            // 
            this.tsmAboutProgram.Name = "tsmAboutProgram";
            this.tsmAboutProgram.Size = new System.Drawing.Size(149, 22);
            this.tsmAboutProgram.Text = "О программе";
            this.tsmAboutProgram.Click += new System.EventHandler(this.tsmAboutProgram_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slCurrentUser,
            this.pbLoadDictionary,
            this.slLoadDictionary});
            this.statusStrip1.Location = new System.Drawing.Point(0, 381);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(686, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // slCurrentUser
            // 
            this.slCurrentUser.Name = "slCurrentUser";
            this.slCurrentUser.Size = new System.Drawing.Size(131, 17);
            this.slCurrentUser.Text = "Пользователь \"admin\"";
            // 
            // pbLoadDictionary
            // 
            this.pbLoadDictionary.Margin = new System.Windows.Forms.Padding(100, 3, 1, 3);
            this.pbLoadDictionary.Name = "pbLoadDictionary";
            this.pbLoadDictionary.Size = new System.Drawing.Size(100, 16);
            // 
            // slLoadDictionary
            // 
            this.slLoadDictionary.Name = "slLoadDictionary";
            this.slLoadDictionary.Size = new System.Drawing.Size(0, 17);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.scButtonContainer, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(686, 357);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // scButtonContainer
            // 
            this.scButtonContainer.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.scButtonContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scButtonContainer.Location = new System.Drawing.Point(3, 3);
            this.scButtonContainer.Name = "scButtonContainer";
            // 
            // scButtonContainer.Panel1
            // 
            this.scButtonContainer.Panel1.Controls.Add(this.label5);
            this.scButtonContainer.Panel1.Controls.Add(this.label4);
            this.scButtonContainer.Panel1.Controls.Add(this.btnExpo);
            this.scButtonContainer.Panel1.Controls.Add(this.btnOrder);
            // 
            // scButtonContainer.Panel2
            // 
            this.scButtonContainer.Panel2.Controls.Add(this.label3);
            this.scButtonContainer.Panel2.Controls.Add(this.label2);
            this.scButtonContainer.Panel2.Controls.Add(this.label1);
            this.scButtonContainer.Panel2.Controls.Add(this.button2);
            this.scButtonContainer.Panel2.Controls.Add(this.button1);
            this.scButtonContainer.Size = new System.Drawing.Size(680, 69);
            this.scButtonContainer.SplitterDistance = 203;
            this.scButtonContainer.TabIndex = 0;
            // 
            // btnExpo
            // 
            this.btnExpo.Location = new System.Drawing.Point(65, 12);
            this.btnExpo.Name = "btnExpo";
            this.btnExpo.Size = new System.Drawing.Size(50, 50);
            this.btnExpo.TabIndex = 1;
            this.btnExpo.Text = "Э";
            this.btnExpo.UseVisualStyleBackColor = true;
            this.btnExpo.Click += new System.EventHandler(this.btnExpo_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(10, 12);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(50, 50);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "З";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(70, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "C";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Д";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Number,
            this.Status,
            this.FIO});
            this.dataGridView1.Location = new System.Drawing.Point(3, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(680, 276);
            this.dataGridView1.TabIndex = 1;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "№ заказа";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 150;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 150;
            // 
            // FIO
            // 
            this.FIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FIO.DataPropertyName = "FIO";
            this.FIO.HeaderText = "ФИО\\Наименование";
            this.FIO.Name = "FIO";
            this.FIO.ReadOnly = true;
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.просмотрToolStripMenuItem.Text = "Просмотр";
            this.просмотрToolStripMenuItem.Click += new System.EventHandler(this.просмотрToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Эта панель для динамически добавляемых команд., в зависимости от вкладки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Команды дублируются в меню Задачи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(403, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "У таблицы дожлен быть фильтр по сотлбцам для быстрого поиска и педжинг";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Быстрый выбор Заказ\\Экспо";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Вместо букв иконки";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 403);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mMenu);
            this.MainMenuStrip = this.mMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mMenu.ResumeLayout(false);
            this.mMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.scButtonContainer.Panel1.ResumeLayout(false);
            this.scButtonContainer.Panel1.PerformLayout();
            this.scButtonContainer.Panel2.ResumeLayout(false);
            this.scButtonContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scButtonContainer)).EndInit();
            this.scButtonContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmMain;
        private System.Windows.Forms.ToolStripMenuItem tsmProgramExit;
        private System.Windows.Forms.ToolStripMenuItem tsmChangeUser;
        private System.Windows.Forms.ToolStripMenuItem tsmTasks;
        private System.Windows.Forms.ToolStripMenuItem tsmSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmHelpGuide;
        private System.Windows.Forms.ToolStripMenuItem tsmAboutProgram;
        private System.Windows.Forms.ToolStripMenuItem tsmProxy;
        private System.Windows.Forms.ToolStripMenuItem tsmUpdateDictionaries;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar pbLoadDictionary;
        private System.Windows.Forms.ToolStripStatusLabel slLoadDictionary;
        private System.Windows.Forms.ToolStripStatusLabel slCurrentUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.SplitContainer scButtonContainer;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnExpo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспозицияToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}