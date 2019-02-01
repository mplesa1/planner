namespace planner
{
    partial class Main
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
            this.buttonAddNote = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.dataGridViewNotes = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddNote
            // 
            this.buttonAddNote.Location = new System.Drawing.Point(40, 396);
            this.buttonAddNote.Name = "buttonAddNote";
            this.buttonAddNote.Size = new System.Drawing.Size(112, 48);
            this.buttonAddNote.TabIndex = 2;
            this.buttonAddNote.Text = "Dodaj zapis";
            this.buttonAddNote.UseVisualStyleBackColor = true;
            this.buttonAddNote.Click += new System.EventHandler(this.buttonAddNote_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(238, 396);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(129, 48);
            this.buttonLogOut.TabIndex = 3;
            this.buttonLogOut.Text = "Odjava";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // dataGridViewNotes
            // 
            this.dataGridViewNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotes.Location = new System.Drawing.Point(465, 25);
            this.dataGridViewNotes.Name = "dataGridViewNotes";
            this.dataGridViewNotes.Size = new System.Drawing.Size(828, 282);
            this.dataGridViewNotes.TabIndex = 4;
            this.dataGridViewNotes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::planner.Properties.Resources.logo;
            this.pictureBox2.InitialImage = global::planner.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(26, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(433, 368);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kliknite na note ili date ako želite obrisati/urediti obavezu.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 769);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridViewNotes);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonAddNote);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddNote;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.DataGridView dataGridViewNotes;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}