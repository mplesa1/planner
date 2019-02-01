namespace planner
{
    partial class AddNote
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.dateTimePickerNote = new System.Windows.Forms.DateTimePicker();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSubmitNote = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Obaveza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum i vrijeme";
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(234, 81);
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(200, 22);
            this.textBoxNote.TabIndex = 2;
            // 
            // dateTimePickerNote
            // 
            this.dateTimePickerNote.Location = new System.Drawing.Point(234, 150);
            this.dateTimePickerNote.Name = "dateTimePickerNote";
            this.dateTimePickerNote.Size = new System.Drawing.Size(288, 22);
            this.dateTimePickerNote.TabIndex = 3;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(93, 230);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(115, 37);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Odustani";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSubmitNote
            // 
            this.buttonSubmitNote.Location = new System.Drawing.Point(336, 230);
            this.buttonSubmitNote.Name = "buttonSubmitNote";
            this.buttonSubmitNote.Size = new System.Drawing.Size(174, 37);
            this.buttonSubmitNote.TabIndex = 5;
            this.buttonSubmitNote.Text = "Dodaj/Izmjeni";
            this.buttonSubmitNote.UseVisualStyleBackColor = true;
            this.buttonSubmitNote.Click += new System.EventHandler(this.submitNote_click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDelete.Location = new System.Drawing.Point(186, 311);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(150, 40);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Izbriši obavezu";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // AddNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 399);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSubmitNote);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.dateTimePickerNote);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNote";
            this.Text = "AddNote";
            this.Load += new System.EventHandler(this.AddNote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        //private planner_csharpDataSet planner_csharpDataSet1;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.DateTimePicker dateTimePickerNote;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSubmitNote;
        private System.Windows.Forms.Button buttonDelete;
    }
}