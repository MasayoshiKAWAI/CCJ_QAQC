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
    public partial class Form原料検査WS詳細 : FormBase
    {
        public int 原料ワークシートID { get; set; }

        public Form原料検査WS詳細(Stack<FormInformation> formopenorderstack, FormInformation forminformation)
            : base(formopenorderstack, forminformation)
        {
            InitializeComponent();

            this.ApplicationName = Properties.Settings.Default.ApplicationName;
            this.ApplicationVersion = Properties.Settings.Default.Version;
            this.ModifyDate = Properties.Settings.Default.ModifyDate;
        }

        //CCJ2Entities ccj2entities;
        //CCJ2EntitiesMILK ccj2entitiesMILK;

        private void Form原料検査WS詳細_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'dataSet検査ワークシート.原料検査ワークシート' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.原料検査ワークシートTableAdapter.Fill(this.dataSet検査ワークシート.原料検査ワークシート);

            if (this.原料ワークシートID == 0)// || 原料ワークシートID == null)
            {
                //メニューから来たのかも。
                //this.原料検査ワークシートBindingNavigator.Enabled = false;
            }

            //通常モードなので、検索に関わるコントロールはInvisibleにする。
            this.buttonSearch.Visible = false;
            this.buttonClearCriteria.Visible = false;
            this.dateTimePicker検索範囲終端.Visible = false;

            // Initialize the object context.
            //ccj2entities = new CCJ2Entities();
            //var genryolist = from result in ccj2entities.原料検査ワークシート 
            //                 where result.ID == 5 
            //                 select result;

            //ccj2entitiesMILK = new CCJ2EntitiesMILK();
            //var genryolist2 = from result in ccj2entitiesMILK.原料検査ワークシート 
            //                 where result.ID == this.ID 
            //                 select result;

            //this.原料検査ワークシートBindingSource.DataSource = genryolist2.ToList();
        }

        private void 検査日DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.官能検査日DateTimePicker.Value = this.検査日DateTimePicker.Value;
            this.色調性状検査日DateTimePicker.Value = this.検査日DateTimePicker.Value;
            this.香気検査日DateTimePicker.Value = this.検査日DateTimePicker.Value;
        }

        private void 検査担当者TextBox_TextChanged(object sender, EventArgs e)
        {
            this.官能検査担当者TextBox.Text = this.検査担当者TextBox.Text;
            this.色調性状合否担当者TextBox.Text = this.検査担当者TextBox.Text;
            this.香気合否担当者TextBox.Text = this.検査担当者TextBox.Text;
        }

        private void 合否TextBox_TextChanged(object sender, EventArgs e)
        {
            this.官能検査合否TextBox.Text = "合";

            if (this.香気合否TextBox.Text.Equals("合") && this.色調性状合否TextBox.Text.Equals("合") && this.官能検査合否TextBox.Text.Equals("合"))
            {
                this.総合判定合否TextBox.Text = "合格";
                this.総合判定合否TextBox.ForeColor = Color.Blue;
            }
            else
            {
                this.総合判定合否TextBox.Text = "不合格";
                this.総合判定合否TextBox.ForeColor = Color.DarkRed;
            }
        }

        private bool 検索モード;

        private void radioButton検索モード_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //フィルタ用文字列
            StringBuilder filterstring = new StringBuilder();

            foreach(Control ctrl in this.toolStripContainerMain.ContentPanel.Controls)
            {
                if (ctrl.GetType() == typeof(Kawai.ApplicationBase.SearchCritriaTextBox))
                {
                    if (ctrl.Text != "")
                    {
                        ((Kawai.ApplicationBase.SearchCritriaTextBox)ctrl).DataSourceTable = this.dataSet検査ワークシート.原料検査ワークシート;
                        filterstring.Append(((Kawai.ApplicationBase.SearchCritriaTextBox)ctrl).QueryString + " AND ");
                    }
                }
            }
            //オシリの「 AND 」を削除する。
            filterstring.Remove(filterstring.Length - 5, 5);

            this.原料検査ワークシートTableAdapter.Fill(this.dataSet検査ワークシート.原料検査ワークシート);
            this.原料検査ワークシートBindingSource.Filter = filterstring.ToString();

            this.EnableControls();
            this.checkBox検索モード.Checked = false;
        }

        private void ClearCriteria()
        {
            if (this.検索モード)
            {
                this.dataSet検査ワークシート.原料検査ワークシート.Clear();

                foreach(Control ctrl in this.toolStripContainerMain.ContentPanel.Controls)
                {
                    if (ctrl.GetType() == typeof(System.Windows.Forms.TextBox))
                    {
                        ctrl.Text = "";
                    }
                    else if (ctrl.GetType() == typeof(Kawai.ApplicationBase.SearchCritriaTextBox))
                    {
                        ctrl.Text = "";
                        //((Kawai.Tools.SearchCritriaTextBox)ctl).DataSourceTable = this.cCJ2DataSetHP8100.Tables["M_ユーザー"];
                    }
                }
                this.検査日DateTimePicker.Value = null;//DateTime.Today;//
                this.入荷日DateTimePicker.Value = null;// DateTime.Today;//null;
                this.dateTimePicker検索範囲終端.Value = null;

                //this.原料検査ワークシートTableAdapter.Fill(this.dataSet検査ワークシート.原料検査ワークシート);
                //this.原料検査ワークシートBindingSource.Filter = "";
            }
        }

        private void EnableControls()
        {
            this.入荷日DateTimePicker.Enabled = true;
            this.入荷日テキストTextBox.Enabled = true;
            this.入荷量TextBox.Enabled = true;
            this.groupBox香気.Enabled = true;
            this.groupBox色調性状.Enabled = true;
            this.容器封緘ラベルTextBox.Enabled = true;
            this.toolStripContainerMain.ContentPanel.Controls["入荷日Label"].ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripContainerMain.ContentPanel.Controls["入荷量Label"].ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripContainerMain.ContentPanel.Controls["容器封緘ラベルLabel"].ForeColor = System.Drawing.SystemColors.Control;

            this.buttonSearch.Visible = false;
            this.buttonClearCriteria.Visible = false;

            if (this.dataSet検査ワークシート.原料検査ワークシート.Rows.Count == 0)
            {
                this.原料検査ワークシートTableAdapter.Fill(this.dataSet検査ワークシート.原料検査ワークシート);
            }
        }

        private void checkBox検索モード_CheckedChanged(object sender, EventArgs e)
        {
            this.検索モード = this.checkBox検索モード.Checked;

            if (this.検索モード)
            {
                this.dateTimePicker検索範囲終端.Visible = true;
                this.入荷日DateTimePicker.Enabled = false;
                this.入荷日テキストTextBox.Enabled = false;
                this.入荷量TextBox.Enabled = false;
                this.groupBox香気.Enabled = false;
                this.groupBox色調性状.Enabled = false;
                this.容器封緘ラベルTextBox.Enabled = false;
                this.toolStripContainerMain.ContentPanel.Controls["入荷日Label"].ForeColor = System.Drawing.SystemColors.InactiveCaption;
                this.toolStripContainerMain.ContentPanel.Controls["入荷量Label"].ForeColor = System.Drawing.SystemColors.InactiveCaption;
                this.toolStripContainerMain.ContentPanel.Controls["容器封緘ラベルLabel"].ForeColor = System.Drawing.SystemColors.InactiveCaption;

                this.ClearCriteria();

                this.buttonSearch.Visible = true;
                this.buttonClearCriteria.Visible = true;
            }
            else
            {
                this.EnableControls();
            }

        }

        private void buttonClearCriteria_Click(object sender, EventArgs e)
        {
            this.ClearCriteria();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("新規データを追加します。", Properties.Settings.Default.ApplicationName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information,MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Cancel)
            {
                //this.原料検査ワークシートBindingNavigator
                this.原料検査ワークシートBindingSource.CancelEdit();
                return;
            }
        }

        private 原料検査ワークシート2 SetCurrentDataToObject()
        {
            原料検査ワークシート2 genryoWS = new 原料検査ワークシート2();

            genryoWS.名称 = this.原料名TextBox.Text;
            genryoWS.コード = this.原料コードTextBox.Text;
            genryoWS.ロット番号 = this.ロット番号TextBox.Text;
            genryoWS.ロット番号備考 = this.ロット番号備考TextBox.Text;

            DateTime tempdatetime = new DateTime();
            if (this.検査日DateTimePicker.Value != null && DateTime.TryParse(this.検査日DateTimePicker.Value.ToString(), out tempdatetime))
            {
                genryoWS.総合判定.測定日時 = tempdatetime;
                genryoWS.香気.測定日時 = tempdatetime;
                genryoWS.色調性状.測定日時 = tempdatetime;
            }
            else
            {
                genryoWS.総合判定.測定日時 = null;
                genryoWS.香気.測定日時 = null;
                genryoWS.色調性状.測定日時 = null;
            }

            genryoWS.総合判定.担当者 = this.検査担当者TextBox.Text;
            genryoWS.総合判定.承認者 = this.検査確認者TextBox.Text;
            genryoWS.総合判定.合否 = this.総合判定合否TextBox.Text;
            genryoWS.総合判定.コメント = this.コメント品管その他検査項目TextBox.Text;

            genryoWS.香気.合否 = this.香気合否TextBox.Text;
            genryoWS.香気.担当者 = this.香気合否担当者TextBox.Text;

            genryoWS.色調性状.合否 = this.色調性状合否TextBox.Text;
            genryoWS.色調性状.担当者 = this.色調性状合否担当者TextBox.Text;

            DateTime tempdatetime2 = new DateTime();
            if (this.入荷日DateTimePicker.Value != null && DateTime.TryParse(this.入荷日DateTimePicker.Value.ToString(), out tempdatetime2))
            {
                genryoWS.入荷.日付 = tempdatetime2;
            }
            else
            {
                genryoWS.入荷.日付 = null;
            }
            genryoWS.入荷.日付テキスト = this.入荷日テキストTextBox.Text;
            double dbl = 0.0;
            genryoWS.入荷.数量 = double.TryParse(this.入荷量TextBox.Text, out dbl) ? dbl : 0.0;
            genryoWS.入荷.数量テキスト = this.入荷量TextBox.Text;
            genryoWS.入荷.付加情報1.値テキスト = this.納入元TextBox.Text;
            genryoWS.入荷.付加情報2.値テキスト = this.製造会社TextBox.Text;

            genryoWS.容器封緘.測定値文字列 = this.容器封緘ラベルTextBox.Text;

            return genryoWS;
        }

        private void 原料検査ワークシートBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            原料検査ワークシート2 genryoWS = this.SetCurrentDataToObject();//new 原料検査ワークシート2();
            
            genryoWS.SaveToDB();

            MessageBox.Show("データベースへ書き込みました。", Properties.Settings.Default.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //現状の値をバックアップして
            原料検査ワークシート2 genryoWS = this.SetCurrentDataToObject();
            //新しい行を追加して
            this.bindingNavigatorAddNewItem.PerformClick();
            //書き戻す。
            this.原料名TextBox.Text = genryoWS.名称;
            this.原料コードTextBox.Text = genryoWS.コード;
            this.ロット番号TextBox.Text = genryoWS.ロット番号;
            this.ロット番号備考TextBox.Text = genryoWS.ロット番号備考;
            this.検査担当者TextBox.Text = genryoWS.総合判定.担当者;
            this.検査確認者TextBox.Text = genryoWS.総合判定.承認者;
            this.総合判定合否TextBox.Text = genryoWS.総合判定.合否;
            this.コメント品管その他検査項目TextBox.Text = genryoWS.総合判定.コメント;
            this.香気合否TextBox.Text = genryoWS.香気.合否;
            this.香気合否担当者TextBox.Text = genryoWS.香気.担当者;
            this.色調性状合否TextBox.Text = genryoWS.色調性状.合否;
            this.色調性状合否担当者TextBox.Text = genryoWS.色調性状.担当者;
            this.入荷日テキストTextBox.Text = genryoWS.入荷.日付テキスト;
            this.入荷量TextBox.Text = genryoWS.入荷.数量.ToString();
            this.入荷日テキストTextBox.Text = genryoWS.入荷.数量テキスト;
            this.納入元TextBox.Text = genryoWS.入荷.付加情報1.値テキスト;
            this.製造会社TextBox.Text = genryoWS.入荷.付加情報2.値テキスト;
            this.容器封緘ラベルTextBox.Text = genryoWS.容器封緘.測定値文字列;
            this.入荷日DateTimePicker.Value = genryoWS.入荷.日付;
            this.検査日DateTimePicker.Value = genryoWS.総合判定.測定日時; 
        }

    }
}
