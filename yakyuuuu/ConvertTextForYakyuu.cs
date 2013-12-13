using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Data;
using System.Linq;

namespace yakyuuuu
{
    /// <summary>
    /// テキストを野球選手名に変換する為のメソッド郡を定義する為のクラスです.
    /// </summary>
    class ConvertTextForYakyuu
    {
        private string lyricsBase;
        private StringWriter lyricsVowel;
        StringWriter LyricsYakyuu { set; get; }
        static readonly char[] SmallChars = { 
                                                'ぁ','ぃ','ぅ','ぇ','ぉ','ゃ','ゅ','ょ',
                                            'ァ','ィ','ゥ','ェ','ォ','ャ','ュ','ョ'};
        static readonly char[] SkipChars = { 'っ', 'ッ', 'ー' /*, 'ン', 'ん' */};

        public ConvertTextForYakyuu(string _lyrics)
        {
            lyricsBase = _lyrics;
            Debug.WriteLine(_lyrics);
            lyricsVowel = new StringWriter();
            LyricsYakyuu = new StringWriter();

            StringReader lyR = new StringReader(lyricsBase);
            
            string st=lyR.ReadLine();

            while (st!=null)
            {
                Debug.WriteLine(st);
                lyricsVowel.WriteLine(convVowelString(st));
                st = lyR.ReadLine();
            }

            Debug.WriteLine(lyricsVowel.ToString());
        }

        static public string convVowelString(string _lyrics)
        {
            int c, d;
            StringWriter lyYakyuuLine = new StringWriter();
            StringReader lyLine = new StringReader(_lyrics);
            d = (char) lyLine.Read();

            while (d>=0)
            {
                if (!SkipChars.Any(((char)d).Equals))
                {
                    c = lyLine.Peek();
                    if (!SmallChars.Any(((char)c).Equals))
                    {
                        lyYakyuuLine.Write(convVowelChar((char)d));
                    }
                }
                d = lyLine.Read();   
            }
            return lyYakyuuLine.ToString();
        }

        /// <summary>
        /// 平仮名を母音に変換する関数.
        /// マッチしなかったらそのまま返ってくる.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        static public char convVowelChar(char c)
        {
            switch (c)
            {
                case 'あ': case 'ぁ':
                case 'か': case 'が':
                case 'さ': case 'ざ':
                case 'た': case 'だ':
                case 'な':
                case 'は': case 'ば': case 'ぱ':
                case 'ま': 
                case 'や': case 'ゃ':
                case 'ら':
                case 'わ': case 'ゎ':
                case 'ア':
                case 'ァ':
                case 'カ':
                case 'ガ':
                case 'サ':
                case 'ザ':
                case 'タ':
                case 'ダ':
                case 'ナ':
                case 'ハ':
                case 'バ':
                case 'パ':
                case 'マ':
                case 'ヤ':
                case 'ャ':
                case 'ラ':
                case 'ワ':
                case 'ヮ':
                    return 'あ';
                case 'い': case 'ぃ':
                case 'き': case 'ぎ':
                case 'し': case 'じ':
                case 'ち': case 'ぢ':
                case 'に':
                case 'ひ': case 'び': case 'ぴ':
                case 'み':
                case 'り':
                case 'イ':
                case 'ィ':
                case 'キ':
                case 'ギ':
                case 'シ':
                case 'ジ':
                case 'チ':
                case 'ヂ':
                case 'ニ':
                case 'ヒ':
                case 'ビ':
                case 'ピ':
                case 'ミ':
                case 'リ':
                    return 'い';
                case 'う':
                case 'く': case 'ぐ':
                case 'す': case 'ず':
                case 'つ': case 'づ':
                case 'ぬ':
                case 'ふ': case 'ぶ': case 'ぷ':
                case 'む': 
                case 'ゆ': case 'ゅ': 
                case 'る':
                case 'ぅ':
                case 'ウ':
                case 'ク':
                case 'グ':
                case 'ス':
                case 'ズ':
                case 'ツ':
                case 'ヅ':
                case 'ヌ':
                case 'フ':
                case 'ブ':
                case 'プ':
                case 'ム':
                case 'ユ':
                case 'ュ':
                case 'ル':
                case 'ゥ':
                    return 'う';
                case 'え':
                case 'け': case 'げ':
                case 'せ': case 'ぜ':
                case 'て': case 'で':
                case 'ね':
                case 'へ': case 'べ': case 'ぺ':
                case 'め':
                case 'れ':
                case 'ぇ':
                case 'エ':
                case 'ケ':
                case 'ゲ':
                case 'セ':
                case 'ゼ':
                case 'テ':
                case 'デ':
                case 'ネ':
                case 'ヘ':
                case 'ベ':
                case 'ペ':
                case 'メ':
                case 'レ':
                case 'ェ':
                    return 'え';
                case 'お':
                case 'こ': case 'ご':
                case 'そ': case 'ぞ':
                case 'と': case 'ど':
                case 'の':
                case 'ほ': case 'ぼ': case 'ぽ':
                case 'も':
                case 'よ': case 'ょ':
                case 'ろ':
                case 'ぉ':
                case 'オ':
                case 'コ':
                case 'ゴ':
                case 'ソ':
                case 'ゾ':
                case 'ト':
                case 'ド':
                case 'ノ':
                case 'ホ':
                case 'ボ':
                case 'ポ':
                case 'モ':
                case 'ヨ':
                case 'ョ':
                case 'ロ':
                case 'ォ':
                    return 'お';
                case 'ん':
                case 'ン':
                    return 'ん';
                default:
                    return c;
            }
        }

        /// <summary>
        /// 歌詞を野球選手名の読みのトークン列に変換する関数
        /// </summary>
        /// <param name="dic"></param>
        /// <returns></returns>
        public String convertLyricYakyuu(YakyuuDic dic)
        {
            LyricsYakyuu.Flush();
            StringReader lybRd = new StringReader(lyricsVowel.ToString());
            String lyb;
            StringWriter buf = new StringWriter();
            StringWriter bufY = new StringWriter();
            var dt = dic.ReadTable;

            {
                foreach(var r in dt)
                {
                    Debug.WriteLine(r.NameReadV);
                }
            }

            lyb = lybRd.ReadLine();

            while (lyb != null)
            {
                foreach (Char c in lyb)
                {
                    buf.Write(c); //バッファに文字を1文字追加

                    var _buf = buf.ToString();

                    if (_buf.Length >= 2)
                    {

                        // 完全一致の検索
                        var rows = from r in dt
                                   where r.NameReadV == _buf
                                   select r;

                        if (rows.Count() != 0) // 一致する物があった場合
                        {
                            // その選手名をバッファに書きこむ
                            bufY.Write(rows.ElementAt(0).NameRead);
                            bufY.Write("/");
                            Debug.WriteLine(_buf + ":" + rows.ElementAt(0).NameRead);
                            buf = new StringWriter();
                        }
                        else
                        {
                            // 前方一致の検索
                            var rowsp = from r in dt
                                        where _buf.StartsWith(r.NameReadV)
                                        select r;
                            //var rowsp = dt.Select("readV like \'" + buf.ToString() + "%\'");
                            if (rowsp.Count() == 0 && _buf.Length > 2)
                            {   // 前方一致も無かった場合は
                                var length = _buf.Length;
                                string _lyb = _buf.Substring(0,length-1);
                                // 1文字だけ消してみる
                                var aimai = from r in dt
                                            where r.NameReadV.Length == length && r.NameReadV.Substring(0, length - 1) == _lyb
                                            select r;
                                //var q = "readV like \'" + _lyb.Substring(0, _lyb.Length - 1) + "%\'";
                                //var aimai = dt.Select(q);
                                if (aimai.Count() == 0) // やっぱりヒットしなかったら
                                {
                                    //バッファの内容をそのまま書きこむ
                                    bufY.Write("(" + _buf + ")");
                                }
                                else
                                {
                                    // ヒットしたらそれを入れる
                                    bufY.Write("[" + aimai.ElementAt(0).NameRead + "]/");
                                    Debug.WriteLine(_buf+":"+aimai.ElementAt(0).NameRead);
                                }
                                buf = new StringWriter();
                            }
                        }
                    }
                }
                // 行を全て読んでしまったらバッファを書きこむ
                bufY.Write(buf.ToString());
                buf = new StringWriter();

                // 選手名バッファの内容を変換後歌詞に書きこむ
                LyricsYakyuu.WriteLine(bufY.ToString());
                bufY = new StringWriter();

                // もう一行読みこむ
                lyb = lybRd.ReadLine();
            }

            return LyricsYakyuu.ToString();
        }
    }
}
