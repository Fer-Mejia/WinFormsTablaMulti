namespace WinFormsTablaMulti
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
            panelprincipal = new Panel();
            richTextBoxResultados = new RichTextBox();
            buttonver = new Button();
            textBoxnum = new TextBox();
            labelnumero = new Label();
            labeltitulo = new Label();
            panelprincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelprincipal
            // 
            panelprincipal.BackColor = Color.FromArgb(255, 192, 192);
            panelprincipal.Controls.Add(richTextBoxResultados);
            panelprincipal.Controls.Add(buttonver);
            panelprincipal.Controls.Add(textBoxnum);
            panelprincipal.Controls.Add(labelnumero);
            panelprincipal.Controls.Add(labeltitulo);
            panelprincipal.Location = new Point(0, 0);
            panelprincipal.Name = "panelprincipal";
            panelprincipal.Size = new Size(798, 448);
            panelprincipal.TabIndex = 0;
            // 
            // richTextBoxResultados
            // 
            richTextBoxResultados.BackColor = Color.FromArgb(224, 224, 224);
            richTextBoxResultados.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxResultados.Location = new Point(297, 91);
            richTextBoxResultados.Name = "richTextBoxResultados";
            richTextBoxResultados.Size = new Size(93, 141);
            richTextBoxResultados.TabIndex = 4;
            richTextBoxResultados.Text = "";
            // 
            // buttonver
            // 
            buttonver.BackColor = Color.Silver;
            buttonver.Location = new Point(112, 175);
            buttonver.Name = "buttonver";
            buttonver.Size = new Size(75, 23);
            buttonver.TabIndex = 3;
            buttonver.Text = "Ver tabla";
            buttonver.UseVisualStyleBackColor = false;
            buttonver.Click += buttonver_Click;
            // 
            // textBoxnum
            // 
            textBoxnum.Location = new Point(107, 129);
            textBoxnum.Name = "textBoxnum";
            textBoxnum.Size = new Size(100, 23);
            textBoxnum.TabIndex = 2;
            // 
            // labelnumero
            // 
            labelnumero.AutoSize = true;
            labelnumero.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelnumero.Location = new Point(105, 91);
            labelnumero.Name = "labelnumero";
            labelnumero.Size = new Size(134, 20);
            labelnumero.TabIndex = 1;
            labelnumero.Text = "¿Cuál tabla quieres?";
            labelnumero.UseMnemonic = false;
            // 
            // labeltitulo
            // 
            labeltitulo.AutoSize = true;
            labeltitulo.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltitulo.Location = new Point(105, 51);
            labeltitulo.Name = "labeltitulo";
            labeltitulo.Size = new Size(152, 21);
            labeltitulo.TabIndex = 0;
            labeltitulo.Text = "Tabla de Multiplicar";
            labeltitulo.Click += labeltitulo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelprincipal);
            Name = "Form1";
            Text = "Form1";
            panelprincipal.ResumeLayout(false);
            panelprincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelprincipal;
        private Label labelnumero;
        private Label labeltitulo;
        private Button buttonver;
        private TextBox textBoxnum;
        private RichTextBox richTextBoxResultados;
    }
}
