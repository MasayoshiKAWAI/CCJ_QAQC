using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kawai.ApplicationBase;

namespace CCJ_QAQC
{
    public partial class Form元番製品コード検索 : FormBase
    {
        public Form元番製品コード検索(Stack<FormInformation> formopenorderstack, FormInformation forminformation)
            : base(formopenorderstack, forminformation)
        {
            InitializeComponent();

            this.ApplicationName = Properties.Settings.Default.ApplicationName;
            this.ApplicationVersion = Properties.Settings.Default.Version;
            this.ModifyDate = Properties.Settings.Default.ModifyDate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //このFormから開ける新しいFormに、FormOpenOrderStackを渡し、自分自身をスタックに登録しておく。
            FormReadCSV frm = new FormReadCSV(this.FormOpenOrderStack, new FormInformation() { OriginForm = this, FormGuid = this.MyGUID });
            frm.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form元番製品コード検索_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'dataSet元番材料コード.処方箋' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            //this.処方箋TableAdapter.Fill(this.dataSet元番材料コード.処方箋);
            // TODO: このコード行はデータを '元番製品コード.処方箋' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            //this.処方箋TableAdapter.Fill(this.元番製品コード.処方箋);
            // TODO: このコード行はデータを '元番製品コード.開発処方箋台帳' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            //this.開発処方箋台帳TableAdapter.Fill(this.元番製品コード.開発処方箋台帳);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //this.dataGridView1.DataSource = this.処方箋BindingSource;
            //this.dataGridView1.DataMember = this.処方箋BindingSource
            //this.dataGridView1.ClearSelection();
            
            if (!string.IsNullOrWhiteSpace(this.textBox製品コード.Text) && !string.IsNullOrWhiteSpace(this.textBox元番.Text))
            {
            }
            else if (!string.IsNullOrWhiteSpace(this.textBox製品コード.Text) && string.IsNullOrWhiteSpace(this.textBox元番.Text))
            {
                this.処方箋TableAdapter.FillBy製品コード(this.dataSet元番材料コード.処方箋,this.textBox製品コード.Text);
            }
            else if(string.IsNullOrWhiteSpace(this.textBox製品コード.Text) && !string.IsNullOrWhiteSpace(this.textBox元番.Text))
            {
                this.処方箋TableAdapter.FillBy元番(this.dataSet元番材料コード.処方箋, this.textBox元番.Text);
            }
            else
            {
                MessageBox.Show("検索条件が設定されていません。", Properties.Settings.Default.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            this.dataGridView1.Columns[0].Width = 100;
            this.dataGridView1.Columns[0].HeaderText = "製品コード";
            this.dataGridView1.Columns[1].Width = 100;
            this.dataGridView1.Columns[2].Width = 300;

        }

        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.buttonSearch.Focus();
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Selected = true;

            if (e.RowIndex > -1)
            {
                //int i = -1;
                //int MaterialID = int.TryParse(this.dataGridView材料マスタ.Rows[e.RowIndex].Cells[2].Value.ToString(), out i) ? i : -1;
                //string MaterialCode = string.IsNullOrWhiteSpace(this.dataGridView材料マスタ.Rows[e.RowIndex].Cells[0].Value.ToString()) ? "" : this.dataGridView材料マスタ.Rows[e.RowIndex].Cells[0].Value.ToString();
                //原材料 _原材料 = 原材料マネージャー.Read基本項目(MaterialCode);
                //if (this.ReadOnly)
                //{
                //    Form原料マスタ詳細読取専用 frm = new Form原料マスタ詳細読取専用();
                //    frm._原材料 = _原材料;
                //    frm.StartPosition = FormStartPosition.CenterScreen;
                //    frm.Show();
                //    frm.OriginForm = this;
                //}
                //else
                //{
                //    Form原料マスタ詳細編集 frm = new Form原料マスタ詳細編集();
                //    frm._原材料 = _原材料;
                //    if (forceReadOnly)
                //    {
                //        frm.ReadOnlyMode = true;
                //    }
                //    frm.StartPosition = FormStartPosition.CenterScreen;
                //    frm.Show();
                //    frm.OriginForm = this;
                //}
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.textBox元番.Text = string.Empty;
            this.textBox製品コード.Text = string.Empty;
            this.dataGridView1.DataSource = null;
        }
    }
}
