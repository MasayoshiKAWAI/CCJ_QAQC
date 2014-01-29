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
    public partial class Form11 : FormBase
    {
        /// <summary>
        /// 引数ありのコンストラクタ。
        /// 引数の内容は、FormBaseクラスでプロパティに書き込まれている。
        /// </summary>
        /// <param name="formopenorderstack">メニューのボタンで新規に作成され、バケツリレーで来ている、Formを開けた順序を保持するStack</param>
        /// <param name="forminformation">このフォームを開けたFormの情報</param>
        public Form11(Stack<FormInformation> formopenorderstack, FormInformation forminformation):base(formopenorderstack,forminformation)
        {
            InitializeComponent();

            this.ApplicationName = "フォームを順序よく閉じるテスト";
            this.ApplicationVersion = "0.0.1";
            this.ModifyDate = DateTime.Today.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Tag == null)
                {
                    f.Tag = "NULL";
                }
                this.listBox1.Items.Add(f.Name + "： Tag = " + f.Tag.ToString() + "： GUID = ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.FormOpenOrderStack.ToList().ForEach((FormInformation fi) => { this.listBox1.Items.Add(fi.OriginForm.Name + ":" + fi.FormGuid); });
        }
    }
}
