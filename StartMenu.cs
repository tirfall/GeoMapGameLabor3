using System.Windows.Forms;

namespace GeoMapGameLabor3
{
    public partial class StartMenu : Form
    {
        Rectangle Rectangle = new Rectangle(10, 10, 200, 100);
        Rectangle Circle = new Rectangle(220, 10, 150, 150);
        Rectangle Square = new Rectangle(380, 10, 150, 150);
        int Y_sqr = 0, X_sqr = 0, Y_crl = 0, X_crl = 0, Y_rct = 0, X_rct = 0;
        PictureBox pb;
        Label l1, l2, l3;
        bool SquareBool = false, CircleBool = false, RectangleBool = false;
        public StartMenu()
        {
            this.Height = 800;
            this.Width = 1000;
            this.Text = "Start menu";

            l1 = new Label();
            l1.Font = new Font("Arial", 24, FontStyle.Bold);
            l1.Text = "Vid";
            l1.Location = new Point(10, 700);
            l1.Size = new Size(50, 50);
            l1.BackColor = Color.LightGray;
            l1.BorderStyle = BorderStyle.Fixed3D;
            this.Controls.Add(l1);

            l2 = new Label();
            l2.Font = new Font("Arial", 24, FontStyle.Bold);
            l2.Text = "Forma";
            l2.Location = new Point(l1.Width + 30, 700);
            l2.Size = new Size(50, 50);
            l2.BackColor = Color.LightGray;
            l2.BorderStyle = BorderStyle.Fixed3D;
            this.Controls.Add(l2);

            l3 = new Label();
            l3.Font = new Font("Arial", 24, FontStyle.Bold);
            l3.Text = "Info";
            l3.Location = new Point(l2.Width + 30, 700);
            l3.Size = new Size(50, 50);
            l3.BackColor = Color.LightGray;
            l3.BorderStyle = BorderStyle.Fixed3D;
            this.Controls.Add(l3);

            pb = new PictureBox();

            pb.Paint += new PaintEventHandler(pb_Paint);
            pb.MouseDown += new MouseEventHandler(pb_MouseDown);
            pb.MouseMove += new MouseEventHandler(pb_MouseMove);
            pb.MouseUp += new MouseEventHandler(pb_MouseUp);
            
            pb.Location = new Point(10, 10);
            
            pb.Size = new Size(800, 400);
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.BorderStyle = BorderStyle.Fixed3D;
            this.Controls.Add(pb);
        }

        private void pb_MouseMove(object? sender, MouseEventArgs e)
        {
            if (SquareBool)
            {
                Square.X = e.X - Square.X;
                Square.Y = e.Y - Square.Y;
            }
            if (CircleBool)
            {
                Circle.X = e.X - Circle.X;
                Circle.Y = e.Y - Circle.Y;
            }
            if (RectangleBool)
            {
                Rectangle.X = e.X - Rectangle.X;
                Rectangle.Y = e.Y - Rectangle.Y;
            }
            pb.Invalidate();
        }

        private void pb_MouseUp(object? sender, MouseEventArgs e)
        {
            CircleBool = false;
            RectangleBool = false;
            SquareBool = false;
        }

        private void pb_MouseDown(object? sender, MouseEventArgs e)
        {
            if ((e.X < Rectangle.X + Rectangle.Width) && (e.X > Rectangle.X))
            {
                if ((e.Y < Rectangle.Y + Rectangle.Height) && (e.Y > Rectangle.Y))
                {
                    RectangleBool = true;

                    X_rct = e.X - Rectangle.X;
                    Y_rct = e.Y - Rectangle.Y;
                }
            }
            if ((e.X < Circle.X + Circle.Width) && (e.X > Circle.X))
            {
                if ((e.Y < Circle.Y + Circle.Height) && (e.Y > Circle.Y))
                {
                    CircleBool = true;

                    X_crl = e.X - Circle.X;
                    Y_crl = e.Y - Circle.Y;
                }
            }
            if ((e.X < Square.X + Square.Width) && (e.X > Square.X))
            {
                if ((e.Y < Square.Y + Square.Height) && (e.Y > Square.Y))
                {
                    SquareBool = true;

                    X_sqr = e.X - Square.X;
                    Y_sqr = e.Y - Square.Y;
                }
            }
        }

        private void pb_Paint(object? sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Red, Circle);
            e.Graphics.FillRectangle(Brushes.Blue, Square);
            e.Graphics.FillRectangle(Brushes.Yellow, Rectangle);
        }
    }
}