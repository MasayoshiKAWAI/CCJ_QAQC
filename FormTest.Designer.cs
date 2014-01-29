namespace CCJ_QAQC
{
    partial class FormTest
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label ユーザーコードLabel;
            System.Windows.Forms.Label 名称Label;
            System.Windows.Forms.Label 郵便番号Label;
            System.Windows.Forms.Label 住所１Label;
            System.Windows.Forms.Label 住所２Label;
            System.Windows.Forms.Label 担当者Label;
            System.Windows.Forms.Label 電話番号Label;
            System.Windows.Forms.Label ｆＡＸ番号Label;
            System.Windows.Forms.Label 送付先名称Label;
            System.Windows.Forms.Label 送付先郵便番号Label;
            System.Windows.Forms.Label 送付先住所１Label;
            System.Windows.Forms.Label 送付先住所２Label;
            System.Windows.Forms.Label 送付先担当者Label;
            System.Windows.Forms.Label 送付先電話番号Label;
            System.Windows.Forms.Label 削除フラグLabel;
            System.Windows.Forms.Label 登録日Label;
            System.Windows.Forms.Label 登録IDLabel;
            System.Windows.Forms.Label 更新日Label;
            System.Windows.Forms.Label 更新IDLabel;
            System.Windows.Forms.Label 表示順Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTest));
            this.mユーザーBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cCJ2DataSetHP8100 = new CCJ_QAQC.CCJ2DataSetHP8100();
            this.m_ユーザーTableAdapter = new CCJ_QAQC.CCJ2DataSetHP8100TableAdapters.M_ユーザーTableAdapter();
            this.tableAdapterManager = new CCJ_QAQC.CCJ2DataSetHP8100TableAdapters.TableAdapterManager();
            this.ユーザーコードTextBox = new Kawai.ApplicationBase.SearchCritriaTextBox();
            this.名称TextBox = new Kawai.ApplicationBase.SearchCritriaTextBox();
            this.郵便番号TextBox = new System.Windows.Forms.TextBox();
            this.住所１TextBox = new System.Windows.Forms.TextBox();
            this.住所２TextBox = new System.Windows.Forms.TextBox();
            this.担当者TextBox = new System.Windows.Forms.TextBox();
            this.電話番号TextBox = new System.Windows.Forms.TextBox();
            this.ｆＡＸ番号TextBox = new System.Windows.Forms.TextBox();
            this.送付先名称TextBox = new System.Windows.Forms.TextBox();
            this.送付先郵便番号TextBox = new System.Windows.Forms.TextBox();
            this.送付先住所１TextBox = new System.Windows.Forms.TextBox();
            this.送付先住所２TextBox = new System.Windows.Forms.TextBox();
            this.送付先担当者TextBox = new System.Windows.Forms.TextBox();
            this.送付先電話番号TextBox = new System.Windows.Forms.TextBox();
            this.削除フラグTextBox = new System.Windows.Forms.TextBox();
            this.登録日DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.登録IDTextBox = new System.Windows.Forms.TextBox();
            this.更新日DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.更新IDTextBox = new System.Windows.Forms.TextBox();
            this.表示順TextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonClassTest = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.新規作成NToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.開くOToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.上書き保存SToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.印刷PToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.切り取りUToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.コピーCToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.貼り付けPToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ヘルプLToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSearchModeON = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer3 = new System.Windows.Forms.ToolStripContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.dataSet検査ワークシート = new CCJ_QAQC.DataSet検査ワークシート();
            this._x_Study1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._x_Study1TableAdapter = new CCJ_QAQC.DataSet検査ワークシートTableAdapters._x_Study1TableAdapter();
            this.tableAdapterManager1 = new CCJ_QAQC.DataSet検査ワークシートTableAdapters.TableAdapterManager();
            this._x_Study1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ユーザーコードLabel = new System.Windows.Forms.Label();
            名称Label = new System.Windows.Forms.Label();
            郵便番号Label = new System.Windows.Forms.Label();
            住所１Label = new System.Windows.Forms.Label();
            住所２Label = new System.Windows.Forms.Label();
            担当者Label = new System.Windows.Forms.Label();
            電話番号Label = new System.Windows.Forms.Label();
            ｆＡＸ番号Label = new System.Windows.Forms.Label();
            送付先名称Label = new System.Windows.Forms.Label();
            送付先郵便番号Label = new System.Windows.Forms.Label();
            送付先住所１Label = new System.Windows.Forms.Label();
            送付先住所２Label = new System.Windows.Forms.Label();
            送付先担当者Label = new System.Windows.Forms.Label();
            送付先電話番号Label = new System.Windows.Forms.Label();
            削除フラグLabel = new System.Windows.Forms.Label();
            登録日Label = new System.Windows.Forms.Label();
            登録IDLabel = new System.Windows.Forms.Label();
            更新日Label = new System.Windows.Forms.Label();
            更新IDLabel = new System.Windows.Forms.Label();
            表示順Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mユーザーBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCJ2DataSetHP8100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStripContainer3.ContentPanel.SuspendLayout();
            this.toolStripContainer3.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet検査ワークシート)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._x_Study1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._x_Study1DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.Location = new System.Drawing.Point(965, 630);
            // 
            // ユーザーコードLabel
            // 
            ユーザーコードLabel.AutoSize = true;
            ユーザーコードLabel.Location = new System.Drawing.Point(164, 19);
            ユーザーコードLabel.Name = "ユーザーコードLabel";
            ユーザーコードLabel.Size = new System.Drawing.Size(97, 18);
            ユーザーコードLabel.TabIndex = 4;
            ユーザーコードLabel.Text = "ユーザーコード:";
            // 
            // 名称Label
            // 
            名称Label.AutoSize = true;
            名称Label.Location = new System.Drawing.Point(164, 50);
            名称Label.Name = "名称Label";
            名称Label.Size = new System.Drawing.Size(37, 18);
            名称Label.TabIndex = 6;
            名称Label.Text = "名称:";
            // 
            // 郵便番号Label
            // 
            郵便番号Label.AutoSize = true;
            郵便番号Label.Location = new System.Drawing.Point(164, 81);
            郵便番号Label.Name = "郵便番号Label";
            郵便番号Label.Size = new System.Drawing.Size(61, 18);
            郵便番号Label.TabIndex = 8;
            郵便番号Label.Text = "郵便番号:";
            // 
            // 住所１Label
            // 
            住所１Label.AutoSize = true;
            住所１Label.Location = new System.Drawing.Point(164, 112);
            住所１Label.Name = "住所１Label";
            住所１Label.Size = new System.Drawing.Size(49, 18);
            住所１Label.TabIndex = 10;
            住所１Label.Text = "住所１:";
            // 
            // 住所２Label
            // 
            住所２Label.AutoSize = true;
            住所２Label.Location = new System.Drawing.Point(164, 143);
            住所２Label.Name = "住所２Label";
            住所２Label.Size = new System.Drawing.Size(49, 18);
            住所２Label.TabIndex = 12;
            住所２Label.Text = "住所２:";
            // 
            // 担当者Label
            // 
            担当者Label.AutoSize = true;
            担当者Label.Location = new System.Drawing.Point(164, 174);
            担当者Label.Name = "担当者Label";
            担当者Label.Size = new System.Drawing.Size(49, 18);
            担当者Label.TabIndex = 14;
            担当者Label.Text = "担当者:";
            // 
            // 電話番号Label
            // 
            電話番号Label.AutoSize = true;
            電話番号Label.Location = new System.Drawing.Point(164, 205);
            電話番号Label.Name = "電話番号Label";
            電話番号Label.Size = new System.Drawing.Size(61, 18);
            電話番号Label.TabIndex = 16;
            電話番号Label.Text = "電話番号:";
            // 
            // ｆＡＸ番号Label
            // 
            ｆＡＸ番号Label.AutoSize = true;
            ｆＡＸ番号Label.Location = new System.Drawing.Point(164, 236);
            ｆＡＸ番号Label.Name = "ｆＡＸ番号Label";
            ｆＡＸ番号Label.Size = new System.Drawing.Size(73, 18);
            ｆＡＸ番号Label.TabIndex = 18;
            ｆＡＸ番号Label.Text = "ＦＡＸ番号:";
            // 
            // 送付先名称Label
            // 
            送付先名称Label.AutoSize = true;
            送付先名称Label.Location = new System.Drawing.Point(164, 267);
            送付先名称Label.Name = "送付先名称Label";
            送付先名称Label.Size = new System.Drawing.Size(73, 18);
            送付先名称Label.TabIndex = 20;
            送付先名称Label.Text = "送付先名称:";
            // 
            // 送付先郵便番号Label
            // 
            送付先郵便番号Label.AutoSize = true;
            送付先郵便番号Label.Location = new System.Drawing.Point(164, 298);
            送付先郵便番号Label.Name = "送付先郵便番号Label";
            送付先郵便番号Label.Size = new System.Drawing.Size(97, 18);
            送付先郵便番号Label.TabIndex = 22;
            送付先郵便番号Label.Text = "送付先郵便番号:";
            // 
            // 送付先住所１Label
            // 
            送付先住所１Label.AutoSize = true;
            送付先住所１Label.Location = new System.Drawing.Point(164, 329);
            送付先住所１Label.Name = "送付先住所１Label";
            送付先住所１Label.Size = new System.Drawing.Size(85, 18);
            送付先住所１Label.TabIndex = 24;
            送付先住所１Label.Text = "送付先住所１:";
            // 
            // 送付先住所２Label
            // 
            送付先住所２Label.AutoSize = true;
            送付先住所２Label.Location = new System.Drawing.Point(164, 360);
            送付先住所２Label.Name = "送付先住所２Label";
            送付先住所２Label.Size = new System.Drawing.Size(85, 18);
            送付先住所２Label.TabIndex = 26;
            送付先住所２Label.Text = "送付先住所２:";
            // 
            // 送付先担当者Label
            // 
            送付先担当者Label.AutoSize = true;
            送付先担当者Label.Location = new System.Drawing.Point(164, 391);
            送付先担当者Label.Name = "送付先担当者Label";
            送付先担当者Label.Size = new System.Drawing.Size(85, 18);
            送付先担当者Label.TabIndex = 28;
            送付先担当者Label.Text = "送付先担当者:";
            // 
            // 送付先電話番号Label
            // 
            送付先電話番号Label.AutoSize = true;
            送付先電話番号Label.Location = new System.Drawing.Point(164, 422);
            送付先電話番号Label.Name = "送付先電話番号Label";
            送付先電話番号Label.Size = new System.Drawing.Size(97, 18);
            送付先電話番号Label.TabIndex = 30;
            送付先電話番号Label.Text = "送付先電話番号:";
            // 
            // 削除フラグLabel
            // 
            削除フラグLabel.AutoSize = true;
            削除フラグLabel.Location = new System.Drawing.Point(164, 453);
            削除フラグLabel.Name = "削除フラグLabel";
            削除フラグLabel.Size = new System.Drawing.Size(73, 18);
            削除フラグLabel.TabIndex = 32;
            削除フラグLabel.Text = "削除フラグ:";
            // 
            // 登録日Label
            // 
            登録日Label.AutoSize = true;
            登録日Label.Location = new System.Drawing.Point(164, 485);
            登録日Label.Name = "登録日Label";
            登録日Label.Size = new System.Drawing.Size(49, 18);
            登録日Label.TabIndex = 34;
            登録日Label.Text = "登録日:";
            // 
            // 登録IDLabel
            // 
            登録IDLabel.AutoSize = true;
            登録IDLabel.Location = new System.Drawing.Point(164, 515);
            登録IDLabel.Name = "登録IDLabel";
            登録IDLabel.Size = new System.Drawing.Size(51, 18);
            登録IDLabel.TabIndex = 36;
            登録IDLabel.Text = "登録ID:";
            // 
            // 更新日Label
            // 
            更新日Label.AutoSize = true;
            更新日Label.Location = new System.Drawing.Point(164, 547);
            更新日Label.Name = "更新日Label";
            更新日Label.Size = new System.Drawing.Size(49, 18);
            更新日Label.TabIndex = 38;
            更新日Label.Text = "更新日:";
            // 
            // 更新IDLabel
            // 
            更新IDLabel.AutoSize = true;
            更新IDLabel.Location = new System.Drawing.Point(164, 577);
            更新IDLabel.Name = "更新IDLabel";
            更新IDLabel.Size = new System.Drawing.Size(51, 18);
            更新IDLabel.TabIndex = 40;
            更新IDLabel.Text = "更新ID:";
            // 
            // 表示順Label
            // 
            表示順Label.AutoSize = true;
            表示順Label.Location = new System.Drawing.Point(164, 608);
            表示順Label.Name = "表示順Label";
            表示順Label.Size = new System.Drawing.Size(49, 18);
            表示順Label.TabIndex = 42;
            表示順Label.Text = "表示順:";
            // 
            // mユーザーBindingSource
            // 
            this.mユーザーBindingSource.DataMember = "M_ユーザー";
            this.mユーザーBindingSource.DataSource = this.cCJ2DataSetHP8100;
            // 
            // cCJ2DataSetHP8100
            // 
            this.cCJ2DataSetHP8100.DataSetName = "CCJ2DataSetHP8100";
            this.cCJ2DataSetHP8100.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_ユーザーTableAdapter
            // 
            this.m_ユーザーTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = CCJ_QAQC.CCJ2DataSetHP8100TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ユーザーコードTextBox
            // 
            this.ユーザーコードTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mユーザーBindingSource, "ユーザーコード", true));
            this.ユーザーコードTextBox.DataSourceTable = null;
            this.ユーザーコードTextBox.Location = new System.Drawing.Point(267, 16);
            this.ユーザーコードTextBox.Name = "ユーザーコードTextBox";
            this.ユーザーコードTextBox.Size = new System.Drawing.Size(200, 25);
            this.ユーザーコードTextBox.TabIndex = 5;
            this.ユーザーコードTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchCriteriaTextBox_KeyUp);
            // 
            // 名称TextBox
            // 
            this.名称TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mユーザーBindingSource, "名称", true));
            this.名称TextBox.DataSourceTable = null;
            this.名称TextBox.Location = new System.Drawing.Point(267, 47);
            this.名称TextBox.Name = "名称TextBox";
            this.名称TextBox.Size = new System.Drawing.Size(200, 25);
            this.名称TextBox.TabIndex = 7;
            this.名称TextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchCriteriaTextBox_KeyUp);
            // 
            // 郵便番号TextBox
            // 
            this.郵便番号TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mユーザーBindingSource, "郵便番号", true));
            this.郵便番号TextBox.Location = new System.Drawing.Point(267, 78);
            this.郵便番号TextBox.Name = "郵便番号TextBox";
            this.郵便番号TextBox.Size = new System.Drawing.Size(200, 25);
            this.郵便番号TextBox.TabIndex = 9;
            // 
            // 住所１TextBox
            // 
            this.住所１TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mユーザーBindingSource, "住所１", true));
            this.住所１TextBox.Location = new System.Drawing.Point(267, 109);
            this.住所１TextBox.Name = "住所１TextBox";
            this.住所１TextBox.Size = new System.Drawing.Size(200, 25);
            this.住所１TextBox.TabIndex = 11;
            // 
            // 住所２TextBox
            // 
            this.住所２TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mユーザーBindingSource, "住所２", true));
            this.住所２TextBox.Location = new System.Drawing.Point(267, 140);
            this.住所２TextBox.Name = "住所２TextBox";
            this.住所２TextBox.Size = new System.Drawing.Size(200, 25);
            this.住所２TextBox.TabIndex = 13;
            // 
            // 担当者TextBox
            // 
            this.担当者TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mユーザーBindingSource, "担当者", true));
            this.担当者TextBox.Location = new System.Drawing.Point(267, 171);
            this.担当者TextBox.Name = "担当者TextBox";
            this.担当者TextBox.Size = new System.Drawing.Size(200, 25);
            this.担当者TextBox.TabIndex = 15;
            // 
            // 電話番号TextBox
            // 
            this.電話番号TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mユーザーBindingSource, "電話番号", true));
            this.電話番号TextBox.Location = new System.Drawing.Point(267, 202);
            this.電話番号TextBox.Name = "電話番号TextBox";
            this.電話番号TextBox.Size = new System.Drawing.Size(200, 25);
            this.電話番号TextBox.TabIndex = 17;
            // 
            // ｆＡＸ番号TextBox
            // 
            this.ｆＡＸ番号TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mユーザーBindingSource, "ＦＡＸ番号", true));
            this.ｆＡＸ番号TextBox.Location = new System.Drawing.Point(267, 233);
            this.ｆＡＸ番号TextBox.Name = "ｆＡＸ番号TextBox";
            this.ｆＡＸ番号TextBox.Size = new System.Drawing.Size(200, 25);
            this.ｆＡＸ番号TextBox.TabIndex = 19;
            // 
            // 送付先名称TextBox
            // 
            this.送付先名称TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mユーザーBindingSource, "送付先名称", true));
            this.送付先名称TextBox.Location = new System.Drawing.Point(267, 264);
            this.送付先名称TextBox.Name = "送付先名称TextBox";
            this.送付先名称TextBox.Size = new System.Drawing.Size(200, 25);
            this.送付先名称TextBox.TabIndex = 21;
            // 
            // 送付先郵便番号TextBox
            // 
            this.送付先郵便番号TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mユーザーBindingSource, "送付先郵便番号", true));
            this.送付先郵便番号TextBox.Location = new System.Drawing.Point(267, 295);
            this.送付先郵便番号TextBox.Name = "送付先郵便番号TextBox";
            this.送付先郵便番号TextBox.Size = new System.Drawing.Size(200, 25);
            this.送付先郵便番号TextBox.TabIndex = 23;
            // 
            // 送付先住所１TextBox
            // 
            this.送付先住所１TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mユーザーBindingSource, "送付先住所１", true));
            this.送付先住所１TextBox.Location = new System.Drawing.Point(267, 326);
            this.送付先住所１TextBox.Name = "送付先住所１TextBox";
            this.送付先住所１TextBox.Size = new System.Drawing.Size(200, 25);
            this.送付先住所１TextBox.TabIndex = 25;
            // 
            // 送付先住所２TextBox
            // 
            this.送付先住所２TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mユーザーBindingSource, "送付先住所２", true));
            this.送付先住所２TextBox.Location = new System.Drawing.Point(267, 357);
            this.送付先住所２TextBox.Name = "送付先住所２TextBox";
            this.送付先住所２TextBox.Size = new System.Drawing.Size(200, 25);
            this.送付先住所２TextBox.TabIndex = 27;
            // 
            // 送付先担当者TextBox
            // 
            this.送付先担当者TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mユーザーBindingSource, "送付先担当者", true));
            this.送付先担当者TextBox.Location = new System.Drawing.Point(267, 388);
            this.送付先担当者TextBox.Name = "送付先担当者TextBox";
            this.送付先担当者TextBox.Size = new System.Drawing.Size(200, 25);
            this.送付先担当者TextBox.TabIndex = 29;
            // 
            // 送付先電話番号TextBox
            // 
            this.送付先電話番号TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mユーザーBindingSource, "送付先電話番号", true));
            this.送付先電話番号TextBox.Location = new System.Drawing.Point(267, 419);
            this.送付先電話番号TextBox.Name = "送付先電話番号TextBox";
            this.送付先電話番号TextBox.Size = new System.Drawing.Size(200, 25);
            this.送付先電話番号TextBox.TabIndex = 31;
            // 
            // 削除フラグTextBox
            // 
            this.削除フラグTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mユーザーBindingSource, "削除フラグ", true));
            this.削除フラグTextBox.Location = new System.Drawing.Point(267, 450);
            this.削除フラグTextBox.Name = "削除フラグTextBox";
            this.削除フラグTextBox.Size = new System.Drawing.Size(200, 25);
            this.削除フラグTextBox.TabIndex = 33;
            // 
            // 登録日DateTimePicker
            // 
            this.登録日DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mユーザーBindingSource, "登録日", true));
            this.登録日DateTimePicker.Location = new System.Drawing.Point(267, 481);
            this.登録日DateTimePicker.Name = "登録日DateTimePicker";
            this.登録日DateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.登録日DateTimePicker.TabIndex = 35;
            // 
            // 登録IDTextBox
            // 
            this.登録IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mユーザーBindingSource, "登録ID", true));
            this.登録IDTextBox.Location = new System.Drawing.Point(267, 512);
            this.登録IDTextBox.Name = "登録IDTextBox";
            this.登録IDTextBox.Size = new System.Drawing.Size(200, 25);
            this.登録IDTextBox.TabIndex = 37;
            // 
            // 更新日DateTimePicker
            // 
            this.更新日DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mユーザーBindingSource, "更新日", true));
            this.更新日DateTimePicker.Location = new System.Drawing.Point(267, 543);
            this.更新日DateTimePicker.Name = "更新日DateTimePicker";
            this.更新日DateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.更新日DateTimePicker.TabIndex = 39;
            // 
            // 更新IDTextBox
            // 
            this.更新IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mユーザーBindingSource, "更新ID", true));
            this.更新IDTextBox.Location = new System.Drawing.Point(267, 574);
            this.更新IDTextBox.Name = "更新IDTextBox";
            this.更新IDTextBox.Size = new System.Drawing.Size(200, 25);
            this.更新IDTextBox.TabIndex = 41;
            // 
            // 表示順TextBox
            // 
            this.表示順TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mユーザーBindingSource, "表示順", true));
            this.表示順TextBox.Location = new System.Drawing.Point(267, 605);
            this.表示順TextBox.Name = "表示順TextBox";
            this.表示順TextBox.Size = new System.Drawing.Size(200, 25);
            this.表示順TextBox.TabIndex = 43;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.mユーザーBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 25);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(206, 25);
            this.bindingNavigator1.TabIndex = 44;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新規追加";
            this.bindingNavigatorAddNewItem.Visible = false;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目の総数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "削除";
            this.bindingNavigatorDeleteItem.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "最初に移動";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "前に戻る";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 25);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "現在の場所";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "次に移動";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "最後に移動";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            this.bindingNavigatorSeparator2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(505, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 45;
            this.button1.Text = "検索";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonClassTest
            // 
            this.buttonClassTest.Location = new System.Drawing.Point(724, 17);
            this.buttonClassTest.Name = "buttonClassTest";
            this.buttonClassTest.Size = new System.Drawing.Size(208, 50);
            this.buttonClassTest.TabIndex = 50;
            this.buttonClassTest.Text = "原料検査ワークシートのテスト";
            this.buttonClassTest.UseVisualStyleBackColor = true;
            this.buttonClassTest.Click += new System.EventHandler(this.buttonClassTest_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(724, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 50);
            this.button3.TabIndex = 50;
            this.button3.Text = "製品検査ワークシートのテスト";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonClassTest2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新規作成NToolStripButton,
            this.開くOToolStripButton,
            this.上書き保存SToolStripButton,
            this.印刷PToolStripButton,
            this.toolStripSeparator,
            this.切り取りUToolStripButton,
            this.コピーCToolStripButton,
            this.貼り付けPToolStripButton,
            this.toolStripSeparator1,
            this.ヘルプLToolStripButton,
            this.toolStripButtonSearchModeON});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(296, 25);
            this.toolStrip1.TabIndex = 51;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // 新規作成NToolStripButton
            // 
            this.新規作成NToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.新規作成NToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("新規作成NToolStripButton.Image")));
            this.新規作成NToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.新規作成NToolStripButton.Name = "新規作成NToolStripButton";
            this.新規作成NToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.新規作成NToolStripButton.Text = "新規作成(&N)";
            // 
            // 開くOToolStripButton
            // 
            this.開くOToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.開くOToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("開くOToolStripButton.Image")));
            this.開くOToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.開くOToolStripButton.Name = "開くOToolStripButton";
            this.開くOToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.開くOToolStripButton.Text = "開く(&O)";
            // 
            // 上書き保存SToolStripButton
            // 
            this.上書き保存SToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.上書き保存SToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("上書き保存SToolStripButton.Image")));
            this.上書き保存SToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.上書き保存SToolStripButton.Name = "上書き保存SToolStripButton";
            this.上書き保存SToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.上書き保存SToolStripButton.Text = "上書き保存(&S)";
            // 
            // 印刷PToolStripButton
            // 
            this.印刷PToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.印刷PToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("印刷PToolStripButton.Image")));
            this.印刷PToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.印刷PToolStripButton.Name = "印刷PToolStripButton";
            this.印刷PToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.印刷PToolStripButton.Text = "印刷(&P)";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // 切り取りUToolStripButton
            // 
            this.切り取りUToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.切り取りUToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("切り取りUToolStripButton.Image")));
            this.切り取りUToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.切り取りUToolStripButton.Name = "切り取りUToolStripButton";
            this.切り取りUToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.切り取りUToolStripButton.Text = "切り取り(&U)";
            // 
            // コピーCToolStripButton
            // 
            this.コピーCToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.コピーCToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("コピーCToolStripButton.Image")));
            this.コピーCToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.コピーCToolStripButton.Name = "コピーCToolStripButton";
            this.コピーCToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.コピーCToolStripButton.Text = "コピー(&C)";
            // 
            // 貼り付けPToolStripButton
            // 
            this.貼り付けPToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.貼り付けPToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("貼り付けPToolStripButton.Image")));
            this.貼り付けPToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.貼り付けPToolStripButton.Name = "貼り付けPToolStripButton";
            this.貼り付けPToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.貼り付けPToolStripButton.Text = "貼り付け(&P)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ヘルプLToolStripButton
            // 
            this.ヘルプLToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ヘルプLToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ヘルプLToolStripButton.Image")));
            this.ヘルプLToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ヘルプLToolStripButton.Name = "ヘルプLToolStripButton";
            this.ヘルプLToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ヘルプLToolStripButton.Text = "ヘルプ(&L)";
            // 
            // toolStripButtonSearchModeON
            // 
            this.toolStripButtonSearchModeON.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSearchModeON.Image")));
            this.toolStripButtonSearchModeON.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSearchModeON.Name = "toolStripButtonSearchModeON";
            this.toolStripButtonSearchModeON.Size = new System.Drawing.Size(88, 22);
            this.toolStripButtonSearchModeON.Text = "検索モード";
            this.toolStripButtonSearchModeON.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonSearchModeON.Click += new System.EventHandler(this.toolStripButtonSearchModeON_Click);
            // 
            // toolStripContainer3
            // 
            this.toolStripContainer3.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer3.ContentPanel
            // 
            this.toolStripContainer3.ContentPanel.AutoScroll = true;
            this.toolStripContainer3.ContentPanel.Controls.Add(this._x_Study1DataGridView);
            this.toolStripContainer3.ContentPanel.Controls.Add(this.button2);
            this.toolStripContainer3.ContentPanel.Controls.Add(this.buttonCloseForm);
            this.toolStripContainer3.ContentPanel.Controls.Add(this.button3);
            this.toolStripContainer3.ContentPanel.Controls.Add(this.buttonClassTest);
            this.toolStripContainer3.ContentPanel.Controls.Add(this.button1);
            this.toolStripContainer3.ContentPanel.Controls.Add(ユーザーコードLabel);
            this.toolStripContainer3.ContentPanel.Controls.Add(this.ユーザーコードTextBox);
            this.toolStripContainer3.ContentPanel.Controls.Add(名称Label);
            this.toolStripContainer3.ContentPanel.Controls.Add(this.名称TextBox);
            this.toolStripContainer3.ContentPanel.Controls.Add(郵便番号Label);
            this.toolStripContainer3.ContentPanel.Controls.Add(this.郵便番号TextBox);
            this.toolStripContainer3.ContentPanel.Controls.Add(住所１Label);
            this.toolStripContainer3.ContentPanel.Controls.Add(this.住所１TextBox);
            this.toolStripContainer3.ContentPanel.Controls.Add(住所２Label);
            this.toolStripContainer3.ContentPanel.Controls.Add(this.住所２TextBox);
            this.toolStripContainer3.ContentPanel.Controls.Add(担当者Label);
            this.toolStripContainer3.ContentPanel.Controls.Add(this.担当者TextBox);
            this.toolStripContainer3.ContentPanel.Controls.Add(電話番号Label);
            this.toolStripContainer3.ContentPanel.Controls.Add(this.電話番号TextBox);
            this.toolStripContainer3.ContentPanel.Controls.Add(ｆＡＸ番号Label);
            this.toolStripContainer3.ContentPanel.Controls.Add(this.ｆＡＸ番号TextBox);
            this.toolStripContainer3.ContentPanel.Controls.Add(送付先名称Label);
            this.toolStripContainer3.ContentPanel.Controls.Add(this.送付先名称TextBox);
            this.toolStripContainer3.ContentPanel.Controls.Add(送付先郵便番号Label);
            this.toolStripContainer3.ContentPanel.Controls.Add(this.送付先郵便番号TextBox);
            this.toolStripContainer3.ContentPanel.Controls.Add(送付先住所１Label);
            this.toolStripContainer3.ContentPanel.Controls.Add(this.送付先住所１TextBox);
            this.toolStripContainer3.ContentPanel.Controls.Add(送付先住所２Label);
            this.toolStripContainer3.ContentPanel.Controls.Add(this.送付先住所２TextBox);
            this.toolStripContainer3.ContentPanel.Controls.Add(送付先担当者Label);
            this.toolStripContainer3.ContentPanel.Controls.Add(this.送付先担当者TextBox);
            this.toolStripContainer3.ContentPanel.Controls.Add(送付先電話番号Label);
            this.toolStripContainer3.ContentPanel.Controls.Add(this.送付先電話番号TextBox);
            this.toolStripContainer3.ContentPanel.Controls.Add(削除フラグLabel);
            this.toolStripContainer3.ContentPanel.Controls.Add(this.削除フラグTextBox);
            this.toolStripContainer3.ContentPanel.Controls.Add(登録日Label);
            this.toolStripContainer3.ContentPanel.Controls.Add(this.登録日DateTimePicker);
            this.toolStripContainer3.ContentPanel.Controls.Add(登録IDLabel);
            this.toolStripContainer3.ContentPanel.Controls.Add(this.登録IDTextBox);
            this.toolStripContainer3.ContentPanel.Controls.Add(更新日Label);
            this.toolStripContainer3.ContentPanel.Controls.Add(this.更新日DateTimePicker);
            this.toolStripContainer3.ContentPanel.Controls.Add(更新IDLabel);
            this.toolStripContainer3.ContentPanel.Controls.Add(this.更新IDTextBox);
            this.toolStripContainer3.ContentPanel.Controls.Add(表示順Label);
            this.toolStripContainer3.ContentPanel.Controls.Add(this.表示順TextBox);
            this.toolStripContainer3.ContentPanel.Size = new System.Drawing.Size(1101, 624);
            this.toolStripContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer3.LeftToolStripPanelVisible = false;
            this.toolStripContainer3.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer3.Name = "toolStripContainer3";
            this.toolStripContainer3.RightToolStripPanelVisible = false;
            this.toolStripContainer3.Size = new System.Drawing.Size(1101, 674);
            this.toolStripContainer3.TabIndex = 54;
            this.toolStripContainer3.Text = "toolStripContainer3";
            // 
            // toolStripContainer3.TopToolStripPanel
            // 
            this.toolStripContainer3.TopToolStripPanel.Controls.Add(this.bindingNavigator1);
            this.toolStripContainer3.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(735, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 43);
            this.button2.TabIndex = 51;
            this.button2.Text = "updateの研究";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // dataSet検査ワークシート
            // 
            this.dataSet検査ワークシート.DataSetName = "DataSet検査ワークシート";
            this.dataSet検査ワークシート.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _x_Study1BindingSource
            // 
            this._x_Study1BindingSource.DataMember = "_x_Study1";
            this._x_Study1BindingSource.DataSource = this.dataSet検査ワークシート;
            // 
            // _x_Study1TableAdapter
            // 
            this._x_Study1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1._x_Study1TableAdapter = this._x_Study1TableAdapter;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = CCJ_QAQC.DataSet検査ワークシートTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.検査ワークシートヘッダTableAdapter = null;
            this.tableAdapterManager1.検査ワークシート属性日付数量TableAdapter = null;
            this.tableAdapterManager1.検査ワークシート属性測定値TableAdapter = null;
            // 
            // _x_Study1DataGridView
            // 
            this._x_Study1DataGridView.AutoGenerateColumns = false;
            this._x_Study1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._x_Study1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this._x_Study1DataGridView.DataSource = this._x_Study1BindingSource;
            this._x_Study1DataGridView.Location = new System.Drawing.Point(763, 380);
            this._x_Study1DataGridView.Name = "_x_Study1DataGridView";
            this._x_Study1DataGridView.RowTemplate.Height = 21;
            this._x_Study1DataGridView.Size = new System.Drawing.Size(300, 220);
            this._x_Study1DataGridView.TabIndex = 51;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "社員コード";
            this.dataGridViewTextBoxColumn1.HeaderText = "社員コード";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "年月";
            this.dataGridViewTextBoxColumn2.HeaderText = "年月";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "出席回数";
            this.dataGridViewTextBoxColumn3.HeaderText = "出席回数";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.ClientSize = new System.Drawing.Size(1101, 696);
            this.Controls.Add(this.toolStripContainer3);
            this.Name = "FormTest";
            this.Load += new System.EventHandler(this.FormTest_Load);
            this.Controls.SetChildIndex(this.toolStripContainer3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.mユーザーBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCJ2DataSetHP8100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripContainer3.ContentPanel.ResumeLayout(false);
            this.toolStripContainer3.ContentPanel.PerformLayout();
            this.toolStripContainer3.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer3.TopToolStripPanel.PerformLayout();
            this.toolStripContainer3.ResumeLayout(false);
            this.toolStripContainer3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet検査ワークシート)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._x_Study1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._x_Study1DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCJ2DataSetHP8100 cCJ2DataSetHP8100;
        private System.Windows.Forms.BindingSource mユーザーBindingSource;
        private CCJ2DataSetHP8100TableAdapters.M_ユーザーTableAdapter m_ユーザーTableAdapter;
        private CCJ2DataSetHP8100TableAdapters.TableAdapterManager tableAdapterManager;
        private Kawai.ApplicationBase.SearchCritriaTextBox ユーザーコードTextBox;
        private Kawai.ApplicationBase.SearchCritriaTextBox 名称TextBox;
        private System.Windows.Forms.TextBox 郵便番号TextBox;
        private System.Windows.Forms.TextBox 住所１TextBox;
        private System.Windows.Forms.TextBox 住所２TextBox;
        private System.Windows.Forms.TextBox 担当者TextBox;
        private System.Windows.Forms.TextBox 電話番号TextBox;
        private System.Windows.Forms.TextBox ｆＡＸ番号TextBox;
        private System.Windows.Forms.TextBox 送付先名称TextBox;
        private System.Windows.Forms.TextBox 送付先郵便番号TextBox;
        private System.Windows.Forms.TextBox 送付先住所１TextBox;
        private System.Windows.Forms.TextBox 送付先住所２TextBox;
        private System.Windows.Forms.TextBox 送付先担当者TextBox;
        private System.Windows.Forms.TextBox 送付先電話番号TextBox;
        private System.Windows.Forms.TextBox 削除フラグTextBox;
        private System.Windows.Forms.DateTimePicker 登録日DateTimePicker;
        private System.Windows.Forms.TextBox 登録IDTextBox;
        private System.Windows.Forms.DateTimePicker 更新日DateTimePicker;
        private System.Windows.Forms.TextBox 更新IDTextBox;
        private System.Windows.Forms.TextBox 表示順TextBox;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonClassTest;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton 新規作成NToolStripButton;
        private System.Windows.Forms.ToolStripButton 開くOToolStripButton;
        private System.Windows.Forms.ToolStripButton 上書き保存SToolStripButton;
        private System.Windows.Forms.ToolStripButton 印刷PToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton 切り取りUToolStripButton;
        private System.Windows.Forms.ToolStripButton コピーCToolStripButton;
        private System.Windows.Forms.ToolStripButton 貼り付けPToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ヘルプLToolStripButton;
        private System.Windows.Forms.ToolStripContainer toolStripContainer3;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearchModeON;
        private System.Windows.Forms.Button button2;
        private DataSet検査ワークシート dataSet検査ワークシート;
        private System.Windows.Forms.BindingSource _x_Study1BindingSource;
        private DataSet検査ワークシートTableAdapters._x_Study1TableAdapter _x_Study1TableAdapter;
        private DataSet検査ワークシートTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView _x_Study1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

    }
}
