using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Kawai.ApplicationBase;
using System.Linq;

using System.Data.SqlClient;
using System.Data.EntityClient;
using System.Data.Metadata.Edm;

namespace CCJ_QAQC
{
    public partial class Form原料検査ワークシートテーブル : Kawai.ApplicationBase.FormBase
    {
        public Form原料検査ワークシートテーブル(Stack<FormInformation> formopenorderstack, FormInformation forminformation)
            : base(formopenorderstack, forminformation)
        {
            InitializeComponent();

            this.ApplicationName = Properties.Settings.Default.ApplicationName;
            this.ApplicationVersion = Properties.Settings.Default.Version;
            this.ModifyDate = Properties.Settings.Default.ModifyDate;
        }

        private const int customerId = 277;

        //CCJ2Entities ccj2entities;

        private void Form原料検査ワークシート_Load(object sender, EventArgs e)
        {
            // Initialize the object context.
            //ccj2entities = new CCJ2Entities();
            //var genryolist = ccj2entities.検査ワークシート;
            this.dataGridView1.DataSource = (new CCJ2EntitiesMILK()).原料検査ワークシート.ToList();//genryolist.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Specify the provider name, server and database.
            string providerName = "System.Data.SqlClient";
            string serverName = "MILK";
            string databaseName = "CCJ2";

            // Initialize the connection string builder for the underlying provider.
            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();

            // Set the properties for the data source.
            sqlBuilder.DataSource = serverName;
            sqlBuilder.InitialCatalog = databaseName;
            sqlBuilder.IntegratedSecurity = true;
            sqlBuilder.UserID = "PrescripSys";

            // Build the SqlConnection connection string.
            string providerString = sqlBuilder.ToString();

            // Initialize the EntityConnectionStringBuilder.
            EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder();

            //Set the provider name.
            entityBuilder.Provider = providerName;

            // Set the provider-specific connection string.
            entityBuilder.ProviderConnectionString = providerString;

            // Set the Metadata location.
            entityBuilder.Metadata = @"res://*/検査ワークシート.csdl|res://*/検査ワークシート.ssdl|res://*/検査ワークシート.msl";
            Console.WriteLine(entityBuilder.ToString());

            using (EntityConnection conn = new EntityConnection(entityBuilder.ToString()))
            {
                conn.Open();
                //ccj2entities = new CCJ2Entities();
                Console.WriteLine("Just testing the connection.");
                //this.dataGridView1.DataSource = null;
                //this.dataGridView1.DataSource = ccj2entities.原料検査ワークシート.ToList();
                //ccj2entitiesMILK = new CCJ2EntitiesMILK();
                //this.dataGridView1.DataSource = ccj2entitiesMILK.検査ワークシート.ToList();

                conn.Close();
            }

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Selected = true;

            if (e.RowIndex > -1)
            {
                int i = -1;
                int MaterialID = int.TryParse(this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), out i) ? i : -1;
                //string MaterialCode = string.IsNullOrWhiteSpace(this.dataGridView材料マスタ.Rows[e.RowIndex].Cells[0].Value.ToString()) ? "" : this.dataGridView材料マスタ.Rows[e.RowIndex].Cells[0].Value.ToString();

                //Code Snippetここから
                //引数にFormを開いた順序を持たせるStackとFormの情報を渡すと、逆順で閉じることができるようになる。
                //新しく開いたFormに、そのStackを渡し、自分自身をスタックに登録しておく。
                Form原料検査WS詳細 frm = new Form原料検査WS詳細(new Stack<FormInformation>(), new FormInformation() { OriginForm = this, FormGuid = this.MyGUID });
                frm.原料ワークシートID = MaterialID;
                frm.Show();
                //this.WindowState = FormWindowState.Minimized;
                //Code Snippetここまで

                //原材料 _原材料 = 原材料マネージャー.Read基本項目(MaterialCode);
                //if (this.ReadOnly)
                //{
                //    Form原料マスタ詳細読取専用 frm = new Form原料マスタ詳細読取専用();
                //    frm._原材料 = _原材料;
                //    frm.StartPosition = FormStartPosition.CenterScreen;
                //    frm.Show();
                //    frm.OriginForm = this;
                //}
                //else
                //{
                //    Form原料マスタ詳細編集 frm = new Form原料マスタ詳細編集();
                //    frm._原材料 = _原材料;
                //    if (forceReadOnly)
                //    {
                //        frm.ReadOnlyMode = true;
                //    }
                //    frm.StartPosition = FormStartPosition.CenterScreen;
                //    frm.Show();
                //    frm.OriginForm = this;
                //}
                this.WindowState = FormWindowState.Minimized;
            }
        }
    }
}
