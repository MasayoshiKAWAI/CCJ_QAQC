namespace CCJ_QAQC
{
    partial class Form元番製品コード検索
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox製品コード = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox元番 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton処方箋台帳を検索 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton開発処方箋台帳を検索 = new System.Windows.Forms.RadioButton();
            this.元番製品コード = new CCJ_QAQC.元番製品コード();
            this.開発処方箋台帳BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.開発処方箋台帳TableAdapter = new CCJ_QAQC.元番製品コードTableAdapters.開発処方箋台帳TableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonClear = new System.Windows.Forms.Button();
            this.処方箋BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.処方箋TableAdapter = new CCJ_QAQC.元番製品コードTableAdapters.処方箋TableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.元番製品コード)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.開発処方箋台帳BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.処方箋BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCloseForm.Location = new System.Drawing.Point(785, 42);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(747, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "サブフォームを開く";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox製品コード
            // 
            this.textBox製品コード.Location = new System.Drawing.Point(96, 96);
            this.textBox製品コード.Name = "textBox製品コード";
            this.textBox製品コード.Size = new System.Drawing.Size(129, 25);
            this.textBox製品コード.TabIndex = 4;
            this.textBox製品コード.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(465, 40);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(112, 55);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "検索";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "製品コード";
            // 
            // textBox元番
            // 
            this.textBox元番.Location = new System.Drawing.Point(96, 33);
            this.textBox元番.Name = "textBox元番";
            this.textBox元番.Size = new System.Drawing.Size(129, 25);
            this.textBox元番.TabIndex = 4;
            this.textBox元番.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "元番";
            // 
            // radioButton処方箋台帳を検索
            // 
            this.radioButton処方箋台帳を検索.AutoSize = true;
            this.radioButton処方箋台帳を検索.Checked = true;
            this.radioButton処方箋台帳を検索.Location = new System.Drawing.Point(15, 16);
            this.radioButton処方箋台帳を検索.Name = "radioButton処方箋台帳を検索";
            this.radioButton処方箋台帳を検索.Size = new System.Drawing.Size(122, 22);
            this.radioButton処方箋台帳を検索.TabIndex = 10;
            this.radioButton処方箋台帳を検索.TabStop = true;
            this.radioButton処方箋台帳を検索.Text = "処方箋台帳を検索";
            this.radioButton処方箋台帳を検索.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton開発処方箋台帳を検索);
            this.groupBox1.Controls.Add(this.radioButton処方箋台帳を検索);
            this.groupBox1.Location = new System.Drawing.Point(248, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 75);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // radioButton開発処方箋台帳を検索
            // 
            this.radioButton開発処方箋台帳を検索.AutoSize = true;
            this.radioButton開発処方箋台帳を検索.Location = new System.Drawing.Point(15, 41);
            this.radioButton開発処方箋台帳を検索.Name = "radioButton開発処方箋台帳を検索";
            this.radioButton開発処方箋台帳を検索.Size = new System.Drawing.Size(146, 22);
            this.radioButton開発処方箋台帳を検索.TabIndex = 10;
            this.radioButton開発処方箋台帳を検索.Text = "開発処方箋台帳を検索";
            this.radioButton開発処方箋台帳を検索.UseVisualStyleBackColor = true;
            // 
            // 元番製品コード
            // 
            this.元番製品コード.DataSetName = "元番製品コード";
            this.元番製品コード.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 開発処方箋台帳BindingSource
            // 
            this.開発処方箋台帳BindingSource.DataMember = "開発処方箋台帳";
            this.開発処方箋台帳BindingSource.DataSource = this.元番製品コード;
            // 
            // 開発処方箋台帳TableAdapter
            // 
            this.開発処方箋台帳TableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(884, 501);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(637, 39);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 56);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "検索条件クリア";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // 処方箋BindingSource
            // 
            this.処方箋BindingSource.DataMember = "処方箋";
            this.処方箋BindingSource.DataSource = this.元番製品コード;
            // 
            // 処方箋TableAdapter
            // 
            this.処方箋TableAdapter.ClearBeforeFill = true;
            // 
            // Form元番製品コード検索
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 662);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBox元番);
            this.Controls.Add(this.textBox製品コード);
            this.Controls.Add(this.button1);
            this.Name = "Form元番製品コード検索";
            this.Text = "元番・製品コード検索";
            this.Load += new System.EventHandler(this.Form元番製品コード検索_Load);
            this.Controls.SetChildIndex(this.buttonCloseForm, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.textBox製品コード, 0);
            this.Controls.SetChildIndex(this.textBox元番, 0);
            this.Controls.SetChildIndex(this.buttonSearch, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.buttonClear, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.元番製品コード)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.開発処方箋台帳BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.処方箋BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private 元番製品コード 元番製品コード;
        private System.Windows.Forms.TextBox textBox製品コード;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource 開発処方箋台帳BindingSource;
        private 元番製品コードTableAdapters.開発処方箋台帳TableAdapter 開発処方箋台帳TableAdapter;
        private System.Windows.Forms.TextBox textBox元番;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton処方箋台帳を検索;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton開発処方箋台帳を検索;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.BindingSource 処方箋BindingSource;
        private 元番製品コードTableAdapters.処方箋TableAdapter 処方箋TableAdapter;

    }
}