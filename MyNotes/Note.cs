using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotes
{
    abstract class Note
    {
        private int _id;
        public int Id
        {
            get { return this._id; }
        }

        private string _text;
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        public Note()
        {
            this._id = -1;
            this._text = "";
        }        

    }
}
