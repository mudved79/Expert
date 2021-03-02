namespace ParseXML
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemWDB = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAppReestr = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCloseApp = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSqlLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDBLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsFname = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainPBar = new System.Windows.Forms.ToolStripProgressBar();
            this.MainMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemWDB,
            this.ToolStripMenuItemCloseApp});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(879, 38);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // ToolStripMenuItemWDB
            // 
            this.ToolStripMenuItemWDB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemConnect,
            this.ToolStripMenuItemAppReestr});
            this.ToolStripMenuItemWDB.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStripMenuItemWDB.Image = global::ParseXML.Properties.Resources.ДБ;
            this.ToolStripMenuItemWDB.Name = "ToolStripMenuItemWDB";
            this.ToolStripMenuItemWDB.Size = new System.Drawing.Size(158, 34);
            this.ToolStripMenuItemWDB.Text = "Работа с БД";
            // 
            // ToolStripMenuItemConnect
            // 
            this.ToolStripMenuItemConnect.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStripMenuItemConnect.Image = global::ParseXML.Properties.Resources.input_devices_settings;
            this.ToolStripMenuItemConnect.Name = "ToolStripMenuItemConnect";
            this.ToolStripMenuItemConnect.Size = new System.Drawing.Size(257, 34);
            this.ToolStripMenuItemConnect.Text = "Подключение";
            this.ToolStripMenuItemConnect.Click += new System.EventHandler(this.ToolStripMenuItemConnect_Click);
            // 
            // ToolStripMenuItemAppReestr
            // 
            this.ToolStripMenuItemAppReestr.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStripMenuItemAppReestr.Image = global::ParseXML.Properties.Resources.download;
            this.ToolStripMenuItemAppReestr.Name = "ToolStripMenuItemAppReestr";
            this.ToolStripMenuItemAppReestr.Size = new System.Drawing.Size(257, 34);
            this.ToolStripMenuItemAppReestr.Text = "Загрузка реестра";
            this.ToolStripMenuItemAppReestr.Click += new System.EventHandler(this.ToolStripMenuItemAppReestr_Click);
            // 
            // ToolStripMenuItemCloseApp
            // 
            this.ToolStripMenuItemCloseApp.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStripMenuItemCloseApp.Image = global::ParseXML.Properties.Resources.power;
            this.ToolStripMenuItemCloseApp.Name = "ToolStripMenuItemCloseApp";
            this.ToolStripMenuItemCloseApp.Size = new System.Drawing.Size(106, 34);
            this.ToolStripMenuItemCloseApp.Text = "Выход";
            this.ToolStripMenuItemCloseApp.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSqlLabel,
            this.toolStripDBLabel,
            this.tsFname,
            this.MainPBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 360);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(879, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSqlLabel
            // 
            this.toolStripSqlLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSqlLabel.Name = "toolStripSqlLabel";
            this.toolStripSqlLabel.Size = new System.Drawing.Size(60, 17);
            this.toolStripSqlLabel.Text = "SQLServer";
            // 
            // toolStripDBLabel
            // 
            this.toolStripDBLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDBLabel.Name = "toolStripDBLabel";
            this.toolStripDBLabel.Size = new System.Drawing.Size(22, 17);
            this.toolStripDBLabel.Text = "DB";
            this.toolStripDBLabel.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // tsFname
            // 
            this.tsFname.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsFname.Name = "tsFname";
            this.tsFname.Size = new System.Drawing.Size(47, 17);
            this.tsFname.Text = "faname";
            this.tsFname.ToolTipText = "обрабатываемый файл";
            // 
            // MainPBar
            // 
            this.MainPBar.MarqueeAnimationSpeed = 400;
            this.MainPBar.Name = "MainPBar";
            this.MainPBar.Size = new System.Drawing.Size(200, 16);
            this.MainPBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(879, 382);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MainMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Экспертиза реестров:";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemWDB;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAppReestr;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemConnect;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCloseApp;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSqlLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripDBLabel;
        private System.Windows.Forms.ToolStripProgressBar MainPBar;
        private System.Windows.Forms.ToolStripStatusLabel tsFname;
    }
}

