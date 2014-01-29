using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCJ_QAQC
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool createdNew;
            //Mutexクラスの作成
            System.Threading.Mutex mutex = new System.Threading.Mutex(true, "CCJ_QAQC", out createdNew);
            if (createdNew == false)
            {
                //ミューテックスの初期所有権が付与されなかったときはすでに起動していると判断して終了
                MessageBox.Show("多重起動はできません。");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMenu());

            //ミューテックスを解放する
            mutex.ReleaseMutex();
        }
    }
}
