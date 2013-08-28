using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SP_BLL
{
    class MMM
    {
        public int index;
        public string ID;
        public string Classify;
        public double MakePrice;
        public double SellPrice;
        public string Unit;
        public string Memo;

        public MMM()
        { }
        public MMM(int _index, string _ID, string _Classify, double _MakePrice, double _SellPrice, string _Unit, string _Memo)
        {
            this.index = _index;
            this.ID = _ID;
            this.Classify = _Classify;
            this.MakePrice = _MakePrice;
            this.SellPrice = _SellPrice;
            this.Unit = _Unit;
            this.Memo = _Memo;
        }
    }
}
