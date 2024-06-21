using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
namespace borrador_RestoNet_Prog3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            botonIzqPresionado = true;
            absPoint = e.Location;

        }
        private void button_MouseUp(object sender, MouseEventArgs e)
        {
            botonIzqPresionado = false;
            (sender as Button).Location = panel1.PointToClient(Cursor.Position);
        }

        private void button_KeyPress(object sender, KeyPressEventArgs e)
        {
            aux = sender as Button;
            if (botonIzqPresionado)
            {
                switch (e.KeyChar)
                {
                    case 'w':
                        aux.Size = new Size(aux.Size.Width, aux.Size.Height + 1);
                        break;
                    case 's':
                        aux.Size = new Size(aux.Size.Width, aux.Size.Height - 1);
                        break;
                    case 'a':
                        aux.Size = new Size(aux.Size.Width - 1, aux.Size.Height);
                        break;
                    case 'd':
                        aux.Size = new Size(aux.Size.Width + 1, aux.Size.Height);
                        break;
                }
                aux = null;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            aux = (sender as Button);
            nuevoComponente = new Button
            {
                Location = new Point(20, 20),
                AutoSize = false,
                Size = aux.Size,
                Name = aux.Name,
                Text = aux.Text
            };
            nuevoComponente.MouseDown += new MouseEventHandler(button_MouseDown);
            nuevoComponente.MouseUp += new MouseEventHandler(button_MouseUp);
            nuevoComponente.KeyPress += new KeyPressEventHandler(button_KeyPress);
            panel1.Controls.Add(nuevoComponente);
            aux = null;
        }

        private void panel1_DragOver(object sender, DragEventArgs e)
        {
            //foreach (Button item in panel1.Controls)
            //    if (item.Focused) aux = item;
            //point = aux.PointToClient(new Point(e.X, e.Y));

        }
    }
}
/*
    if (e.Button == MouseButtons.Right)
    {
        aux = sender as Button;
        point = aux.PointToClient(new Point(e.X, e.Y));
        MessageBox.Show($"X abs {e.X} Y abs {e.Y} \nX rel {point.X} Y rel {point.Y}");
    }
*/
