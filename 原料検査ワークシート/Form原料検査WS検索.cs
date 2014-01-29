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

using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Data.Common;

namespace CCJ_QAQC
{
    public partial class Form原料検査WS検索 : FormBase
    {
        public string 原料コード { get; set; }

        /// <summary>
        /// 引数ありのコンストラクタ。
        /// 引数の内容は、FormBaseクラスでプロパティに書き込まれている。
        /// </summary>
        /// <param name="formopenorderstack">メニューにある、このFormを新しく作ったときのボタンで新規に生成されたStack</param>
        /// <param name="forminformation">メニューとなっているFormの情報</param>
        public Form原料検査WS検索(Stack<FormInformation> formopenorderstack, FormInformation forminformation) : base(formopenorderstack, forminformation)
        {
            InitializeComponent();

            this.ApplicationName = Properties.Settings.Default.ApplicationName.ToString();
            this.ApplicationVersion = Properties.Settings.Default.Version.ToString();
            this.ModifyDate = Properties.Settings.Default.ModifyDate.ToString();
        }
        
        
        private void Form原料検査WS検索_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'dataSet検査ワークシート.原料検査ワークシート' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.原料検査ワークシートTableAdapter.Fill(this.dataSet検査ワークシート.原料検査ワークシート);
            // TODO: このコード行はデータを '元番製品コード.材料マスタ' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.材料マスタTableAdapter.FillBy材料コード(this.元番製品コード.材料マスタ, this.原料コード);
            //this.原料検査ワークシートDataGridView.DataSource = (new CCJ2EntitiesMILK()).原料検査ワークシート.ToList();
            CCJ2EntitiesMILK ccj2Entities_MILK = new CCJ2EntitiesMILK();
            //ccj2Entities = Select ref from

            //this.原料検査ワークシートDataGridView.DataSource = ccj2Entities_MILK.原料検査ワークシート.ToList();

            //return;

            //if (!string.IsNullOrWhiteSpace(this.原料コード))
            //{
            //    //this.原料検査ワークシートBindingSource.Filter  = "原料コード = '" + this.原料コード + "'";

            //    var worksheet =
            //        from ws in ccj2Entities_MILK.原料検査ワークシート
            //        where ws.原料コード == this.原料コード//order.OnlineOrderFlag == true
            //        select new
            //        {
            //            ID = ws.ID,
            //            原料コード = ws.原料コード,
            //            原料名 = ws.原料名,
            //            ロット番号 = ws.ロット番号,
            //            ロット番号備考 = ws.ロット番号備考,
            //            入荷日 = ws.入荷日,
            //            入荷日テキスト = ws.入荷日テキスト,
            //            納入元 = ws.納入元,
            //            容器封緘ラベル = ws.容器封緘ラベル,
            //            検査日 = ws.検査日,
            //            検査担当者 = ws.検査担当者,
            //            官能検査合否 = ws.官能検査合否,
            //            コメントその他検査項目 = ws.コメントその他検査項目,
            //            総合判定 = ws.総合判定,
            //            製造会社 = ws.製造会社,
            //            入荷量 = ws.入荷量
            //        };
            //    this.原料検査ワークシートDataGridView.DataSource = worksheet.ToList();
            //}
            //this.原料検査ワークシートDataGridView.DataSource = (new CCJ2Entities()).原料検査ワークシート.ToList();
        }

        private void 原料検査ワークシートDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.原料検査ワークシートDataGridView.Rows[e.RowIndex].Selected = true;

            if (e.RowIndex > -1)
            {
                //このFormから開ける新しいFormに、FormOpenOrderStackを渡し、自分自身をスタックに登録しておく。
                Form原料検査WS詳細 frm = new Form原料検査WS詳細(this.FormOpenOrderStack, new FormInformation() { OriginForm = this, FormGuid = this.MyGUID });
                frm.原料ワークシートID = int.Parse( this.原料検査ワークシートDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                frm.Show();
                this.WindowState = FormWindowState.Minimized;
            }
        }
    }
}
