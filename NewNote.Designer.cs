namespace NoteApp
{
    partial class NewNote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNote = new TextBox();
            txtTitle = new TextBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // txtNote
            // 
            txtNote.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNote.Location = new Point(12, 73);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.PlaceholderText = "Note";
            txtNote.Size = new Size(547, 398);
            txtNote.TabIndex = 0;
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTitle.Location = new Point(12, 12);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Title";
            txtTitle.Size = new Size(547, 55);
            txtTitle.TabIndex = 1;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Bottom;
            btnSubmit.BackColor = Color.FromArgb(128, 255, 128);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnSubmit.Location = new Point(198, 477);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(184, 50);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // NewNote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(571, 539);
            Controls.Add(btnSubmit);
            Controls.Add(txtTitle);
            Controls.Add(txtNote);
            MinimumSize = new Size(589, 586);
            Name = "NewNote";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewNote";
            FormClosing += NewNote_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNote;
        private TextBox txtTitle;
        private Button btnSubmit;
    }
}