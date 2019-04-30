using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
    
{
    public partial class Form1 : Form
    {
        Boolean blnMoveLeft = true, blneMoveTop = true;
        int intScore = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.A)
                j1.Location = new Point(j1.Location.X - 5, j1.Location.Y);
            if (j1.Left <= this.ClientRectangle.Left)
                j1.Location = new Point(j1.Location.X + 5, j1.Location.Y);

            if (e.KeyCode == Keys.D)
                j1.Location = new Point(j1.Location.X + 5, j1.Location.Y);
            if (j1.Right >= this.ClientRectangle.Right)
                j1.Location = new Point(j1.Location.X - 5, j1.Location.Y);


            if (e.KeyCode == Keys.W)
                j1.Location = new Point(j1.Location.X, j1.Location.Y - 10);
            if (j1.Top <= this.ClientRectangle.Top)
                j1.Location = new Point(j1.Location.X, j1.Location.Y + 10);


            if (e.KeyCode == Keys.S)
                j1.Location = new Point(j1.Location.X, j1.Location.Y + 10);
            if (j1.Bottom >= this.ClientRectangle.Bottom)
                j1.Location = new Point(j1.Location.X, j1.Location.Y - 10);

            //jugador 2

            if (e.KeyCode == Keys.Left)
                j2.Location = new Point(j2.Location.X - 10, j2.Location.Y);
            if (j2.Left <= this.ClientRectangle.Left)
                j2.Location = new Point(j2.Location.X + 10, j2.Location.Y);

            if (e.KeyCode == Keys.Right)
                j2.Location = new Point(j2.Location.X + 10, j2.Location.Y);
            if (j2.Right >= this.ClientRectangle.Right)
                j2.Location = new Point(j2.Location.X - 10, j2.Location.Y);

            if (e.KeyCode == Keys.Up)
                j2.Location = new Point(j2.Location.X, j2.Location.Y - 10);
            if (j2.Top <= this.ClientRectangle.Top)
                j2.Location = new Point(j2.Location.X, j2.Location.Y + 10);

            if (e.KeyCode == Keys.Down)
                j2.Location = new Point(j2.Location.X, j2.Location.Y + 10);
            if (j2.Bottom >= this.ClientRectangle.Bottom)
                j2.Location = new Point(j2.Location.X, j2.Location.Y - 10);







        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ball.Location = new Point(ball.Location.X + 10, ball.Location.Y);
            ball.Location = new Point(ball.Location.X, ball.Location.Y - 20);
        }

       
    }
}
