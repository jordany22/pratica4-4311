namespace GestorDeFormularios
{
    partial class Fibonacci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fibonacci));
            txtLimite = new TextBox();
            btnGenerar = new Button();
            txtResultado = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // txtLimite
            // 
            txtLimite.Location = new Point(114, 156);
            txtLimite.Margin = new Padding(2);
            txtLimite.Name = "txtLimite";
            txtLimite.Size = new Size(217, 23);
            txtLimite.TabIndex = 0;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.Cyan;
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerar.ForeColor = Color.Black;
            btnGenerar.Location = new Point(171, 218);
            btnGenerar.Margin = new Padding(2);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(135, 39);
            btnGenerar.TabIndex = 1;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // txtResultado
            // 
            txtResultado.BackColor = Color.White;
            txtResultado.Font = new Font("Arial Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResultado.ForeColor = Color.DarkBlue;
            txtResultado.Location = new Point(100, 284);
            txtResultado.Margin = new Padding(2);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.ScrollBars = ScrollBars.Vertical;
            txtResultado.Size = new Size(488, 85);
            txtResultado.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 11F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(114, 127);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(211, 22);
            label1.TabIndex = 3;
            label1.Text = "Numero limite a generar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(116, 36);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(414, 31);
            label2.TabIndex = 4;
            label2.Text = "Generador De La Serie Fibonacci";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DeepSkyBlue;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.Black;
            btnLimpiar.Location = new Point(349, 218);
            btnLimpiar.Margin = new Padding(2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(135, 39);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Fibonacci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(720, 399);
            Controls.Add(btnLimpiar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtResultado);
            Controls.Add(btnGenerar);
            Controls.Add(txtLimite);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Fibonacci";
            Text = "Fibonacci";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLimite;
        private Button btnGenerar;
        private TextBox txtResultado;
        private Label label1;
        private Label label2;
        private Button btnLimpiar;
    }
}