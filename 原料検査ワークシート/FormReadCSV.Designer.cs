namespace CCJ_QAQC
{
    partial class FormReadCSV
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonReadCSV = new System.Windows.Forms.Button();
            this.textBoxLoadPath = new System.Windows.Forms.TextBox();
            this.dataGridViewCSVData = new System.Windows.Forms.DataGridView();
            this.checkBoxFirstRowIsTitle = new System.Windows.Forms.CheckBox();
            this.buttonWriteToDB = new System.Windows.Forms.Button();
            this.checkBoxSortable = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem列の消去 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxMultiselectable = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCSVData)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.Location = new System.Drawing.Point(785, 576);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "*.csv";
            this.openFileDialog1.Filter = "CSVファイル|*.CSV ";
            // 
            // buttonReadCSV
            // 
            this.buttonReadCSV.Location = new System.Drawing.Point(32, 16);
            this.buttonReadCSV.Name = "buttonReadCSV";
            this.buttonReadCSV.Size = new System.Drawing.Size(180, 50);
            this.buttonReadCSV.TabIndex = 3;
            this.buttonReadCSV.Text = "CSVファイル読み込み";
            this.buttonReadCSV.UseVisualStyleBackColor = true;
            this.buttonReadCSV.Click += new System.EventHandler(this.buttonReadCSV_Click);
            // 
            // textBoxLoadPath
            // 
            this.textBoxLoadPath.Location = new System.Drawing.Point(236, 16);
            this.textBoxLoadPath.Name = "textBoxLoadPath";
            this.textBoxLoadPath.Size = new System.Drawing.Size(596, 25);
            this.textBoxLoadPath.TabIndex = 4;
            // 
            // dataGridViewCSVData
            // 
            this.dataGridViewCSVData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCSVData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCSVData.Location = new System.Drawing.Point(0, 82);
            this.dataGridViewCSVData.MultiSelect = false;
            this.dataGridViewCSVData.Name = "dataGridViewCSVData";
            this.dataGridViewCSVData.RowTemplate.Height = 21;
            this.dataGridViewCSVData.Size = new System.Drawing.Size(884, 477);
            this.dataGridViewCSVData.TabIndex = 5;
            this.dataGridViewCSVData.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCSVData_CellMouseClick);
            this.dataGridViewCSVData.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCSVData_ColumnHeaderMouseClick);
            // 
            // checkBoxFirstRowIsTitle
            // 
            this.checkBoxFirstRowIsTitle.AutoSize = true;
            this.checkBoxFirstRowIsTitle.Location = new System.Drawing.Point(236, 47);
            this.checkBoxFirstRowIsTitle.Name = "checkBoxFirstRowIsTitle";
            this.checkBoxFirstRowIsTitle.Size = new System.Drawing.Size(243, 22);
            this.checkBoxFirstRowIsTitle.TabIndex = 6;
            this.checkBoxFirstRowIsTitle.Text = "先頭行をデータの見出しとして使用する";
            this.checkBoxFirstRowIsTitle.UseVisualStyleBackColor = true;
            // 
            // buttonWriteToDB
            // 
            this.buttonWriteToDB.Location = new System.Drawing.Point(32, 576);
            this.buttonWriteToDB.Name = "buttonWriteToDB";
            this.buttonWriteToDB.Size = new System.Drawing.Size(180, 50);
            this.buttonWriteToDB.TabIndex = 7;
            this.buttonWriteToDB.Text = "データベースへ書き込み";
            this.buttonWriteToDB.UseVisualStyleBackColor = true;
            this.buttonWriteToDB.Click += new System.EventHandler(this.buttonWriteToDB_Click);
            // 
            // checkBoxSortable
            // 
            this.checkBoxSortable.AutoSize = true;
            this.checkBoxSortable.Checked = true;
            this.checkBoxSortable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSortable.Location = new System.Drawing.Point(689, 54);
            this.checkBoxSortable.Name = "checkBoxSortable";
            this.checkBoxSortable.Size = new System.Drawing.Size(195, 22);
            this.checkBoxSortable.TabIndex = 8;
            this.checkBoxSortable.Text = "列見出しをクリックで並べ替え";
            this.checkBoxSortable.UseVisualStyleBackColor = true;
            this.checkBoxSortable.CheckedChanged += new System.EventHandler(this.checkBoxSortable_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem列の消去});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // ToolStripMenuItem列の消去
            // 
            this.ToolStripMenuItem列の消去.Name = "ToolStripMenuItem列の消去";
            this.ToolStripMenuItem列の消去.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem列の消去.Text = "列の消去";
            this.ToolStripMenuItem列の消去.Click += new System.EventHandler(this.ToolStripMenuItem列の消去_Click);
            // 
            // checkBoxMultiselectable
            // 
            this.checkBoxMultiselectable.AutoSize = true;
            this.checkBoxMultiselectable.Location = new System.Drawing.Point(549, 54);
            this.checkBoxMultiselectable.Name = "checkBoxMultiselectable";
            this.checkBoxMultiselectable.Size = new System.Drawing.Size(111, 22);
            this.checkBoxMultiselectable.TabIndex = 9;
            this.checkBoxMultiselectable.Text = "複数列選択可能";
            this.checkBoxMultiselectable.UseVisualStyleBackColor = true;
            this.checkBoxMultiselectable.CheckedChanged += new System.EventHandler(this.checkBoxMultiselectable_CheckedChanged);
            // 
            // FormReadCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 662);
            this.Controls.Add(this.checkBoxMultiselectable);
            this.Controls.Add(this.checkBoxSortable);
            this.Controls.Add(this.buttonWriteToDB);
            this.Controls.Add(this.checkBoxFirstRowIsTitle);
            this.Controls.Add(this.dataGridViewCSVData);
            this.Controls.Add(this.textBoxLoadPath);
            this.Controls.Add(this.buttonReadCSV);
            this.Name = "FormReadCSV";
            this.Text = "Form21";
            this.Controls.SetChildIndex(this.buttonCloseForm, 0);
            this.Controls.SetChildIndex(this.buttonReadCSV, 0);
            this.Controls.SetChildIndex(this.textBoxLoadPath, 0);
            this.Controls.SetChildIndex(this.dataGridViewCSVData, 0);
            this.Controls.SetChildIndex(this.checkBoxFirstRowIsTitle, 0);
            this.Controls.SetChildIndex(this.buttonWriteToDB, 0);
            this.Controls.SetChildIndex(this.checkBoxSortable, 0);
            this.Controls.SetChildIndex(this.checkBoxMultiselectable, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCSVData)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonReadCSV;
        private System.Windows.Forms.TextBox textBoxLoadPath;
        private System.Windows.Forms.DataGridView dataGridViewCSVData;
        private System.Windows.Forms.CheckBox checkBoxFirstRowIsTitle;
        private System.Windows.Forms.Button buttonWriteToDB;
        private System.Windows.Forms.CheckBox checkBoxSortable;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem列の消去;
        private System.Windows.Forms.CheckBox checkBoxMultiselectable;
    }
}