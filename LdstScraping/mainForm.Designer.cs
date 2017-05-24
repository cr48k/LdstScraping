namespace LdstScraping
{
    partial class mainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.mainWebBrowser = new System.Windows.Forms.WebBrowser();
            this.browserUrlTextBox = new System.Windows.Forms.TextBox();
            this.characterInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.characterNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serverNameLabel = new System.Windows.Forms.Label();
            this.mainMenuGroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.acquiredDataCountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.characterInfoGroupBox.SuspendLayout();
            this.mainMenuGroupBox.SuspendLayout();
            this.infoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.BackColor = System.Drawing.SystemColors.Control;
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.IsSplitterFixed = true;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.mainWebBrowser);
            this.mainSplitContainer.Panel1.Controls.Add(this.browserUrlTextBox);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.mainSplitContainer.Panel2.Controls.Add(this.infoGroupBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.mainMenuGroupBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.characterInfoGroupBox);
            this.mainSplitContainer.Size = new System.Drawing.Size(1384, 793);
            this.mainSplitContainer.SplitterDistance = 1123;
            this.mainSplitContainer.TabIndex = 0;
            // 
            // mainWebBrowser
            // 
            this.mainWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainWebBrowser.Location = new System.Drawing.Point(0, 23);
            this.mainWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.mainWebBrowser.Name = "mainWebBrowser";
            this.mainWebBrowser.Size = new System.Drawing.Size(1123, 770);
            this.mainWebBrowser.TabIndex = 1;
            this.mainWebBrowser.Url = new System.Uri("http://jp.finalfantasyxiv.com/lodestone/", System.UriKind.Absolute);
            // 
            // browserUrlTextBox
            // 
            this.browserUrlTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.browserUrlTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.browserUrlTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.browserUrlTextBox.Location = new System.Drawing.Point(0, 0);
            this.browserUrlTextBox.Name = "browserUrlTextBox";
            this.browserUrlTextBox.ReadOnly = true;
            this.browserUrlTextBox.Size = new System.Drawing.Size(1123, 23);
            this.browserUrlTextBox.TabIndex = 0;
            this.browserUrlTextBox.TabStop = false;
            // 
            // characterInfoGroupBox
            // 
            this.characterInfoGroupBox.Controls.Add(this.serverNameLabel);
            this.characterInfoGroupBox.Controls.Add(this.label2);
            this.characterInfoGroupBox.Controls.Add(this.characterNameLabel);
            this.characterInfoGroupBox.Controls.Add(this.label1);
            this.characterInfoGroupBox.Location = new System.Drawing.Point(3, 3);
            this.characterInfoGroupBox.Name = "characterInfoGroupBox";
            this.characterInfoGroupBox.Size = new System.Drawing.Size(251, 85);
            this.characterInfoGroupBox.TabIndex = 0;
            this.characterInfoGroupBox.TabStop = false;
            this.characterInfoGroupBox.Text = "ログイン中のキャラクター";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "キャラクター名:";
            // 
            // characterNameLabel
            // 
            this.characterNameLabel.AutoSize = true;
            this.characterNameLabel.Location = new System.Drawing.Point(88, 28);
            this.characterNameLabel.Name = "characterNameLabel";
            this.characterNameLabel.Size = new System.Drawing.Size(12, 15);
            this.characterNameLabel.TabIndex = 1;
            this.characterNameLabel.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "サーバー名:";
            // 
            // serverNameLabel
            // 
            this.serverNameLabel.AutoSize = true;
            this.serverNameLabel.Location = new System.Drawing.Point(88, 52);
            this.serverNameLabel.Name = "serverNameLabel";
            this.serverNameLabel.Size = new System.Drawing.Size(12, 15);
            this.serverNameLabel.TabIndex = 3;
            this.serverNameLabel.Text = "-";
            // 
            // mainMenuGroupBox
            // 
            this.mainMenuGroupBox.Controls.Add(this.label5);
            this.mainMenuGroupBox.Controls.Add(this.label4);
            this.mainMenuGroupBox.Controls.Add(this.label3);
            this.mainMenuGroupBox.Controls.Add(this.button3);
            this.mainMenuGroupBox.Controls.Add(this.button2);
            this.mainMenuGroupBox.Controls.Add(this.button1);
            this.mainMenuGroupBox.Location = new System.Drawing.Point(3, 94);
            this.mainMenuGroupBox.Name = "mainMenuGroupBox";
            this.mainMenuGroupBox.Size = new System.Drawing.Size(251, 132);
            this.mainMenuGroupBox.TabIndex = 1;
            this.mainMenuGroupBox.TabStop = false;
            this.mainMenuGroupBox.Text = "メニュー";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(6, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "データ取得";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(6, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "データ表示";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(6, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "設定";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "データの取得を行います";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "取得したデータを表示します";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "アプリケーション設定を開きます";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.Controls.Add(this.acquiredDataCountLabel);
            this.infoGroupBox.Controls.Add(this.label6);
            this.infoGroupBox.Location = new System.Drawing.Point(3, 232);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Size = new System.Drawing.Size(251, 115);
            this.infoGroupBox.TabIndex = 2;
            this.infoGroupBox.TabStop = false;
            this.infoGroupBox.Text = "情報";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "取得済み件数:";
            // 
            // acquiredDataCountLabel
            // 
            this.acquiredDataCountLabel.AutoSize = true;
            this.acquiredDataCountLabel.Location = new System.Drawing.Point(95, 28);
            this.acquiredDataCountLabel.Name = "acquiredDataCountLabel";
            this.acquiredDataCountLabel.Size = new System.Drawing.Size(14, 15);
            this.acquiredDataCountLabel.TabIndex = 1;
            this.acquiredDataCountLabel.Text = "0";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1384, 793);
            this.Controls.Add(this.mainSplitContainer);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lodestone Scraping";
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel1.PerformLayout();
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.characterInfoGroupBox.ResumeLayout(false);
            this.characterInfoGroupBox.PerformLayout();
            this.mainMenuGroupBox.ResumeLayout(false);
            this.mainMenuGroupBox.PerformLayout();
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.WebBrowser mainWebBrowser;
        private System.Windows.Forms.TextBox browserUrlTextBox;
        private System.Windows.Forms.GroupBox characterInfoGroupBox;
        private System.Windows.Forms.Label serverNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label characterNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox mainMenuGroupBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.Label acquiredDataCountLabel;
        private System.Windows.Forms.Label label6;
    }
}

