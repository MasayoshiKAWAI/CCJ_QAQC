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
    public partial class FormMenu : Kawai.ApplicationBase.FormMenuBase
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            this.statusStrip1.SizingGrip = false;
            this.ApplicationName = Properties.Settings.Default.ApplicationName.ToString();
            this.ApplicationVersion = Properties.Settings.Default.Version.ToString();
            this.ModifyDate = Properties.Settings.Default.ModifyDate.ToString();
        }

        private void button元番製品コード検索_Click(object sender, EventArgs e)
        {
            //引数にFormを開いた順序を持たせるStackとFormの情報を渡すと、逆順で閉じることができるようになる。
            //新しく開いたFormに、そのStackを渡し、自分自身をスタックに登録しておく。
            Form元番製品コード検索 frm = new Form元番製品コード検索(new Stack<FormInformation>(), new FormInformation() { OriginForm = this, FormGuid = this.MyGUID });
            frm.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void button原料検索_Click(object sender, EventArgs e)
        {
            //引数にFormを開いた順序を持たせるStackとFormの情報を渡すと、逆順で閉じることができるようになる。
            //新しく開いたFormに、そのStackを渡し、自分自身をスタックに登録しておく。
            Form原料コード検索 frm = new Form原料コード検索(new Stack<FormInformation>(), new FormInformation() { OriginForm = this, FormGuid = this.MyGUID });
            frm.Show();
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //引数にFormを開いた順序を持たせるStackとFormの情報を渡すと、逆順で閉じることができるようになる。
            //新しく開いたFormに、そのStackを渡し、自分自身をスタックに登録しておく。
            Form原料検査ワークシートテーブル frm = new Form原料検査ワークシートテーブル(new Stack<FormInformation>(), new FormInformation() { OriginForm = this, FormGuid = this.MyGUID });
            frm.Show();
            this.WindowState = FormWindowState.Minimized;
         }

        private void button原料検査ワークシート_Click(object sender, EventArgs e)
        {
            //引数にFormを開いた順序を持たせるStackとFormの情報を渡すと、逆順で閉じることができるようになる。
            //新しく開いたFormに、そのStackを渡し、自分自身をスタックに登録しておく。
            Form原料検査WS検索 frm = new Form原料検査WS検索(new Stack<FormInformation>(), new FormInformation() { OriginForm = this, FormGuid = this.MyGUID });
            frm.Show();
            this.WindowState = FormWindowState.Minimized;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //引数にFormを開いた順序を持たせるStackとFormの情報を渡すと、逆順で閉じることができるようになる。
            //新しく開いたFormに、そのStackを渡し、自分自身をスタックに登録しておく。
            FormReadCSV frm = new FormReadCSV(new Stack<FormInformation>(), new FormInformation() { OriginForm = this, FormGuid = this.MyGUID });
            frm.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //引数にFormを開いた順序を持たせるStackとFormの情報を渡すと、逆順で閉じることができるようになる。
            //新しく開いたFormに、そのStackを渡し、自分自身をスタックに登録しておく。
            Form原料検査WS詳細 frm = new Form原料検査WS詳細(new Stack<FormInformation>(), new FormInformation() { OriginForm = this, FormGuid = this.MyGUID });
            frm.Show();
            this.WindowState = FormWindowState.Minimized;

        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            //Code Snippetここから
            //引数にFormを開いた順序を持たせるStackとFormの情報を渡すと、逆順で閉じることができるようになる。
            //新しく開いたFormに、そのStackを渡し、自分自身をスタックに登録しておく。
            FormTest frm = new FormTest(new Stack<FormInformation>(), new FormInformation() { OriginForm = this, FormGuid = this.MyGUID });
            frm.Show();
            this.WindowState = FormWindowState.Minimized;
            //Code Snippetここまで
                    
        }

        private void button原料検査ワークシート作成_Click(object sender, EventArgs e)
        {
            
            //Code Snippetここから
            //引数にFormを開いた順序を持たせるStackとFormの情報を渡すと、逆順で閉じることができるようになる。
            //新しく開いたFormに、そのStackを渡し、自分自身をスタックに登録しておく。
            Form原料検査WS詳細 frm = new Form原料検査WS詳細(new Stack<FormInformation>(), new FormInformation() { OriginForm = this, FormGuid = this.MyGUID });
            frm.Show();
            this.WindowState = FormWindowState.Minimized;
            //Code Snippetここまで
                    
        }

    }
}
