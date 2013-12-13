using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace yakyuuuu
{
    /// <summary>
    /// やきうめいたいそかいせきをし, 文字列をトークン列として管理するクラス.
    /// </summary>
    class LatticedString
    {

        YakyuuTokens[] tokens;
        String baseString;

        public YakyuuTokens[] Tokens { get { return tokens; } }
        public String BaseString { get { return baseString;} }


        /// <summary>
        /// 文字列からラティス構造を生成する.
        /// </summary>
        /// <param name="str">対象文字列</param>
        /// <param name="dic">野球選手名辞書オブジェクト</param>
        public LatticedString(String str, YakyuuDic dic)
        {
            tokens = new YakyuuTokens[str.Length];
            baseString = str;
            makeLattice(tokens, str, dic, 0);
        }

        /// <summary>
        /// 文字列からマッチする母音のラティス構造を生成します.
        /// </summary>
        /// <param name="tokens">文字列と同じ長さを持った空の配列</param>
        /// <param name="str">対象文字列</param>
        /// <param name="dic">野球名辞書データ</param>
        /// <param name="index">最初に呼び出す時はゼロ</param>
        private void makeLattice(YakyuuTokens[] tokens,String str,YakyuuDic dic, int index)
        {
            string _str = "";
            int length = str.Length;

            tokens[index] = new YakyuuTokens();

            for (int i = 1; index+i <= length  ; i++)
            {
                // 文字を1文字読みこむ
                _str += str[index + i -1];

                // 該当の母音が存在するかを探す
                var readv = dic.selectReadV(_str);

                if (readv.Count() != 0)
                {
                    // 末尾まで探索が終了したらそれを辞書に追加する
                    if (index + i == length)
                    {
                        Debug.WriteLine("find token " + _str);
                        tokens[index].token.Add(_str, null);
                        return;
                    }

                    // もし一つでも存在し, かつその先の探索が行なわれてなければ
                    // そこから再帰的に探索をする.
                    if (tokens[index + i] == null)
                    {
                        makeLattice(tokens, str, dic, index + i);
                    }

                    // その先からの探索が成功していれば
                    // 単語の追加を行う.
                    if (tokens[index + i].token.Count != 0)
                    {
                        Debug.WriteLine("find token " + _str);
                        tokens[index].token.Add(_str, tokens[index + i]);
                    }
                }

            }
        }

        /// <summary>
        /// ラティス構造からリストリストを作成して返す
        /// </summary>
        /// <returns>最初から最後まで読める全てのトークン列</returns>
        public List<List<string>> unfoldLattice()
        {
            return _unfoldLattice(tokens[0]);
        }

        /// <summary>
        /// unfoldLatticeから呼びだされる再帰関数
        /// </summary>
        /// <param name="yakyuuTokens">探索を初める位置</param>
        /// <returns></returns>
        private List<List<string>> _unfoldLattice(YakyuuTokens yakyuuTokens)
        {
            var _llist = new List<List<String>>();
            var _list = new List<String>();

            if (yakyuuTokens == null)
            {
                _list.Add("[end]");
                _llist.Add(_list);
                return _llist;
            }

            foreach (var n in yakyuuTokens.token)
            {
                _llist = _llist.Union(
                            _unfoldLattice(n.Value)
                            .Select<List<String>,List<String>>(
                                (s => insertRet(s,n.Key))
                             )
                         ).ToList();
            }

            return _llist;
        }

        List<String> insertRet(List<String> l,String s)
        {
            l.Insert(0, s);
            return l;
        }

        /// <summary>
        /// 最初から最後まで読める全てのパターンを文字列として出力する
        /// </summary>
        /// <param name="sep">トークンの間に挟む文字列</param>
        /// <returns></returns>
        public List<String> unfoldLatticeToString(String sep = "/")
        {
            var llist = unfoldLattice();
            var list = new List<String>();

            foreach (var _li in llist)
            {
                var str = _li.Aggregate((s, t) => s + sep + t);
                list.Add(str);
            }

            return list;
        }

        /// <summary>
        /// とりあえず元の文字列を返す
        /// </summary>
        /// <returns>解析元の文字列</returns>
        public String toString(){
            return baseString;
        }

        public List<String> allTokens()
        {
            var ans = new List<String>();

            foreach (var tok in tokens)
            {
                if (tok != null)
                {
                    foreach (var str in tok.token)
                    {
                        ans.Add(str.Key);
                    }
                }
            }

            return ans;
        }
    }

    class YakyuuTokens
    {
        public Dictionary<String, YakyuuTokens> token;
        
        public YakyuuTokens()
        {
            token = new Dictionary<string, YakyuuTokens>();
        }
    }
}
