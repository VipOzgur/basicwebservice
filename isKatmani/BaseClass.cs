using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isKatmani
{
    public class BaseClass
    {
        private int _Id;
        private DateTime _CreateDate;

        public BaseClass(int id,DateTime cd) {
        this._Id = id;
        this._CreateDate = cd;
        }  
        public int Id { get { return _Id; } set { this._Id = value; } }
        public DateTime CreateDate { get {return _CreateDate; }set { this._CreateDate = value; } }
    }
}
