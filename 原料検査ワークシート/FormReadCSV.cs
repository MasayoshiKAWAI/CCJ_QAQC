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
using Microsoft.VisualBasic.FileIO;

namespace CCJ_QAQC
{
    public partial class FormReadCSV : FormBase
    {
        private DataTable datatableCSVData = new DataTable();

        public FormReadCSV(Stack<FormInformation> formopenorderstack, FormInformation forminformation)
            : base(formopenorderstack, forminformation)
        {
            InitializeComponent();

            this.ApplicationName = "フォームを順序よく閉じるテスト";
            this.ApplicationVersion = "0.0.1";
            this.ModifyDate = DateTime.Today.ToShortDateString();
        }



        private void buttonReadCSV_Click(object sender, EventArgs e)
        {
            string filepath;
            if (string.IsNullOrEmpty(this.textBoxLoadPath.Text) || !System.IO.File.Exists(this.textBoxLoadPath.Text))
            {
                if (this.openFileDialog1.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                filepath = this.openFileDialog1.FileName;
                this.textBoxLoadPath.Text = filepath;
            }
            else
            {
                filepath = this.textBoxLoadPath.Text;
                if (!System.IO.File.Exists(filepath))
                {
                    MessageBox.Show("選択されているファイルが存在しません。\nもう一度選択し直してください。", Properties.Settings.Default.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.textBoxLoadPath.Text = string.Empty;
                    return;
                }
            }

            DataRow dr;
            TextFieldParser parser = new TextFieldParser(filepath, System.Text.Encoding.GetEncoding("Shift_JIS"));

            using (parser)
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(","); // 区切り文字はコンマ

                // parser.HasFieldsEnclosedInQuotes = false;
                // parser.TrimWhiteSpace = false;

                try
                {
                    while (!parser.EndOfData)
                    {
                        string[] row = parser.ReadFields(); // 1行読み込み
                        //if (row.Length > datatableCSVData.Columns.Count)
                        //{
                        while (row.Length > datatableCSVData.Columns.Count)
                        {
                            datatableCSVData.Columns.Add();
                        }
                        //}

                        dr = datatableCSVData.NewRow();
                        int cnt = 0;
                        foreach (string field in row)
                        {
                            //string f = field;
                            //f = f.Replace("\r\n", "n"); // 改行をnで表示
                            //f = f.Replace(" ", "_"); // 空白を_で表示
                            //Console.Write(f + "\t"); // TAB区切りで出力
                            dr[cnt++] = field;
                        }
                        datatableCSVData.Rows.Add(dr);
                    }
                }
                catch (MalformedLineException excp)
                {
                    MessageBox.Show(excp.Message, Properties.Settings.Default.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception excp)
                {
                    MessageBox.Show(excp.Message, Properties.Settings.Default.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            this.dataGridViewCSVData.DataSource = datatableCSVData;

            if (this.checkBoxFirstRowIsTitle.Checked)
            {
                //DataTable先頭行をDataGridViewのタイトルに使う
                for(int col = 0; col < datatableCSVData.Columns.Count; col++)
                {
                    this.dataGridViewCSVData.Columns[col].HeaderText = datatableCSVData.Rows[0][col].ToString();
                }
                //先頭行をデータから削除する。
                dataGridViewCSVData.Rows.RemoveAt(0);
            }
            else
            {
                for(int col = 0; col < datatableCSVData.Columns.Count; col++)
                {
                    this.dataGridViewCSVData.Columns[col].HeaderText = string.Empty;
                }
            }
            //foreach (DataColumn dc in datatableCSVData.Columns)
            //{
            //    this.listBoxCSVDataColumnsName.Items.Add(dc.ColumnName);
            //}
            //this.dataGridView整形済み.DataSource = SplitData((DataTable)this.dataGridViewAccessData.DataSource, this.textBoxDataColumn.Text);
            //if (string.IsNullOrEmpty(this.textBoxLoadPath.Text))
            //{

            //    if (this.saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            //    {
            //        return;
            //    }

            //    this.textBoxLoadPath.Text = this.saveFileDialog1.FileName;
            //}
            //else
            //{
            //    if (MessageBox.Show("保存先は" + this.textBoxLoadPath.Text + "です。\nよろしいですか。", Properties.Settings.Default.ApplicationName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
            //    {
            //        return;
            //    }
            //}
            //// CSVファイルオープン
            //System.IO.StreamWriter sw = new System.IO.StreamWriter(this.textBoxLoadPath.Text, false, System.Text.Encoding.GetEncoding("SHIFT-JIS"));
            //for (int r = 0; r <= this.dataGridView整形済み.Rows.Count - 1; r++)
            //{
            //    for (int c = 0; c <= this.dataGridView整形済み.Columns.Count - 1; c++)
            //    {
            //        // DataGridViewのセルのデータ取得
            //        string dt = string.Empty;
            //        object obj = this.dataGridView整形済み.Rows[r].Cells[c].Value;
            //        if (obj != null)
            //        {
            //            dt = obj.ToString();
            //        }
            //        if (c < this.dataGridView整形済み.Columns.Count - 1)
            //        {
            //            dt = dt + ",";
            //        }
            //        // CSVファイル書込
            //        if (!string.IsNullOrEmpty(dt))
            //        {
            //            sw.Write(dt);
            //        }
            //    }
            //    sw.Write("\n");
            //}
            //// CSVファイルクローズ
            //sw.Close();
        }

        private void buttonWriteToDB_Click(object sender, EventArgs e)
        {
            if (datatableCSVData.Rows.Count == 0)
            {
                MessageBox.Show("CSVファイルから読み込まれていません。", Properties.Settings.Default.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //DialogResult response = MessageBox.Show("「原料検査ワークシート」テーブルのデータを全件削除しますか？", Properties.Settings.Default.ApplicationName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            //if (response == System.Windows.Forms.DialogResult.Cancel)
            //{
            //    return;
            //}
            //else if(response == System.Windows.Forms.DialogResult.Yes)
            //{
            //    Cursor = Cursors.WaitCursor;

            //    System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
            //    //Settingsにある接続文字列を利用します。（CCJ2ConnectionStringエントリ）
            //    conn.ConnectionString = Properties.Settings.Default.CCJQAQCConnectionString.ToString();
            //    System.Data.SqlClient.SqlCommand com = new System.Data.SqlClient.SqlCommand();
            //    com.Connection = conn;
            //    com.CommandType = CommandType.Text;//必要に応じてStoredProcedureに変えてください。
            //    com.CommandText = "TRUNCATE TABLE [原料検査ワークシート]";

            //    try
            //    {
            //        conn.Open();

            //        com.ExecuteNonQuery();

            //        conn.Close();
            //    }
            //    catch (System.Data.SqlClient.SqlException excp)
            //    {
            //        MessageBox.Show(excp.Message, Properties.Settings.Default.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        Console.WriteLine(excp.Message);
            //        return;
            //    }
            //    catch (Exception excp)
            //    {
            //        MessageBox.Show(excp.Message, Properties.Settings.Default.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        Console.WriteLine(excp.Message);
            //        return;
            //    }
            //    finally
            //    {
            //        conn.Close();
            //        Cursor = Cursors.Default;
            //    }					
            //}

            DateTime inspectiondate = new DateTime();
            double dbl = 0.0;

            Cursor = Cursors.WaitCursor;

            原料検査ワークシート2 genryo = new 原料検査ワークシート2();
            
            using (var test = new CCJ2EntitiesMILK())//CCJ2EntitiesMILK())//var test = new CCJ2Entities())
            {
                for (int row = 0; row < datatableCSVData.Rows.Count; row++ )
                {
                    //test.原料検査ワークシート.Add(new 原料検査ワークシート
                    //{
                    //    原料コード = datatableCSVData.Rows[row][0].ToString(),
                    //    原料名 = datatableCSVData.Rows[row][1].ToString(),
                    //    ロット番号備考 = datatableCSVData.Rows[row][3].ToString(),
                    //    入荷日テキスト = datatableCSVData.Rows[row][5].ToString(),
                    //    納入元 = datatableCSVData.Rows[row][6].ToString(),
                    //    容器封緘ラベル = datatableCSVData.Rows[row][7].ToString(),
                    //    検査日 = (DateTime.TryParse(datatableCSVData.Rows[row][8].ToString(),out inspectiondate) ? inspectiondate : new DateTime(1900,1,1)),
                    //    検査担当者 = datatableCSVData.Rows[row][9].ToString(),
                    //    官能検査合否 = datatableCSVData.Rows[row][10].ToString(),
                    //    コメントその他検査項目 = datatableCSVData.Rows[row][11].ToString(),
                    //    総合判定 = datatableCSVData.Rows[row][12].ToString(),
                    //    製造会社 = datatableCSVData.Rows[row][13].ToString(),
                    //    入荷量 = datatableCSVData.Rows[row][14].ToString()
                    //});

                    genryo.コード = datatableCSVData.Rows[row][0].ToString();
                    genryo.名称 = datatableCSVData.Rows[row][1].ToString();
                    genryo.ロット番号 = datatableCSVData.Rows[row][3].ToString();
                    genryo.ロット番号備考 = datatableCSVData.Rows[row][3].ToString();

                    genryo.色調性状.合否 = datatableCSVData.Rows[row][10].ToString();
                    genryo.色調性状.担当者 = datatableCSVData.Rows[row][9].ToString();
                    genryo.色調性状.測定日時 = (DateTime.TryParse(datatableCSVData.Rows[row][8].ToString(), out inspectiondate) ? inspectiondate : new DateTime(1900, 1, 1));

                    genryo.香気.合否 = datatableCSVData.Rows[row][10].ToString();
                    genryo.香気.担当者 = datatableCSVData.Rows[row][9].ToString();
                    genryo.香気.測定日時 = (DateTime.TryParse(datatableCSVData.Rows[row][8].ToString(), out inspectiondate) ? inspectiondate : new DateTime(1900, 1, 1));

                    //実際には「官能検査」の欄は使わないことにした。
                    //genryo.官能検査.測定日時 = new DateTime(1900, 1, 1);
                    //genryo.官能検査.担当者 = "-";
                    //genryo.官能検査.合否 = "A";

                    genryo.総合判定.測定日時 = (DateTime.TryParse(datatableCSVData.Rows[row][8].ToString(), out inspectiondate) ? inspectiondate : new DateTime(1900, 1, 1));//検査日	2013/6/3
                    genryo.総合判定.担当者 = datatableCSVData.Rows[row][9].ToString();
                    genryo.総合判定.合否 = datatableCSVData.Rows[row][12].ToString();
                    genryo.総合判定.コメント = datatableCSVData.Rows[row][11].ToString();

                    genryo.容器封緘.測定日時 = (DateTime.TryParse(datatableCSVData.Rows[row][8].ToString(), out inspectiondate) ? inspectiondate : new DateTime(1900, 1, 1));
                    genryo.容器封緘.測定値文字列 = datatableCSVData.Rows[row][7].ToString();
                    genryo.容器封緘.担当者 = datatableCSVData.Rows[row][9].ToString();

                    ////genryo.入荷.日付 //空欄
                    genryo.入荷.日付 = new DateTime(2013, 6, 3);//入荷日テキスト	6/3
                    genryo.入荷.日付テキスト = datatableCSVData.Rows[row][5].ToString();
                    genryo.入荷.数量テキスト = datatableCSVData.Rows[row][14].ToString();
                    genryo.入荷.数量 = double.TryParse(datatableCSVData.Rows[row][14].ToString(), out dbl) ? dbl : 0;//入荷量	1
                    //genryo.入荷.付加情報1名称 = "納入元";
                    genryo.入荷.付加情報1.値テキスト = datatableCSVData.Rows[row][6].ToString();
                    //genryo.入荷.付加情報2名称 = "製造会社";
                    genryo.入荷.付加情報2.値テキスト = datatableCSVData.Rows[row][13].ToString();

                    genryo.SaveToDB();

                    if (row % 100 == 0)
                    {
                        this.toolStripStatusLabelMessage.Text = row.ToString() + "行目";
                        this.Refresh();
                    }
                    
                    test.SaveChanges();
                }

            }

            Cursor = Cursors.Default;
            this.toolStripStatusLabelMessage.Text = "";
        }

        private void checkBoxSortable_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSortable.Checked)
            {
foreach(DataGridViewColumn col in this.dataGridViewCSVData.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.Automatic;
            }
            }
            else
            {
            foreach(DataGridViewColumn col in this.dataGridViewCSVData.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            }

        }

        private void dataGridViewCSVData_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //DataGridViewのColumnHeaderをクリックしていたら
            if (!this.checkBoxSortable.Checked)
            {
                //ソート可能のチェックが外れていたなら、ヘッダをクリックしたら選択されるモードにし、その列を選択状態にする。
                this.dataGridViewCSVData.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
                this.dataGridViewCSVData.Columns[e.ColumnIndex].Selected = true;
            }

        }
        
        private void dataGridViewCSVData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //DataGridViewの上でマウスクリックをして、右クリックで、選択された列が0以上で、
            if (e.Button == System.Windows.Forms.MouseButtons.Right && this.dataGridViewCSVData.SelectedColumns.Count > 0) // && e.ColumnIndex == this.dataGridViewCSVData.SelectedColumns[0].Index)
            {
                //選択されている列の中で、マウスの右クリックが行われていたら,ContextMenuを表示する。
                foreach (DataGridViewColumn dgvcol in this.dataGridViewCSVData.SelectedColumns)
                {
                    if (e.ColumnIndex == dgvcol.Index)
                    {
                        this.dataGridViewCSVData.Columns[e.ColumnIndex].ContextMenuStrip = this.contextMenuStrip1;
                        break;
                    }
                }
            }
        }

        private void ToolStripMenuItem列の消去_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("選択されている列を削除してよろしいですか？",Properties.Settings.Default.ApplicationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            List<int> selectedcolumnindex = new List<int>();
            foreach (DataGridViewColumn dgvcol in this.dataGridViewCSVData.SelectedColumns)
            {
                Console.WriteLine(dgvcol.Index);
                //datatableCSVData.Columns.RemoveAt(dgvcol.Index);
                selectedcolumnindex.Add(dgvcol.Index);
            }
            selectedcolumnindex.Sort((a, b) => b - a);
            selectedcolumnindex.ForEach(col => this.datatableCSVData.Columns.RemoveAt(col));
        }

        private void checkBoxMultiselectable_CheckedChanged(object sender, EventArgs e)
        {
            //複数列選択できるようにするか。
            this.dataGridViewCSVData.MultiSelect = this.checkBoxMultiselectable.Checked;
        }
    }
}
