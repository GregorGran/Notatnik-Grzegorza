namespace Notatnik_Grzegorza
{
    partial class Form1
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
            Nowytekst = new Button();
            Usun = new Button();
            dateTimePicker1 = new DateTimePicker();
            zapisz = new Button();
            Edytuj = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            Notatka1 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Nowytekst
            // 
            Nowytekst.BackColor = SystemColors.Highlight;
            Nowytekst.Location = new Point(12, 12);
            Nowytekst.Name = "Nowytekst";
            Nowytekst.Size = new Size(195, 34);
            Nowytekst.TabIndex = 0;
            Nowytekst.Text = "Stwórz nową notatkę";
            Nowytekst.UseVisualStyleBackColor = false;
            Nowytekst.Click += Nowytekst_Click;
            // 
            // Usun
            // 
            Usun.BackColor = Color.IndianRed;
            Usun.Location = new Point(12, 65);
            Usun.Name = "Usun";
            Usun.Size = new Size(195, 34);
            Usun.TabIndex = 1;
            Usun.Text = "Usuń notatkę";
            Usun.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.SkyBlue;
            dateTimePicker1.Location = new Point(12, 126);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(346, 31);
            dateTimePicker1.TabIndex = 2;
            // 
            // zapisz
            // 
            zapisz.Location = new Point(246, 12);
            zapisz.Name = "zapisz";
            zapisz.Size = new Size(112, 34);
            zapisz.TabIndex = 3;
            zapisz.Text = "zapisz";
            zapisz.UseVisualStyleBackColor = true;
            // 
            // Edytuj
            // 
            Edytuj.Location = new Point(246, 65);
            Edytuj.Name = "Edytuj";
            Edytuj.Size = new Size(112, 34);
            Edytuj.TabIndex = 4;
            Edytuj.Text = "Edytuj";
            Edytuj.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(404, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(626, 145);
            textBox1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Notatka1 });
            dataGridView1.Location = new Point(12, 203);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1018, 527);
            dataGridView1.TabIndex = 6;
            // 
            // Notatka1
            // 
            Notatka1.HeaderText = "Notatka1";
            Notatka1.MinimumWidth = 8;
            Notatka1.Name = "Notatka1";
            Notatka1.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1042, 742);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(Edytuj);
            Controls.Add(zapisz);
            Controls.Add(dateTimePicker1);
            Controls.Add(Usun);
            Controls.Add(Nowytekst);
            Name = "Form1";
            Text = "Notatnik";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Nowytekst;
        private Button Usun;
        private DateTimePicker dateTimePicker1;
        private Button zapisz;
        private Button Edytuj;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Notatka1;
    }
}
