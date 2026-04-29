using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isKatmani
{
    public class Veriler : BaseClass
    {
        private string _data;

        public Veriler(int id,string data,DateTime cd):base(id,cd) {
            this._data = data;
        }
        public string Data { get {return this._data; } set {this._data=value; } }
    }
}
