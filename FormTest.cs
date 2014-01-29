using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Kawai.ApplicationBase;

namespace CCJ_QAQC
{
    public partial class FormTest : Kawai.ApplicationBase.FormBase
    {
        public FormTest(Stack<FormInformation> formopenorderstack, FormInformation forminformation)
            : base(formopenorderstack, forminformation)
        {
            InitializeComponent();

            this.ApplicationName = "フォームを順序よく閉じるテスト";
            this.ApplicationVersion = "0.0.1";
            this.ModifyDate = DateTime.Today.ToShortDateString();
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'dataSet検査ワークシート._x_Study1' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this._x_Study1TableAdapter.Fill(this.dataSet検査ワークシート._x_Study1);
            // TODO: このコード行はデータを 'cCJ2DataSetHP8100.M_ユーザー' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.m_ユーザーTableAdapter.Fill(this.cCJ2DataSetHP8100.M_ユーザー);

            //this.bindingNavigator1.Enabled = false;
        }

        private void toolStripButtonSearchModeON_Click(object sender, EventArgs e)
        {
            //this.bindingNavigator1.Enabled = true;

            foreach(Control ctl in this.toolStripContainer3.ContentPanel.Controls)
            {
                if (ctl.GetType() == typeof(System.Windows.Forms.TextBox))
                {
                    ctl.Text = "";
                }
                else if (ctl.GetType() == typeof(Kawai.ApplicationBase.SearchCritriaTextBox))
                {
                    ctl.Text = "";
                    //((Kawai.Tools.SearchCritriaTextBox)ctl).DataSourceTable = this.cCJ2DataSetHP8100.Tables["M_ユーザー"];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ユーザーコードTextBox.DataSourceTable = this.cCJ2DataSetHP8100.Tables["M_ユーザー"];
            //Console.WriteLine(this.ユーザーコードTextBox1.DataTypeString);
            //Console.WriteLine(this.ユーザーコードTextBox1.QueryString);
            this.名称TextBox.DataSourceTable = this.cCJ2DataSetHP8100.Tables["M_ユーザー"];
            //this.ユーザーコードTextBox.DataSourceTable = this.cCJ2DataSetHP8100.Tables["M_ユーザー"];

            string filterstring = this.ユーザーコードTextBox.QueryString + " AND " + this.名称TextBox.QueryString;//"名称 LIKE '%J%'";// this.ユーザーコードTextBox1.QueryString + " AND " + this.名称TextBox1.QueryString;
            this.m_ユーザーTableAdapter.Fill(this.cCJ2DataSetHP8100.M_ユーザー);
            this.mユーザーBindingSource.Filter = filterstring;

            return;

            BindingMemberInfo bminfo = this.登録日DateTimePicker.DataBindings["Value"].BindingMemberInfo;


            string querystring = this.ユーザーコードTextBox.DataBindings["Text"].BindingMemberInfo.BindingMember.ToString() + " LIKE '%";
            Console.WriteLine("\t BindingPath: " + bminfo.BindingPath);
            Console.WriteLine("\t BindingField: " + bminfo.BindingField);
            Console.WriteLine("\t BindingMember: " + bminfo.BindingMember);
            //MessageBox.Show(bminfo.BindingMember.ToString(), Properties.Settings.Default.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Console.WriteLine("\t " + this.mユーザーBindingSource.DataSource.ToString());
            Console.WriteLine("\t " + this.mユーザーBindingSource.DataMember.ToString());
            //DataTable dt = 
            Console.WriteLine(this.cCJ2DataSetHP8100.Tables[this.mユーザーBindingSource.DataMember.ToString()].Columns[bminfo.BindingField].DataType.ToString());//.Count.ToString());//Columns//this.mユーザーBindingSource.DataSource.ToString()];//.Columns.Count);//.Columns[this.mユーザーBindingSource.DataMember.ToString()].DataType.ToString());
            //Console.WriteLine(dt.Columns[0].DataType.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void buttonClassTest_Click(object sender, EventArgs e)
        {
            原料検査ワークシート2 genryo = new 原料検査ワークシート2();

            //genryo.ID = 99999;
            genryo.コード = "P10002";
            genryo.名称 = "和梨フレーバー22-747";
            genryo.ロット番号 = "130531-01";

            genryo.総合判定.測定日時 = new DateTime(2013,6,3);//検査日	2013/6/3
            genryo.総合判定.担当者 = "小川";//検査担当者	小川
            genryo.総合判定.合否 = "合格";

            //genryo.官能検査.測定日時 = new DateTime(2013,6,3);//検査日	2013/6/3
            //genryo.官能検査.担当者 = "小川";//検査担当者	小川
            //genryo.官能検査.合否 = "A";//官能合否	A
            //genryo.官能検査.コメント = "なし";//コメントその他検査項目	

            genryo.容器封緘.測定日時 = new DateTime(2013,6,3);//検査日	2013/6/3
            genryo.容器封緘.測定値文字列 = "異常なし　2年";
            genryo.容器封緘.担当者 = "小川";//検査担当者	小川

            ////genryo.入荷.日付 //空欄
            genryo.入荷.日付 = new DateTime(2013, 6, 3);//入荷日テキスト	6/3
            genryo.入荷.数量 = 1;//入荷量	1
            //genryo.入荷.付加情報1名称 = "納入元";
            genryo.入荷.付加情報1.値テキスト = "ＳＮ";
            //genryo.入荷.付加情報2名称 = "製造会社";
            genryo.入荷.付加情報2.値テキスト = "ＳＮ";
            
            genryo.SaveToDB();
            
        }

        private void buttonClassTest2_Click(object sender, EventArgs e)
        {
            製品検査ワークシート seihin = new 製品検査ワークシート(3,"製品");
            seihin.コード = "CCA-195147";
            seihin.名称 = "パイナップル　ＦＬ";
            seihin.ロット番号 = "311071";
            seihin.ナンバー = "13";

            seihin.総合判定.測定日時 = new DateTime(2013, 11, 8);
            seihin.総合判定.担当者 = "佐藤（栄）";
            seihin.総合判定.合否 = "合格";
            seihin.総合判定.コメント = "比重：0.910～0.930　屈折率：1.372～1.382初回生産品につき小川シニアアドバイザーも官能評価済み";

            seihin.官能検査.測定日時 = null;
            seihin.官能検査.担当者 = "横山";
            seihin.官能検査.承認者 = "小川";
            seihin.官能検査.合否 = "A";

            seihin.比重.測定値数値 = 0.92;
            seihin.比重.規格値MIN = 0.910;
            seihin.比重.規格値MAX = 0.930;
            seihin.比重.合否 = "合";

            seihin.屈折率.測定値数値 = 1.377;
            seihin.屈折率.規格値MIN = 1.372;
            seihin.屈折率.規格値MAX = 1.382;
            seihin.屈折率.合否 = "合";

            seihin.pH.測定値数値 = 0;
            seihin.pH.合否 = "-";

            seihin.製造.数量 = 4;
            seihin.製造.付加情報1.値テキスト = "山口";
            seihin.製造.付加情報2.値テキスト = "製造部コメントなし";

            seihin.出荷.数量 = 4;
            seihin.出荷.日付 = new DateTime(2013, 11, 8);
            seihin.出荷.付加情報1.値テキスト = "アピ（池田）";

            seihin.SaveToDB();
        }

        private void TextBoxSearchCriteria_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void SearchCriteriaTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button1.PerformClick();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //DataSet検査ワークシート._x_Study1Row dr = this.dataSet検査ワークシート._x_Study1.New_x_Study1Row();//.NewRow();
            //dr.社員コード = "X001";
            //dr.出席回数 = 1;
            //dr.年月 = "2014/1";

            //this.dataSet検査ワークシート._x_Study1.Rows.Add(dr);

            //this._x_Study1TableAdapter.Update(this.dataSet検査ワークシート._x_Study1);


            DataSet検査ワークシート.検査ワークシートヘッダRow dr = this.dataSet検査ワークシート.検査ワークシートヘッダ.New検査ワークシートヘッダRow();
            //this._x_Study1TableAdapter.Update()
            DataSet検査ワークシートTableAdapters.検査ワークシートヘッダTableAdapter ta = new DataSet検査ワークシートTableAdapters.検査ワークシートヘッダTableAdapter();
            //ta.UpdateQuery(null, "試験", "xxxxx", "試験", "99999", "bikou", "no1", "tes123", "合格", 23233, 1, 987, 0, "",1, "P10002", 1, "和梨フレーバー22-747", 0, "130531-01", 0, "", 0, "", 0, "", 0, "", 23233);
            //ta.UpdateQuery1(999, "試験", "xxxxx", "試験", "99999", "bikou", "no1", "tes123", "合格", 23233);
            ta.UpdateQuery(999, "試験", "xxxxx", "試験", "Lot123", "bikou", "no1", "tes123", "合格", 23233);
            MessageBox.Show("update done!", Properties.Settings.Default.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
