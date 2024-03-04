using System.Data;
using System.Windows.Forms;

namespace NoteApp
{
    public partial class NoteApp : Form
    {
        public DataTable NotesDataTable = new DataTable();
        public NoteApp()
        {
            InitializeComponent();
            NotesDataTable.Columns.Add("Title");
            NotesDataTable.Columns.Add("Note");
            dgNotes.DataSource = NotesDataTable;
            RefreshNotes();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewNote newNote = new NewNote(this);
            newNote.Show();
            this.Hide();

        }

        public void RefreshNotes()
        {
            NotesDataTable = DBAccess.LoadNotes();
            dgNotes.DataSource = NotesDataTable;

        }

        private void dgNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgNotes.Rows.Count != 0)
            {
                // Access data using actual column names in DataTable
                string title = NotesDataTable.Rows[e.RowIndex]["Title"].ToString();
                string note = NotesDataTable.Rows[e.RowIndex]["Note"].ToString();

                Note noteForm = new Note(title, note, this);
                noteForm.Show();
            }
            else
            {
                dgNotes.CurrentCell = null;
                MessageBox.Show("No notes!");
            }
        }

        private void NoteApp_Shown(object sender, EventArgs e)
        {
            RefreshNotes();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgNotes.CurrentCell != null)
            {
                DialogResult dg = MessageBox.Show("Are you sure you want to delete this note?", "delete", MessageBoxButtons.YesNo);
                if (dg == DialogResult.Yes)
                {
                    try
                    {
                        string title = dgNotes.CurrentRow.Cells["Title"].Value.ToString();
                        string note = dgNotes.CurrentRow.Cells["Note"].Value.ToString();
                        DBAccess.DeleteNote(new NoteModel(title, note));
                        RefreshNotes();
                    }
                    catch (Exception) { MessageBox.Show("An error occurred while deleting the note."); }
                }
            }
            else
            {
                MessageBox.Show("No note selected!");
            }
        }

    }

}
