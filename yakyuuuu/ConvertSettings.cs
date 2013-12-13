using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace yakyuuuu
{
    /// <summary>
    /// 変換の為の設定を管理する為のクラスです
    /// </summary>
    public class ConvertSettings
    {

        static readonly String PROP_FILE = "settings.prop";

        public Boolean SkipN;

        /// <summary>
        /// 現在の設定を取得または設定します.
        /// </summary>
        public RawConvertSettings CURRENT_SETTING
        {
            get { return cur_set; }
            set {  cur_set = value; }
        }
        /// <summary>
        /// 現在の設定を保存しておく変数です
        /// </summary>
        private static RawConvertSettings cur_set=null;

        public ConvertSettings()
        {
            if (cur_set == null)
            {
                FileStream fs;
                XmlSerializer ser = new XmlSerializer(typeof(ConvertSettings));
                // 設定ファイルを読みこもうとする
                try
                {
                    fs = new FileStream(PROP_FILE, FileMode.Open);
                    // あったらそれを現在設定にしようとする
                    cur_set = (RawConvertSettings)ser.Deserialize(fs);
                    fs.Close();
                }
                catch(FileNotFoundException e)
                {
                    // 無かったらとりあえずコレを現在の設定にして
                    // 項目を適当にイニシャライズする
                    cur_set = new RawConvertSettings();

                    cur_set.SkipN = true;

                    fs = new FileStream(PROP_FILE, FileMode.Create);
                    ser.Serialize(fs, cur_set);

                    return;
                }


            }

        }
    }
}
