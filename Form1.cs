using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;

namespace figures
{
    public partial class Form1 : Form
    {


        Bitmap bmp;
        Pen pen;
        public Form1()
        {
            InitializeComponent();
            this.pen = new Pen(Color.Black, 10);
            this.bmp = new Bitmap(workplace.ClientSize.Width, workplace.ClientSize.Height);

            Init.picture_box = workplace;
            Init.bitmap = this.bmp;
            Init.pen = this.pen;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripContainer1_RightToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void tools_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected_item = tools_list.SelectedIndices[0];

            switch (selected_item)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;

            }


        }
    }


    static class Init
    {
        public static Bitmap bitmap;
        public static PictureBox picture_box;
        public static Pen pen;
    }
}