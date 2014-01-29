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
    public partial class Form原料コード検索 : FormBase
    {
        public Form原料コード検索(Stack<FormInformation> formopenorderstack, FormInformation forminformation)
            : base(formopenorderstack, forminformation)
        {
            InitializeComponent();

            this.ApplicationName = Properties.Settings.Default.ApplicationName;
            this.ApplicationVersion = Properties.Settings.Default.Version;
            this.ModifyDate = Properties.Settings.Default.ModifyDate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form元番製品コード検索_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'dataSet元番材料コード.材料マスタ' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.材料マスタTableAdapter.Fill(this.dataSet元番材料コード.材料マスタ);
            // TODO: このコード行はデータを '元番製品コード.材料マスタ' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            //this.材料マスタTableAdapter.Fill(this.元番製品コード.材料マスタ);
            // TODO: このコード行はデータを '元番製品コード.開発処方箋台帳' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            //this.開発処方箋台帳TableAdapter.Fill(this.元番製品コード.開発処方箋台帳);
            // TODO: このコード行はデータを '元番製品コード.顧客サンプル台帳' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            //this.顧客サンプル台帳TableAdapter.Fill(this.元番製品コード.顧客サンプル台帳);

        }

        /// <summary>
        /// 入力条件のテキストボックスで（条件を入力した後に）Enterキーを押すと「検索」ボタン（BunttonSearch）へフォーカスを飛ばす
        /// </summary>
        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            //Enterキーが押されていて、TextBoxが空ではなかったら
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
                this.buttonSearch.Focus();
            }
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.ClearSelection();
            //this.元番製品コード.顧客サンプル台帳.Clear();
            //this.元番製品コード.開発処方箋台帳.Clear();
            
            if (!string.IsNullOrWhiteSpace(this.textBox原料コード.Text))
            {
                this.dataGridView1.DataSource = this.材料マスタBindingSource;
                //this.材料マスタTableAdapter.FillBy材料コード(this.元番製品コード.材料マスタ, this.textBox原料コード.Text);
            }
            else
            {
                MessageBox.Show("検索条件が設定されていません。", Properties.Settings.Default.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.textBox原料コード.Text = string.Empty;
            this.dataGridView1.DataSource = null;
        }


        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Selected = true;

            if (e.RowIndex > -1)
            {
                //このFormから開ける新しいFormに、FormOpenOrderStackを渡し、自分自身をスタックに登録しておく。
                Form原料検査WS検索 frm = new Form原料検査WS検索(this.FormOpenOrderStack, new FormInformation() { OriginForm = this, FormGuid = this.MyGUID });
                frm.原料コード = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                frm.Show();
                this.WindowState = FormWindowState.Minimized;
            }
        }

    }
}
