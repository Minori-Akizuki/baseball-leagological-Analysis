using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace yakyuuuu
{
    public class RawConvertSettings
    {

        /// <summary>
        /// 「ん」を読みとばすかどうかを設定, 又は取得します.
        /// </summary>
        public Boolean SkipN { get; set; }

        public RawConvertSettings()
        {
            SkipN = true;
        }
    }
}
