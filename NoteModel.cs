using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    public class NoteModel
    {
        public string Title {  get; set; }
        public string Note { get; set; }

        public NoteModel()
        {
            
        }
        public NoteModel(string nt, string nd)
        {
            Title = nt;
            Note = nd;
        }
 
    }
}
