namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ball = new System.Windows.Forms.Label();
            this.j1 = new System.Windows.Forms.Label();
            this.j2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.AutoSize = true;
            this.ball.Font = new System.Drawing.Font("Goudy Stout", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ball.ForeColor = System.Drawing.Color.LimeGreen;
            this.ball.Location = new System.Drawing.Point(465, 223);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(46, 32);
            this.ball.TabIndex = 0;
            this.ball.Text = "O";
            this.ball.Click += new System.EventHandler(this.label1_Click);
            // 
            // j1
            // 
            this.j1.AutoSize = true;
            this.j1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.j1.ForeColor = System.Drawing.Color.Maroon;
            this.j1.Location = new System.Drawing.Point(12, 183);
            this.j1.Name = "j1";
            this.j1.Size = new System.Drawing.Size(71, 108);
            this.j1.TabIndex = 1;
            this.j1.Text = "|";
            // 
            // j2
            // 
            this.j2.AutoSize = true;
            this.j2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.j2.ForeColor = System.Drawing.Color.Blue;
            this.j2.Location = new System.Drawing.Point(869, 183);
            this.j2.Name = "j2";
            this.j2.Size = new System.Drawing.Size(71, 108);
            this.j2.TabIndex = 2;
            this.j2.Text = "|";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(952, 480);
            this.Controls.Add(this.j2);
            this.Controls.Add(this.j1);
            this.Controls.Add(this.ball);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ball;
        private System.Windows.Forms.Label j1;
        private System.Windows.Forms.Label j2;
        private System.Windows.Forms.Timer timer1;
    }
}

