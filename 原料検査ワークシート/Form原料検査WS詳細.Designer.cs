namespace CCJ_QAQC
{
    partial class Form原料検査WS詳細
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
            System.Windows.Forms.Label 原料コードLabel;
            System.Windows.Forms.Label 原料名Label;
            System.Windows.Forms.Label ロット番号Label;
            System.Windows.Forms.Label 入荷日Label;
            System.Windows.Forms.Label 納入元Label;
            System.Windows.Forms.Label 容器封緘ラベルLabel;
            System.Windows.Forms.Label 官能検査合否Label;
            System.Windows.Forms.Label 総合判定合否Label;
            System.Windows.Forms.Label 製造会社Label;
            System.Windows.Forms.Label 入荷量Label;
            System.Windows.Forms.Label 色調性状検査日Label;
            System.Windows.Forms.Label 色調性状合否担当者Label;
            System.Windows.Forms.Label 色調性状合否確認者Label;
            System.Windows.Forms.Label 色調性状合否Label;
            System.Windows.Forms.Label 香気検査日Label;
            System.Windows.Forms.Label 香気合否確認者Label;
            System.Windows.Forms.Label 官能検査日Label;
            System.Windows.Forms.Label 官能検査担当者Label;
            System.Windows.Forms.Label 検査日Label;
            System.Windows.Forms.Label 検査担当者Label;
            System.Windows.Forms.Label 検査確認者Label;
            System.Windows.Forms.Label コメント品管その他検査項目Label;
            System.Windows.Forms.Label 入荷量単位Label;
            System.Windows.Forms.Label 香気合否担当者Label;
            System.Windows.Forms.Label 香気合否Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form原料検査WS詳細));
            this.toolStripContainerMain = new System.Windows.Forms.ToolStripContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonClearCriteria = new System.Windows.Forms.Button();
            this.checkBox検索モード = new System.Windows.Forms.CheckBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dateTimePicker検索範囲終端 = new Kawai.ApplicationBase.NullableDateTimePicker();
            this.groupBox香気 = new System.Windows.Forms.GroupBox();
            this.香気合否ComboBox = new System.Windows.Forms.ComboBox();
            this.原料検査ワークシートBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet検査ワークシート = new CCJ_QAQC.DataSet検査ワークシート();
            this.香気合否TextBox = new System.Windows.Forms.TextBox();
            this.香気合否担当者TextBox = new System.Windows.Forms.TextBox();
            this.groupBox色調性状 = new System.Windows.Forms.GroupBox();
            this.色調性状合否TextBox = new System.Windows.Forms.TextBox();
            this.色調性状合否担当者TextBox = new System.Windows.Forms.TextBox();
            this.原料コードTextBox = new Kawai.ApplicationBase.SearchCritriaTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.官能検査合否TextBox = new System.Windows.Forms.TextBox();
            this.官能検査日DateTimePicker = new Kawai.ApplicationBase.NullableDateTimePicker();
            this.香気検査日DateTimePicker = new Kawai.ApplicationBase.NullableDateTimePicker();
            this.色調性状検査日DateTimePicker = new Kawai.ApplicationBase.NullableDateTimePicker();
            this.官能検査担当者TextBox = new System.Windows.Forms.TextBox();
            this.色調性状合否確認者TextBox = new System.Windows.Forms.TextBox();
            this.香気合否確認者TextBox = new System.Windows.Forms.TextBox();
            this.原料名TextBox = new Kawai.ApplicationBase.SearchCritriaTextBox();
            this.ロット番号TextBox = new Kawai.ApplicationBase.SearchCritriaTextBox();
            this.ロット番号備考TextBox = new Kawai.ApplicationBase.SearchCritriaTextBox();
            this.入荷日DateTimePicker = new Kawai.ApplicationBase.NullableDateTimePicker();
            this.入荷日テキストTextBox = new System.Windows.Forms.TextBox();
            this.納入元TextBox = new Kawai.ApplicationBase.SearchCritriaTextBox();
            this.容器封緘ラベルTextBox = new System.Windows.Forms.TextBox();
            this.総合判定合否TextBox = new System.Windows.Forms.TextBox();
            this.製造会社TextBox = new Kawai.ApplicationBase.SearchCritriaTextBox();
            this.入荷量TextBox = new System.Windows.Forms.TextBox();
            this.検査日DateTimePicker = new Kawai.ApplicationBase.NullableDateTimePicker();
            this.検査担当者TextBox = new Kawai.ApplicationBase.SearchCritriaTextBox();
            this.検査確認者TextBox = new Kawai.ApplicationBase.SearchCritriaTextBox();
            this.コメント品管その他検査項目TextBox = new Kawai.ApplicationBase.SearchCritriaTextBox();
            this.原料検査ワークシートBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.原料検査ワークシートBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.原料検査ワークシートTableAdapter = new CCJ_QAQC.DataSet検査ワークシートTableAdapters.原料検査ワークシートTableAdapter();
            this.tableAdapterManager = new CCJ_QAQC.DataSet検査ワークシートTableAdapters.TableAdapterManager();
            原料コードLabel = new System.Windows.Forms.Label();
            原料名Label = new System.Windows.Forms.Label();
            ロット番号Label = new System.Windows.Forms.Label();
            入荷日Label = new System.Windows.Forms.Label();
            納入元Label = new System.Windows.Forms.Label();
            容器封緘ラベルLabel = new System.Windows.Forms.Label();
            官能検査合否Label = new System.Windows.Forms.Label();
            総合判定合否Label = new System.Windows.Forms.Label();
            製造会社Label = new System.Windows.Forms.Label();
            入荷量Label = new System.Windows.Forms.Label();
            色調性状検査日Label = new System.Windows.Forms.Label();
            色調性状合否担当者Label = new System.Windows.Forms.Label();
            色調性状合否確認者Label = new System.Windows.Forms.Label();
            色調性状合否Label = new System.Windows.Forms.Label();
            香気検査日Label = new System.Windows.Forms.Label();
            香気合否確認者Label = new System.Windows.Forms.Label();
            官能検査日Label = new System.Windows.Forms.Label();
            官能検査担当者Label = new System.Windows.Forms.Label();
            検査日Label = new System.Windows.Forms.Label();
            検査担当者Label = new System.Windows.Forms.Label();
            検査確認者Label = new System.Windows.Forms.Label();
            コメント品管その他検査項目Label = new System.Windows.Forms.Label();
            入荷量単位Label = new System.Windows.Forms.Label();
            香気合否担当者Label = new System.Windows.Forms.Label();
            香気合否Label = new System.Windows.Forms.Label();
            this.toolStripContainerMain.ContentPanel.SuspendLayout();
            this.toolStripContainerMain.SuspendLayout();
            this.groupBox香気.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.原料検査ワークシートBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet検査ワークシート)).BeginInit();
            this.groupBox色調性状.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.原料検査ワークシートBindingNavigator)).BeginInit();
            this.原料検査ワークシートBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.Location = new System.Drawing.Point(972, 561);
            this.buttonCloseForm.TabStop = false;
            // 
            // 原料コードLabel
            // 
            原料コードLabel.AutoSize = true;
            原料コードLabel.Font = new System.Drawing.Font("メイリオ", 12F);
            原料コードLabel.Location = new System.Drawing.Point(31, 207);
            原料コードLabel.Name = "原料コードLabel";
            原料コードLabel.Size = new System.Drawing.Size(90, 24);
            原料コードLabel.TabIndex = 2;
            原料コードLabel.Text = "原料コード";
            // 
            // 原料名Label
            // 
            原料名Label.AutoSize = true;
            原料名Label.Font = new System.Drawing.Font("メイリオ", 12F);
            原料名Label.Location = new System.Drawing.Point(31, 134);
            原料名Label.Name = "原料名Label";
            原料名Label.Size = new System.Drawing.Size(58, 24);
            原料名Label.TabIndex = 4;
            原料名Label.Text = "原料名";
            // 
            // ロット番号Label
            // 
            ロット番号Label.AutoSize = true;
            ロット番号Label.Font = new System.Drawing.Font("メイリオ", 12F);
            ロット番号Label.Location = new System.Drawing.Point(296, 207);
            ロット番号Label.Name = "ロット番号Label";
            ロット番号Label.Size = new System.Drawing.Size(90, 24);
            ロット番号Label.TabIndex = 6;
            ロット番号Label.Text = "ロット番号";
            // 
            // 入荷日Label
            // 
            入荷日Label.AutoSize = true;
            入荷日Label.Font = new System.Drawing.Font("メイリオ", 10F);
            入荷日Label.Location = new System.Drawing.Point(31, 306);
            入荷日Label.Name = "入荷日Label";
            入荷日Label.Size = new System.Drawing.Size(52, 21);
            入荷日Label.TabIndex = 10;
            入荷日Label.Text = "入荷日";
            // 
            // 納入元Label
            // 
            納入元Label.AutoSize = true;
            納入元Label.Font = new System.Drawing.Font("メイリオ", 10F);
            納入元Label.Location = new System.Drawing.Point(31, 389);
            納入元Label.Name = "納入元Label";
            納入元Label.Size = new System.Drawing.Size(52, 21);
            納入元Label.TabIndex = 14;
            納入元Label.Text = "納入元";
            // 
            // 容器封緘ラベルLabel
            // 
            容器封緘ラベルLabel.AutoSize = true;
            容器封緘ラベルLabel.Font = new System.Drawing.Font("メイリオ", 12F);
            容器封緘ラベルLabel.Location = new System.Drawing.Point(564, 275);
            容器封緘ラベルLabel.Name = "容器封緘ラベルLabel";
            容器封緘ラベルLabel.Size = new System.Drawing.Size(122, 24);
            容器封緘ラベルLabel.TabIndex = 16;
            容器封緘ラベルLabel.Text = "容器封緘ラベル";
            // 
            // 官能検査合否Label
            // 
            官能検査合否Label.AutoSize = true;
            官能検査合否Label.Location = new System.Drawing.Point(32, 152);
            官能検査合否Label.Name = "官能検査合否Label";
            官能検査合否Label.Size = new System.Drawing.Size(74, 17);
            官能検査合否Label.TabIndex = 0;
            官能検査合否Label.Text = "官能検査合否";
            // 
            // 総合判定合否Label
            // 
            総合判定合否Label.AutoSize = true;
            総合判定合否Label.Font = new System.Drawing.Font("メイリオ", 28F);
            総合判定合否Label.Location = new System.Drawing.Point(359, 556);
            総合判定合否Label.Name = "総合判定合否Label";
            総合判定合否Label.Size = new System.Drawing.Size(177, 57);
            総合判定合否Label.TabIndex = 22;
            総合判定合否Label.Text = "総合判定";
            // 
            // 製造会社Label
            // 
            製造会社Label.AutoSize = true;
            製造会社Label.Font = new System.Drawing.Font("メイリオ", 10F);
            製造会社Label.Location = new System.Drawing.Point(296, 389);
            製造会社Label.Name = "製造会社Label";
            製造会社Label.Size = new System.Drawing.Size(66, 21);
            製造会社Label.TabIndex = 24;
            製造会社Label.Text = "製造会社";
            // 
            // 入荷量Label
            // 
            入荷量Label.AutoSize = true;
            入荷量Label.Font = new System.Drawing.Font("メイリオ", 10F);
            入荷量Label.Location = new System.Drawing.Point(296, 306);
            入荷量Label.Name = "入荷量Label";
            入荷量Label.Size = new System.Drawing.Size(52, 21);
            入荷量Label.TabIndex = 26;
            入荷量Label.Text = "入荷量";
            // 
            // 色調性状検査日Label
            // 
            色調性状検査日Label.AutoSize = true;
            色調性状検査日Label.Font = new System.Drawing.Font("メイリオ", 8F);
            色調性状検査日Label.Location = new System.Drawing.Point(18, 41);
            色調性状検査日Label.Name = "色調性状検査日Label";
            色調性状検査日Label.Size = new System.Drawing.Size(85, 17);
            色調性状検査日Label.TabIndex = 28;
            色調性状検査日Label.Text = "色調性状検査日";
            // 
            // 色調性状合否担当者Label
            // 
            色調性状合否担当者Label.AutoSize = true;
            色調性状合否担当者Label.Font = new System.Drawing.Font("メイリオ", 10F);
            色調性状合否担当者Label.Location = new System.Drawing.Point(23, 69);
            色調性状合否担当者Label.Name = "色調性状合否担当者Label";
            色調性状合否担当者Label.Size = new System.Drawing.Size(52, 21);
            色調性状合否担当者Label.TabIndex = 30;
            色調性状合否担当者Label.Text = "担当者";
            // 
            // 色調性状合否確認者Label
            // 
            色調性状合否確認者Label.AutoSize = true;
            色調性状合否確認者Label.Location = new System.Drawing.Point(14, 102);
            色調性状合否確認者Label.Name = "色調性状合否確認者Label";
            色調性状合否確認者Label.Size = new System.Drawing.Size(107, 17);
            色調性状合否確認者Label.TabIndex = 32;
            色調性状合否確認者Label.Text = "色調性状合否確認者";
            // 
            // 色調性状合否Label
            // 
            色調性状合否Label.AutoSize = true;
            色調性状合否Label.Font = new System.Drawing.Font("メイリオ", 10F);
            色調性状合否Label.Location = new System.Drawing.Point(22, 36);
            色調性状合否Label.Name = "色調性状合否Label";
            色調性状合否Label.Size = new System.Drawing.Size(38, 21);
            色調性状合否Label.TabIndex = 34;
            色調性状合否Label.Text = "合否";
            // 
            // 香気検査日Label
            // 
            香気検査日Label.AutoSize = true;
            香気検査日Label.Font = new System.Drawing.Font("メイリオ", 8F);
            香気検査日Label.Location = new System.Drawing.Point(18, 65);
            香気検査日Label.Name = "香気検査日Label";
            香気検査日Label.Size = new System.Drawing.Size(63, 17);
            香気検査日Label.TabIndex = 36;
            香気検査日Label.Text = "香気検査日";
            // 
            // 香気合否確認者Label
            // 
            香気合否確認者Label.AutoSize = true;
            香気合否確認者Label.Location = new System.Drawing.Point(14, 122);
            香気合否確認者Label.Name = "香気合否確認者Label";
            香気合否確認者Label.Size = new System.Drawing.Size(85, 17);
            香気合否確認者Label.TabIndex = 40;
            香気合否確認者Label.Text = "香気合否確認者";
            // 
            // 官能検査日Label
            // 
            官能検査日Label.AutoSize = true;
            官能検査日Label.Location = new System.Drawing.Point(18, 18);
            官能検査日Label.Name = "官能検査日Label";
            官能検査日Label.Size = new System.Drawing.Size(63, 17);
            官能検査日Label.TabIndex = 44;
            官能検査日Label.Text = "官能検査日";
            // 
            // 官能検査担当者Label
            // 
            官能検査担当者Label.AutoSize = true;
            官能検査担当者Label.Location = new System.Drawing.Point(32, 173);
            官能検査担当者Label.Name = "官能検査担当者Label";
            官能検査担当者Label.Size = new System.Drawing.Size(85, 17);
            官能検査担当者Label.TabIndex = 46;
            官能検査担当者Label.Text = "官能検査担当者";
            // 
            // 検査日Label
            // 
            検査日Label.AutoSize = true;
            検査日Label.Font = new System.Drawing.Font("メイリオ", 12F);
            検査日Label.Location = new System.Drawing.Point(31, 42);
            検査日Label.Name = "検査日Label";
            検査日Label.Size = new System.Drawing.Size(58, 24);
            検査日Label.TabIndex = 48;
            検査日Label.Text = "検査日";
            // 
            // 検査担当者Label
            // 
            検査担当者Label.AutoSize = true;
            検査担当者Label.Font = new System.Drawing.Font("メイリオ", 12F);
            検査担当者Label.Location = new System.Drawing.Point(296, 42);
            検査担当者Label.Name = "検査担当者Label";
            検査担当者Label.Size = new System.Drawing.Size(90, 24);
            検査担当者Label.TabIndex = 50;
            検査担当者Label.Text = "検査担当者";
            // 
            // 検査確認者Label
            // 
            検査確認者Label.AutoSize = true;
            検査確認者Label.Font = new System.Drawing.Font("メイリオ", 12F);
            検査確認者Label.Location = new System.Drawing.Point(564, 42);
            検査確認者Label.Name = "検査確認者Label";
            検査確認者Label.Size = new System.Drawing.Size(90, 24);
            検査確認者Label.TabIndex = 52;
            検査確認者Label.Text = "検査確認者";
            // 
            // コメント品管その他検査項目Label
            // 
            コメント品管その他検査項目Label.AutoSize = true;
            コメント品管その他検査項目Label.Font = new System.Drawing.Font("メイリオ", 12F);
            コメント品管その他検査項目Label.Location = new System.Drawing.Point(564, 352);
            コメント品管その他検査項目Label.Name = "コメント品管その他検査項目Label";
            コメント品管その他検査項目Label.Size = new System.Drawing.Size(282, 24);
            コメント品管その他検査項目Label.TabIndex = 54;
            コメント品管その他検査項目Label.Text = "品質管理部コメント・その他検査項目";
            // 
            // 入荷量単位Label
            // 
            入荷量単位Label.AutoSize = true;
            入荷量単位Label.Font = new System.Drawing.Font("メイリオ", 10F);
            入荷量単位Label.Location = new System.Drawing.Point(384, 334);
            入荷量単位Label.Name = "入荷量単位Label";
            入荷量単位Label.Size = new System.Drawing.Size(27, 21);
            入荷量単位Label.TabIndex = 26;
            入荷量単位Label.Text = "Kg";
            // 
            // 香気合否担当者Label
            // 
            香気合否担当者Label.AutoSize = true;
            香気合否担当者Label.Font = new System.Drawing.Font("メイリオ", 10F);
            香気合否担当者Label.Location = new System.Drawing.Point(23, 69);
            香気合否担当者Label.Name = "香気合否担当者Label";
            香気合否担当者Label.Size = new System.Drawing.Size(52, 21);
            香気合否担当者Label.TabIndex = 38;
            香気合否担当者Label.Text = "担当者";
            // 
            // 香気合否Label
            // 
            香気合否Label.AutoSize = true;
            香気合否Label.Font = new System.Drawing.Font("メイリオ", 10F);
            香気合否Label.Location = new System.Drawing.Point(23, 36);
            香気合否Label.Name = "香気合否Label";
            香気合否Label.Size = new System.Drawing.Size(38, 21);
            香気合否Label.TabIndex = 42;
            香気合否Label.Text = "合否";
            // 
            // toolStripContainerMain
            // 
            // 
            // toolStripContainerMain.ContentPanel
            // 
            this.toolStripContainerMain.ContentPanel.AutoScroll = true;
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.button1);
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.buttonClearCriteria);
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.checkBox検索モード);
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.buttonSearch);
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.dateTimePicker検索範囲終端);
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.groupBox香気);
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.groupBox色調性状);
            this.toolStripContainerMain.ContentPanel.Controls.Add(原料コードLabel);
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.原料コードTextBox);
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainerMain.ContentPanel.Controls.Add(原料名Label);
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.原料名TextBox);
            this.toolStripContainerMain.ContentPanel.Controls.Add(ロット番号Label);
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.ロット番号TextBox);
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.ロット番号備考TextBox);
            this.toolStripContainerMain.ContentPanel.Controls.Add(入荷日Label);
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.入荷日DateTimePicker);
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.入荷日テキストTextBox);
            this.toolStripContainerMain.ContentPanel.Controls.Add(納入元Label);
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.納入元TextBox);
            this.toolStripContainerMain.ContentPanel.Controls.Add(容器封緘ラベルLabel);
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.容器封緘ラベルTextBox);
            this.toolStripContainerMain.ContentPanel.Controls.Add(総合判定合否Label);
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.総合判定合否TextBox);
            this.toolStripContainerMain.ContentPanel.Controls.Add(製造会社Label);
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.製造会社TextBox);
            this.toolStripContainerMain.ContentPanel.Controls.Add(入荷量Label);
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.入荷量TextBox);
            this.toolStripContainerMain.ContentPanel.Controls.Add(検査日Label);
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.検査日DateTimePicker);
            this.toolStripContainerMain.ContentPanel.Controls.Add(検査担当者Label);
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.検査担当者TextBox);
            this.toolStripContainerMain.ContentPanel.Controls.Add(検査確認者Label);
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.検査確認者TextBox);
            this.toolStripContainerMain.ContentPanel.Controls.Add(コメント品管その他検査項目Label);
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.コメント品管その他検査項目TextBox);
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.buttonCloseForm);
            this.toolStripContainerMain.ContentPanel.Controls.Add(入荷量単位Label);
            this.toolStripContainerMain.ContentPanel.Size = new System.Drawing.Size(1091, 637);
            this.toolStripContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainerMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainerMain.Name = "toolStripContainerMain";
            this.toolStripContainerMain.Size = new System.Drawing.Size(1091, 662);
            this.toolStripContainerMain.TabIndex = 2;
            this.toolStripContainerMain.Text = "toolStripContainer1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 537);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 70);
            this.button1.TabIndex = 67;
            this.button1.Text = "このデータを使って新規のワークシートを作成";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonClearCriteria
            // 
            this.buttonClearCriteria.Location = new System.Drawing.Point(944, 76);
            this.buttonClearCriteria.Name = "buttonClearCriteria";
            this.buttonClearCriteria.Size = new System.Drawing.Size(115, 39);
            this.buttonClearCriteria.TabIndex = 66;
            this.buttonClearCriteria.Text = "検索条件クリア";
            this.buttonClearCriteria.UseVisualStyleBackColor = true;
            this.buttonClearCriteria.Click += new System.EventHandler(this.buttonClearCriteria_Click);
            // 
            // checkBox検索モード
            // 
            this.checkBox検索モード.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox検索モード.AutoSize = true;
            this.checkBox検索モード.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.checkBox検索モード.FlatAppearance.BorderSize = 2;
            this.checkBox検索モード.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.checkBox検索モード.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox検索モード.Font = new System.Drawing.Font("メイリオ", 12F);
            this.checkBox検索モード.Location = new System.Drawing.Point(830, 36);
            this.checkBox検索モード.MaximumSize = new System.Drawing.Size(120, 0);
            this.checkBox検索モード.MinimumSize = new System.Drawing.Size(120, 0);
            this.checkBox検索モード.Name = "checkBox検索モード";
            this.checkBox検索モード.Size = new System.Drawing.Size(120, 34);
            this.checkBox検索モード.TabIndex = 65;
            this.checkBox検索モード.Text = "検索モード";
            this.checkBox検索モード.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox検索モード.UseVisualStyleBackColor = true;
            this.checkBox検索モード.CheckedChanged += new System.EventHandler(this.checkBox検索モード_CheckedChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(830, 78);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(94, 37);
            this.buttonSearch.TabIndex = 64;
            this.buttonSearch.Text = "検索";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dateTimePicker検索範囲終端
            // 
            this.dateTimePicker検索範囲終端.Font = new System.Drawing.Font("メイリオ", 12F);
            this.dateTimePicker検索範囲終端.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dateTimePicker検索範囲終端.Location = new System.Drawing.Point(35, 101);
            this.dateTimePicker検索範囲終端.Name = "dateTimePicker検索範囲終端";
            this.dateTimePicker検索範囲終端.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker検索範囲終端.TabIndex = 60;
            this.dateTimePicker検索範囲終端.TabStop = false;
            this.dateTimePicker検索範囲終端.Value = new System.DateTime(2014, 1, 24, 17, 19, 6, 0);
            // 
            // groupBox香気
            // 
            this.groupBox香気.Controls.Add(this.香気合否ComboBox);
            this.groupBox香気.Controls.Add(this.香気合否TextBox);
            this.groupBox香気.Controls.Add(香気合否Label);
            this.groupBox香気.Controls.Add(this.香気合否担当者TextBox);
            this.groupBox香気.Controls.Add(香気合否担当者Label);
            this.groupBox香気.Font = new System.Drawing.Font("メイリオ", 12F);
            this.groupBox香気.Location = new System.Drawing.Point(562, 134);
            this.groupBox香気.Name = "groupBox香気";
            this.groupBox香気.Size = new System.Drawing.Size(232, 115);
            this.groupBox香気.TabIndex = 58;
            this.groupBox香気.TabStop = false;
            this.groupBox香気.Text = "香気";
            // 
            // 香気合否ComboBox
            // 
            this.香気合否ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.原料検査ワークシートBindingSource, "香気合否", true));
            this.香気合否ComboBox.FormattingEnabled = true;
            this.香気合否ComboBox.Items.AddRange(new object[] {
            "合",
            "否"});
            this.香気合否ComboBox.Location = new System.Drawing.Point(142, 30);
            this.香気合否ComboBox.Name = "香気合否ComboBox";
            this.香気合否ComboBox.Size = new System.Drawing.Size(80, 32);
            this.香気合否ComboBox.TabIndex = 0;
            this.香気合否ComboBox.TabStop = false;
            // 
            // 原料検査ワークシートBindingSource
            // 
            this.原料検査ワークシートBindingSource.DataMember = "原料検査ワークシート";
            this.原料検査ワークシートBindingSource.DataSource = this.dataSet検査ワークシート;
            // 
            // dataSet検査ワークシート
            // 
            this.dataSet検査ワークシート.DataSetName = "DataSet検査ワークシート";
            this.dataSet検査ワークシート.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 香気合否TextBox
            // 
            this.香気合否TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.原料検査ワークシートBindingSource, "香気合否", true));
            this.香気合否TextBox.Font = new System.Drawing.Font("メイリオ", 10F);
            this.香気合否TextBox.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.香気合否TextBox.Location = new System.Drawing.Point(81, 33);
            this.香気合否TextBox.Name = "香気合否TextBox";
            this.香気合否TextBox.Size = new System.Drawing.Size(55, 27);
            this.香気合否TextBox.TabIndex = 9;
            this.香気合否TextBox.TextChanged += new System.EventHandler(this.合否TextBox_TextChanged);
            // 
            // 香気合否担当者TextBox
            // 
            this.香気合否担当者TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.原料検査ワークシートBindingSource, "香気合否担当者", true));
            this.香気合否担当者TextBox.Font = new System.Drawing.Font("メイリオ", 10F);
            this.香気合否担当者TextBox.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.香気合否担当者TextBox.Location = new System.Drawing.Point(81, 66);
            this.香気合否担当者TextBox.Name = "香気合否担当者TextBox";
            this.香気合否担当者TextBox.Size = new System.Drawing.Size(122, 27);
            this.香気合否担当者TextBox.TabIndex = 39;
            this.香気合否担当者TextBox.TabStop = false;
            // 
            // groupBox色調性状
            // 
            this.groupBox色調性状.Controls.Add(this.色調性状合否TextBox);
            this.groupBox色調性状.Controls.Add(色調性状合否Label);
            this.groupBox色調性状.Controls.Add(this.色調性状合否担当者TextBox);
            this.groupBox色調性状.Controls.Add(色調性状合否担当者Label);
            this.groupBox色調性状.Font = new System.Drawing.Font("メイリオ", 12F);
            this.groupBox色調性状.Location = new System.Drawing.Point(830, 134);
            this.groupBox色調性状.Name = "groupBox色調性状";
            this.groupBox色調性状.Size = new System.Drawing.Size(232, 115);
            this.groupBox色調性状.TabIndex = 59;
            this.groupBox色調性状.TabStop = false;
            this.groupBox色調性状.Text = "色調・性状";
            // 
            // 色調性状合否TextBox
            // 
            this.色調性状合否TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.原料検査ワークシートBindingSource, "色調性状合否", true));
            this.色調性状合否TextBox.Font = new System.Drawing.Font("メイリオ", 10F);
            this.色調性状合否TextBox.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.色調性状合否TextBox.Location = new System.Drawing.Point(78, 33);
            this.色調性状合否TextBox.Name = "色調性状合否TextBox";
            this.色調性状合否TextBox.Size = new System.Drawing.Size(122, 27);
            this.色調性状合否TextBox.TabIndex = 10;
            this.色調性状合否TextBox.TextChanged += new System.EventHandler(this.合否TextBox_TextChanged);
            // 
            // 色調性状合否担当者TextBox
            // 
            this.色調性状合否担当者TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.原料検査ワークシートBindingSource, "色調性状合否担当者", true));
            this.色調性状合否担当者TextBox.Font = new System.Drawing.Font("メイリオ", 10F);
            this.色調性状合否担当者TextBox.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.色調性状合否担当者TextBox.Location = new System.Drawing.Point(78, 66);
            this.色調性状合否担当者TextBox.Name = "色調性状合否担当者TextBox";
            this.色調性状合否担当者TextBox.Size = new System.Drawing.Size(122, 27);
            this.色調性状合否担当者TextBox.TabIndex = 31;
            this.色調性状合否担当者TextBox.TabStop = false;
            // 
            // 原料コードTextBox
            // 
            this.原料コードTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.原料検査ワークシートBindingSource, "原料コード", true));
            this.原料コードTextBox.DataSourceTable = null;
            this.原料コードTextBox.Font = new System.Drawing.Font("メイリオ", 12F);
            this.原料コードTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.原料コードTextBox.Location = new System.Drawing.Point(35, 234);
            this.原料コードTextBox.Name = "原料コードTextBox";
            this.原料コードTextBox.Size = new System.Drawing.Size(200, 31);
            this.原料コードTextBox.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.官能検査合否TextBox);
            this.panel1.Controls.Add(官能検査合否Label);
            this.panel1.Controls.Add(this.官能検査日DateTimePicker);
            this.panel1.Controls.Add(官能検査日Label);
            this.panel1.Controls.Add(this.香気検査日DateTimePicker);
            this.panel1.Controls.Add(香気検査日Label);
            this.panel1.Controls.Add(this.色調性状検査日DateTimePicker);
            this.panel1.Controls.Add(this.官能検査担当者TextBox);
            this.panel1.Controls.Add(色調性状検査日Label);
            this.panel1.Controls.Add(官能検査担当者Label);
            this.panel1.Controls.Add(this.色調性状合否確認者TextBox);
            this.panel1.Controls.Add(色調性状合否確認者Label);
            this.panel1.Controls.Add(香気合否確認者Label);
            this.panel1.Controls.Add(this.香気合否確認者TextBox);
            this.panel1.Font = new System.Drawing.Font("メイリオ", 8F);
            this.panel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(909, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(62, 103);
            this.panel1.TabIndex = 56;
            this.panel1.Visible = false;
            // 
            // 官能検査合否TextBox
            // 
            this.官能検査合否TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.原料検査ワークシートBindingSource, "官能検査合否", true));
            this.官能検査合否TextBox.Location = new System.Drawing.Point(112, 152);
            this.官能検査合否TextBox.Name = "官能検査合否TextBox";
            this.官能検査合否TextBox.Size = new System.Drawing.Size(63, 23);
            this.官能検査合否TextBox.TabIndex = 19;
            this.官能検査合否TextBox.TabStop = false;
            // 
            // 官能検査日DateTimePicker
            // 
            this.官能検査日DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.原料検査ワークシートBindingSource, "官能検査日", true));
            this.官能検査日DateTimePicker.Location = new System.Drawing.Point(104, 15);
            this.官能検査日DateTimePicker.Name = "官能検査日DateTimePicker";
            this.官能検査日DateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.官能検査日DateTimePicker.TabIndex = 45;
            this.官能検査日DateTimePicker.TabStop = false;
            this.官能検査日DateTimePicker.Value = new System.DateTime(2014, 1, 24, 23, 22, 42, 0);
            // 
            // 香気検査日DateTimePicker
            // 
            this.香気検査日DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.原料検査ワークシートBindingSource, "香気検査日", true));
            this.香気検査日DateTimePicker.Font = new System.Drawing.Font("メイリオ", 8F);
            this.香気検査日DateTimePicker.Location = new System.Drawing.Point(104, 62);
            this.香気検査日DateTimePicker.Name = "香気検査日DateTimePicker";
            this.香気検査日DateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.香気検査日DateTimePicker.TabIndex = 37;
            this.香気検査日DateTimePicker.TabStop = false;
            this.香気検査日DateTimePicker.Value = new System.DateTime(2014, 1, 24, 23, 22, 42, 0);
            // 
            // 色調性状検査日DateTimePicker
            // 
            this.色調性状検査日DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.原料検査ワークシートBindingSource, "色調性状検査日", true));
            this.色調性状検査日DateTimePicker.Font = new System.Drawing.Font("メイリオ", 8F);
            this.色調性状検査日DateTimePicker.Location = new System.Drawing.Point(104, 38);
            this.色調性状検査日DateTimePicker.Name = "色調性状検査日DateTimePicker";
            this.色調性状検査日DateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.色調性状検査日DateTimePicker.TabIndex = 29;
            this.色調性状検査日DateTimePicker.TabStop = false;
            this.色調性状検査日DateTimePicker.Value = new System.DateTime(2014, 1, 24, 23, 22, 42, 0);
            // 
            // 官能検査担当者TextBox
            // 
            this.官能検査担当者TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.原料検査ワークシートBindingSource, "官能検査担当者", true));
            this.官能検査担当者TextBox.Location = new System.Drawing.Point(112, 173);
            this.官能検査担当者TextBox.Name = "官能検査担当者TextBox";
            this.官能検査担当者TextBox.Size = new System.Drawing.Size(63, 23);
            this.官能検査担当者TextBox.TabIndex = 47;
            this.官能検査担当者TextBox.TabStop = false;
            // 
            // 色調性状合否確認者TextBox
            // 
            this.色調性状合否確認者TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.原料検査ワークシートBindingSource, "色調性状合否確認者", true));
            this.色調性状合否確認者TextBox.Location = new System.Drawing.Point(127, 96);
            this.色調性状合否確認者TextBox.Name = "色調性状合否確認者TextBox";
            this.色調性状合否確認者TextBox.Size = new System.Drawing.Size(151, 23);
            this.色調性状合否確認者TextBox.TabIndex = 33;
            this.色調性状合否確認者TextBox.TabStop = false;
            // 
            // 香気合否確認者TextBox
            // 
            this.香気合否確認者TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.原料検査ワークシートBindingSource, "香気合否確認者", true));
            this.香気合否確認者TextBox.Location = new System.Drawing.Point(127, 119);
            this.香気合否確認者TextBox.Name = "香気合否確認者TextBox";
            this.香気合否確認者TextBox.Size = new System.Drawing.Size(175, 23);
            this.香気合否確認者TextBox.TabIndex = 41;
            this.香気合否確認者TextBox.TabStop = false;
            // 
            // 原料名TextBox
            // 
            this.原料名TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.原料検査ワークシートBindingSource, "原料名", true));
            this.原料名TextBox.DataSourceTable = null;
            this.原料名TextBox.Font = new System.Drawing.Font("メイリオ", 12F);
            this.原料名TextBox.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.原料名TextBox.Location = new System.Drawing.Point(35, 161);
            this.原料名TextBox.Name = "原料名TextBox";
            this.原料名TextBox.Size = new System.Drawing.Size(467, 31);
            this.原料名TextBox.TabIndex = 2;
            // 
            // ロット番号TextBox
            // 
            this.ロット番号TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.原料検査ワークシートBindingSource, "ロット番号", true));
            this.ロット番号TextBox.DataSourceTable = null;
            this.ロット番号TextBox.Font = new System.Drawing.Font("メイリオ", 12F);
            this.ロット番号TextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ロット番号TextBox.Location = new System.Drawing.Point(300, 234);
            this.ロット番号TextBox.Name = "ロット番号TextBox";
            this.ロット番号TextBox.Size = new System.Drawing.Size(200, 31);
            this.ロット番号TextBox.TabIndex = 4;
            // 
            // ロット番号備考TextBox
            // 
            this.ロット番号備考TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ロット番号備考TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.原料検査ワークシートBindingSource, "ロット番号備考", true));
            this.ロット番号備考TextBox.DataSourceTable = null;
            this.ロット番号備考TextBox.Enabled = false;
            this.ロット番号備考TextBox.Font = new System.Drawing.Font("メイリオ", 8F);
            this.ロット番号備考TextBox.Location = new System.Drawing.Point(305, 265);
            this.ロット番号備考TextBox.Name = "ロット番号備考TextBox";
            this.ロット番号備考TextBox.Size = new System.Drawing.Size(195, 16);
            this.ロット番号備考TextBox.TabIndex = 9;
            // 
            // 入荷日DateTimePicker
            // 
            this.入荷日DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.原料検査ワークシートBindingSource, "入荷日", true));
            this.入荷日DateTimePicker.Font = new System.Drawing.Font("メイリオ", 10F);
            this.入荷日DateTimePicker.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.入荷日DateTimePicker.Location = new System.Drawing.Point(35, 327);
            this.入荷日DateTimePicker.Name = "入荷日DateTimePicker";
            this.入荷日DateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.入荷日DateTimePicker.TabIndex = 5;
            this.入荷日DateTimePicker.Value = new System.DateTime(2014, 1, 24, 23, 22, 42, 0);
            // 
            // 入荷日テキストTextBox
            // 
            this.入荷日テキストTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.入荷日テキストTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.原料検査ワークシートBindingSource, "入荷日テキスト", true));
            this.入荷日テキストTextBox.Enabled = false;
            this.入荷日テキストTextBox.Font = new System.Drawing.Font("メイリオ", 8F);
            this.入荷日テキストTextBox.Location = new System.Drawing.Point(40, 354);
            this.入荷日テキストTextBox.Name = "入荷日テキストTextBox";
            this.入荷日テキストTextBox.Size = new System.Drawing.Size(195, 16);
            this.入荷日テキストTextBox.TabIndex = 13;
            // 
            // 納入元TextBox
            // 
            this.納入元TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.原料検査ワークシートBindingSource, "納入元", true));
            this.納入元TextBox.DataSourceTable = null;
            this.納入元TextBox.Font = new System.Drawing.Font("メイリオ", 10F);
            this.納入元TextBox.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.納入元TextBox.Location = new System.Drawing.Point(35, 413);
            this.納入元TextBox.Name = "納入元TextBox";
            this.納入元TextBox.Size = new System.Drawing.Size(200, 27);
            this.納入元TextBox.TabIndex = 7;
            // 
            // 容器封緘ラベルTextBox
            // 
            this.容器封緘ラベルTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.原料検査ワークシートBindingSource, "容器封緘ラベル", true));
            this.容器封緘ラベルTextBox.Font = new System.Drawing.Font("メイリオ", 10F);
            this.容器封緘ラベルTextBox.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.容器封緘ラベルTextBox.Location = new System.Drawing.Point(565, 302);
            this.容器封緘ラベルTextBox.Name = "容器封緘ラベルTextBox";
            this.容器封緘ラベルTextBox.Size = new System.Drawing.Size(200, 27);
            this.容器封緘ラベルTextBox.TabIndex = 11;
            // 
            // 総合判定合否TextBox
            // 
            this.総合判定合否TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.総合判定合否TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.原料検査ワークシートBindingSource, "総合判定合否", true));
            this.総合判定合否TextBox.Font = new System.Drawing.Font("メイリオ", 28F);
            this.総合判定合否TextBox.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.総合判定合否TextBox.Location = new System.Drawing.Point(542, 549);
            this.総合判定合否TextBox.Name = "総合判定合否TextBox";
            this.総合判定合否TextBox.Size = new System.Drawing.Size(156, 63);
            this.総合判定合否TextBox.TabIndex = 13;
            this.総合判定合否TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 製造会社TextBox
            // 
            this.製造会社TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.原料検査ワークシートBindingSource, "製造会社", true));
            this.製造会社TextBox.DataSourceTable = null;
            this.製造会社TextBox.Font = new System.Drawing.Font("メイリオ", 10F);
            this.製造会社TextBox.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.製造会社TextBox.Location = new System.Drawing.Point(300, 413);
            this.製造会社TextBox.Name = "製造会社TextBox";
            this.製造会社TextBox.Size = new System.Drawing.Size(200, 27);
            this.製造会社TextBox.TabIndex = 8;
            // 
            // 入荷量TextBox
            // 
            this.入荷量TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.原料検査ワークシートBindingSource, "入荷量", true));
            this.入荷量TextBox.Font = new System.Drawing.Font("メイリオ", 10F);
            this.入荷量TextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.入荷量TextBox.Location = new System.Drawing.Point(300, 327);
            this.入荷量TextBox.Name = "入荷量TextBox";
            this.入荷量TextBox.Size = new System.Drawing.Size(86, 27);
            this.入荷量TextBox.TabIndex = 6;
            this.入荷量TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // 検査日DateTimePicker
            // 
            this.検査日DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.原料検査ワークシートBindingSource, "検査日", true));
            this.検査日DateTimePicker.Font = new System.Drawing.Font("メイリオ", 12F);
            this.検査日DateTimePicker.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.検査日DateTimePicker.Location = new System.Drawing.Point(35, 69);
            this.検査日DateTimePicker.Name = "検査日DateTimePicker";
            this.検査日DateTimePicker.Size = new System.Drawing.Size(200, 31);
            this.検査日DateTimePicker.TabIndex = 0;
            this.検査日DateTimePicker.Value = new System.DateTime(2014, 1, 24, 23, 22, 42, 0);
            this.検査日DateTimePicker.ValueChanged += new System.EventHandler(this.検査日DateTimePicker_ValueChanged);
            // 
            // 検査担当者TextBox
            // 
            this.検査担当者TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.原料検査ワークシートBindingSource, "検査担当者", true));
            this.検査担当者TextBox.DataSourceTable = null;
            this.検査担当者TextBox.Font = new System.Drawing.Font("メイリオ", 12F);
            this.検査担当者TextBox.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.検査担当者TextBox.Location = new System.Drawing.Point(300, 69);
            this.検査担当者TextBox.Name = "検査担当者TextBox";
            this.検査担当者TextBox.Size = new System.Drawing.Size(200, 31);
            this.検査担当者TextBox.TabIndex = 1;
            this.検査担当者TextBox.TextChanged += new System.EventHandler(this.検査担当者TextBox_TextChanged);
            // 
            // 検査確認者TextBox
            // 
            this.検査確認者TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.原料検査ワークシートBindingSource, "検査確認者", true));
            this.検査確認者TextBox.DataSourceTable = null;
            this.検査確認者TextBox.Font = new System.Drawing.Font("メイリオ", 12F);
            this.検査確認者TextBox.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.検査確認者TextBox.Location = new System.Drawing.Point(562, 69);
            this.検査確認者TextBox.Name = "検査確認者TextBox";
            this.検査確認者TextBox.Size = new System.Drawing.Size(200, 31);
            this.検査確認者TextBox.TabIndex = 6;
            this.検査確認者TextBox.TabStop = false;
            // 
            // コメント品管その他検査項目TextBox
            // 
            this.コメント品管その他検査項目TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.原料検査ワークシートBindingSource, "コメント品管その他検査項目", true));
            this.コメント品管その他検査項目TextBox.DataSourceTable = null;
            this.コメント品管その他検査項目TextBox.Font = new System.Drawing.Font("メイリオ", 10F);
            this.コメント品管その他検査項目TextBox.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.コメント品管その他検査項目TextBox.Location = new System.Drawing.Point(565, 376);
            this.コメント品管その他検査項目TextBox.Multiline = true;
            this.コメント品管その他検査項目TextBox.Name = "コメント品管その他検査項目TextBox";
            this.コメント品管その他検査項目TextBox.Size = new System.Drawing.Size(494, 132);
            this.コメント品管その他検査項目TextBox.TabIndex = 12;
            // 
            // 原料検査ワークシートBindingNavigator
            // 
            this.原料検査ワークシートBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.原料検査ワークシートBindingNavigator.BindingSource = this.原料検査ワークシートBindingSource;
            this.原料検査ワークシートBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.原料検査ワークシートBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.原料検査ワークシートBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.原料検査ワークシートBindingNavigatorSaveItem});
            this.原料検査ワークシートBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.原料検査ワークシートBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.原料検査ワークシートBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.原料検査ワークシートBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.原料検査ワークシートBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.原料検査ワークシートBindingNavigator.Name = "原料検査ワークシートBindingNavigator";
            this.原料検査ワークシートBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.原料検査ワークシートBindingNavigator.Size = new System.Drawing.Size(1091, 25);
            this.原料検査ワークシートBindingNavigator.TabIndex = 3;
            this.原料検査ワークシートBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新規追加";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // 
            // 原料検査ワークシートBindingNavigatorSaveItem
            // 
            this.原料検査ワークシートBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.原料検査ワークシートBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("原料検査ワークシートBindingNavigatorSaveItem.Image")));
            this.原料検査ワークシートBindingNavigatorSaveItem.Name = "原料検査ワークシートBindingNavigatorSaveItem";
            this.原料検査ワークシートBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.原料検査ワークシートBindingNavigatorSaveItem.Text = "データの保存";
            this.原料検査ワークシートBindingNavigatorSaveItem.Click += new System.EventHandler(this.原料検査ワークシートBindingNavigatorSaveItem_Click);
            // 
            // 原料検査ワークシートTableAdapter
            // 
            this.原料検査ワークシートTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._x_Study1TableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = CCJ_QAQC.DataSet検査ワークシートTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.検査ワークシートヘッダTableAdapter = null;
            this.tableAdapterManager.検査ワークシート属性日付数量TableAdapter = null;
            this.tableAdapterManager.検査ワークシート属性測定値TableAdapter = null;
            // 
            // Form原料検査WS詳細
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 684);
            this.Controls.Add(this.原料検査ワークシートBindingNavigator);
            this.Controls.Add(this.toolStripContainerMain);
            this.Name = "Form原料検査WS詳細";
            this.Text = "原料検査ワークシート　詳細画面";
            this.Load += new System.EventHandler(this.Form原料検査WS詳細_Load);
            this.Controls.SetChildIndex(this.toolStripContainerMain, 0);
            this.Controls.SetChildIndex(this.原料検査ワークシートBindingNavigator, 0);
            this.toolStripContainerMain.ContentPanel.ResumeLayout(false);
            this.toolStripContainerMain.ContentPanel.PerformLayout();
            this.toolStripContainerMain.ResumeLayout(false);
            this.toolStripContainerMain.PerformLayout();
            this.groupBox香気.ResumeLayout(false);
            this.groupBox香気.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.原料検査ワークシートBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet検査ワークシート)).EndInit();
            this.groupBox色調性状.ResumeLayout(false);
            this.groupBox色調性状.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.原料検査ワークシートBindingNavigator)).EndInit();
            this.原料検査ワークシートBindingNavigator.ResumeLayout(false);
            this.原料検査ワークシートBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainerMain;
        private DataSet検査ワークシート dataSet検査ワークシート;
        private System.Windows.Forms.BindingSource 原料検査ワークシートBindingSource;
        private DataSet検査ワークシートTableAdapters.原料検査ワークシートTableAdapter 原料検査ワークシートTableAdapter;
        private DataSet検査ワークシートTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator 原料検査ワークシートBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton 原料検査ワークシートBindingNavigatorSaveItem;
        private Kawai.ApplicationBase.SearchCritriaTextBox 原料コードTextBox;
        private Kawai.ApplicationBase.SearchCritriaTextBox 原料名TextBox;
        private Kawai.ApplicationBase.SearchCritriaTextBox ロット番号TextBox;
        private Kawai.ApplicationBase.SearchCritriaTextBox ロット番号備考TextBox;
        private Kawai.ApplicationBase.NullableDateTimePicker 入荷日DateTimePicker;
        private System.Windows.Forms.TextBox 入荷日テキストTextBox;
        private Kawai.ApplicationBase.SearchCritriaTextBox 納入元TextBox;
        private System.Windows.Forms.TextBox 容器封緘ラベルTextBox;
        private System.Windows.Forms.TextBox 官能検査合否TextBox;
        private System.Windows.Forms.TextBox 総合判定合否TextBox;
        private Kawai.ApplicationBase.SearchCritriaTextBox 製造会社TextBox;
        private System.Windows.Forms.TextBox 入荷量TextBox;
        private Kawai.ApplicationBase.NullableDateTimePicker 色調性状検査日DateTimePicker;
        private System.Windows.Forms.TextBox 色調性状合否担当者TextBox;
        private System.Windows.Forms.TextBox 色調性状合否確認者TextBox;
        private System.Windows.Forms.TextBox 色調性状合否TextBox;
        private Kawai.ApplicationBase.NullableDateTimePicker 香気検査日DateTimePicker;
        private System.Windows.Forms.TextBox 香気合否確認者TextBox;
        private Kawai.ApplicationBase.NullableDateTimePicker 官能検査日DateTimePicker;
        private System.Windows.Forms.TextBox 官能検査担当者TextBox;
        private Kawai.ApplicationBase.NullableDateTimePicker 検査日DateTimePicker;
        private Kawai.ApplicationBase.SearchCritriaTextBox 検査担当者TextBox;
        private Kawai.ApplicationBase.SearchCritriaTextBox 検査確認者TextBox;
        private Kawai.ApplicationBase.SearchCritriaTextBox コメント品管その他検査項目TextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox色調性状;
        private System.Windows.Forms.GroupBox groupBox香気;
        private System.Windows.Forms.TextBox 香気合否TextBox;
        private System.Windows.Forms.TextBox 香気合否担当者TextBox;
        private Kawai.ApplicationBase.NullableDateTimePicker dateTimePicker検索範囲終端;
        private System.Windows.Forms.ComboBox 香気合否ComboBox;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.CheckBox checkBox検索モード;
        private System.Windows.Forms.Button buttonClearCriteria;
        private System.Windows.Forms.Button button1;

    }
}