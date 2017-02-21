using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ini2Flame
{
    public class DBHeaderObj
    {
        public string stFile;
        public string stSection;
        public bool blSelect;

        public DBHeaderObj(string astFile,
                           string astSection,
                           bool ablSelect)
        {
            stFile = astFile;
            stSection = astSection;
            blSelect = ablSelect;
        }
    }
}
