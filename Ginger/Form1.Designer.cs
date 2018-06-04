namespace Ginger
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripButton = new System.Windows.Forms.ToolStrip();
            this.ButtonCatalogue = new System.Windows.Forms.ToolStripButton();
            this.ButtonRented = new System.Windows.Forms.ToolStripButton();
            this.ButtonArchive = new System.Windows.Forms.ToolStripButton();
            this.ButtonMeetings = new System.Windows.Forms.ToolStripButton();
            this.ButtonClients = new System.Windows.Forms.ToolStripButton();
            this.ButtonAgents = new System.Windows.Forms.ToolStripButton();
            this.ButtonReports = new System.Windows.Forms.ToolStripButton();
            this.ButtonSettings = new System.Windows.Forms.ToolStripButton();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.PanelCatalogue = new System.Windows.Forms.Panel();
            this.tableCatalogue = new System.Windows.Forms.TableLayoutPanel();
            this.flowButtonsCatalogue = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonToRented = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.dataGridCatalogue = new System.Windows.Forms.DataGridView();
            this.contextMenuCatalogue = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuToRentFromCatalogue = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuToArchiveFromCatalogue = new System.Windows.Forms.ToolStripMenuItem();
            this.CatalogBindingSrc = new System.Windows.Forms.BindingSource(this.components);
            this.PanelRented = new System.Windows.Forms.Panel();
            this.tableRented = new System.Windows.Forms.TableLayoutPanel();
            this.flowButtonsRented = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonToCatalogueFromRented = new System.Windows.Forms.Button();
            this.ButtonToArcFromRented = new System.Windows.Forms.Button();
            this.DataGridRented = new System.Windows.Forms.DataGridView();
            this.contextMenuRented = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuToActiveFromRented = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuToArchiveFromRented = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelArchive = new System.Windows.Forms.Panel();
            this.tableArchive = new System.Windows.Forms.TableLayoutPanel();
            this.flowButtonsArchive = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonToCatalogueFromArc = new System.Windows.Forms.Button();
            this.DataGridArchive = new System.Windows.Forms.DataGridView();
            this.contextMenuArchive = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuToActiveFromArc = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelMeetings = new System.Windows.Forms.Panel();
            this.lblMeetingsPanel = new System.Windows.Forms.Label();
            this.PanelClients = new System.Windows.Forms.Panel();
            this.lblClientsPanel = new System.Windows.Forms.Label();
            this.PanelAgents = new System.Windows.Forms.Panel();
            this.lblAgentsPanel = new System.Windows.Forms.Label();
            this.PanelReports = new System.Windows.Forms.Panel();
            this.lblReportsPanel = new System.Windows.Forms.Label();
            this.PanelSettings = new System.Windows.Forms.Panel();
            this.groupColorIndication = new System.Windows.Forms.GroupBox();
            this.flowDaysTooLittle = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDaysTooLittle = new System.Windows.Forms.Label();
            this.maskDaysTooLittle = new System.Windows.Forms.MaskedTextBox();
            this.ColorForDaysTooLittle = new System.Windows.Forms.PictureBox();
            this.flowDaysLittle = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDaysLittle = new System.Windows.Forms.Label();
            this.maskDaysLittle = new System.Windows.Forms.MaskedTextBox();
            this.ColorForDaysLittle = new System.Windows.Forms.PictureBox();
            this.ButtonAdminAccess = new System.Windows.Forms.Button();
            this.groupDBSetting = new System.Windows.Forms.GroupBox();
            this.ButtonCreateDB = new System.Windows.Forms.Button();
            this.ButtonCheckConnection = new System.Windows.Forms.Button();
            this.flowConnectionString = new System.Windows.Forms.FlowLayoutPanel();
            this.lblConnectionString = new System.Windows.Forms.Label();
            this.boxConnectionString = new System.Windows.Forms.TextBox();
            this.flowPicturePath = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPicturePath = new System.Windows.Forms.Label();
            this.boxPicturePath = new System.Windows.Forms.TextBox();
            this.ButtonSelectPictureFolder = new System.Windows.Forms.Button();
            this.ButtonCancelIni = new System.Windows.Forms.Button();
            this.ButtonSaveIni = new System.Windows.Forms.Button();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.ArcBindingSrc = new System.Windows.Forms.BindingSource(this.components);
            this.RentedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PanelStart = new System.Windows.Forms.Panel();
            this.panelWebBrowser = new System.Windows.Forms.Panel();
            this.dlgFolderSelect = new System.Windows.Forms.FolderBrowserDialog();
            this.colorSelectDialog = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.StatusStrip1.SuspendLayout();
            this.ToolStripButton.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.PanelCatalogue.SuspendLayout();
            this.tableCatalogue.SuspendLayout();
            this.flowButtonsCatalogue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCatalogue)).BeginInit();
            this.contextMenuCatalogue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatalogBindingSrc)).BeginInit();
            this.PanelRented.SuspendLayout();
            this.tableRented.SuspendLayout();
            this.flowButtonsRented.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridRented)).BeginInit();
            this.contextMenuRented.SuspendLayout();
            this.PanelArchive.SuspendLayout();
            this.tableArchive.SuspendLayout();
            this.flowButtonsArchive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridArchive)).BeginInit();
            this.contextMenuArchive.SuspendLayout();
            this.PanelMeetings.SuspendLayout();
            this.PanelClients.SuspendLayout();
            this.PanelAgents.SuspendLayout();
            this.PanelReports.SuspendLayout();
            this.PanelSettings.SuspendLayout();
            this.groupColorIndication.SuspendLayout();
            this.flowDaysTooLittle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorForDaysTooLittle)).BeginInit();
            this.flowDaysLittle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorForDaysLittle)).BeginInit();
            this.groupDBSetting.SuspendLayout();
            this.flowConnectionString.SuspendLayout();
            this.flowPicturePath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArcBindingSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentedBindingSource)).BeginInit();
            this.PanelStart.SuspendLayout();
            this.panelWebBrowser.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 570);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(932, 22);
            this.StatusStrip1.TabIndex = 1;
            this.StatusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(106, 17);
            this.toolStripStatusLabel1.Text = "Строка состояния";
            // 
            // ToolStripButton
            // 
            this.ToolStripButton.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolStripButton.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonCatalogue,
            this.ButtonRented,
            this.ButtonArchive,
            this.ButtonMeetings,
            this.ButtonClients,
            this.ButtonAgents,
            this.ButtonReports,
            this.ButtonSettings});
            this.ToolStripButton.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.ToolStripButton.Location = new System.Drawing.Point(0, 0);
            this.ToolStripButton.Name = "ToolStripButton";
            this.ToolStripButton.Padding = new System.Windows.Forms.Padding(0);
            this.ToolStripButton.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStripButton.Size = new System.Drawing.Size(103, 946);
            this.ToolStripButton.Stretch = true;
            this.ToolStripButton.TabIndex = 2;
            this.ToolStripButton.Text = "LeftPanel";
            // 
            // ButtonCatalogue
            // 
            this.ButtonCatalogue.Image = global::Ginger.Properties.Resources.Catalogue_01_96;
            this.ButtonCatalogue.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButtonCatalogue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonCatalogue.Name = "ButtonCatalogue";
            this.ButtonCatalogue.Size = new System.Drawing.Size(102, 115);
            this.ButtonCatalogue.Text = "Квартиры";
            this.ButtonCatalogue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonCatalogue.Click += new System.EventHandler(this.ButtonCatalogue_Click);
            // 
            // ButtonRented
            // 
            this.ButtonRented.Image = global::Ginger.Properties.Resources.list_01_96;
            this.ButtonRented.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButtonRented.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonRented.Name = "ButtonRented";
            this.ButtonRented.Size = new System.Drawing.Size(102, 115);
            this.ButtonRented.Text = "Сданные";
            this.ButtonRented.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonRented.Click += new System.EventHandler(this.ButtonRented_Click);
            // 
            // ButtonArchive
            // 
            this.ButtonArchive.Image = global::Ginger.Properties.Resources.archive_01_96;
            this.ButtonArchive.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButtonArchive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonArchive.Name = "ButtonArchive";
            this.ButtonArchive.Padding = new System.Windows.Forms.Padding(1, 0, 2, 0);
            this.ButtonArchive.Size = new System.Drawing.Size(102, 115);
            this.ButtonArchive.Text = "Архив";
            this.ButtonArchive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonArchive.Click += new System.EventHandler(this.ButtonArchive_Click);
            // 
            // ButtonMeetings
            // 
            this.ButtonMeetings.Enabled = false;
            this.ButtonMeetings.Image = global::Ginger.Properties.Resources.Meetings_01_96;
            this.ButtonMeetings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButtonMeetings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonMeetings.Name = "ButtonMeetings";
            this.ButtonMeetings.Size = new System.Drawing.Size(102, 115);
            this.ButtonMeetings.Text = "Встречи";
            this.ButtonMeetings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonMeetings.Click += new System.EventHandler(this.ButtonMeetings_Click);
            // 
            // ButtonClients
            // 
            this.ButtonClients.Enabled = false;
            this.ButtonClients.Image = global::Ginger.Properties.Resources.Contact_List_01_96;
            this.ButtonClients.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButtonClients.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonClients.Name = "ButtonClients";
            this.ButtonClients.Size = new System.Drawing.Size(102, 115);
            this.ButtonClients.Text = "Клиенты";
            this.ButtonClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonClients.Click += new System.EventHandler(this.ButtonClients_Click);
            // 
            // ButtonAgents
            // 
            this.ButtonAgents.Enabled = false;
            this.ButtonAgents.Image = global::Ginger.Properties.Resources.Contact_List_02_96;
            this.ButtonAgents.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButtonAgents.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonAgents.Name = "ButtonAgents";
            this.ButtonAgents.Size = new System.Drawing.Size(102, 115);
            this.ButtonAgents.Text = "Агенты";
            this.ButtonAgents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonAgents.Click += new System.EventHandler(this.ButtonAgents_Click);
            // 
            // ButtonReports
            // 
            this.ButtonReports.Enabled = false;
            this.ButtonReports.Image = global::Ginger.Properties.Resources.Reports_01_96;
            this.ButtonReports.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButtonReports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonReports.Name = "ButtonReports";
            this.ButtonReports.Size = new System.Drawing.Size(102, 115);
            this.ButtonReports.Text = "Отчеты";
            this.ButtonReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonReports.Click += new System.EventHandler(this.ButtonReports_Click);
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.Image = global::Ginger.Properties.Resources.Settings_01_96;
            this.ButtonSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(102, 115);
            this.ButtonSettings.Text = "Настройки";
            this.ButtonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // LeftPanel
            // 
            this.LeftPanel.AutoScroll = true;
            this.LeftPanel.Controls.Add(this.ToolStripButton);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(131, 570);
            this.LeftPanel.TabIndex = 3;
            // 
            // PanelCatalogue
            // 
            this.PanelCatalogue.Controls.Add(this.tableCatalogue);
            this.PanelCatalogue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCatalogue.Location = new System.Drawing.Point(131, 0);
            this.PanelCatalogue.Name = "PanelCatalogue";
            this.PanelCatalogue.Size = new System.Drawing.Size(801, 570);
            this.PanelCatalogue.TabIndex = 4;
            // 
            // tableCatalogue
            // 
            this.tableCatalogue.ColumnCount = 1;
            this.tableCatalogue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableCatalogue.Controls.Add(this.flowButtonsCatalogue, 0, 1);
            this.tableCatalogue.Controls.Add(this.dataGridCatalogue, 0, 0);
            this.tableCatalogue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableCatalogue.Location = new System.Drawing.Point(0, 0);
            this.tableCatalogue.Name = "tableCatalogue";
            this.tableCatalogue.RowCount = 3;
            this.tableCatalogue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableCatalogue.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableCatalogue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableCatalogue.Size = new System.Drawing.Size(801, 570);
            this.tableCatalogue.TabIndex = 9;
            // 
            // flowButtonsCatalogue
            // 
            this.flowButtonsCatalogue.AutoSize = true;
            this.flowButtonsCatalogue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowButtonsCatalogue.Controls.Add(this.ButtonToRented);
            this.flowButtonsCatalogue.Controls.Add(this.ButtonAdd);
            this.flowButtonsCatalogue.Controls.Add(this.ButtonEdit);
            this.flowButtonsCatalogue.Controls.Add(this.ButtonDelete);
            this.flowButtonsCatalogue.Location = new System.Drawing.Point(3, 533);
            this.flowButtonsCatalogue.Name = "flowButtonsCatalogue";
            this.flowButtonsCatalogue.Size = new System.Drawing.Size(324, 29);
            this.flowButtonsCatalogue.TabIndex = 10;
            // 
            // ButtonToRented
            // 
            this.ButtonToRented.Enabled = false;
            this.ButtonToRented.Location = new System.Drawing.Point(3, 3);
            this.ButtonToRented.Name = "ButtonToRented";
            this.ButtonToRented.Size = new System.Drawing.Size(75, 23);
            this.ButtonToRented.TabIndex = 5;
            this.ButtonToRented.Text = "Сдать";
            this.ButtonToRented.UseVisualStyleBackColor = true;
            this.ButtonToRented.Click += new System.EventHandler(this.ButtonFillGrid_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Enabled = false;
            this.ButtonAdd.Location = new System.Drawing.Point(84, 3);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 6;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Enabled = false;
            this.ButtonEdit.Location = new System.Drawing.Point(165, 3);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.ButtonEdit.TabIndex = 7;
            this.ButtonEdit.Text = "Изменить";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Enabled = false;
            this.ButtonDelete.Location = new System.Drawing.Point(246, 3);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 8;
            this.ButtonDelete.Text = "Удалить";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // dataGridCatalogue
            // 
            this.dataGridCatalogue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCatalogue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCatalogue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCatalogue.ContextMenuStrip = this.contextMenuCatalogue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCatalogue.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridCatalogue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridCatalogue.Location = new System.Drawing.Point(3, 3);
            this.dataGridCatalogue.Name = "dataGridCatalogue";
            this.dataGridCatalogue.Size = new System.Drawing.Size(795, 524);
            this.dataGridCatalogue.TabIndex = 1;
            this.dataGridCatalogue.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Catalogue_CellMouseDoubleClick);
            // 
            // contextMenuCatalogue
            // 
            this.contextMenuCatalogue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuToRentFromCatalogue,
            this.MenuToArchiveFromCatalogue});
            this.contextMenuCatalogue.Name = "contextMenuCatalogue";
            this.contextMenuCatalogue.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuCatalogue.Size = new System.Drawing.Size(116, 48);
            // 
            // MenuToRentFromCatalogue
            // 
            this.MenuToRentFromCatalogue.Name = "MenuToRentFromCatalogue";
            this.MenuToRentFromCatalogue.Size = new System.Drawing.Size(115, 22);
            this.MenuToRentFromCatalogue.Text = "Сдать";
            this.MenuToRentFromCatalogue.Click += new System.EventHandler(this.MenuToRentFromCatalogue_Click);
            // 
            // MenuToArchiveFromCatalogue
            // 
            this.MenuToArchiveFromCatalogue.Name = "MenuToArchiveFromCatalogue";
            this.MenuToArchiveFromCatalogue.Size = new System.Drawing.Size(115, 22);
            this.MenuToArchiveFromCatalogue.Text = "В архив";
            this.MenuToArchiveFromCatalogue.Click += new System.EventHandler(this.MenuToArchiveFromCatalogue_Click);
            // 
            // PanelRented
            // 
            this.PanelRented.Controls.Add(this.tableRented);
            this.PanelRented.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRented.Location = new System.Drawing.Point(131, 0);
            this.PanelRented.Name = "PanelRented";
            this.PanelRented.Size = new System.Drawing.Size(801, 570);
            this.PanelRented.TabIndex = 1;
            this.PanelRented.Visible = false;
            // 
            // tableRented
            // 
            this.tableRented.ColumnCount = 1;
            this.tableRented.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableRented.Controls.Add(this.flowButtonsRented, 0, 1);
            this.tableRented.Controls.Add(this.DataGridRented, 0, 0);
            this.tableRented.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableRented.Location = new System.Drawing.Point(0, 0);
            this.tableRented.Name = "tableRented";
            this.tableRented.RowCount = 3;
            this.tableRented.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableRented.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableRented.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableRented.Size = new System.Drawing.Size(801, 570);
            this.tableRented.TabIndex = 1;
            // 
            // flowButtonsRented
            // 
            this.flowButtonsRented.AutoSize = true;
            this.flowButtonsRented.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowButtonsRented.Controls.Add(this.ButtonToCatalogueFromRented);
            this.flowButtonsRented.Controls.Add(this.ButtonToArcFromRented);
            this.flowButtonsRented.Location = new System.Drawing.Point(3, 533);
            this.flowButtonsRented.Name = "flowButtonsRented";
            this.flowButtonsRented.Size = new System.Drawing.Size(162, 29);
            this.flowButtonsRented.TabIndex = 3;
            // 
            // ButtonToCatalogueFromRented
            // 
            this.ButtonToCatalogueFromRented.Enabled = false;
            this.ButtonToCatalogueFromRented.Location = new System.Drawing.Point(3, 3);
            this.ButtonToCatalogueFromRented.Name = "ButtonToCatalogueFromRented";
            this.ButtonToCatalogueFromRented.Size = new System.Drawing.Size(75, 23);
            this.ButtonToCatalogueFromRented.TabIndex = 2;
            this.ButtonToCatalogueFromRented.Text = "В активные";
            this.toolTipMain.SetToolTip(this.ButtonToCatalogueFromRented, "Клавиша помещает квартиру в каталог активных (свободных)");
            this.ButtonToCatalogueFromRented.UseVisualStyleBackColor = true;
            this.ButtonToCatalogueFromRented.Click += new System.EventHandler(this.MenuToActiveFromArchive_Click);
            // 
            // ButtonToArcFromRented
            // 
            this.ButtonToArcFromRented.Enabled = false;
            this.ButtonToArcFromRented.Location = new System.Drawing.Point(84, 3);
            this.ButtonToArcFromRented.Name = "ButtonToArcFromRented";
            this.ButtonToArcFromRented.Size = new System.Drawing.Size(75, 23);
            this.ButtonToArcFromRented.TabIndex = 4;
            this.ButtonToArcFromRented.Text = "В архив";
            this.ButtonToArcFromRented.UseVisualStyleBackColor = true;
            // 
            // DataGridRented
            // 
            this.DataGridRented.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridRented.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridRented.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridRented.ContextMenuStrip = this.contextMenuRented;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridRented.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridRented.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridRented.Location = new System.Drawing.Point(3, 3);
            this.DataGridRented.Name = "DataGridRented";
            this.DataGridRented.Size = new System.Drawing.Size(795, 524);
            this.DataGridRented.TabIndex = 0;
            // 
            // contextMenuRented
            // 
            this.contextMenuRented.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuToActiveFromRented,
            this.MenuToArchiveFromRented});
            this.contextMenuRented.Name = "contextMenuCatalogue";
            this.contextMenuRented.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuRented.Size = new System.Drawing.Size(183, 48);
            // 
            // MenuToActiveFromRented
            // 
            this.MenuToActiveFromRented.Name = "MenuToActiveFromRented";
            this.MenuToActiveFromRented.Size = new System.Drawing.Size(182, 22);
            this.MenuToActiveFromRented.Text = "Вернуть в активные";
            this.MenuToActiveFromRented.Click += new System.EventHandler(this.MenuToActiveFromRented_Click);
            // 
            // MenuToArchiveFromRented
            // 
            this.MenuToArchiveFromRented.Name = "MenuToArchiveFromRented";
            this.MenuToArchiveFromRented.Size = new System.Drawing.Size(182, 22);
            this.MenuToArchiveFromRented.Text = "В архив";
            this.MenuToArchiveFromRented.Click += new System.EventHandler(this.MenuToArchiveFromRented_Click);
            // 
            // PanelArchive
            // 
            this.PanelArchive.Controls.Add(this.tableArchive);
            this.PanelArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelArchive.Location = new System.Drawing.Point(131, 0);
            this.PanelArchive.Name = "PanelArchive";
            this.PanelArchive.Size = new System.Drawing.Size(801, 570);
            this.PanelArchive.TabIndex = 1;
            this.PanelArchive.Visible = false;
            // 
            // tableArchive
            // 
            this.tableArchive.ColumnCount = 1;
            this.tableArchive.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableArchive.Controls.Add(this.flowButtonsArchive, 0, 1);
            this.tableArchive.Controls.Add(this.DataGridArchive, 0, 0);
            this.tableArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableArchive.Location = new System.Drawing.Point(0, 0);
            this.tableArchive.Name = "tableArchive";
            this.tableArchive.RowCount = 3;
            this.tableArchive.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableArchive.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableArchive.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableArchive.Size = new System.Drawing.Size(801, 570);
            this.tableArchive.TabIndex = 0;
            // 
            // flowButtonsArchive
            // 
            this.flowButtonsArchive.AutoSize = true;
            this.flowButtonsArchive.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowButtonsArchive.Controls.Add(this.ButtonToCatalogueFromArc);
            this.flowButtonsArchive.Location = new System.Drawing.Point(3, 533);
            this.flowButtonsArchive.Name = "flowButtonsArchive";
            this.flowButtonsArchive.Size = new System.Drawing.Size(81, 29);
            this.flowButtonsArchive.TabIndex = 0;
            // 
            // ButtonToCatalogueFromArc
            // 
            this.ButtonToCatalogueFromArc.Enabled = false;
            this.ButtonToCatalogueFromArc.Location = new System.Drawing.Point(3, 3);
            this.ButtonToCatalogueFromArc.Name = "ButtonToCatalogueFromArc";
            this.ButtonToCatalogueFromArc.Size = new System.Drawing.Size(75, 23);
            this.ButtonToCatalogueFromArc.TabIndex = 0;
            this.ButtonToCatalogueFromArc.Text = "В активные";
            this.toolTipMain.SetToolTip(this.ButtonToCatalogueFromArc, "Клавиша возвращает квартиру в каталог активных (свободных)");
            this.ButtonToCatalogueFromArc.UseVisualStyleBackColor = true;
            // 
            // DataGridArchive
            // 
            this.DataGridArchive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridArchive.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridArchive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridArchive.ContextMenuStrip = this.contextMenuArchive;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridArchive.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridArchive.Location = new System.Drawing.Point(3, 3);
            this.DataGridArchive.Name = "DataGridArchive";
            this.DataGridArchive.Size = new System.Drawing.Size(795, 524);
            this.DataGridArchive.TabIndex = 1;
            // 
            // contextMenuArchive
            // 
            this.contextMenuArchive.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuToActiveFromArc});
            this.contextMenuArchive.Name = "contextMenuCatalogue";
            this.contextMenuArchive.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuArchive.Size = new System.Drawing.Size(183, 26);
            // 
            // MenuToActiveFromArc
            // 
            this.MenuToActiveFromArc.Name = "MenuToActiveFromArc";
            this.MenuToActiveFromArc.Size = new System.Drawing.Size(182, 22);
            this.MenuToActiveFromArc.Text = "Вернуть в активные";
            this.MenuToActiveFromArc.Click += new System.EventHandler(this.MenuToActiveFromArchive_Click);
            // 
            // PanelMeetings
            // 
            this.PanelMeetings.Controls.Add(this.lblMeetingsPanel);
            this.PanelMeetings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMeetings.Location = new System.Drawing.Point(131, 0);
            this.PanelMeetings.Name = "PanelMeetings";
            this.PanelMeetings.Size = new System.Drawing.Size(801, 570);
            this.PanelMeetings.TabIndex = 0;
            this.PanelMeetings.Visible = false;
            // 
            // lblMeetingsPanel
            // 
            this.lblMeetingsPanel.AutoSize = true;
            this.lblMeetingsPanel.Location = new System.Drawing.Point(13, 15);
            this.lblMeetingsPanel.Name = "lblMeetingsPanel";
            this.lblMeetingsPanel.Size = new System.Drawing.Size(48, 13);
            this.lblMeetingsPanel.TabIndex = 1;
            this.lblMeetingsPanel.Text = "Встречи";
            // 
            // PanelClients
            // 
            this.PanelClients.Controls.Add(this.lblClientsPanel);
            this.PanelClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelClients.Location = new System.Drawing.Point(131, 0);
            this.PanelClients.Name = "PanelClients";
            this.PanelClients.Size = new System.Drawing.Size(801, 570);
            this.PanelClients.TabIndex = 2;
            this.PanelClients.Visible = false;
            // 
            // lblClientsPanel
            // 
            this.lblClientsPanel.AutoSize = true;
            this.lblClientsPanel.Location = new System.Drawing.Point(17, 15);
            this.lblClientsPanel.Name = "lblClientsPanel";
            this.lblClientsPanel.Size = new System.Drawing.Size(51, 13);
            this.lblClientsPanel.TabIndex = 0;
            this.lblClientsPanel.Text = "Клиенты";
            // 
            // PanelAgents
            // 
            this.PanelAgents.Controls.Add(this.lblAgentsPanel);
            this.PanelAgents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAgents.Location = new System.Drawing.Point(131, 0);
            this.PanelAgents.Name = "PanelAgents";
            this.PanelAgents.Size = new System.Drawing.Size(801, 570);
            this.PanelAgents.TabIndex = 3;
            this.PanelAgents.Visible = false;
            // 
            // lblAgentsPanel
            // 
            this.lblAgentsPanel.AutoSize = true;
            this.lblAgentsPanel.Location = new System.Drawing.Point(17, 15);
            this.lblAgentsPanel.Name = "lblAgentsPanel";
            this.lblAgentsPanel.Size = new System.Drawing.Size(44, 13);
            this.lblAgentsPanel.TabIndex = 4;
            this.lblAgentsPanel.Text = "Агенты";
            // 
            // PanelReports
            // 
            this.PanelReports.Controls.Add(this.lblReportsPanel);
            this.PanelReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelReports.Location = new System.Drawing.Point(131, 0);
            this.PanelReports.Name = "PanelReports";
            this.PanelReports.Size = new System.Drawing.Size(801, 570);
            this.PanelReports.TabIndex = 1;
            this.PanelReports.Visible = false;
            // 
            // lblReportsPanel
            // 
            this.lblReportsPanel.AutoSize = true;
            this.lblReportsPanel.Location = new System.Drawing.Point(17, 15);
            this.lblReportsPanel.Name = "lblReportsPanel";
            this.lblReportsPanel.Size = new System.Drawing.Size(44, 13);
            this.lblReportsPanel.TabIndex = 3;
            this.lblReportsPanel.Text = "Отчеты";
            // 
            // PanelSettings
            // 
            this.PanelSettings.Controls.Add(this.groupColorIndication);
            this.PanelSettings.Controls.Add(this.ButtonAdminAccess);
            this.PanelSettings.Controls.Add(this.groupDBSetting);
            this.PanelSettings.Controls.Add(this.flowPicturePath);
            this.PanelSettings.Controls.Add(this.ButtonCancelIni);
            this.PanelSettings.Controls.Add(this.ButtonSaveIni);
            this.PanelSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelSettings.Location = new System.Drawing.Point(131, 0);
            this.PanelSettings.Name = "PanelSettings";
            this.PanelSettings.Size = new System.Drawing.Size(801, 570);
            this.PanelSettings.TabIndex = 4;
            this.toolTipMain.SetToolTip(this.PanelSettings, "Доступ");
            this.PanelSettings.Visible = false;
            // 
            // groupColorIndication
            // 
            this.groupColorIndication.Controls.Add(this.flowDaysTooLittle);
            this.groupColorIndication.Controls.Add(this.flowDaysLittle);
            this.groupColorIndication.Location = new System.Drawing.Point(13, 144);
            this.groupColorIndication.Name = "groupColorIndication";
            this.groupColorIndication.Size = new System.Drawing.Size(564, 102);
            this.groupColorIndication.TabIndex = 3;
            this.groupColorIndication.TabStop = false;
            this.groupColorIndication.Text = "Индикация";
            // 
            // flowDaysTooLittle
            // 
            this.flowDaysTooLittle.AutoSize = true;
            this.flowDaysTooLittle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowDaysTooLittle.Controls.Add(this.lblDaysTooLittle);
            this.flowDaysTooLittle.Controls.Add(this.maskDaysTooLittle);
            this.flowDaysTooLittle.Controls.Add(this.ColorForDaysTooLittle);
            this.flowDaysTooLittle.Location = new System.Drawing.Point(16, 58);
            this.flowDaysTooLittle.Name = "flowDaysTooLittle";
            this.flowDaysTooLittle.Size = new System.Drawing.Size(240, 36);
            this.flowDaysTooLittle.TabIndex = 1;
            // 
            // lblDaysTooLittle
            // 
            this.lblDaysTooLittle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDaysTooLittle.AutoSize = true;
            this.lblDaysTooLittle.Location = new System.Drawing.Point(3, 11);
            this.lblDaysTooLittle.Name = "lblDaysTooLittle";
            this.lblDaysTooLittle.Size = new System.Drawing.Size(147, 13);
            this.lblDaysTooLittle.TabIndex = 0;
            this.lblDaysTooLittle.Text = "Осталось очень мало дней:";
            // 
            // maskDaysTooLittle
            // 
            this.maskDaysTooLittle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.maskDaysTooLittle.Location = new System.Drawing.Point(156, 8);
            this.maskDaysTooLittle.Mask = "00000";
            this.maskDaysTooLittle.Name = "maskDaysTooLittle";
            this.maskDaysTooLittle.ResetOnPrompt = false;
            this.maskDaysTooLittle.ResetOnSpace = false;
            this.maskDaysTooLittle.Size = new System.Drawing.Size(45, 20);
            this.maskDaysTooLittle.TabIndex = 1;
            this.maskDaysTooLittle.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskDaysTooLittle.ValidatingType = typeof(int);
            this.maskDaysTooLittle.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.MaskDaysTooLittle_TypeValidationCompleted);
            // 
            // ColorForDaysTooLittle
            // 
            this.ColorForDaysTooLittle.BackColor = System.Drawing.Color.Fuchsia;
            this.ColorForDaysTooLittle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorForDaysTooLittle.Location = new System.Drawing.Point(207, 3);
            this.ColorForDaysTooLittle.Name = "ColorForDaysTooLittle";
            this.ColorForDaysTooLittle.Size = new System.Drawing.Size(30, 30);
            this.ColorForDaysTooLittle.TabIndex = 9;
            this.ColorForDaysTooLittle.TabStop = false;
            this.toolTipMain.SetToolTip(this.ColorForDaysTooLittle, "Дважды щелкните мышкой для выбора цвета");
            this.ColorForDaysTooLittle.DoubleClick += new System.EventHandler(this.ColorForDaysTooLittle_DoubleClick);
            // 
            // flowDaysLittle
            // 
            this.flowDaysLittle.AutoSize = true;
            this.flowDaysLittle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowDaysLittle.Controls.Add(this.lblDaysLittle);
            this.flowDaysLittle.Controls.Add(this.maskDaysLittle);
            this.flowDaysLittle.Controls.Add(this.ColorForDaysLittle);
            this.flowDaysLittle.Location = new System.Drawing.Point(48, 19);
            this.flowDaysLittle.Name = "flowDaysLittle";
            this.flowDaysLittle.Size = new System.Drawing.Size(208, 36);
            this.flowDaysLittle.TabIndex = 0;
            // 
            // lblDaysLittle
            // 
            this.lblDaysLittle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDaysLittle.AutoSize = true;
            this.lblDaysLittle.Location = new System.Drawing.Point(3, 11);
            this.lblDaysLittle.Name = "lblDaysLittle";
            this.lblDaysLittle.Size = new System.Drawing.Size(115, 13);
            this.lblDaysLittle.TabIndex = 0;
            this.lblDaysLittle.Text = "Осталось мало дней:";
            // 
            // maskDaysLittle
            // 
            this.maskDaysLittle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.maskDaysLittle.Location = new System.Drawing.Point(124, 8);
            this.maskDaysLittle.Mask = "00000";
            this.maskDaysLittle.Name = "maskDaysLittle";
            this.maskDaysLittle.ResetOnPrompt = false;
            this.maskDaysLittle.ResetOnSpace = false;
            this.maskDaysLittle.Size = new System.Drawing.Size(45, 20);
            this.maskDaysLittle.TabIndex = 1;
            this.maskDaysLittle.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskDaysLittle.ValidatingType = typeof(int);
            this.maskDaysLittle.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.MaskDaysLittle_TypeValidationCompleted);
            // 
            // ColorForDaysLittle
            // 
            this.ColorForDaysLittle.BackColor = System.Drawing.Color.Yellow;
            this.ColorForDaysLittle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorForDaysLittle.Location = new System.Drawing.Point(175, 3);
            this.ColorForDaysLittle.Name = "ColorForDaysLittle";
            this.ColorForDaysLittle.Size = new System.Drawing.Size(30, 30);
            this.ColorForDaysLittle.TabIndex = 9;
            this.ColorForDaysLittle.TabStop = false;
            this.toolTipMain.SetToolTip(this.ColorForDaysLittle, "Дважды щелкните мышкой для выбора цвета");
            this.ColorForDaysLittle.DoubleClick += new System.EventHandler(this.ColorForDaysLittle_DoubleClick);
            // 
            // ButtonAdminAccess
            // 
            this.ButtonAdminAccess.AutoSize = true;
            this.ButtonAdminAccess.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonAdminAccess.Image = global::Ginger.Properties.Resources.Button_OFF_64x64;
            this.ButtonAdminAccess.Location = new System.Drawing.Point(583, 21);
            this.ButtonAdminAccess.Name = "ButtonAdminAccess";
            this.ButtonAdminAccess.Padding = new System.Windows.Forms.Padding(1);
            this.ButtonAdminAccess.Size = new System.Drawing.Size(72, 72);
            this.ButtonAdminAccess.TabIndex = 6;
            this.ButtonAdminAccess.Tag = "off";
            this.ButtonAdminAccess.UseVisualStyleBackColor = true;
            this.ButtonAdminAccess.Click += new System.EventHandler(this.ButtonAdminAccess_Click);
            // 
            // groupDBSetting
            // 
            this.groupDBSetting.AutoSize = true;
            this.groupDBSetting.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupDBSetting.Controls.Add(this.ButtonCreateDB);
            this.groupDBSetting.Controls.Add(this.ButtonCheckConnection);
            this.groupDBSetting.Controls.Add(this.flowConnectionString);
            this.groupDBSetting.Location = new System.Drawing.Point(13, 16);
            this.groupDBSetting.Name = "groupDBSetting";
            this.groupDBSetting.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.groupDBSetting.Size = new System.Drawing.Size(564, 87);
            this.groupDBSetting.TabIndex = 5;
            this.groupDBSetting.TabStop = false;
            this.groupDBSetting.Text = "Настройки БД";
            // 
            // ButtonCreateDB
            // 
            this.ButtonCreateDB.Enabled = false;
            this.ButtonCreateDB.Location = new System.Drawing.Point(216, 48);
            this.ButtonCreateDB.Name = "ButtonCreateDB";
            this.ButtonCreateDB.Size = new System.Drawing.Size(95, 23);
            this.ButtonCreateDB.TabIndex = 3;
            this.ButtonCreateDB.Text = "Создать базу";
            this.ButtonCreateDB.UseVisualStyleBackColor = true;
            this.ButtonCreateDB.Click += new System.EventHandler(this.ButtonCreateDB_Click);
            // 
            // ButtonCheckConnection
            // 
            this.ButtonCheckConnection.Location = new System.Drawing.Point(135, 48);
            this.ButtonCheckConnection.Name = "ButtonCheckConnection";
            this.ButtonCheckConnection.Size = new System.Drawing.Size(75, 23);
            this.ButtonCheckConnection.TabIndex = 2;
            this.ButtonCheckConnection.Text = "Проверить";
            this.ButtonCheckConnection.UseVisualStyleBackColor = true;
            this.ButtonCheckConnection.Click += new System.EventHandler(this.ButtonCheckConnection_Click);
            // 
            // flowConnectionString
            // 
            this.flowConnectionString.AutoSize = true;
            this.flowConnectionString.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowConnectionString.Controls.Add(this.lblConnectionString);
            this.flowConnectionString.Controls.Add(this.boxConnectionString);
            this.flowConnectionString.Location = new System.Drawing.Point(10, 19);
            this.flowConnectionString.Name = "flowConnectionString";
            this.flowConnectionString.Size = new System.Drawing.Size(548, 26);
            this.flowConnectionString.TabIndex = 1;
            // 
            // lblConnectionString
            // 
            this.lblConnectionString.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblConnectionString.AutoSize = true;
            this.lblConnectionString.Location = new System.Drawing.Point(3, 6);
            this.lblConnectionString.Name = "lblConnectionString";
            this.lblConnectionString.Size = new System.Drawing.Size(116, 13);
            this.lblConnectionString.TabIndex = 0;
            this.lblConnectionString.Text = "Строка подключения:";
            this.toolTipMain.SetToolTip(this.lblConnectionString, "Строка соединения с базой данных");
            // 
            // boxConnectionString
            // 
            this.boxConnectionString.Location = new System.Drawing.Point(125, 3);
            this.boxConnectionString.Name = "boxConnectionString";
            this.boxConnectionString.Size = new System.Drawing.Size(420, 20);
            this.boxConnectionString.TabIndex = 0;
            this.toolTipMain.SetToolTip(this.boxConnectionString, "Строка соединения с базой данных");
            this.boxConnectionString.UseSystemPasswordChar = true;
            // 
            // flowPicturePath
            // 
            this.flowPicturePath.AutoSize = true;
            this.flowPicturePath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowPicturePath.Controls.Add(this.lblPicturePath);
            this.flowPicturePath.Controls.Add(this.boxPicturePath);
            this.flowPicturePath.Controls.Add(this.ButtonSelectPictureFolder);
            this.flowPicturePath.Location = new System.Drawing.Point(23, 109);
            this.flowPicturePath.Name = "flowPicturePath";
            this.flowPicturePath.Size = new System.Drawing.Size(551, 29);
            this.flowPicturePath.TabIndex = 4;
            // 
            // lblPicturePath
            // 
            this.lblPicturePath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPicturePath.AutoSize = true;
            this.lblPicturePath.Location = new System.Drawing.Point(3, 8);
            this.lblPicturePath.Name = "lblPicturePath";
            this.lblPicturePath.Size = new System.Drawing.Size(185, 13);
            this.lblPicturePath.TabIndex = 0;
            this.lblPicturePath.Text = "Путь к каталогу с изображениями:";
            // 
            // boxPicturePath
            // 
            this.boxPicturePath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.boxPicturePath.Location = new System.Drawing.Point(194, 4);
            this.boxPicturePath.Name = "boxPicturePath";
            this.boxPicturePath.Size = new System.Drawing.Size(322, 20);
            this.boxPicturePath.TabIndex = 0;
            this.boxPicturePath.UseSystemPasswordChar = true;
            // 
            // ButtonSelectPictureFolder
            // 
            this.ButtonSelectPictureFolder.AutoSize = true;
            this.ButtonSelectPictureFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonSelectPictureFolder.Location = new System.Drawing.Point(522, 3);
            this.ButtonSelectPictureFolder.Name = "ButtonSelectPictureFolder";
            this.ButtonSelectPictureFolder.Size = new System.Drawing.Size(26, 23);
            this.ButtonSelectPictureFolder.TabIndex = 2;
            this.ButtonSelectPictureFolder.Text = "...";
            this.ButtonSelectPictureFolder.UseVisualStyleBackColor = true;
            this.ButtonSelectPictureFolder.Click += new System.EventHandler(this.ButtonSelectPictureFolder_Click);
            // 
            // ButtonCancelIni
            // 
            this.ButtonCancelIni.Location = new System.Drawing.Point(108, 349);
            this.ButtonCancelIni.Name = "ButtonCancelIni";
            this.ButtonCancelIni.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancelIni.TabIndex = 0;
            this.ButtonCancelIni.Text = "Отменить";
            this.ButtonCancelIni.UseVisualStyleBackColor = true;
            this.ButtonCancelIni.Click += new System.EventHandler(this.ButtonCancelIni_Click);
            // 
            // ButtonSaveIni
            // 
            this.ButtonSaveIni.Location = new System.Drawing.Point(27, 349);
            this.ButtonSaveIni.Name = "ButtonSaveIni";
            this.ButtonSaveIni.Size = new System.Drawing.Size(75, 23);
            this.ButtonSaveIni.TabIndex = 4;
            this.ButtonSaveIni.Text = "Сохранить";
            this.ButtonSaveIni.UseVisualStyleBackColor = true;
            this.ButtonSaveIni.Click += new System.EventHandler(this.ButtonSaveIni_Click);
            // 
            // PanelStart
            // 
            this.PanelStart.Controls.Add(this.panelWebBrowser);
            this.PanelStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelStart.Location = new System.Drawing.Point(131, 0);
            this.PanelStart.Name = "PanelStart";
            this.PanelStart.Size = new System.Drawing.Size(801, 570);
            this.PanelStart.TabIndex = 9;
            // 
            // panelWebBrowser
            // 
            this.panelWebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelWebBrowser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWebBrowser.Controls.Add(this.button1);
            this.panelWebBrowser.Location = new System.Drawing.Point(22, 15);
            this.panelWebBrowser.Name = "panelWebBrowser";
            this.panelWebBrowser.Size = new System.Drawing.Size(756, 528);
            this.panelWebBrowser.TabIndex = 1;
            // 
            // colorSelectDialog
            // 
            this.colorSelectDialog.AllowFullOpen = false;
            this.colorSelectDialog.ShowHelp = true;
            this.colorSelectDialog.SolidColorOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 592);
            this.Controls.Add(this.PanelStart);
            this.Controls.Add(this.PanelCatalogue);
            this.Controls.Add(this.PanelRented);
            this.Controls.Add(this.PanelArchive);
            this.Controls.Add(this.PanelSettings);
            this.Controls.Add(this.PanelAgents);
            this.Controls.Add(this.PanelMeetings);
            this.Controls.Add(this.PanelReports);
            this.Controls.Add(this.PanelClients);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.StatusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Имбирь";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ToolStripButton.ResumeLayout(false);
            this.ToolStripButton.PerformLayout();
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.PanelCatalogue.ResumeLayout(false);
            this.tableCatalogue.ResumeLayout(false);
            this.tableCatalogue.PerformLayout();
            this.flowButtonsCatalogue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCatalogue)).EndInit();
            this.contextMenuCatalogue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CatalogBindingSrc)).EndInit();
            this.PanelRented.ResumeLayout(false);
            this.tableRented.ResumeLayout(false);
            this.tableRented.PerformLayout();
            this.flowButtonsRented.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridRented)).EndInit();
            this.contextMenuRented.ResumeLayout(false);
            this.PanelArchive.ResumeLayout(false);
            this.tableArchive.ResumeLayout(false);
            this.tableArchive.PerformLayout();
            this.flowButtonsArchive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridArchive)).EndInit();
            this.contextMenuArchive.ResumeLayout(false);
            this.PanelMeetings.ResumeLayout(false);
            this.PanelMeetings.PerformLayout();
            this.PanelClients.ResumeLayout(false);
            this.PanelClients.PerformLayout();
            this.PanelAgents.ResumeLayout(false);
            this.PanelAgents.PerformLayout();
            this.PanelReports.ResumeLayout(false);
            this.PanelReports.PerformLayout();
            this.PanelSettings.ResumeLayout(false);
            this.PanelSettings.PerformLayout();
            this.groupColorIndication.ResumeLayout(false);
            this.groupColorIndication.PerformLayout();
            this.flowDaysTooLittle.ResumeLayout(false);
            this.flowDaysTooLittle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorForDaysTooLittle)).EndInit();
            this.flowDaysLittle.ResumeLayout(false);
            this.flowDaysLittle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorForDaysLittle)).EndInit();
            this.groupDBSetting.ResumeLayout(false);
            this.groupDBSetting.PerformLayout();
            this.flowConnectionString.ResumeLayout(false);
            this.flowConnectionString.PerformLayout();
            this.flowPicturePath.ResumeLayout(false);
            this.flowPicturePath.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArcBindingSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentedBindingSource)).EndInit();
            this.PanelStart.ResumeLayout(false);
            this.panelWebBrowser.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip StatusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip ToolStripButton;
        private System.Windows.Forms.ToolStripButton ButtonCatalogue;
        private System.Windows.Forms.ToolStripButton ButtonRented;
        private System.Windows.Forms.ToolStripButton ButtonArchive;
        private System.Windows.Forms.ToolStripButton ButtonMeetings;
        private System.Windows.Forms.ToolStripButton ButtonClients;
        private System.Windows.Forms.ToolStripButton ButtonAgents;
        private System.Windows.Forms.ToolStripButton ButtonReports;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel PanelCatalogue;
        private System.Windows.Forms.Panel PanelRented;
        private System.Windows.Forms.DataGridView DataGridRented;
        private System.Windows.Forms.ToolStripButton ButtonSettings;
        private System.Windows.Forms.Panel PanelArchive;
        private System.Windows.Forms.Panel PanelAgents;
        private System.Windows.Forms.Panel PanelClients;
        private System.Windows.Forms.Panel PanelReports;
        private System.Windows.Forms.Panel PanelMeetings;
        private System.Windows.Forms.Panel PanelSettings;
        private System.Windows.Forms.Label lblClientsPanel;
        private System.Windows.Forms.Label lblMeetingsPanel;
        private System.Windows.Forms.Label lblReportsPanel;
        private System.Windows.Forms.Label lblAgentsPanel;
        private System.Windows.Forms.Button ButtonToRented;
        private System.Windows.Forms.DataGridView dataGridCatalogue;
        private System.Windows.Forms.BindingSource CatalogBindingSrc;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.FlowLayoutPanel flowConnectionString;
        private System.Windows.Forms.Label lblConnectionString;
        private System.Windows.Forms.TextBox boxConnectionString;
        private System.Windows.Forms.ToolTip toolTipMain;
        private System.Windows.Forms.Button ButtonSaveIni;
        private System.Windows.Forms.Button ButtonCancelIni;
        private System.Windows.Forms.ContextMenuStrip contextMenuCatalogue;
        private System.Windows.Forms.ToolStripMenuItem MenuToArchiveFromCatalogue;
        private System.Windows.Forms.FlowLayoutPanel flowButtonsCatalogue;
        private System.Windows.Forms.TableLayoutPanel tableCatalogue;
        private System.Windows.Forms.FlowLayoutPanel flowPicturePath;
        private System.Windows.Forms.Label lblPicturePath;
        private System.Windows.Forms.TextBox boxPicturePath;
        private System.Windows.Forms.TableLayoutPanel tableRented;
        private System.Windows.Forms.FlowLayoutPanel flowButtonsRented;
        private System.Windows.Forms.Button ButtonToCatalogueFromRented;
        private System.Windows.Forms.Button ButtonToArcFromRented;
        private System.Windows.Forms.TableLayoutPanel tableArchive;
        private System.Windows.Forms.FlowLayoutPanel flowButtonsArchive;
        private System.Windows.Forms.Button ButtonToCatalogueFromArc;
        private System.Windows.Forms.DataGridView DataGridArchive;
        private System.Windows.Forms.BindingSource ArcBindingSrc;
        private System.Windows.Forms.BindingSource RentedBindingSource;
        private System.Windows.Forms.Panel PanelStart;
        private System.Windows.Forms.Panel panelWebBrowser;
        private System.Windows.Forms.GroupBox groupDBSetting;
        private System.Windows.Forms.Button ButtonCheckConnection;
        private System.Windows.Forms.Button ButtonSelectPictureFolder;
        private System.Windows.Forms.FolderBrowserDialog dlgFolderSelect;
        private System.Windows.Forms.Button ButtonAdminAccess;
        private System.Windows.Forms.GroupBox groupColorIndication;
        private System.Windows.Forms.FlowLayoutPanel flowDaysLittle;
        private System.Windows.Forms.Label lblDaysLittle;
        private System.Windows.Forms.Button ButtonCreateDB;
        private System.Windows.Forms.ColorDialog colorSelectDialog;
        private System.Windows.Forms.PictureBox ColorForDaysLittle;
        private System.Windows.Forms.FlowLayoutPanel flowDaysTooLittle;
        private System.Windows.Forms.Label lblDaysTooLittle;
        private System.Windows.Forms.PictureBox ColorForDaysTooLittle;
        private System.Windows.Forms.MaskedTextBox maskDaysLittle;
        private System.Windows.Forms.MaskedTextBox maskDaysTooLittle;
        private System.Windows.Forms.ToolStripMenuItem MenuToRentFromCatalogue;
        private System.Windows.Forms.ContextMenuStrip contextMenuArchive;
        private System.Windows.Forms.ToolStripMenuItem MenuToActiveFromArc;
        private System.Windows.Forms.ContextMenuStrip contextMenuRented;
        private System.Windows.Forms.ToolStripMenuItem MenuToActiveFromRented;
        private System.Windows.Forms.ToolStripMenuItem MenuToArchiveFromRented;
        private System.Windows.Forms.Button button1;
    }
}

