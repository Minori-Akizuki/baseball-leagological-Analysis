namespace yakyuuuu
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLoadNameDB = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLoadLyrics = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveLyrics = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOption = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxLyrics = new System.Windows.Forms.TextBox();
            this.textBoxConverted = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.openFileDialogYakyuuName = new System.Windows.Forms.OpenFileDialog();
            this.listBoxRead = new System.Windows.Forms.ListBox();
            this.listBoxReadV = new System.Windows.Forms.ListBox();
            this.textBoxAnnotation = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemOption});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(701, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemLoadNameDB,
            this.toolStripMenuItemLoadLyrics,
            this.toolStripMenuItemSaveLyrics});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(68, 22);
            this.toolStripMenuItemFile.Text = "ファイル";
            // 
            // toolStripMenuItemLoadNameDB
            // 
            this.toolStripMenuItemLoadNameDB.Name = "toolStripMenuItemLoadNameDB";
            this.toolStripMenuItemLoadNameDB.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItemLoadNameDB.Text = "選手名読み込み";
            this.toolStripMenuItemLoadNameDB.Click += new System.EventHandler(this.ToolStripMenuItemLoadNameDB_Click);
            // 
            // toolStripMenuItemLoadLyrics
            // 
            this.toolStripMenuItemLoadLyrics.Name = "toolStripMenuItemLoadLyrics";
            this.toolStripMenuItemLoadLyrics.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItemLoadLyrics.Text = "歌詞読み込み";
            // 
            // toolStripMenuItemSaveLyrics
            // 
            this.toolStripMenuItemSaveLyrics.Name = "toolStripMenuItemSaveLyrics";
            this.toolStripMenuItemSaveLyrics.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItemSaveLyrics.Text = "保存";
            // 
            // toolStripMenuItemOption
            // 
            this.toolStripMenuItemOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSettings});
            this.toolStripMenuItemOption.Name = "toolStripMenuItemOption";
            this.toolStripMenuItemOption.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItemOption.Text = "オプション";
            // 
            // ToolStripMenuItemSettings
            // 
            this.ToolStripMenuItemSettings.Name = "ToolStripMenuItemSettings";
            this.ToolStripMenuItemSettings.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItemSettings.Text = "設定";
            this.ToolStripMenuItemSettings.Click += new System.EventHandler(this.ToolStripMenuItemSettings_Click);
            // 
            // textBoxLyrics
            // 
            this.textBoxLyrics.AcceptsReturn = true;
            this.textBoxLyrics.AllowDrop = true;
            this.textBoxLyrics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLyrics.Location = new System.Drawing.Point(12, 29);
            this.textBoxLyrics.Multiline = true;
            this.textBoxLyrics.Name = "textBoxLyrics";
            this.textBoxLyrics.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLyrics.Size = new System.Drawing.Size(294, 193);
            this.textBoxLyrics.TabIndex = 1;
            // 
            // textBoxConverted
            // 
            this.textBoxConverted.AcceptsReturn = true;
            this.textBoxConverted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxConverted.Location = new System.Drawing.Point(393, 29);
            this.textBoxConverted.Multiline = true;
            this.textBoxConverted.Name = "textBoxConverted";
            this.textBoxConverted.ReadOnly = true;
            this.textBoxConverted.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxConverted.Size = new System.Drawing.Size(294, 193);
            this.textBoxConverted.TabIndex = 2;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(312, 115);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(75, 23);
            this.buttonConvert.TabIndex = 3;
            this.buttonConvert.Text = "> 変換 >";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.ananlysLyric);
            // 
            // openFileDialogYakyuuName
            // 
            this.openFileDialogYakyuuName.Filter = "CSV|*.csv";
            this.openFileDialogYakyuuName.Multiselect = true;
            // 
            // listBoxRead
            // 
            this.listBoxRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxRead.FormattingEnabled = true;
            this.listBoxRead.ItemHeight = 12;
            this.listBoxRead.Location = new System.Drawing.Point(157, 246);
            this.listBoxRead.Name = "listBoxRead";
            this.listBoxRead.Size = new System.Drawing.Size(139, 244);
            this.listBoxRead.TabIndex = 5;
            this.listBoxRead.SelectedIndexChanged += new System.EventHandler(this.listBoxRead_SelectedIndexChanged);
            // 
            // listBoxReadV
            // 
            this.listBoxReadV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxReadV.FormattingEnabled = true;
            this.listBoxReadV.ItemHeight = 12;
            this.listBoxReadV.Location = new System.Drawing.Point(12, 246);
            this.listBoxReadV.Name = "listBoxReadV";
            this.listBoxReadV.Size = new System.Drawing.Size(139, 244);
            this.listBoxReadV.TabIndex = 4;
            this.listBoxReadV.SelectedIndexChanged += new System.EventHandler(this.listBoxReadV_SelectedIndexChanged);
            // 
            // textBoxAnnotation
            // 
            this.textBoxAnnotation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxAnnotation.Location = new System.Drawing.Point(302, 246);
            this.textBoxAnnotation.Multiline = true;
            this.textBoxAnnotation.Name = "textBoxAnnotation";
            this.textBoxAnnotation.Size = new System.Drawing.Size(141, 244);
            this.textBoxAnnotation.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "debug";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 502);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxAnnotation);
            this.Controls.Add(this.listBoxRead);
            this.Controls.Add(this.listBoxReadV);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.textBoxConverted);
            this.Controls.Add(this.textBoxLyrics);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "やきうせんしゅめいたいそかいせき";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLoadNameDB;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOption;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSettings;
        private System.Windows.Forms.TextBox textBoxLyrics;
        private System.Windows.Forms.TextBox textBoxConverted;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveLyrics;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLoadLyrics;
        private System.Windows.Forms.OpenFileDialog openFileDialogYakyuuName;
        private System.Windows.Forms.ListBox listBoxRead;
        private System.Windows.Forms.ListBox listBoxReadV;
        private System.Windows.Forms.TextBox textBoxAnnotation;
        private System.Windows.Forms.Button button1;
    }
}

