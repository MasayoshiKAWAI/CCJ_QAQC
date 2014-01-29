namespace CCJ_QAQC
{
    partial class Form原料検査WS検索
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label 材料コードLabel;
            System.Windows.Forms.Label 材料名称Label;
            System.Windows.Forms.Label 名称Label;
            System.Windows.Forms.Label 原価Label;
            System.Windows.Forms.Label sEQLabel;
            System.Windows.Forms.Label 使用基準有無Label;
            System.Windows.Forms.Label 使用基準文言１Label;
            System.Windows.Forms.Label 使用基準文言２Label;
            System.Windows.Forms.Label 注意事項文言１Label;
            System.Windows.Forms.Label 注意事項文言２Label;
            System.Windows.Forms.Label 注意事項文言３Label;
            System.Windows.Forms.Label 状態Label;
            System.Windows.Forms.Label 品質保証書区分Label;
            System.Windows.Forms.Label 食品添加物Label;
            System.Windows.Forms.Label 一般名Label;
            System.Windows.Forms.Label 類別Label;
            System.Windows.Forms.Label 保管条件Label;
            System.Windows.Forms.Label 備考Label;
            System.Windows.Forms.Label 大分類Label;
            System.Windows.Forms.Label 中分類名称Label;
            System.Windows.Forms.Label 小分類Label;
            System.Windows.Forms.Label 安全衛生法１Label;
            System.Windows.Forms.Label 安全衛生法２Label;
            System.Windows.Forms.Label pRTRLabel;
            System.Windows.Forms.Label gHSLabel;
            System.Windows.Forms.Label 終売Label;
            System.Windows.Forms.Label イミテーションLabel;
            System.Windows.Forms.Label 品番Label;
            System.Windows.Forms.Label 登録日Label;
            System.Windows.Forms.Label 登録IDLabel;
            System.Windows.Forms.Label 更新日Label;
            System.Windows.Forms.Label 更新IDLabel;
            this.原料検査ワークシートDataGridView = new System.Windows.Forms.DataGridView();
            this.原料検査ワークシートBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.元番製品コード = new CCJ_QAQC.元番製品コード();
            this.材料マスタBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.材料マスタTableAdapter = new CCJ_QAQC.元番製品コードTableAdapters.材料マスタTableAdapter();
            this.tableAdapterManager = new CCJ_QAQC.元番製品コードTableAdapters.TableAdapterManager();
            this.材料コードTextBox = new System.Windows.Forms.TextBox();
            this.材料名称TextBox = new System.Windows.Forms.TextBox();
            this.名称TextBox = new System.Windows.Forms.TextBox();
            this.原価TextBox = new System.Windows.Forms.TextBox();
            this.sEQTextBox = new System.Windows.Forms.TextBox();
            this.使用基準有無TextBox = new System.Windows.Forms.TextBox();
            this.使用基準文言１TextBox = new System.Windows.Forms.TextBox();
            this.使用基準文言２TextBox = new System.Windows.Forms.TextBox();
            this.注意事項文言１TextBox = new System.Windows.Forms.TextBox();
            this.注意事項文言２TextBox = new System.Windows.Forms.TextBox();
            this.注意事項文言３TextBox = new System.Windows.Forms.TextBox();
            this.状態TextBox = new System.Windows.Forms.TextBox();
            this.品質保証書区分TextBox = new System.Windows.Forms.TextBox();
            this.食品添加物TextBox = new System.Windows.Forms.TextBox();
            this.一般名TextBox = new System.Windows.Forms.TextBox();
            this.類別TextBox = new System.Windows.Forms.TextBox();
            this.保管条件TextBox = new System.Windows.Forms.TextBox();
            this.備考TextBox = new System.Windows.Forms.TextBox();
            this.大分類TextBox = new System.Windows.Forms.TextBox();
            this.中分類名称TextBox = new System.Windows.Forms.TextBox();
            this.小分類TextBox = new System.Windows.Forms.TextBox();
            this.安全衛生法１TextBox = new System.Windows.Forms.TextBox();
            this.安全衛生法２TextBox = new System.Windows.Forms.TextBox();
            this.pRTRTextBox = new System.Windows.Forms.TextBox();
            this.gHSTextBox = new System.Windows.Forms.TextBox();
            this.終売TextBox = new System.Windows.Forms.TextBox();
            this.イミテーションTextBox = new System.Windows.Forms.TextBox();
            this.品番TextBox = new System.Windows.Forms.TextBox();
            this.登録日DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.登録IDTextBox = new System.Windows.Forms.TextBox();
            this.更新日DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.更新IDTextBox = new System.Windows.Forms.TextBox();
            this.dataSet検査ワークシート = new CCJ_QAQC.DataSet検査ワークシート();
            this.原料コードDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.原料名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ロット番号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ロット番号備考DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入荷日DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入荷日テキストDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.納入元DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.容器封緘ラベルDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.官能検査日DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.官能検査担当者DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.官能検査合否DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.コメントその他検査項目DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.総合判定合否DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.製造会社DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入荷量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.原料検査ワークシートTableAdapter = new CCJ_QAQC.DataSet検査ワークシートTableAdapters.原料検査ワークシートTableAdapter();
            材料コードLabel = new System.Windows.Forms.Label();
            材料名称Label = new System.Windows.Forms.Label();
            名称Label = new System.Windows.Forms.Label();
            原価Label = new System.Windows.Forms.Label();
            sEQLabel = new System.Windows.Forms.Label();
            使用基準有無Label = new System.Windows.Forms.Label();
            使用基準文言１Label = new System.Windows.Forms.Label();
            使用基準文言２Label = new System.Windows.Forms.Label();
            注意事項文言１Label = new System.Windows.Forms.Label();
            注意事項文言２Label = new System.Windows.Forms.Label();
            注意事項文言３Label = new System.Windows.Forms.Label();
            状態Label = new System.Windows.Forms.Label();
            品質保証書区分Label = new System.Windows.Forms.Label();
            食品添加物Label = new System.Windows.Forms.Label();
            一般名Label = new System.Windows.Forms.Label();
            類別Label = new System.Windows.Forms.Label();
            保管条件Label = new System.Windows.Forms.Label();
            備考Label = new System.Windows.Forms.Label();
            大分類Label = new System.Windows.Forms.Label();
            中分類名称Label = new System.Windows.Forms.Label();
            小分類Label = new System.Windows.Forms.Label();
            安全衛生法１Label = new System.Windows.Forms.Label();
            安全衛生法２Label = new System.Windows.Forms.Label();
            pRTRLabel = new System.Windows.Forms.Label();
            gHSLabel = new System.Windows.Forms.Label();
            終売Label = new System.Windows.Forms.Label();
            イミテーションLabel = new System.Windows.Forms.Label();
            品番Label = new System.Windows.Forms.Label();
            登録日Label = new System.Windows.Forms.Label();
            登録IDLabel = new System.Windows.Forms.Label();
            更新日Label = new System.Windows.Forms.Label();
            更新IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.原料検査ワークシートDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.原料検査ワークシートBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.元番製品コード)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.材料マスタBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet検査ワークシート)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCloseForm.Location = new System.Drawing.Point(967, 28);
            // 
            // 材料コードLabel
            // 
            材料コードLabel.AutoSize = true;
            材料コードLabel.Location = new System.Drawing.Point(30, 31);
            材料コードLabel.Name = "材料コードLabel";
            材料コードLabel.Size = new System.Drawing.Size(73, 18);
            材料コードLabel.TabIndex = 4;
            材料コードLabel.Text = "材料コード:";
            // 
            // 材料名称Label
            // 
            材料名称Label.AutoSize = true;
            材料名称Label.Location = new System.Drawing.Point(30, 62);
            材料名称Label.Name = "材料名称Label";
            材料名称Label.Size = new System.Drawing.Size(61, 18);
            材料名称Label.TabIndex = 6;
            材料名称Label.Text = "材料名称:";
            // 
            // 名称Label
            // 
            名称Label.AutoSize = true;
            名称Label.Location = new System.Drawing.Point(30, 93);
            名称Label.Name = "名称Label";
            名称Label.Size = new System.Drawing.Size(37, 18);
            名称Label.TabIndex = 8;
            名称Label.Text = "名称:";
            // 
            // 原価Label
            // 
            原価Label.AutoSize = true;
            原価Label.Location = new System.Drawing.Point(30, 124);
            原価Label.Name = "原価Label";
            原価Label.Size = new System.Drawing.Size(37, 18);
            原価Label.TabIndex = 10;
            原価Label.Text = "原価:";
            // 
            // sEQLabel
            // 
            sEQLabel.AutoSize = true;
            sEQLabel.Location = new System.Drawing.Point(30, 155);
            sEQLabel.Name = "sEQLabel";
            sEQLabel.Size = new System.Drawing.Size(37, 18);
            sEQLabel.TabIndex = 12;
            sEQLabel.Text = "SEQ:";
            // 
            // 使用基準有無Label
            // 
            使用基準有無Label.AutoSize = true;
            使用基準有無Label.Location = new System.Drawing.Point(30, 186);
            使用基準有無Label.Name = "使用基準有無Label";
            使用基準有無Label.Size = new System.Drawing.Size(85, 18);
            使用基準有無Label.TabIndex = 14;
            使用基準有無Label.Text = "使用基準有無:";
            // 
            // 使用基準文言１Label
            // 
            使用基準文言１Label.AutoSize = true;
            使用基準文言１Label.Location = new System.Drawing.Point(30, 217);
            使用基準文言１Label.Name = "使用基準文言１Label";
            使用基準文言１Label.Size = new System.Drawing.Size(97, 18);
            使用基準文言１Label.TabIndex = 16;
            使用基準文言１Label.Text = "使用基準文言１:";
            // 
            // 使用基準文言２Label
            // 
            使用基準文言２Label.AutoSize = true;
            使用基準文言２Label.Location = new System.Drawing.Point(30, 248);
            使用基準文言２Label.Name = "使用基準文言２Label";
            使用基準文言２Label.Size = new System.Drawing.Size(97, 18);
            使用基準文言２Label.TabIndex = 18;
            使用基準文言２Label.Text = "使用基準文言２:";
            // 
            // 注意事項文言１Label
            // 
            注意事項文言１Label.AutoSize = true;
            注意事項文言１Label.Location = new System.Drawing.Point(30, 279);
            注意事項文言１Label.Name = "注意事項文言１Label";
            注意事項文言１Label.Size = new System.Drawing.Size(97, 18);
            注意事項文言１Label.TabIndex = 20;
            注意事項文言１Label.Text = "注意事項文言１:";
            // 
            // 注意事項文言２Label
            // 
            注意事項文言２Label.AutoSize = true;
            注意事項文言２Label.Location = new System.Drawing.Point(30, 310);
            注意事項文言２Label.Name = "注意事項文言２Label";
            注意事項文言２Label.Size = new System.Drawing.Size(97, 18);
            注意事項文言２Label.TabIndex = 22;
            注意事項文言２Label.Text = "注意事項文言２:";
            // 
            // 注意事項文言３Label
            // 
            注意事項文言３Label.AutoSize = true;
            注意事項文言３Label.Location = new System.Drawing.Point(30, 341);
            注意事項文言３Label.Name = "注意事項文言３Label";
            注意事項文言３Label.Size = new System.Drawing.Size(97, 18);
            注意事項文言３Label.TabIndex = 24;
            注意事項文言３Label.Text = "注意事項文言３:";
            // 
            // 状態Label
            // 
            状態Label.AutoSize = true;
            状態Label.Location = new System.Drawing.Point(30, 372);
            状態Label.Name = "状態Label";
            状態Label.Size = new System.Drawing.Size(37, 18);
            状態Label.TabIndex = 26;
            状態Label.Text = "状態:";
            // 
            // 品質保証書区分Label
            // 
            品質保証書区分Label.AutoSize = true;
            品質保証書区分Label.Location = new System.Drawing.Point(30, 403);
            品質保証書区分Label.Name = "品質保証書区分Label";
            品質保証書区分Label.Size = new System.Drawing.Size(97, 18);
            品質保証書区分Label.TabIndex = 28;
            品質保証書区分Label.Text = "品質保証書区分:";
            // 
            // 食品添加物Label
            // 
            食品添加物Label.AutoSize = true;
            食品添加物Label.Location = new System.Drawing.Point(30, 434);
            食品添加物Label.Name = "食品添加物Label";
            食品添加物Label.Size = new System.Drawing.Size(73, 18);
            食品添加物Label.TabIndex = 30;
            食品添加物Label.Text = "食品添加物:";
            // 
            // 一般名Label
            // 
            一般名Label.AutoSize = true;
            一般名Label.Location = new System.Drawing.Point(30, 465);
            一般名Label.Name = "一般名Label";
            一般名Label.Size = new System.Drawing.Size(49, 18);
            一般名Label.TabIndex = 32;
            一般名Label.Text = "一般名:";
            // 
            // 類別Label
            // 
            類別Label.AutoSize = true;
            類別Label.Location = new System.Drawing.Point(30, 496);
            類別Label.Name = "類別Label";
            類別Label.Size = new System.Drawing.Size(37, 18);
            類別Label.TabIndex = 34;
            類別Label.Text = "類別:";
            // 
            // 保管条件Label
            // 
            保管条件Label.AutoSize = true;
            保管条件Label.Location = new System.Drawing.Point(30, 527);
            保管条件Label.Name = "保管条件Label";
            保管条件Label.Size = new System.Drawing.Size(61, 18);
            保管条件Label.TabIndex = 36;
            保管条件Label.Text = "保管条件:";
            // 
            // 備考Label
            // 
            備考Label.AutoSize = true;
            備考Label.Location = new System.Drawing.Point(30, 558);
            備考Label.Name = "備考Label";
            備考Label.Size = new System.Drawing.Size(37, 18);
            備考Label.TabIndex = 38;
            備考Label.Text = "備考:";
            // 
            // 大分類Label
            // 
            大分類Label.AutoSize = true;
            大分類Label.Location = new System.Drawing.Point(369, 27);
            大分類Label.Name = "大分類Label";
            大分類Label.Size = new System.Drawing.Size(49, 18);
            大分類Label.TabIndex = 40;
            大分類Label.Text = "大分類:";
            // 
            // 中分類名称Label
            // 
            中分類名称Label.AutoSize = true;
            中分類名称Label.Location = new System.Drawing.Point(369, 58);
            中分類名称Label.Name = "中分類名称Label";
            中分類名称Label.Size = new System.Drawing.Size(73, 18);
            中分類名称Label.TabIndex = 42;
            中分類名称Label.Text = "中分類名称:";
            // 
            // 小分類Label
            // 
            小分類Label.AutoSize = true;
            小分類Label.Location = new System.Drawing.Point(369, 89);
            小分類Label.Name = "小分類Label";
            小分類Label.Size = new System.Drawing.Size(49, 18);
            小分類Label.TabIndex = 44;
            小分類Label.Text = "小分類:";
            // 
            // 安全衛生法１Label
            // 
            安全衛生法１Label.AutoSize = true;
            安全衛生法１Label.Location = new System.Drawing.Point(369, 120);
            安全衛生法１Label.Name = "安全衛生法１Label";
            安全衛生法１Label.Size = new System.Drawing.Size(85, 18);
            安全衛生法１Label.TabIndex = 46;
            安全衛生法１Label.Text = "安全衛生法１:";
            // 
            // 安全衛生法２Label
            // 
            安全衛生法２Label.AutoSize = true;
            安全衛生法２Label.Location = new System.Drawing.Point(369, 151);
            安全衛生法２Label.Name = "安全衛生法２Label";
            安全衛生法２Label.Size = new System.Drawing.Size(85, 18);
            安全衛生法２Label.TabIndex = 48;
            安全衛生法２Label.Text = "安全衛生法２:";
            // 
            // pRTRLabel
            // 
            pRTRLabel.AutoSize = true;
            pRTRLabel.Location = new System.Drawing.Point(369, 182);
            pRTRLabel.Name = "pRTRLabel";
            pRTRLabel.Size = new System.Drawing.Size(44, 18);
            pRTRLabel.TabIndex = 50;
            pRTRLabel.Text = "PRTR:";
            // 
            // gHSLabel
            // 
            gHSLabel.AutoSize = true;
            gHSLabel.Location = new System.Drawing.Point(369, 213);
            gHSLabel.Name = "gHSLabel";
            gHSLabel.Size = new System.Drawing.Size(39, 18);
            gHSLabel.TabIndex = 52;
            gHSLabel.Text = "GHS:";
            // 
            // 終売Label
            // 
            終売Label.AutoSize = true;
            終売Label.Location = new System.Drawing.Point(369, 244);
            終売Label.Name = "終売Label";
            終売Label.Size = new System.Drawing.Size(37, 18);
            終売Label.TabIndex = 54;
            終売Label.Text = "終売:";
            // 
            // イミテーションLabel
            // 
            イミテーションLabel.AutoSize = true;
            イミテーションLabel.Location = new System.Drawing.Point(369, 275);
            イミテーションLabel.Name = "イミテーションLabel";
            イミテーションLabel.Size = new System.Drawing.Size(97, 18);
            イミテーションLabel.TabIndex = 56;
            イミテーションLabel.Text = "イミテーション:";
            // 
            // 品番Label
            // 
            品番Label.AutoSize = true;
            品番Label.Location = new System.Drawing.Point(369, 306);
            品番Label.Name = "品番Label";
            品番Label.Size = new System.Drawing.Size(37, 18);
            品番Label.TabIndex = 58;
            品番Label.Text = "品番:";
            // 
            // 登録日Label
            // 
            登録日Label.AutoSize = true;
            登録日Label.Location = new System.Drawing.Point(369, 338);
            登録日Label.Name = "登録日Label";
            登録日Label.Size = new System.Drawing.Size(49, 18);
            登録日Label.TabIndex = 60;
            登録日Label.Text = "登録日:";
            // 
            // 登録IDLabel
            // 
            登録IDLabel.AutoSize = true;
            登録IDLabel.Location = new System.Drawing.Point(369, 368);
            登録IDLabel.Name = "登録IDLabel";
            登録IDLabel.Size = new System.Drawing.Size(51, 18);
            登録IDLabel.TabIndex = 62;
            登録IDLabel.Text = "登録ID:";
            // 
            // 更新日Label
            // 
            更新日Label.AutoSize = true;
            更新日Label.Location = new System.Drawing.Point(369, 400);
            更新日Label.Name = "更新日Label";
            更新日Label.Size = new System.Drawing.Size(49, 18);
            更新日Label.TabIndex = 64;
            更新日Label.Text = "更新日:";
            // 
            // 更新IDLabel
            // 
            更新IDLabel.AutoSize = true;
            更新IDLabel.Location = new System.Drawing.Point(369, 430);
            更新IDLabel.Name = "更新IDLabel";
            更新IDLabel.Size = new System.Drawing.Size(51, 18);
            更新IDLabel.TabIndex = 66;
            更新IDLabel.Text = "更新ID:";
            // 
            // 原料検査ワークシートDataGridView
            // 
            this.原料検査ワークシートDataGridView.AllowUserToAddRows = false;
            this.原料検査ワークシートDataGridView.AllowUserToDeleteRows = false;
            this.原料検査ワークシートDataGridView.AutoGenerateColumns = false;
            this.原料検査ワークシートDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.原料検査ワークシートDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.原料コードDataGridViewTextBoxColumn,
            this.原料名DataGridViewTextBoxColumn,
            this.ロット番号DataGridViewTextBoxColumn,
            this.ロット番号備考DataGridViewTextBoxColumn,
            this.入荷日DataGridViewTextBoxColumn,
            this.入荷日テキストDataGridViewTextBoxColumn,
            this.納入元DataGridViewTextBoxColumn,
            this.容器封緘ラベルDataGridViewTextBoxColumn,
            this.官能検査日DataGridViewTextBoxColumn,
            this.官能検査担当者DataGridViewTextBoxColumn,
            this.官能検査合否DataGridViewTextBoxColumn,
            this.コメントその他検査項目DataGridViewTextBoxColumn,
            this.総合判定合否DataGridViewTextBoxColumn,
            this.製造会社DataGridViewTextBoxColumn,
            this.入荷量DataGridViewTextBoxColumn});
            this.原料検査ワークシートDataGridView.DataSource = this.原料検査ワークシートBindingSource;
            this.原料検査ワークシートDataGridView.Location = new System.Drawing.Point(33, 598);
            this.原料検査ワークシートDataGridView.Name = "原料検査ワークシートDataGridView";
            this.原料検査ワークシートDataGridView.ReadOnly = true;
            this.原料検査ワークシートDataGridView.RowTemplate.Height = 21;
            this.原料検査ワークシートDataGridView.Size = new System.Drawing.Size(991, 349);
            this.原料検査ワークシートDataGridView.TabIndex = 4;
            this.原料検査ワークシートDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.原料検査ワークシートDataGridView_CellMouseDoubleClick);
            // 
            // 原料検査ワークシートBindingSource
            // 
            this.原料検査ワークシートBindingSource.DataMember = "原料検査ワークシート";
            this.原料検査ワークシートBindingSource.DataSource = this.dataSet検査ワークシート;
            // 
            // 元番製品コード
            // 
            this.元番製品コード.DataSetName = "元番製品コード";
            this.元番製品コード.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 材料マスタBindingSource
            // 
            this.材料マスタBindingSource.DataMember = "材料マスタ";
            this.材料マスタBindingSource.DataSource = this.元番製品コード;
            // 
            // 材料マスタTableAdapter
            // 
            this.材料マスタTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = CCJ_QAQC.元番製品コードTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // 材料コードTextBox
            // 
            this.材料コードTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.材料マスタBindingSource, "材料コード", true));
            this.材料コードTextBox.Location = new System.Drawing.Point(133, 28);
            this.材料コードTextBox.Name = "材料コードTextBox";
            this.材料コードTextBox.Size = new System.Drawing.Size(200, 25);
            this.材料コードTextBox.TabIndex = 5;
            // 
            // 材料名称TextBox
            // 
            this.材料名称TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.材料マスタBindingSource, "材料名称", true));
            this.材料名称TextBox.Location = new System.Drawing.Point(133, 59);
            this.材料名称TextBox.Name = "材料名称TextBox";
            this.材料名称TextBox.Size = new System.Drawing.Size(200, 25);
            this.材料名称TextBox.TabIndex = 7;
            // 
            // 名称TextBox
            // 
            this.名称TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.材料マスタBindingSource, "名称", true));
            this.名称TextBox.Location = new System.Drawing.Point(133, 90);
            this.名称TextBox.Name = "名称TextBox";
            this.名称TextBox.Size = new System.Drawing.Size(200, 25);
            this.名称TextBox.TabIndex = 9;
            // 
            // 原価TextBox
            // 
            this.原価TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.材料マスタBindingSource, "原価", true));
            this.原価TextBox.Location = new System.Drawing.Point(133, 121);
            this.原価TextBox.Name = "原価TextBox";
            this.原価TextBox.Size = new System.Drawing.Size(200, 25);
            this.原価TextBox.TabIndex = 11;
            // 
            // sEQTextBox
            // 
            this.sEQTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.材料マスタBindingSource, "SEQ", true));
            this.sEQTextBox.Location = new System.Drawing.Point(133, 152);
            this.sEQTextBox.Name = "sEQTextBox";
            this.sEQTextBox.Size = new System.Drawing.Size(200, 25);
            this.sEQTextBox.TabIndex = 13;
            // 
            // 使用基準有無TextBox
            // 
            this.使用基準有無TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.材料マスタBindingSource, "使用基準有無", true));
            this.使用基準有無TextBox.Location = new System.Drawing.Point(133, 183);
            this.使用基準有無TextBox.Name = "使用基準有無TextBox";
            this.使用基準有無TextBox.Size = new System.Drawing.Size(200, 25);
            this.使用基準有無TextBox.TabIndex = 15;
            // 
            // 使用基準文言１TextBox
            // 
            this.使用基準文言１TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.材料マスタBindingSource, "使用基準文言１", true));
            this.使用基準文言１TextBox.Location = new System.Drawing.Point(133, 214);
            this.使用基準文言１TextBox.Name = "使用基準文言１TextBox";
            this.使用基準文言１TextBox.Size = new System.Drawing.Size(200, 25);
            this.使用基準文言１TextBox.TabIndex = 17;
            // 
            // 使用基準文言２TextBox
            // 
            this.使用基準文言２TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.材料マスタBindingSource, "使用基準文言２", true));
            this.使用基準文言２TextBox.Location = new System.Drawing.Point(133, 245);
            this.使用基準文言２TextBox.Name = "使用基準文言２TextBox";
            this.使用基準文言２TextBox.Size = new System.Drawing.Size(200, 25);
            this.使用基準文言２TextBox.TabIndex = 19;
            // 
            // 注意事項文言１TextBox
            // 
            this.注意事項文言１TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.材料マスタBindingSource, "注意事項文言１", true));
            this.注意事項文言１TextBox.Location = new System.Drawing.Point(133, 276);
            this.注意事項文言１TextBox.Name = "注意事項文言１TextBox";
            this.注意事項文言１TextBox.Size = new System.Drawing.Size(200, 25);
            this.注意事項文言１TextBox.TabIndex = 21;
            // 
            // 注意事項文言２TextBox
            // 
            this.注意事項文言２TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.材料マスタBindingSource, "注意事項文言２", true));
            this.注意事項文言２TextBox.Location = new System.Drawing.Point(133, 307);
            this.注意事項文言２TextBox.Name = "注意事項文言２TextBox";
            this.注意事項文言２TextBox.Size = new System.Drawing.Size(200, 25);
            this.注意事項文言２TextBox.TabIndex = 23;
            // 
            // 注意事項文言３TextBox
            // 
            this.注意事項文言３TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.材料マスタBindingSource, "注意事項文言３", true));
            this.注意事項文言３TextBox.Location = new System.Drawing.Point(133, 338);
            this.注意事項文言３TextBox.Name = "注意事項文言３TextBox";
            this.注意事項文言３TextBox.Size = new System.Drawing.Size(200, 25);
            this.注意事項文言３TextBox.TabIndex = 25;
            // 
            // 状態TextBox
            // 
            this.状態TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.材料マスタBindingSource, "状態", true));
            this.状態TextBox.Location = new System.Drawing.Point(133, 369);
            this.状態TextBox.Name = "状態TextBox";
            this.状態TextBox.Size = new System.Drawing.Size(200, 25);
            this.状態TextBox.TabIndex = 27;
            // 
            // 品質保証書区分TextBox
            // 
            this.品質保証書区分TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.材料マスタBindingSource, "品質保証書区分", true));
            this.品質保証書区分TextBox.Location = new System.Drawing.Point(133, 400);
            this.品質保証書区分TextBox.Name = "品質保証書区分TextBox";
            this.品質保証書区分TextBox.Size = new System.Drawing.Size(200, 25);
            this.品質保証書区分TextBox.TabIndex = 29;
            // 
            // 食品添加物TextBox
            // 
            this.食品添加物TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.材料マスタBindingSource, "食品添加物", true));
            this.食品添加物TextBox.Location = new System.Drawing.Point(133, 431);
            this.食品添加物TextBox.Name = "食品添加物TextBox";
            this.食品添加物TextBox.Size = new System.Drawing.Size(200, 25);
            this.食品添加物TextBox.TabIndex = 31;
            // 
            // 一般名TextBox
            // 
            this.一般名TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.材料マスタBindingSource, "一般名", true));
            this.一般名TextBox.Location = new System.Drawing.Point(133, 462);
            this.一般名TextBox.Name = "一般名TextBox";
            this.一般名TextBox.Size = new System.Drawing.Size(200, 25);
            this.一般名TextBox.TabIndex = 33;
            // 
            // 類別TextBox
            // 
            this.類別TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.材料マスタBindingSource, "類別", true));
            this.類別TextBox.Location = new System.Drawing.Point(133, 493);
            this.類別TextBox.Name = "類別TextBox";
            this.類別TextBox.Size = new System.Drawing.Size(200, 25);
            this.類別TextBox.TabIndex = 35;
            // 
            // 保管条件TextBox
            // 
            this.保管条件TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.材料マスタBindingSource, "保管条件", true));
            this.保管条件TextBox.Location = new System.Drawing.Point(133, 524);
            this.保管条件TextBox.Name = "保管条件TextBox";
            this.保管条件TextBox.Size = new System.Drawing.Size(200, 25);
            this.保管条件TextBox.TabIndex = 37;
            // 
            // 備考TextBox
            // 
            this.備考TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.材料マスタBindingSource, "備考", true));
            this.備考TextBox.Location = new System.Drawing.Point(133, 555);
            this.備考TextBox.Name = "備考TextBox";
            this.備考TextBox.Size = new System.Drawing.Size(200, 25);
            this.備考TextBox.TabIndex = 39;
            // 
            // 大分類TextBox
            // 
            this.大分類TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.材料マスタBindingSource, "大分類", true));
            this.大分類TextBox.Location = new System.Drawing.Point(472, 24);
            this.大分類TextBox.Name = "大分類TextBox";
            this.大分類TextBox.Size = new System.Drawing.Size(200, 25);
            this.大分類TextBox.TabIndex = 41;
            // 
            // 中分類名称TextBox
            // 
            this.中分類名称TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.材料マスタBindingSource, "中分類名称", true));
            this.中分類名称TextBox.Location = new System.Drawing.Point(472, 55);
            this.中分類名称TextBox.Name = "中分類名称TextBox";
            this.中分類名称TextBox.Size = new System.Drawing.Size(200, 25);
            this.中分類名称TextBox.TabIndex = 43;
            // 
            // 小分類TextBox
            // 
            this.小分類TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.材料マスタBindingSource, "小分類", true));
            this.小分類TextBox.Location = new System.Drawing.Point(472, 86);
            this.小分類TextBox.Name = "小分類TextBox";
            this.小分類TextBox.Size = new System.Drawing.Size(200, 25);
            this.小分類TextBox.TabIndex = 45;
            // 
            // 安全衛生法１TextBox
            // 
            this.安全衛生法１TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.材料マスタBindingSource, "安全衛生法１", true));
            this.安全衛生法１TextBox.Location = new System.Drawing.Point(472, 117);
            this.安全衛生法１TextBox.Name = "安全衛生法１TextBox";
            this.安全衛生法１TextBox.Size = new System.Drawing.Size(200, 25);
            this.安全衛生法１TextBox.TabIndex = 47;
            // 
            // 安全衛生法２TextBox
            // 
            this.安全衛生法２TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.材料マスタBindingSource, "安全衛生法２", true));
            this.安全衛生法２TextBox.Location = new System.Drawing.Point(472, 148);
            this.安全衛生法２TextBox.Name = "安全衛生法２TextBox";
            this.安全衛生法２TextBox.Size = new System.Drawing.Size(200, 25);
            this.安全衛生法２TextBox.TabIndex = 49;
            // 
            // pRTRTextBox
            // 
            this.pRTRTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.材料マスタBindingSource, "PRTR", true));
            this.pRTRTextBox.Location = new System.Drawing.Point(472, 179);
            this.pRTRTextBox.Name = "pRTRTextBox";
            this.pRTRTextBox.Size = new System.Drawing.Size(200, 25);
            this.pRTRTextBox.TabIndex = 51;
            // 
            // gHSTextBox
            // 
            this.gHSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.材料マスタBindingSource, "GHS", true));
            this.gHSTextBox.Location = new System.Drawing.Point(472, 210);
            this.gHSTextBox.Name = "gHSTextBox";
            this.gHSTextBox.Size = new System.Drawing.Size(200, 25);
            this.gHSTextBox.TabIndex = 53;
            // 
            // 終売TextBox
            // 
            this.終売TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.材料マスタBindingSource, "終売", true));
            this.終売TextBox.Location = new System.Drawing.Point(472, 241);
            this.終売TextBox.Name = "終売TextBox";
            this.終売TextBox.Size = new System.Drawing.Size(200, 25);
            this.終売TextBox.TabIndex = 55;
            // 
            // イミテーションTextBox
            // 
            this.イミテーションTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.材料マスタBindingSource, "イミテーション", true));
            this.イミテーションTextBox.Location = new System.Drawing.Point(472, 272);
            this.イミテーションTextBox.Name = "イミテーションTextBox";
            this.イミテーションTextBox.Size = new System.Drawing.Size(200, 25);
            this.イミテーションTextBox.TabIndex = 57;
            // 
            // 品番TextBox
            // 
            this.品番TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.材料マスタBindingSource, "品番", true));
            this.品番TextBox.Location = new System.Drawing.Point(472, 303);
            this.品番TextBox.Name = "品番TextBox";
            this.品番TextBox.Size = new System.Drawing.Size(200, 25);
            this.品番TextBox.TabIndex = 59;
            // 
            // 登録日DateTimePicker
            // 
            this.登録日DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.材料マスタBindingSource, "登録日", true));
            this.登録日DateTimePicker.Location = new System.Drawing.Point(472, 334);
            this.登録日DateTimePicker.Name = "登録日DateTimePicker";
            this.登録日DateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.登録日DateTimePicker.TabIndex = 61;
            // 
            // 登録IDTextBox
            // 
            this.登録IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.材料マスタBindingSource, "登録ID", true));
            this.登録IDTextBox.Location = new System.Drawing.Point(472, 365);
            this.登録IDTextBox.Name = "登録IDTextBox";
            this.登録IDTextBox.Size = new System.Drawing.Size(200, 25);
            this.登録IDTextBox.TabIndex = 63;
            // 
            // 更新日DateTimePicker
            // 
            this.更新日DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.材料マスタBindingSource, "更新日", true));
            this.更新日DateTimePicker.Location = new System.Drawing.Point(472, 396);
            this.更新日DateTimePicker.Name = "更新日DateTimePicker";
            this.更新日DateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.更新日DateTimePicker.TabIndex = 65;
            // 
            // 更新IDTextBox
            // 
            this.更新IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.材料マスタBindingSource, "更新ID", true));
            this.更新IDTextBox.Location = new System.Drawing.Point(472, 427);
            this.更新IDTextBox.Name = "更新IDTextBox";
            this.更新IDTextBox.Size = new System.Drawing.Size(200, 25);
            this.更新IDTextBox.TabIndex = 67;
            // 
            // dataSet検査ワークシート
            // 
            this.dataSet検査ワークシート.DataSetName = "DataSet検査ワークシート";
            this.dataSet検査ワークシート.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 原料コードDataGridViewTextBoxColumn
            // 
            this.原料コードDataGridViewTextBoxColumn.DataPropertyName = "原料コード";
            this.原料コードDataGridViewTextBoxColumn.HeaderText = "原料コード";
            this.原料コードDataGridViewTextBoxColumn.Name = "原料コードDataGridViewTextBoxColumn";
            this.原料コードDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 原料名DataGridViewTextBoxColumn
            // 
            this.原料名DataGridViewTextBoxColumn.DataPropertyName = "原料名";
            this.原料名DataGridViewTextBoxColumn.HeaderText = "原料名";
            this.原料名DataGridViewTextBoxColumn.Name = "原料名DataGridViewTextBoxColumn";
            this.原料名DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ロット番号DataGridViewTextBoxColumn
            // 
            this.ロット番号DataGridViewTextBoxColumn.DataPropertyName = "ロット番号";
            this.ロット番号DataGridViewTextBoxColumn.HeaderText = "ロット番号";
            this.ロット番号DataGridViewTextBoxColumn.Name = "ロット番号DataGridViewTextBoxColumn";
            this.ロット番号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ロット番号備考DataGridViewTextBoxColumn
            // 
            this.ロット番号備考DataGridViewTextBoxColumn.DataPropertyName = "ロット番号備考";
            this.ロット番号備考DataGridViewTextBoxColumn.HeaderText = "ロット番号備考";
            this.ロット番号備考DataGridViewTextBoxColumn.Name = "ロット番号備考DataGridViewTextBoxColumn";
            this.ロット番号備考DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 入荷日DataGridViewTextBoxColumn
            // 
            this.入荷日DataGridViewTextBoxColumn.DataPropertyName = "入荷日";
            this.入荷日DataGridViewTextBoxColumn.HeaderText = "入荷日";
            this.入荷日DataGridViewTextBoxColumn.Name = "入荷日DataGridViewTextBoxColumn";
            this.入荷日DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 入荷日テキストDataGridViewTextBoxColumn
            // 
            this.入荷日テキストDataGridViewTextBoxColumn.DataPropertyName = "入荷日テキスト";
            this.入荷日テキストDataGridViewTextBoxColumn.HeaderText = "入荷日テキスト";
            this.入荷日テキストDataGridViewTextBoxColumn.Name = "入荷日テキストDataGridViewTextBoxColumn";
            this.入荷日テキストDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 納入元DataGridViewTextBoxColumn
            // 
            this.納入元DataGridViewTextBoxColumn.DataPropertyName = "納入元";
            this.納入元DataGridViewTextBoxColumn.HeaderText = "納入元";
            this.納入元DataGridViewTextBoxColumn.Name = "納入元DataGridViewTextBoxColumn";
            this.納入元DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 容器封緘ラベルDataGridViewTextBoxColumn
            // 
            this.容器封緘ラベルDataGridViewTextBoxColumn.DataPropertyName = "容器封緘ラベル";
            this.容器封緘ラベルDataGridViewTextBoxColumn.HeaderText = "容器封緘ラベル";
            this.容器封緘ラベルDataGridViewTextBoxColumn.Name = "容器封緘ラベルDataGridViewTextBoxColumn";
            this.容器封緘ラベルDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 官能検査日DataGridViewTextBoxColumn
            // 
            this.官能検査日DataGridViewTextBoxColumn.DataPropertyName = "（官能）検査日";
            this.官能検査日DataGridViewTextBoxColumn.HeaderText = "（官能）検査日";
            this.官能検査日DataGridViewTextBoxColumn.Name = "官能検査日DataGridViewTextBoxColumn";
            this.官能検査日DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 官能検査担当者DataGridViewTextBoxColumn
            // 
            this.官能検査担当者DataGridViewTextBoxColumn.DataPropertyName = "（官能）検査担当者";
            this.官能検査担当者DataGridViewTextBoxColumn.HeaderText = "（官能）検査担当者";
            this.官能検査担当者DataGridViewTextBoxColumn.Name = "官能検査担当者DataGridViewTextBoxColumn";
            this.官能検査担当者DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 官能検査合否DataGridViewTextBoxColumn
            // 
            this.官能検査合否DataGridViewTextBoxColumn.DataPropertyName = "官能検査合否";
            this.官能検査合否DataGridViewTextBoxColumn.HeaderText = "官能検査合否";
            this.官能検査合否DataGridViewTextBoxColumn.Name = "官能検査合否DataGridViewTextBoxColumn";
            this.官能検査合否DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // コメントその他検査項目DataGridViewTextBoxColumn
            // 
            this.コメントその他検査項目DataGridViewTextBoxColumn.DataPropertyName = "コメントその他検査項目";
            this.コメントその他検査項目DataGridViewTextBoxColumn.HeaderText = "コメントその他検査項目";
            this.コメントその他検査項目DataGridViewTextBoxColumn.Name = "コメントその他検査項目DataGridViewTextBoxColumn";
            this.コメントその他検査項目DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 総合判定合否DataGridViewTextBoxColumn
            // 
            this.総合判定合否DataGridViewTextBoxColumn.DataPropertyName = "総合判定合否";
            this.総合判定合否DataGridViewTextBoxColumn.HeaderText = "総合判定合否";
            this.総合判定合否DataGridViewTextBoxColumn.Name = "総合判定合否DataGridViewTextBoxColumn";
            this.総合判定合否DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 製造会社DataGridViewTextBoxColumn
            // 
            this.製造会社DataGridViewTextBoxColumn.DataPropertyName = "製造会社";
            this.製造会社DataGridViewTextBoxColumn.HeaderText = "製造会社";
            this.製造会社DataGridViewTextBoxColumn.Name = "製造会社DataGridViewTextBoxColumn";
            this.製造会社DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 入荷量DataGridViewTextBoxColumn
            // 
            this.入荷量DataGridViewTextBoxColumn.DataPropertyName = "入荷量";
            this.入荷量DataGridViewTextBoxColumn.HeaderText = "入荷量";
            this.入荷量DataGridViewTextBoxColumn.Name = "入荷量DataGridViewTextBoxColumn";
            this.入荷量DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 原料検査ワークシートTableAdapter
            // 
            this.原料検査ワークシートTableAdapter.ClearBeforeFill = true;
            // 
            // Form原料検査WS検索
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1066, 970);
            this.Controls.Add(材料コードLabel);
            this.Controls.Add(this.材料コードTextBox);
            this.Controls.Add(材料名称Label);
            this.Controls.Add(this.材料名称TextBox);
            this.Controls.Add(名称Label);
            this.Controls.Add(this.名称TextBox);
            this.Controls.Add(原価Label);
            this.Controls.Add(this.原価TextBox);
            this.Controls.Add(sEQLabel);
            this.Controls.Add(this.sEQTextBox);
            this.Controls.Add(使用基準有無Label);
            this.Controls.Add(this.使用基準有無TextBox);
            this.Controls.Add(使用基準文言１Label);
            this.Controls.Add(this.使用基準文言１TextBox);
            this.Controls.Add(使用基準文言２Label);
            this.Controls.Add(this.使用基準文言２TextBox);
            this.Controls.Add(注意事項文言１Label);
            this.Controls.Add(this.注意事項文言１TextBox);
            this.Controls.Add(注意事項文言２Label);
            this.Controls.Add(this.注意事項文言２TextBox);
            this.Controls.Add(注意事項文言３Label);
            this.Controls.Add(this.注意事項文言３TextBox);
            this.Controls.Add(状態Label);
            this.Controls.Add(this.状態TextBox);
            this.Controls.Add(品質保証書区分Label);
            this.Controls.Add(this.品質保証書区分TextBox);
            this.Controls.Add(食品添加物Label);
            this.Controls.Add(this.食品添加物TextBox);
            this.Controls.Add(一般名Label);
            this.Controls.Add(this.一般名TextBox);
            this.Controls.Add(類別Label);
            this.Controls.Add(this.類別TextBox);
            this.Controls.Add(保管条件Label);
            this.Controls.Add(this.保管条件TextBox);
            this.Controls.Add(備考Label);
            this.Controls.Add(this.備考TextBox);
            this.Controls.Add(大分類Label);
            this.Controls.Add(this.大分類TextBox);
            this.Controls.Add(中分類名称Label);
            this.Controls.Add(this.中分類名称TextBox);
            this.Controls.Add(小分類Label);
            this.Controls.Add(this.小分類TextBox);
            this.Controls.Add(安全衛生法１Label);
            this.Controls.Add(this.安全衛生法１TextBox);
            this.Controls.Add(安全衛生法２Label);
            this.Controls.Add(this.安全衛生法２TextBox);
            this.Controls.Add(pRTRLabel);
            this.Controls.Add(this.pRTRTextBox);
            this.Controls.Add(gHSLabel);
            this.Controls.Add(this.gHSTextBox);
            this.Controls.Add(終売Label);
            this.Controls.Add(this.終売TextBox);
            this.Controls.Add(イミテーションLabel);
            this.Controls.Add(this.イミテーションTextBox);
            this.Controls.Add(品番Label);
            this.Controls.Add(this.品番TextBox);
            this.Controls.Add(登録日Label);
            this.Controls.Add(this.登録日DateTimePicker);
            this.Controls.Add(登録IDLabel);
            this.Controls.Add(this.登録IDTextBox);
            this.Controls.Add(更新日Label);
            this.Controls.Add(this.更新日DateTimePicker);
            this.Controls.Add(更新IDLabel);
            this.Controls.Add(this.更新IDTextBox);
            this.Controls.Add(this.原料検査ワークシートDataGridView);
            this.Name = "Form原料検査WS検索";
            this.Text = "原料検査ワークシート検索";
            this.Load += new System.EventHandler(this.Form原料検査WS検索_Load);
            this.Controls.SetChildIndex(this.buttonCloseForm, 0);
            this.Controls.SetChildIndex(this.原料検査ワークシートDataGridView, 0);
            this.Controls.SetChildIndex(this.更新IDTextBox, 0);
            this.Controls.SetChildIndex(更新IDLabel, 0);
            this.Controls.SetChildIndex(this.更新日DateTimePicker, 0);
            this.Controls.SetChildIndex(更新日Label, 0);
            this.Controls.SetChildIndex(this.登録IDTextBox, 0);
            this.Controls.SetChildIndex(登録IDLabel, 0);
            this.Controls.SetChildIndex(this.登録日DateTimePicker, 0);
            this.Controls.SetChildIndex(登録日Label, 0);
            this.Controls.SetChildIndex(this.品番TextBox, 0);
            this.Controls.SetChildIndex(品番Label, 0);
            this.Controls.SetChildIndex(this.イミテーションTextBox, 0);
            this.Controls.SetChildIndex(イミテーションLabel, 0);
            this.Controls.SetChildIndex(this.終売TextBox, 0);
            this.Controls.SetChildIndex(終売Label, 0);
            this.Controls.SetChildIndex(this.gHSTextBox, 0);
            this.Controls.SetChildIndex(gHSLabel, 0);
            this.Controls.SetChildIndex(this.pRTRTextBox, 0);
            this.Controls.SetChildIndex(pRTRLabel, 0);
            this.Controls.SetChildIndex(this.安全衛生法２TextBox, 0);
            this.Controls.SetChildIndex(安全衛生法２Label, 0);
            this.Controls.SetChildIndex(this.安全衛生法１TextBox, 0);
            this.Controls.SetChildIndex(安全衛生法１Label, 0);
            this.Controls.SetChildIndex(this.小分類TextBox, 0);
            this.Controls.SetChildIndex(小分類Label, 0);
            this.Controls.SetChildIndex(this.中分類名称TextBox, 0);
            this.Controls.SetChildIndex(中分類名称Label, 0);
            this.Controls.SetChildIndex(this.大分類TextBox, 0);
            this.Controls.SetChildIndex(大分類Label, 0);
            this.Controls.SetChildIndex(this.備考TextBox, 0);
            this.Controls.SetChildIndex(備考Label, 0);
            this.Controls.SetChildIndex(this.保管条件TextBox, 0);
            this.Controls.SetChildIndex(保管条件Label, 0);
            this.Controls.SetChildIndex(this.類別TextBox, 0);
            this.Controls.SetChildIndex(類別Label, 0);
            this.Controls.SetChildIndex(this.一般名TextBox, 0);
            this.Controls.SetChildIndex(一般名Label, 0);
            this.Controls.SetChildIndex(this.食品添加物TextBox, 0);
            this.Controls.SetChildIndex(食品添加物Label, 0);
            this.Controls.SetChildIndex(this.品質保証書区分TextBox, 0);
            this.Controls.SetChildIndex(品質保証書区分Label, 0);
            this.Controls.SetChildIndex(this.状態TextBox, 0);
            this.Controls.SetChildIndex(状態Label, 0);
            this.Controls.SetChildIndex(this.注意事項文言３TextBox, 0);
            this.Controls.SetChildIndex(注意事項文言３Label, 0);
            this.Controls.SetChildIndex(this.注意事項文言２TextBox, 0);
            this.Controls.SetChildIndex(注意事項文言２Label, 0);
            this.Controls.SetChildIndex(this.注意事項文言１TextBox, 0);
            this.Controls.SetChildIndex(注意事項文言１Label, 0);
            this.Controls.SetChildIndex(this.使用基準文言２TextBox, 0);
            this.Controls.SetChildIndex(使用基準文言２Label, 0);
            this.Controls.SetChildIndex(this.使用基準文言１TextBox, 0);
            this.Controls.SetChildIndex(使用基準文言１Label, 0);
            this.Controls.SetChildIndex(this.使用基準有無TextBox, 0);
            this.Controls.SetChildIndex(使用基準有無Label, 0);
            this.Controls.SetChildIndex(this.sEQTextBox, 0);
            this.Controls.SetChildIndex(sEQLabel, 0);
            this.Controls.SetChildIndex(this.原価TextBox, 0);
            this.Controls.SetChildIndex(原価Label, 0);
            this.Controls.SetChildIndex(this.名称TextBox, 0);
            this.Controls.SetChildIndex(名称Label, 0);
            this.Controls.SetChildIndex(this.材料名称TextBox, 0);
            this.Controls.SetChildIndex(材料名称Label, 0);
            this.Controls.SetChildIndex(this.材料コードTextBox, 0);
            this.Controls.SetChildIndex(材料コードLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.原料検査ワークシートDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.原料検査ワークシートBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.元番製品コード)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.材料マスタBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet検査ワークシート)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource 原料検査ワークシートBindingSource;
        private System.Windows.Forms.DataGridView 原料検査ワークシートDataGridView;
        private 元番製品コード 元番製品コード;
        private System.Windows.Forms.BindingSource 材料マスタBindingSource;
        private 元番製品コードTableAdapters.材料マスタTableAdapter 材料マスタTableAdapter;
        private 元番製品コードTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox 材料コードTextBox;
        private System.Windows.Forms.TextBox 材料名称TextBox;
        private System.Windows.Forms.TextBox 名称TextBox;
        private System.Windows.Forms.TextBox 原価TextBox;
        private System.Windows.Forms.TextBox sEQTextBox;
        private System.Windows.Forms.TextBox 使用基準有無TextBox;
        private System.Windows.Forms.TextBox 使用基準文言１TextBox;
        private System.Windows.Forms.TextBox 使用基準文言２TextBox;
        private System.Windows.Forms.TextBox 注意事項文言１TextBox;
        private System.Windows.Forms.TextBox 注意事項文言２TextBox;
        private System.Windows.Forms.TextBox 注意事項文言３TextBox;
        private System.Windows.Forms.TextBox 状態TextBox;
        private System.Windows.Forms.TextBox 品質保証書区分TextBox;
        private System.Windows.Forms.TextBox 食品添加物TextBox;
        private System.Windows.Forms.TextBox 一般名TextBox;
        private System.Windows.Forms.TextBox 類別TextBox;
        private System.Windows.Forms.TextBox 保管条件TextBox;
        private System.Windows.Forms.TextBox 備考TextBox;
        private System.Windows.Forms.TextBox 大分類TextBox;
        private System.Windows.Forms.TextBox 中分類名称TextBox;
        private System.Windows.Forms.TextBox 小分類TextBox;
        private System.Windows.Forms.TextBox 安全衛生法１TextBox;
        private System.Windows.Forms.TextBox 安全衛生法２TextBox;
        private System.Windows.Forms.TextBox pRTRTextBox;
        private System.Windows.Forms.TextBox gHSTextBox;
        private System.Windows.Forms.TextBox 終売TextBox;
        private System.Windows.Forms.TextBox イミテーションTextBox;
        private System.Windows.Forms.TextBox 品番TextBox;
        private System.Windows.Forms.DateTimePicker 登録日DateTimePicker;
        private System.Windows.Forms.TextBox 登録IDTextBox;
        private System.Windows.Forms.DateTimePicker 更新日DateTimePicker;
        private System.Windows.Forms.TextBox 更新IDTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn 原料コードDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 原料名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ロット番号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ロット番号備考DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入荷日DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入荷日テキストDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 納入元DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 容器封緘ラベルDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 官能検査日DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 官能検査担当者DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 官能検査合否DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn コメントその他検査項目DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 総合判定合否DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 製造会社DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入荷量DataGridViewTextBoxColumn;
        private DataSet検査ワークシート dataSet検査ワークシート;
        private DataSet検査ワークシートTableAdapters.原料検査ワークシートTableAdapter 原料検査ワークシートTableAdapter;
    }
}