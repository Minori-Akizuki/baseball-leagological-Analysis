using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic.FileIO;
using System.Data;
using System.Diagnostics;

namespace yakyuuuu
{
    /// <summary>
    /// 野球選手名を定義する為のクラス
    /// </summary>
    class YakyuuName
    {
        /// <summary>
        /// 名前
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// 読み
        /// </summary>
        public String NameRead { get; set; }

        /// <summary>
        /// 注釈
        /// </summary>
        public String Annotation { get; set; }

        /// <summary>
        /// 使用回数
        /// </summary>
        public int Used { get; set; }

        public override String ToString() { return Name; }
    }

    /// <summary>
    /// 野球選手名の読みを管理するためのクラス
    /// </summary>
    class YakyuuRead
    {
        public YakyuuRead(string read, string readV)
        {
            this.NameRead = read;
            this.NameReadV = readV;
        }
        /// <summary>
        /// 読み
        /// </summary>
        public String NameRead { get; set; }
        /// <summary>
        /// 読みの母音
        /// </summary>
        public String NameReadV { get; set; }
    }

    class YakyuuDic
    {
        public List<YakyuuName> NameTable;
        public List<YakyuuRead> ReadTable;

        public YakyuuDic(String filepath)
        {
            readDicFile(filepath);
        }

        /// <summary>
        /// 「名前, 名前読み, [注釈]」のフォーマットをした
        /// 外部CSVファイルから辞書を作成する
        /// </summary>
        /// <param name="filepath">DSVファイルのパス</param>
        private void readDicFile(String filepath)
        {

            TextFieldParser parser = new TextFieldParser(filepath);
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");

            NameTable = new List<YakyuuName>();
            while (!parser.EndOfData)
            {   // 名前, 名前読み, 注釈
                string[] csvRow = parser.ReadFields();
                YakyuuName dataRow = new YakyuuName();
                dataRow.Name = csvRow[0];
                dataRow.NameRead = csvRow[1];
                if (csvRow.Length >= 3)
                {
                    dataRow.Annotation = csvRow[2];
                }
                else
                {
                    dataRow.Annotation = "";
                }

                dataRow.Used = 0;

                NameTable.Add(dataRow);

                //Debug.WriteLine( "data Set:" + dataRow.Name + " " + dataRow.NameRead + " "+ dataRow.Annotation);

            }
            Debug.WriteLine("NameData : " + NameTable.Count + " lines" );
            ReadTable = new List<YakyuuRead>();

            var nameUnuqRead = from YakyuuName n in NameTable
                               group n by n.NameRead;
            foreach (var gr in nameUnuqRead)
            {
                String read = gr.Key;
                String readV = ConvertTextForYakyuu.convVowelString(read);
                YakyuuRead r = new YakyuuRead(read,readV);
                //Debug.WriteLine("Data set : " + r.NameRead + ":"+ r.NameReadV);
                ReadTable.Add(r);
            }
            Debug.WriteLine("ReadData : " + ReadTable.Count + " lines");
        }

        /// <summary>
        /// 読みの母音がマッチする名前の一覧を返します.
        /// </summary>
        /// <param name="readv">読みの母音</param>
        /// <returns>その母音がマッチする名前の読み</returns>
        public IEnumerable<YakyuuRead> selectReadV(string readv)
        {
            return from n in ReadTable
                   where n.NameReadV == readv
                   select n;
        }

        /// <summary>
        /// 読みから選手の一覧を返します.
        /// </summary>
        /// <param name="read">名前の読み</param>
        /// <returns>その読みを持つ選手一覧</returns>
        public IEnumerable<YakyuuName> selectName(string read)
        {
            return from n in NameTable
                   where n.NameRead == read
                   select n;
        }

        public IEnumerable<YakyuuName> selectNameFromReadV(string readV)
        {
            var ts = selectReadV(readV);

            List<YakyuuName> ynss = new List<YakyuuName>();

            foreach (YakyuuRead t in ts)
            {
                IEnumerable<YakyuuName> yns = selectName(t.NameRead);

                ynss = ynss.Concat(yns).ToList();
            }

            return ynss;
        }

    }
}
