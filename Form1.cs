using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace figures
{
    public partial class Form1 : Form
    {


        Bitmap bmp;
        Pen pen;
        private int previous_controls = 4;

        private int previous_selected_tool = 3;

        ShapeContainer sc = new ShapeContainer();

        private Dictionary<int, string> ind_figure = new Dictionary<int, string>() {
            { 3, "Square"},
            { 4, "Rectangle"}
        
        };

        public Form1()
        {
            InitializeComponent();
            AllocConsole();
            tools_list.Items[4].Selected = true;

            this.pen = new Pen(Color.Black, 10);
            this.bmp = new Bitmap(workplace.ClientSize.Width, workplace.ClientSize.Height);
            Init.picture_box = workplace;
            Init.bitmap = this.bmp;
            Init.pen = this.pen;



        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
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

        private void create_one_len()
        {
            properties.Controls.Remove(height_lbl);
            properties.Controls.Remove(height_inp);
            properties.SetColumnSpan(width_lbl, 4);
            properties.SetColumnSpan(width_inp, 4);
        }

        private void create_two_len()
        {
            properties.SetColumnSpan(width_lbl, 2);
            properties.SetColumnSpan(width_inp, 2);
            properties.Controls.Add(height_lbl, 2, 3);
            properties.Controls.Add(height_inp, 2, 3);
        }

        private void tools_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected_item = tools_list.SelectedIndices[0];


            // Проверка на одинаковый "тип" интерфейса контролеров
            int[] one_idexies = new int[] { 0, 3 };
            if (one_idexies.Contains(selected_item) &&
                one_idexies.Contains(previous_controls) ||
                !one_idexies.Contains(selected_item) &&
                !one_idexies.Contains(previous_controls))
            {
                return;
            }

            switch (selected_item)
            {
                case 0:
                    create_one_len();
                    break;

                case 1:
                    create_two_len();
                    break;

                case 2:
                    create_two_len();
                    break;

                case 3:
                    create_one_len();
                    update_elem_list(ind_figure[3]);
                    break;

                case 4:
                    create_two_len();
                    update_elem_list(ind_figure[4]);
                    break;
                case 5:

                    break;
                case 6:
                    create_one_len();
                    break;
            }

            previous_controls = selected_item;



        }


        private void update_elem_list(String f_type)
        {
            select_elem.Items.Clear();
            select_elem.Items.Add("Новый");
            select_elem.SelectedIndex = 0;
            foreach (AbstractFigure i in ShapeContainer.get_list())
            {
                if (i.GetType().Name == f_type)
                {
                    select_elem.Items.Add(i.number);
                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            Console.WriteLine(10);
            if (!(select_elem.SelectedItem.ToString() == "Новый"))
            {
                return;
            }

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
                    Square sq = new Square(Convert.ToInt32(x_change.Value),
                                           Convert.ToInt32(y_change.Value),
                                           Convert.ToInt32(width_inp.Value));

                    ShapeContainer.AddFigure(sq);
                    ShapeContainer.DrawAll();
                    update_elem_list(ind_figure[3]);
                    break;

                case 4:
                    Rectangle rect = new Rectangle(Convert.ToInt32(x_change.Value),
                                           Convert.ToInt32(y_change.Value),
                                           Convert.ToInt32(width_inp.Value),
                                           Convert.ToInt32(height_inp.Value));
                    ShapeContainer.AddFigure(rect);
                    ShapeContainer.DrawAll();
                    update_elem_list(ind_figure[4]);
                    break;
                case 5:

                    break;
                case 6:
                    break;
            }

        }

        private void tools_list_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                properties.Enabled = true;

            }
            else
            {
                properties.Enabled = false;
            }

            //elem_lbl.Text = e.ItemIndex.ToString();
        }
    }


    static class Init
    {
        public static Bitmap bitmap;
        public static PictureBox picture_box;
        public static Pen pen;
    }
}