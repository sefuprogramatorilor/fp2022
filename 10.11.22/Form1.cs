namespace _10._11._22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Random random = new Random();
        Graphics grp;
        Bitmap bmp;
        int n = 20;
        PointF[] points;

        private void drawPoint(Graphics grp, Brush brush,
                                      float centerX, float centerY, float radius)
        {
            grp.FillEllipse(brush, centerX - radius, centerY - radius,
                          radius + radius, radius + radius);
        }

            int a, b, c;
        float det(PointF a, PointF b, PointF c)
        {
            return a.X * b.X + b.X * a.Y - a.Y * b.X - b.Y * c.X - c.Y * a.X;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            grp = Graphics.FromImage(bmp);
            points = new PointF[n];
            
            for (int i = 0; i < n; i++)
            {
                points[i] = new PointF(random.Next(pictureBox.Width), random.Next(pictureBox.Height));
                drawPoint(grp, new SolidBrush(Color.Beige), points[i].X, points[i].Y, 2);
            }

            float min = 0.5f * Math.Abs(det(points[0], points[1], points[2]));
            for (int i = 0; i < n-2; i++)
            {
                for(int j = i+1; j < n-1; j++)
                {
                    for(int k = j+1; k < n; k++)
                    {
                        float d = 0.5f * Math.Abs(det(points[i], points[j], points[k]));
                        if(min > d)
                        {
                            a = i;
                            b = j;
                            c = k;
                            min = d;

                        }
                    }
                }
            }

            grp.DrawLine(new Pen(Color.HotPink), points[a], points[b]);
            grp.DrawLine(new Pen(Color.Magenta), points[b], points[c]);
            grp.DrawLine(new Pen(Color.Turquoise), points[a], points[c]);

            pictureBox.Image = bmp;

        }
    }
}