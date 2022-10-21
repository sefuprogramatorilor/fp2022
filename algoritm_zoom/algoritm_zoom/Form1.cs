using System.IO.Compression;
using System.Windows.Forms;

namespace algoritm_zoom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         Bitmap Source;
         Bitmap dest;
         Color c1;
         Color c2;
         Color cr;
         
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            Source = new Bitmap(@"..\..\..\resurse\img2.jpg");
            pictureBox1.Image = Source ;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dest = new Bitmap(Source.Width * 2 - 1, Source.Height * 2 - 1);
            for(int i = 0; i < Source.Width; i++)
                for (int j = 0; j < Source.Height; j++)
                {
                    c1=Source.GetPixel(i, j);
                    dest.SetPixel(i*2,j*2,c1);
                }
            pictureBox3.Image = dest;
            for (int i = 0; i < dest.Width; i++)
                for(int j = 1 ; j < dest.Height-1; j+=2)
                {
                    c1 = dest.GetPixel(i, j-1);
                    c2 = dest.GetPixel(i, j+1);
                    int R = (c1.R + c2.R)/2;
                    int B = (c1.B + c2.B)/2;
                    int G = (c1.G + c2.G)/2;
                    cr = Color.FromArgb(R, G, B);
                    dest.SetPixel(i, j, cr);
                }
            for (int i = 1; i < dest.Width - 1; i += 2)
                for (int j = 0; j < dest.Height; j++)
                {
                    c1 = dest.GetPixel(i - 1, j);
                    c2 = dest.GetPixel(i + 1, j);
                    int R = (c1.R + c2.R) / 2;
                    int B = (c1.B + c2.B) / 2;
                    int G = (c1.G + c2.G) / 2;
                    cr = Color.FromArgb(R, G, B);
                    dest.SetPixel(i, j, cr);
                }
        }
    }
}