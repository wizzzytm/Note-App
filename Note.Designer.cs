namespace NoteApp
{
    partial class Note
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
            lblTitle = new Label();
            lblNote = new Label();
            btnModify = new Button();
            btnSave = new Button();
            txtModifyNote = new TextBox();
            txtModifyTitle = new TextBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(658, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "label1";
            // 
            // lblNote
            // 
            lblNote.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNote.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblNote.Location = new Point(12, 50);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(658, 441);
            lblNote.TabIndex = 1;
            lblNote.Text = "label2";
            // 
            // btnModify
            // 
            btnModify.Anchor = AnchorStyles.Bottom;
            btnModify.BackColor = Color.FromArgb(128, 255, 255);
            btnModify.FlatStyle = FlatStyle.Flat;
            btnModify.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnModify.Location = new Point(166, 506);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(168, 55);
            btnModify.TabIndex = 3;
            btnModify.Text = "Modify";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.BackColor = Color.FromArgb(128, 255, 128);
            btnSave.Enabled = false;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnSave.Location = new Point(340, 506);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(168, 55);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtModifyNote
            // 
            txtModifyNote.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtModifyNote.Location = new Point(12, 53);
            txtModifyNote.Multiline = true;
            txtModifyNote.Name = "txtModifyNote";
            txtModifyNote.Size = new Size(658, 438);
            txtModifyNote.TabIndex = 5;
            txtModifyNote.Visible = false;
            // 
            // txtModifyTitle
            // 
            txtModifyTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtModifyTitle.Location = new Point(12, 6);
            txtModifyTitle.Multiline = true;
            txtModifyTitle.Name = "txtModifyTitle";
            txtModifyTitle.Size = new Size(658, 41);
            txtModifyTitle.TabIndex = 6;
            txtModifyTitle.Visible = false;
            // 
            // Note
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(682, 573);
            Controls.Add(txtModifyTitle);
            Controls.Add(txtModifyNote);
            Controls.Add(btnSave);
            Controls.Add(btnModify);
            Controls.Add(lblNote);
            Controls.Add(lblTitle);
            MinimumSize = new Size(700, 620);
            Name = "Note";
            Text = "Note";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblNote;
        private Button btnModify;
        private Button btnSave;
        private TextBox txtModifyNote;
        private TextBox txtModifyTitle;
    }
}