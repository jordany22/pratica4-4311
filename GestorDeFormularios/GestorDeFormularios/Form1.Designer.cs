namespace GestorDeFormularios
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            menuStrip1 = new MenuStrip();
            registroDePersonaToolStripMenuItem = new ToolStripMenuItem();
            conversorDeDivisasToolStripMenuItem = new ToolStripMenuItem();
            cálculoDeImpuestosToolStripMenuItem = new ToolStripMenuItem();
            generadorDeLaSerieFibonacciToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { registroDePersonaToolStripMenuItem, conversorDeDivisasToolStripMenuItem, cálculoDeImpuestosToolStripMenuItem, generadorDeLaSerieFibonacciToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // registroDePersonaToolStripMenuItem
            // 
            registroDePersonaToolStripMenuItem.Name = "registroDePersonaToolStripMenuItem";
            registroDePersonaToolStripMenuItem.Size = new Size(123, 20);
            registroDePersonaToolStripMenuItem.Text = "Registro de persona";
            registroDePersonaToolStripMenuItem.Click += registroDePersonaToolStripMenuItem_Click;
            // 
            // conversorDeDivisasToolStripMenuItem
            // 
            conversorDeDivisasToolStripMenuItem.Name = "conversorDeDivisasToolStripMenuItem";
            conversorDeDivisasToolStripMenuItem.Size = new Size(128, 20);
            conversorDeDivisasToolStripMenuItem.Text = "Conversor de Divisas";
            conversorDeDivisasToolStripMenuItem.Click += conversorDeDivisasToolStripMenuItem_Click;
            // 
            // cálculoDeImpuestosToolStripMenuItem
            // 
            cálculoDeImpuestosToolStripMenuItem.Name = "cálculoDeImpuestosToolStripMenuItem";
            cálculoDeImpuestosToolStripMenuItem.Size = new Size(133, 20);
            cálculoDeImpuestosToolStripMenuItem.Text = "Cálculo de Impuestos";
            cálculoDeImpuestosToolStripMenuItem.Click += cálculoDeImpuestosToolStripMenuItem_Click;
            // 
            // generadorDeLaSerieFibonacciToolStripMenuItem
            // 
            generadorDeLaSerieFibonacciToolStripMenuItem.Name = "generadorDeLaSerieFibonacciToolStripMenuItem";
            generadorDeLaSerieFibonacciToolStripMenuItem.Size = new Size(184, 20);
            generadorDeLaSerieFibonacciToolStripMenuItem.Text = "Generador de la Serie Fibonacci";
            generadorDeLaSerieFibonacciToolStripMenuItem.Click += generadorDeLaSerieFibonacciToolStripMenuItem_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "frmPrincipal";
            Text = "Gestor De Formularios";
            Load += frmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem registroDePersonaToolStripMenuItem;
        private ToolStripMenuItem conversorDeDivisasToolStripMenuItem;
        private ToolStripMenuItem cálculoDeImpuestosToolStripMenuItem;
        private ToolStripMenuItem generadorDeLaSerieFibonacciToolStripMenuItem;
    }
}
