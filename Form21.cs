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
    public partial class Form21 : FormBase
    {
        public Form21(Stack<FormInformation> formopenorderstack, FormInformation forminformation)
            : base(formopenorderstack, forminformation)
        {
            InitializeComponent();

            this.ApplicationName = "フォームを順序よく閉じるテスト";
            this.ApplicationVersion = "0.0.1";
            this.ModifyDate = DateTime.Today.ToShortDateString();
        }
    }
}
