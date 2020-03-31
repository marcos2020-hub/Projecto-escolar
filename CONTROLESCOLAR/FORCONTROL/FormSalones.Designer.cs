namespace ControlEscolar
{
    partial class FormSalones
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
            this.GradosCombox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Ocupadastxt = new System.Windows.Forms.TextBox();
            this.Totaltxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Mostrar = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(348, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "AULAS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GradosCombox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Ocupadastxt);
            this.panel1.Controls.Add(this.Totaltxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(116, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 113);
            this.panel1.TabIndex = 1;
            // 
            // GradosCombox
            // 
            this.GradosCombox.BackColor = System.Drawing.Color.Lime;
            this.GradosCombox.FormattingEnabled = true;
            this.GradosCombox.Location = new System.Drawing.Point(51, 9);
            this.GradosCombox.Name = "GradosCombox";
            this.GradosCombox.Size = new System.Drawing.Size(57, 21);
            this.GradosCombox.TabIndex = 5;
            this.GradosCombox.SelectedIndexChanged += new System.EventHandler(this.GradosCombox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "TOTAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "OCUPADAS";
            // 
            // Ocupadastxt
            // 
            this.Ocupadastxt.BackColor = System.Drawing.Color.Lime;
            this.Ocupadastxt.Location = new System.Drawing.Point(387, 62);
            this.Ocupadastxt.Name = "Ocupadastxt";
            this.Ocupadastxt.Size = new System.Drawing.Size(105, 20);
            this.Ocupadastxt.TabIndex = 2;
            // 
            // Totaltxt
            // 
            this.Totaltxt.BackColor = System.Drawing.Color.Lime;
            this.Totaltxt.Location = new System.Drawing.Point(195, 62);
            this.Totaltxt.Name = "Totaltxt";
            this.Totaltxt.Size = new System.Drawing.Size(100, 20);
            this.Totaltxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "GRADO";
            // 
            // Mostrar
            // 
            this.Mostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Mostrar.Location = new System.Drawing.Point(12, 263);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(776, 252);
            this.Mostrar.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(539, 518);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "label5";
            // 
            // FormSalones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Mostrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FormSalones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSalones";
            this.Load += new System.EventHandler(this.FormSalones_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox GradosCombox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Ocupadastxt;
        private System.Windows.Forms.TextBox Totaltxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Mostrar;
        private System.Windows.Forms.Label label5;
    }
}