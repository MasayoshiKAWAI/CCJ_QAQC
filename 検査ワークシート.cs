using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;

namespace CCJ_QAQC
{
    public class 検査ワークシートヘッダー
    {
        /// <summary>
        /// データベースで生成されるUnique Identity
        /// </summary>
        public int ID { get; set;}

        /// <summary>
        /// 原料検査、中間製品検査、製品検査の別をIDで持つ
        /// </summary>
        public int 検査種別ID { get; set; }

        /// <summary>
        /// 原料検査、中間製品検査、製品検査の別を文字列で持つ
        /// </summary>
        public string 検査種別テキスト { get; set; }

        /// <summary>
        /// 原料コード（材料コード）、製品コード（製品管理番号）など
        /// </summary>
        public string コード { get; set; }
        
        /// <summary>
        /// 原料名称、材料名称、製品名など
        /// </summary>
        public string 名称 { get; set; }
        
        /// <summary>
        /// ロット番号
        /// </summary>
        public string ロット番号 { get; set; }
        
        /// <summary>
        /// 主にデータ移行用に準備したロット番号の規則に則っていない場合に入れる場所
        /// </summary>
        public string ロット番号備考 { get; set; }
        
        /// <summary>
        /// 製品・中間製品検査ワークシートにある「No.」フィールド格納用
        /// </summary>
        public string ナンバー { get; set; }
        
        /// <summary>
        /// 元番、処方箋番号、処方番号など
        /// </summary>
        public string 元番 { get; set; }

        public int 品質保証期間 { get; set; }

        public DateTime 品質保証期限 { get; set; }


        /// <summary>
        /// コンストラクタ
        /// </summary>
        public 検査ワークシートヘッダー(int _検査種別ID, string _検査種別)
        {
            this.検査種別ID = _検査種別ID;
            this.検査種別テキスト = _検査種別;
        }

        public 検査ワークシートヘッダー()
        {
            this.検査種別ID = 0;
            this.検査種別テキスト = "";
        }
        
        /// <summary>
        /// データベースへ書き込む
        /// </summary>
        /// <param name="connection">接続文字列（トランザクション処理をするために引数で渡す）</param>
        /// <param name="trans">Transactionオブジェクト（トランザクション処理をするために引数で渡す）</param>
        public void SaveToDB(System.Data.SqlClient.SqlConnection connection, System.Data.SqlClient.SqlTransaction trans, bool updateDB = false)
        {
            DataSet検査ワークシートTableAdapters.検査ワークシートヘッダTableAdapter wsHeaderDA = new DataSet検査ワークシートTableAdapters.検査ワークシートヘッダTableAdapter();

            //トランザクションを有効にするために、TableAdapterのConnectionプロパティを新しいconnectionオブジェクトで上書きする。
            wsHeaderDA.Connection = connection;
            //transオブジェクトをTransactionプロパティにセットして、同じTransaction にする。
            wsHeaderDA.Transaction = trans;
            try
            {
                if (updateDB)
                {
                    //wsHeaderDA.UpdateQuery(検査種別ID,)
                }
                else
                {
                    //Insertする。
                    wsHeaderDA.InsertQuery(検査種別ID, 検査種別テキスト, コード, 名称, ロット番号, ロット番号備考, ナンバー, 元番);
                    //今InsertしたIDを拾う。
                    var maxID = wsHeaderDA.GetMaxID();
                    //int maxID = Convert.ToInt32(ds.検査ワークシートヘッダ.Compute("MAX(ID)", string.Empty));//←まぁ、こんな方法もあり。
                    int i = 0;
                    this.ID = int.TryParse(maxID.ToString(), out i) ? i : int.MinValue;
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                //SQLExceptionオブジェクトは、いろいろな情報を持っているので、展開する。
                System.Text.StringBuilder errorMessages = new StringBuilder();
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                throw new Exception(errorMessages.ToString());
            }
            catch(Exception excp)
            {
                throw new Exception(excp.Message);
            }
        }
    }

    public class 検査ワークシート測定値
    {
        /// <summary>
        /// この検査ワークシート測定値オブジェクトがぶら下がっている検査ワークシートのオブジェクト
        /// IDやコード、ロット番号を共有するために渡す。
        /// </summary>
        public 検査ワークシートヘッダー ヘッダー { get; set; }
        
        /// <summary>
        /// この検査ワークシート測定値オブジェクトの種類のID
        /// （今のところ、測定項目名称で管理しているが、将来拡張用）
        /// </summary>
        public int 測定項目ID { get; set; }
        
        /// <summary>
        /// この検査ワークシート測定値オブジェクトの種類の名称
        /// （総合判定、官能検査、容器封緘、屈折率、比重、など）
        /// </summary>
        public string 測定項目名称 { get; set; }
        
        /// <summary>
        /// この検査ワークシート測定値オブジェクトの測定値（実数）
        /// </summary>
        public double 測定値数値 { get; set; }

        private string _測定値文字列 = string.Empty;
        /// <summary>
        /// 測定結果を文字列で表現する場合に利用します（単位を付加したい場合や、何らかの記号を含めたい場合など）
        /// なお、測定結果のデータの厳密性を維持するため、「測定値文字列」プロパティに設定されている文字列から変換可能な数値と「測定値数値」が食い違うと例外がスローされます。
        /// </summary>
        public string 測定値文字列 {
            get
            {
                if (this._測定値文字列.Equals(string.Empty))
                {
                    return this.測定値数値.ToString();
                }
                else
                {
                    return _測定値文字列;
                }
            }
            set
            {
                double tempdbl = Microsoft.VisualBasic.Conversion.Val(value);
                //変換可能な数値が0以外で、「測定値数値」が0ではなく（既に何らかの値が設定されている）、
                //それでいて、設定された文字列から変換された数値が既存の「測定値数値」と一致しないのは異常とする。
                if (tempdbl != 0 &&  this.測定値数値 != 0 && this.測定値数値 != tempdbl)
                {
                    throw new Exception("「測定値数値」プロパティに設定されている数値と「測定値文字列」に設定されている値から数値に変換した値とが一致しません。");
                }
                this.測定値数値 = tempdbl;
                this._測定値文字列 = value;
            }
        }
        public string 規格値文字列 { get; set; }
        public double 規格値MIN { get; set; }
        public double 規格値MAX { get; set; }
        public string 測定方法 { get; set; }
        public string 担当者 { get; set; }
        public Nullable<System.DateTime> 測定日時 { get; set; }
        public string 測定日時文字列 
        {
            get
            {
                return this.測定日時.ToString();
            }
            set
            {
                DateTime dt = new DateTime();
                if (DateTime.TryParse(value, out dt))
                {
                    測定日時 = dt;
                }
                else
                {
                    測定日時 = null;
                }
                //try
                //{
                //    //DateTime dt = DateTime.MinValue;
                //    測定日時 = DateTime.Parse(value);
                //}
                //catch (FormatException excp)
                //{
                //    throw new Exception("「検査ワークシート測定値」クラスの「測定日時文字列」プロパティでエラーが発生しました。\n日時として認識できない文字列が設定されました。\n" + excp.Message);
                //}
            }
        }
        public string 承認者 { get; set; }
        public Nullable<System.DateTime> 承認日時 { get; set; }
        public string 合否 { get; set; }
        public string コメント { get; set; }

        public 検査ワークシート測定値()
        {
            this.ヘッダー = new 検査ワークシートヘッダー(1, "原料");
            this.測定値数値 = 0;
            this.規格値MAX = double.MaxValue;
            this.規格値MIN = double.MinValue;
            this.コメント = string.Empty;
            this.測定日時 = null;
            this.承認日時 = null;
        }

        /// <summary>
        /// データベースへ書き込む
        /// </summary>
        /// <param name="connection">接続文字列（トランザクション処理をするために引数で渡す）</param>
        /// <param name="trans">Transactionオブジェクト（トランザクション処理をするために引数で渡す）</param>
        public void SaveToDB(System.Data.SqlClient.SqlConnection connection, System.Data.SqlClient.SqlTransaction trans, bool updateDB = false, int headerID = 0)
        {
            DataSet検査ワークシートTableAdapters.検査ワークシート属性測定値TableAdapter wsMeasureTA = new DataSet検査ワークシートTableAdapters.検査ワークシート属性測定値TableAdapter();

            //トランザクションを有効にするために、TableAdapterのConnectionプロパティを新しいconnectionオブジェクトで上書きする。
            wsMeasureTA.Connection = connection;
            //全体と同じtransオブジェクトを設定して、トランザクションを有効にする。
            wsMeasureTA.Transaction = trans;
            try
            {
                //Insertする。
                //this.ID = headerID;
                if (updateDB)
                {
                }
                else
                {
                    wsMeasureTA.InsertQuery(this.ヘッダー.ID, this.ヘッダー.コード, this.ヘッダー.ロット番号, 測定項目ID, 測定項目名称, 測定値文字列, 測定値数値, 規格値文字列, 規格値MIN, 規格値MAX, 測定方法, 担当者, (測定日時 == new DateTime(1, 1, 1, 0, 0, 0) ? null : 測定日時), 承認者, (承認日時 == new DateTime(1, 1, 1, 0, 0, 0) ? null : 承認日時), 合否, コメント);
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                //SQLExceptionオブジェクトは、いろいろな情報を持っているので、展開する。
                System.Text.StringBuilder errorMessages = new StringBuilder();
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                throw new Exception(errorMessages.ToString());
            }
            catch(Exception excp)
            {
                throw new Exception(excp.Message);
            }

        }
    }

    public class 検査ワークシート日付数量
    {
        public 検査ワークシートヘッダー ヘッダー { get; set; }
        public int 項目ID { get; set; }
        public string 項目名称 { get; set; }
        public Nullable<System.DateTime> 日付 { get; set; }
        public string 日付テキスト
        {
            get
            {
                return 日付.ToString();
            }
            set
            {
                DateTime dt = new DateTime();
                if (DateTime.TryParse(value, out dt))
                {
                    日付 = dt;
                }
                else
                {
                    日付 = null;
                }
                //try
                //{
                //    //DateTime dt = DateTime.MinValue;
                //    日付 = DateTime.Parse(value);
                //}
                //catch (FormatException excp)
                //{
                //    throw new Exception("「検査ワークシート日付数量」クラスの「検査日時文字列」プロパティでエラーが発生しました。\n日時として認識できない文字列が設定されました。\n" + excp.Message);
                //}
            }
        }
        public double 数量 { get; set; }
        public string 数量テキスト { get; set; }

        public 付加情報 付加情報1 { get; set; }
        public 付加情報 付加情報2 { get; set; }
        public 付加情報 付加情報3 { get; set; }
        //public string 付加情報1名称 { get; set; }
        //public double 付加情報1値 { get; set; }
        //public string 付加情報1値テキスト { get; set; }
        //public string 付加情報2名称 { get; set; }
        //public double 付加情報2値 { get; set; }
        //public string 付加情報2値テキスト { get; set; }
        //public string 付加情報3名称 { get; set; }
        //public double 付加情報3値 { get; set; }
        //public string 付加情報3値テキスト { get; set; }

        public 検査ワークシート日付数量()
        {
            this.ヘッダー = new 検査ワークシートヘッダー();
            this.数量 = 0;
            this.数量テキスト = string.Empty;
            this.付加情報1 = new 付加情報();
            this.付加情報2 = new 付加情報();
            this.付加情報3 = new 付加情報();
        }
        
        public void SaveToDB(System.Data.SqlClient.SqlConnection connection, System.Data.SqlClient.SqlTransaction trans)
        {
            DataSet検査ワークシートTableAdapters.検査ワークシート属性日付数量TableAdapter wsDateTimeQuantityTA = new DataSet検査ワークシートTableAdapters.検査ワークシート属性日付数量TableAdapter();

            //トランザクションを有効にするために、TableAdapterのConnectionプロパティを新しいconnectionオブジェクトで上書きする。
            wsDateTimeQuantityTA.Connection = connection;;
            //全体と同じtransオブジェクトを設定して、トランザクションを有効にする。
            wsDateTimeQuantityTA.Transaction = trans;
            try
            {
                //Insertする。
                wsDateTimeQuantityTA.InsertQuery(this.ヘッダー.ID, this.ヘッダー.コード, this.ヘッダー.ロット番号, 項目ID, 項目名称, (日付 == new DateTime(1, 1, 1, 0, 0, 0) ? null : 日付), 日付テキスト, 数量, 数量テキスト,
                    付加情報1.名称, 付加情報1.値, 付加情報1.値テキスト, 付加情報2.名称, 付加情報2.値, 付加情報2.値テキスト, 付加情報3.名称, 付加情報3.値, 付加情報3.値テキスト);
                //wsMeasureDA.InsertQuery(ヘッダID, コード, ロット番号, 測定項目ID, 測定項目名称, 測定値文字列, 測定値数値, 規格値文字列, 規格値MIN, 規格値MAX, 測定方法, 担当者, 測定日時, 承認者, 承認日時, 合否, コメント);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                //SQLExceptionオブジェクトは、いろいろな情報を持っているので、展開する。
                System.Text.StringBuilder errorMessages = new StringBuilder();
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                throw new Exception(errorMessages.ToString());
            }
            catch (Exception excp)
            {
                throw new Exception(excp.Message);
            }
        }
    }

    /// <summary>
    /// 「検査ワークシート日付数量」のプロパティにある「付加情報」用のクラス
    /// </summary>
    public class 付加情報
    {
        public string 名称 { get; set; }
        public double 値 { get; set; }
        public string 値テキスト { get; set; }
    }

    public class 原料検査ワークシート2:検査ワークシートヘッダー
    {
        public 検査ワークシート測定値 総合判定 { get; set; }
        //public 検査ワークシート測定値 官能検査 { get; set; }
        public 検査ワークシート測定値 色調性状 { get; set; }
        public 検査ワークシート測定値 香気 { get; set; }
        public 検査ワークシート測定値 容器封緘 { get; set; }
        public 検査ワークシート日付数量 入荷 { get; set; }
        public 検査ワークシート日付数量 乾燥減量 { get; set; }

        public 原料検査ワークシート2(int _検査種別ID = 1, string _検査種別 = "原料")
        {
            this.検査種別ID = _検査種別ID;
            this.検査種別テキスト = _検査種別;

            総合判定 = new 検査ワークシート測定値();
            総合判定.ヘッダー = this;
            総合判定.測定項目名称 = "総合判定";

            //官能検査 = new 検査ワークシート測定値();
            //官能検査.ヘッダー = this;
            //官能検査.測定項目名称 = "官能検査";

            色調性状 = new 検査ワークシート測定値();
            色調性状.ヘッダー = this;
            色調性状.測定項目名称 = "色調性状";

            香気 = new 検査ワークシート測定値();
            香気.ヘッダー = this;
            香気.測定項目名称 = "香気";
            
            容器封緘 = new 検査ワークシート測定値();
            容器封緘.ヘッダー = this;
            容器封緘.測定項目名称 = "容器封緘";

            入荷 = new 検査ワークシート日付数量();
            入荷.ヘッダー = this;
            入荷.項目名称 = "入荷";
            //入荷.付加情報1 = new 付加情報();
            入荷.付加情報1.名称 = "納入元";
            //入荷.付加情報2 = new 付加情報();
            入荷.付加情報2.名称 = "製造会社";

            乾燥減量 = new 検査ワークシート日付数量();
            乾燥減量.ヘッダー = this;
            乾燥減量.項目名称 = "乾燥減量";
        }
        
        public void SaveToDB()
        {
           // DataSet検査ワークシート ds = new DataSet検査ワークシート();

            System.Data.SqlClient.SqlTransaction trans;

            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.CCJQAQCConnectionString.ToString()))
            {
                connection.Open();

                trans = connection.BeginTransaction();

                try
                {
                    SaveToDB(connection,trans);//ヘッダ部分の保存
                    総合判定.SaveToDB(connection,trans);
                    //官能検査.SaveToDB(connection,trans);
                    色調性状.SaveToDB(connection, trans);
                    香気.SaveToDB(connection, trans);
                    容器封緘.SaveToDB(connection,trans);
                    入荷.SaveToDB(connection, trans);

                    trans.Commit();

                    //System.Windows.Forms.MessageBox.Show("原料検査ワークシート2クラスデータベース書き込み終了です。", Properties.Settings.Default.ApplicationName, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    trans.Rollback();
                    System.Windows.Forms.MessageBox.Show("Rollbackしたよ", Properties.Settings.Default.ApplicationName, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
                catch (Exception excp)
                {
                    System.Windows.Forms.MessageBox.Show(excp.Message, Properties.Settings.Default.ApplicationName, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
            }
        }
    }




    public class 製品検査ワークシート : 検査ワークシートヘッダー
    {
        public 検査ワークシート測定値 総合判定 { get; set; }
        public 検査ワークシート測定値 官能検査 { get; set; }
        public 検査ワークシート測定値 色調性状 { get; set; }
        public 検査ワークシート測定値 香気 { get; set; }
        public 検査ワークシート測定値 比重 { get; set; }
        public 検査ワークシート測定値 屈折率 { get; set; }
        public 検査ワークシート測定値 pH { get; set; }

        public 検査ワークシート日付数量 出荷 { get; set; }
        public 検査ワークシート日付数量 製造 { get; set; }

        public 検査ワークシートヘッダー 貼り替え元 { get; set; }

        public 製品検査ワークシート(int _検査種別ID, string _検査種別)
        {
            this.検査種別ID = _検査種別ID;
            this.検査種別テキスト = _検査種別;

            総合判定 = new 検査ワークシート測定値();
            総合判定.ヘッダー = this;
            総合判定.測定項目名称 = "総合判定";

            官能検査 = new 検査ワークシート測定値();
            官能検査.ヘッダー = this;
            官能検査.測定項目名称 = "官能検査";

            色調性状 = new 検査ワークシート測定値();
            色調性状.ヘッダー = this;
            色調性状.測定項目名称 = "色調性状";

            香気 = new 検査ワークシート測定値();
            香気.ヘッダー = this;
            香気.測定項目名称 = "香気";

            比重 = new 検査ワークシート測定値();
            比重.ヘッダー = this;
            比重.測定項目名称 = "比重";

            屈折率 = new 検査ワークシート測定値();
            屈折率.ヘッダー = this;
            屈折率.測定項目名称 = "屈折率";

            pH = new 検査ワークシート測定値();
            pH.ヘッダー = this;
            pH.測定項目名称 = "pH";

            pH = new 検査ワークシート測定値();
            pH.ヘッダー = this;
            pH.測定項目名称 = "pH";

            出荷 = new 検査ワークシート日付数量();
            出荷.ヘッダー = this;
            出荷.項目名称 = "出荷";
            //出荷.付加情報1 = new 付加情報();
            出荷.付加情報1.名称 = "出荷先";
            //入荷.付加情報2名称 = "製造会社";

            製造 = new 検査ワークシート日付数量();
            製造.ヘッダー = this;
            製造.項目名称 = "製造";
            //製造.付加情報1 = new 付加情報();
            製造.付加情報1.名称 = "製造担当者・外部製造元";
            //製造.付加情報2 = new 付加情報();
            製造.付加情報2.名称 = "製造部コメント";
        }

        public void SaveToDB()
        {
            //DataSet検査ワークシート ds = new DataSet検査ワークシート();
            //DataSet検査ワークシートTableAdapters.検査ワークシートヘッダTableAdapter wsheaderta = new DataSet検査ワークシートTableAdapters.検査ワークシートヘッダTableAdapter();
            //DataSet検査ワークシートTableAdapters.検査ワークシート属性測定値TableAdapter wsmeastureta = new DataSet検査ワークシートTableAdapters.検査ワークシート属性測定値TableAdapter();

            System.Data.SqlClient.SqlTransaction trans;

            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.CCJQAQCConnectionString.ToString()))
            {
                connection.Open();

                trans = connection.BeginTransaction();

                try
                {
                    SaveToDB(connection, trans);
                    総合判定.SaveToDB(connection, trans);
                    官能検査.SaveToDB(connection, trans);
                    比重.SaveToDB(connection, trans);
                    屈折率.SaveToDB(connection, trans); 
                    pH.SaveToDB(connection, trans);
                    
                    出荷.SaveToDB(connection, trans); 
                    製造.SaveToDB(connection, trans);
                    
                    trans.Commit();

                    System.Windows.Forms.MessageBox.Show("原料検査ワークシート2クラスデータベース書き込み終了です。", Properties.Settings.Default.ApplicationName, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    trans.Rollback();
                    System.Windows.Forms.MessageBox.Show("Rollbackしたよ", Properties.Settings.Default.ApplicationName, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
                catch (Exception excp)
                {
                    System.Windows.Forms.MessageBox.Show(excp.Message, Properties.Settings.Default.ApplicationName, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
            }
        }
    }
}
