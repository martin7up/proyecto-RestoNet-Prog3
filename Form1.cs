
using System.Drawing;
using System.Drawing.Design;

namespace proyRestoNetProg3
{
    public partial class Form1 : Form
    {
        //private List<Point> _points;
        //private Point point;
        public Form1()
        {
            InitializeComponent();
            //_points = new();

        }

        private void pictureBox_mouseDown(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).DoDragDrop(((PictureBox)sender).Image, DragDropEffects.Copy);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.AllowDrop = true;
        }

        

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
        }
        //Evento de prueba
        private void pictureBox1_MouseClick_1(object sender, MouseEventArgs e)
        {
            pictureBox1.CreateGraphics().DrawIcon(SystemIcons.WinLogo, e.X, e.Y);
            //_points.Add(new(e.X, e.Y));
        }

        void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox1.CreateGraphics().DrawImage((Image)e.Data.GetData(DataFormats.Bitmap), e.X-25, e.Y-25);
        }

        //private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        //{
        //    point = new(e.X, e.Y);
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //PaintEventArgs a = e as PaintEventArgs; para usar con un codigo en paga de microsoft
        //    using (Pen pen = new Pen(Color.Black))
        //    {
        //        foreach (Point item in _points)
        //        {
        //            Point aux = item;
        //            foreach (Point meti in _points)
        //            {
        //                pictureBox1.CreateGraphics().DrawLine(pen, item, meti);
        //            }
        //        }
        //    }
        //}   
    }
}
