using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;
using FastMember;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NoteApp
{
    public class DBAccess
    {
        public static DataTable LoadNotes()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<NoteModel>("SELECT * FROM NotesTable", new DynamicParameters());
                DataTable table = new DataTable();
                using (var reader = ObjectReader.Create(output))
                {
                    table.Load(reader);
                }
                return table;
            }
        }

        public static void AddNote(NoteModel model)
        {
            using(IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO NotesTable(Title, Note) VALUES (@Title, @Note)", model);
            }
        }

        public static void ModifyNote(NoteModel model, string oldTitle)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE NotesTable SET Title = @Title, Note = @Note WHERE Title = @OldTitle", new { Title = model.Title, Note = model.Note, OldTitle = oldTitle });
            }
        }

        public static void DeleteNote(NoteModel model)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"DELETE FROM NotesTable WHERE Title = @Title AND Note = @Note", model);
            }
        }

        private static string LoadConnectionString(string id="Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
