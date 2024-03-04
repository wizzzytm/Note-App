namespace NoteApp
{
    partial class NoteApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            btnDelete = new Button();
            label1 = new Label();
            dgNotes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgNotes).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top;
            btnAdd.BackColor = Color.FromArgb(128, 255, 128);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnAdd.Location = new Point(12, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(370, 74);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add note";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top;
            btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnDelete.Location = new Point(400, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(370, 74);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete note";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(283, 524);
            label1.Name = "label1";
            label1.Size = new Size(204, 20);
            label1.TabIndex = 2;
            label1.Text = "(Double click to display note)";
            // 
            // dgNotes
            // 
            dgNotes.AllowUserToAddRows = false;
            dgNotes.AllowUserToDeleteRows = false;
            dgNotes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgNotes.Location = new Point(12, 92);
            dgNotes.Name = "dgNotes";
            dgNotes.ReadOnly = true;
            dgNotes.RowHeadersWidth = 51;
            dgNotes.Size = new Size(758, 429);
            dgNotes.TabIndex = 3;
            dgNotes.CellDoubleClick += dgNotes_CellDoubleClick;
            // 
            // NoteApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(782, 553);
            Controls.Add(dgNotes);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            MinimumSize = new Size(800, 600);
            Name = "NoteApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NoteApp";
            Shown += NoteApp_Shown;
            ((System.ComponentModel.ISupportInitialize)dgNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnDelete;
        private Label label1;
        private DataGridView dgNotes;
    }
}
