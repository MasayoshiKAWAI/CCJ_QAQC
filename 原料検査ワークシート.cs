//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはテンプレートから生成されました。
//
//     このファイルを手動で変更すると、アプリケーションで予期しない動作が発生する可能性があります。
//     このファイルに対する手動の変更は、コードが再生成されると上書きされます。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CCJ_QAQC
{
    using System;
    using System.Collections.Generic;
    
    public partial class 原料検査ワークシート
    {
        public int ID { get; set; }
        public string 原料コード { get; set; }
        public string 原料名 { get; set; }
        public string ロット番号 { get; set; }
        public string ロット番号備考 { get; set; }
        public Nullable<System.DateTime> 入荷日 { get; set; }
        public string 入荷日テキスト { get; set; }
        public string 納入元 { get; set; }
        public string 容器封緘ラベル { get; set; }
        public Nullable<System.DateTime> 検査日 { get; set; }
        public string 検査担当者 { get; set; }
        public string 官能検査合否 { get; set; }
        public string コメントその他検査項目 { get; set; }
        public string 総合判定 { get; set; }
        public string 製造会社 { get; set; }
        public string 入荷量 { get; set; }
    }
}
