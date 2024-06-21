using System;
using System.Drawing;
using System.Windows.Forms;

namespace Resto_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LabelBlue_Click(object sender, EventArgs e)
        {
            CreateDraggableLabel(Color.MediumBlue);
        }

        private void LabelGreen_Click(object sender, EventArgs e)
        {
            CreateDraggableLabel(Color.Green);
        }

        private void LabelRed_Click(object sender, EventArgs e)
        {
            CreateDraggableLabel(Color.Red);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            CreateDraggableLabel(Color.Brown);
        }

        private void CreateDraggableLabel(Color backColor)
        {
            Label label = new Label
            {
                Location = new Point(13, 13),
                AutoSize = false,
                Size = new Size(90, 54),
                BackColor = backColor
            };
            label.MouseDown += new MouseEventHandler(Label_MouseDown);
            label.MouseMove += new MouseEventHandler(Label_MouseMove);
            label.MouseUp += new MouseEventHandler(Label_MouseUp);
            label.Click += new EventHandler(Label_Click);
            labels.Add(label);
            panel1.Controls.Add(label);
        }

        private void Label_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                draggedLabel = sender as Label;
                dragStartPoint = e.Location;
                draggedLabel.BringToFront();
            }
        }
        private void Label_MouseMove(object sender, MouseEventArgs e)
        {
            if (draggedLabel != null)
            {
                draggedLabel.Left += e.X - dragStartPoint.X;
                draggedLabel.Top += e.Y - dragStartPoint.Y;
            }
        }
        private void Label_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (draggedLabel != null && panel1.ClientRectangle.Contains(panel1.PointToClient(draggedLabel.Location)))
                {
                    panel1.Controls.Add(draggedLabel);
                    draggedLabel.Location = panel1.PointToClient(draggedLabel.Location);
                }
                draggedLabel = null;
            }
        }

        private void Label_Click(object sender, EventArgs e){
            bool booleano = ((Label) sender).Focus();
        }
    }
}
