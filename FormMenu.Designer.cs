namespace CCJ_QAQC
{
    partial class FormMenu
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.button元番製品コード検索 = new System.Windows.Forms.Button();
            this.button原料検査ワークシート = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button原料検索 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button原料検査ワークシート作成 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.Location = new System.Drawing.Point(581, 520);
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // button元番製品コード検索
            // 
            this.button元番製品コード検索.Location = new System.Drawing.Point(265, 234);
            this.button元番製品コード検索.Name = "button元番製品コード検索";
            this.button元番製品コード検索.Size = new System.Drawing.Size(388, 51);
            this.button元番製品コード検索.TabIndex = 2;
            this.button元番製品コード検索.Text = "元番・製品コード検索";
            this.button元番製品コード検索.UseVisualStyleBackColor = true;
            this.button元番製品コード検索.Click += new System.EventHandler(this.button元番製品コード検索_Click);
            // 
            // button原料検査ワークシート
            // 
            this.button原料検査ワークシート.Location = new System.Drawing.Point(42, 319);
            this.button原料検査ワークシート.Name = "button原料検査ワークシート";
            this.button原料検査ワークシート.Size = new System.Drawing.Size(170, 51);
            this.button原料検査ワークシート.TabIndex = 5;
            this.button原料検査ワークシート.Text = "原料検査ワークシート";
            this.button原料検査ワークシート.UseVisualStyleBackColor = true;
            this.button原料検査ワークシート.Click += new System.EventHandler(this.button原料検査ワークシート_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "CSVファイル操作";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(265, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 48);
            this.button2.TabIndex = 7;
            this.button2.Text = "「原料検査ワークシート」テーブル表示";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(265, 478);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 46);
            this.button3.TabIndex = 8;
            this.button3.Text = "詳細画面";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button原料検索
            // 
            this.button原料検索.Location = new System.Drawing.Point(42, 234);
            this.button原料検索.Name = "button原料検索";
            this.button原料検索.Size = new System.Drawing.Size(170, 51);
            this.button原料検索.TabIndex = 9;
            this.button原料検索.Text = "原料コード検索";
            this.button原料検索.UseVisualStyleBackColor = true;
            this.button原料検索.Click += new System.EventHandler(this.button原料検索_Click);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(265, 319);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(170, 51);
            this.button5.TabIndex = 5;
            this.button5.Text = "中間製品ワークシート";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button原料検査ワークシート_Click);
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(483, 319);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(170, 51);
            this.button6.TabIndex = 5;
            this.button6.Text = "製品ワークシート";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button原料検査ワークシート_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::CCJ_QAQC.Properties.Resources.titleimage;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
            // 
            // button原料検査ワークシート作成
            // 
            this.button原料検査ワークシート作成.Location = new System.Drawing.Point(42, 95);
            this.button原料検査ワークシート作成.Name = "button原料検査ワークシート作成";
            this.button原料検査ワークシート作成.Size = new System.Drawing.Size(170, 52);
            this.button原料検査ワークシート作成.TabIndex = 10;
            this.button原料検査ワークシート作成.Text = "原料検査ワークシート作成";
            this.button原料検査ワークシート作成.UseVisualStyleBackColor = true;
            this.button原料検査ワークシート作成.Click += new System.EventHandler(this.button原料検査ワークシート作成_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 608);
            this.Controls.Add(this.button原料検査ワークシート作成);
            this.Controls.Add(this.button原料検索);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button原料検査ワークシート);
            this.Controls.Add(this.button元番製品コード検索);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 650);
            this.MinimumSize = new System.Drawing.Size(700, 650);
            this.Name = "FormMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "メインメニュー";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.Controls.SetChildIndex(this.buttonCloseForm, 0);
            this.Controls.SetChildIndex(this.button元番製品コード検索, 0);
            this.Controls.SetChildIndex(this.button原料検査ワークシート, 0);
            this.Controls.SetChildIndex(this.button5, 0);
            this.Controls.SetChildIndex(this.button6, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button原料検索, 0);
            this.Controls.SetChildIndex(this.button原料検査ワークシート作成, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button元番製品コード検索;//Kawai.ApplicationBase.MenuButton button1;
        private System.Windows.Forms.Button button原料検査ワークシート;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button原料検索;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button原料検査ワークシート作成;
    }
}

