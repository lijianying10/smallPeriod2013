using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SP_BLL
{
    public class PersionAttention
    {
        public int  index;
        public string ID;
        public string Tel;
        public string Mobile;
        public string PoliStatus;
        public string Hometown;
        public string Address;
        public string Memo;

        public PersionAttention() { }
        public PersionAttention(int _index, string _ID, string _Tel, string _Mobile, string _PoliStatus, string _Hometown, string _Address, string _Memo)
        {
            this.index = _index;
            this.ID = _ID;
            this.Tel = _Tel;
            this.Mobile = _Mobile;
            this.PoliStatus = _PoliStatus;
            this.Hometown = _Hometown;
            this.Address = _Address;
            this.Memo = _Memo;
        }
    }
}
