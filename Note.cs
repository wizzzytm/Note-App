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
    public partial class Note : Form
    {
        string noteTitle;
        string noteContent;
        string oldTitle;
        NoteApp AppInstance;
        public Note(string title, string note, NoteApp instance)
        {
            InitializeComponent();
            noteTitle = title;
            noteContent = note;
            lblTitle.Text = noteTitle;
            lblNote.Text = noteContent;
            oldTitle = title;
            AppInstance = instance;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            txtModifyNote.Text = noteContent;
            txtModifyTitle.Text = noteTitle;
            txtModifyTitle.Visible = true;
            txtModifyNote.Visible = true;
            ChangeEnabled();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DBAccess.ModifyNote(new NoteModel(txtModifyTitle.Text, txtModifyNote.Text), oldTitle);
            oldTitle = txtModifyTitle.Text;
            ChangeEnabled();
            AppInstance.RefreshNotes();

        }
        private void ChangeEnabled()
        {
            btnModify.Enabled = !btnModify.Enabled;
            btnSave.Enabled = !btnSave.Enabled;
        }
    }
}
