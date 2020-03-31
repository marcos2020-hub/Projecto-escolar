namespace ControlEscolar
{
    partial class FormnNotas
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.MostrarNotas = new System.Windows.Forms.DataGridView();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.NotaText = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.DescripcionText = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.CursosText = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.TrimestreText = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.IDText = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MostrarNotas)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkOrange;
			this.label1.Location = new System.Drawing.Point(471, 11);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "NOTAS";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.MostrarNotas);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.NotaText);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.DescripcionText);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.CursosText);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.TrimestreText);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.IDText);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(72, 92);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1025, 485);
			this.panel1.TabIndex = 1;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(780, 453);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(70, 25);
			this.label7.TabIndex = 13;
			this.label7.Text = "label7";
			// 
			// MostrarNotas
			// 
			this.MostrarNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.MostrarNotas.Location = new System.Drawing.Point(28, 228);
			this.MostrarNotas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MostrarNotas.Name = "MostrarNotas";
			this.MostrarNotas.Size = new System.Drawing.Size(967, 222);
			this.MostrarNotas.TabIndex = 12;
			this.MostrarNotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MostrarNotas_CellContentClick);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(871, 134);
			this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 65);
			this.button2.TabIndex = 11;
			this.button2.Text = "ABRIR";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(727, 134);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 65);
			this.button1.TabIndex = 10;
			this.button1.Text = "BUSCAR";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// NotaText
			// 
			this.NotaText.BackColor = System.Drawing.Color.LimeGreen;
			this.NotaText.Location = new System.Drawing.Point(451, 174);
			this.NotaText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.NotaText.Name = "NotaText";
			this.NotaText.Size = new System.Drawing.Size(92, 22);
			this.NotaText.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(389, 177);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(51, 17);
			this.label6.TabIndex = 8;
			this.label6.Text = "NOTA:";
			// 
			// DescripcionText
			// 
			this.DescripcionText.BackColor = System.Drawing.Color.LimeGreen;
			this.DescripcionText.Location = new System.Drawing.Point(147, 170);
			this.DescripcionText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.DescripcionText.Name = "DescripcionText";
			this.DescripcionText.Size = new System.Drawing.Size(200, 22);
			this.DescripcionText.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(28, 174);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 17);
			this.label5.TabIndex = 6;
			this.label5.Text = "DESCRIPCION:";
			// 
			// CursosText
			// 
			this.CursosText.BackColor = System.Drawing.Color.LimeGreen;
			this.CursosText.Location = new System.Drawing.Point(720, 18);
			this.CursosText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.CursosText.Name = "CursosText";
			this.CursosText.Size = new System.Drawing.Size(201, 22);
			this.CursosText.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(613, 22);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 17);
			this.label4.TabIndex = 4;
			this.label4.Text = "CURSOS:";
			// 
			// TrimestreText
			// 
			this.TrimestreText.BackColor = System.Drawing.Color.LimeGreen;
			this.TrimestreText.Location = new System.Drawing.Point(357, 15);
			this.TrimestreText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.TrimestreText.Name = "TrimestreText";
			this.TrimestreText.Size = new System.Drawing.Size(201, 22);
			this.TrimestreText.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(251, 18);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "TRIMESTRE:";
			// 
			// IDText
			// 
			this.IDText.BackColor = System.Drawing.Color.LimeGreen;
			this.IDText.Location = new System.Drawing.Point(64, 15);
			this.IDText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.IDText.Name = "IDText";
			this.IDText.Size = new System.Drawing.Size(63, 22);
			this.IDText.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(28, 18);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(25, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "ID:";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(191, 604);
			this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(151, 60);
			this.button3.TabIndex = 2;
			this.button3.Text = "GUARDAR";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(441, 604);
			this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(151, 60);
			this.button4.TabIndex = 3;
			this.button4.Text = "ELIMINAR";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(661, 604);
			this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(151, 60);
			this.button6.TabIndex = 5;
			this.button6.Text = "LIMPIAR";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// FormnNotas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1143, 679);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FormnNotas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormnNotas";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.MostrarNotas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox CursosText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TrimestreText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IDText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView MostrarNotas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NotaText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DescripcionText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
    }
}