using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace yakyuuuu
{
    public partial class Form1 : Form
    {
        YakyuuDic yakyuuNameDic;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォームが読まれた時の動作.
        /// 辞書データをnull初期化してるだけ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            yakyuuNameDic = null;
        }

        /// <summary>
        /// 野球選手名読み込み
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemLoadNameDB_Click(object sender, EventArgs e)
        {
            if (openFileDialogYakyuuName.ShowDialog() == DialogResult.OK)
            {
                yakyuuNameDic = new YakyuuDic(openFileDialogYakyuuName.FileName);
            }
        }


        /// <summary>
        /// 変換ボタンを押した時の動作.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ananlysLyric(object sender, EventArgs e)
        {
            // 選手名辞書が空だったらその場で動作を止める
            if (yakyuuNameDic == null)
            {
                textBoxConverted.Text = "no loaded dics!!";
                return;
            }

            resetSelList();

            // 変換後テキストの初期化
            textBoxConverted.Text = "";

            // 入力されたテキストを母音列に変換
            string readv =  ConvertTextForYakyuu.convVowelString( textBoxLyrics.Text );
            // 母音列をトークン列に変換
            var ls = new LatticedString(readv, yakyuuNameDic);

            // 元の文字列を表示
            textBoxConverted.Text += "[" + ls.BaseString + "]\r\n";

            // グラフを展開したものを順次表示
            foreach (var s in ls.unfoldLatticeToString())
            {
                textBoxConverted.Text += s + "\r\n";
            }

            // 全てのトークンを取得
            var selList = new HashSet<String>(ls.allTokens());
            
            // 一回リストをクリアしてからそれらを下のリストボックスに追加
            listBoxReadV.Items.Clear();
            var li = selList.ToList();
            li.Sort();
            listBoxReadV.Items.AddRange(li.ToArray());
        }

        /// <summary>
        /// 左ののリストボックスを選択した時の動作.
        /// まんなかのリストにその母音と一致する名前を並べる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxReadV_SelectedIndexChanged(object sender, EventArgs e)
        {
            String sel = (String) listBoxReadV.SelectedItem;
            var li = from r in yakyuuNameDic.NameTable
                     where sel == ConvertTextForYakyuu.convVowelString(r.NameRead)
                     select r;
            listBoxRead.Items.Clear();
            listBoxRead.Items.AddRange(li.ToArray());
            textBoxAnnotation.Text = "";
        }

        /// <summary>
        /// 真ん中のリストボックスを選択した時の動作
        /// その名前についている注釈を右のテキストボックスに表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxRead_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxAnnotation.Text = ((YakyuuName)listBoxRead.SelectedItem).Annotation;
        }

        /// <summary>
        /// 下のリストボックス郡をリセットする.
        /// それだけ.
        /// </summary>
        private void resetSelList()
        {
            listBoxRead.Items.Clear();
            listBoxReadV.Items.Clear();
            textBoxAnnotation.Text = "";
        }

        private void buttonSearchV_Click(object sender, EventArgs e)
        {
            //var str = textBoxToSerach.Text;

        }

        private void ToolStripMenuItemSettings_Click(object sender, EventArgs e)
        {
            var settingFm = new SettingDialog();
            settingFm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var str = textBoxLyrics.Text;

            var list = yakyuuNameDic.selectNameFromReadV(ConvertTextForYakyuu.convVowelString(str));
            foreach (YakyuuName y in list)
            {
                textBoxConverted.Text += "\r\n" + y.Name;
            }
        }

    }
}
