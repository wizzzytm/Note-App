using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteApp
{
    public partial class NewNote : Form
    {
        NoteApp formInstance;
        public NewNote(NoteApp instance)
        {
            formInstance = instance;
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DBAccess.AddNote(new NoteModel(txtTitle.Text, txtNote.Text));
            txtTitle.Clear();
            txtNote.Clear();
            formInstance.RefreshNotes();
            formInstance.Show();
            this.Close();
        }

        private void NewNote_FormClosing(object sender, FormClosingEventArgs e)
        {
            formInstance.Show();
        }
    }
}
