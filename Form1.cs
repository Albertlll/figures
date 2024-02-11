using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace figures
{
    public partial class Form1 : Form
    {
        private int previous_controls = 4;
        private AbstractFigure? now_elem = null;

        private Dictionary<int, string> ind_figure = new Dictionary<int, string>() {
            { 0, "Сircle"},
            { 1, "Ellipse"},
            { 2, "Triangle"},
            { 3, "Square"},
            { 4, "Rectangle"},
            { 5, "Polygon"},
            { 6, "Own"}


        };
        public Form1()
        {
            InitializeComponent();
            AllocConsole();
            tools_list.Items[4].Selected = true;
            select_elem.SelectedIndex = 0;

            Init.picture_box = workplace;
            Init.bitmap = new Bitmap(workplace.ClientSize.Width, workplace.ClientSize.Height);
            Init.pen = new Pen(Color.Black, 10);

        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();


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
                    update_elem_list(ind_figure[1]);
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
            foreach (AbstractFigure i in ShapeContainer.list)
            {
                if (i.GetType().Name == f_type)
                {
                    select_elem.Items.Add(i.number);
                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (!(select_elem.Text.ToString() == "Новый"))
            {
                return;
            }



            int selected_item = tools_list.SelectedIndices[0];
            switch (selected_item)
            {
                case 0:
                    break;

                case 1:
                    Ellipse el = new Ellipse(Convert.ToInt32(x_change.Value),
                       Convert.ToInt32(y_change.Value),
                       Convert.ToInt32(width_inp.Value),
                       Convert.ToInt32(height_inp.Value));
                    ShapeContainer.DrawAll();
                    update_elem_list(ind_figure[1]);
                    break;

                case 2:
                    break;

                case 3:
                    Square sq = new Square(Convert.ToInt32(x_change.Value),
                                           Convert.ToInt32(y_change.Value),
                                           Convert.ToInt32(width_inp.Value));
                    ShapeContainer.DrawAll();
                    update_elem_list(ind_figure[3]);
                    break;

                case 4:
                    Rectangle rect = new Rectangle(Convert.ToInt32(x_change.Value),
                                           Convert.ToInt32(y_change.Value),
                                           Convert.ToInt32(width_inp.Value),
                                           Convert.ToInt32(height_inp.Value));
                    //ShapeContainer.list.Add(rect);
                    ShapeContainer.DrawAll();
                    update_elem_list(ind_figure[4]);
                    break;
                case 5:

                    break;
                case 6:
                    break;
            }

            Console.WriteLine(ShapeContainer.list);

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

        private void select_elem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (select_elem.Text == "Новый")
            {
                now_elem = null;
                past_new_values();
                return;
            }

            add.Enabled = false;
            foreach (AbstractFigure i in ShapeContainer.list)
            {
                if (i.number.ToString() == select_elem.Text)
                {
                    now_elem = i;
                    parse_properties(i);
                    break;
                }
            }
            foreach (AbstractFigure i in ShapeContainer.list)
            {
                Console.WriteLine(i.number);

            }

        }

        private void parse_properties(AbstractFigure f)
        {
            x_change.ValueChanged -= inp_ValueChanged;
            y_change.ValueChanged -= inp_ValueChanged;

            x_change.Value = f.x;
            y_change.Value = f.y;

            x_change.ValueChanged += inp_ValueChanged;
            y_change.ValueChanged += inp_ValueChanged;

            width_inp.Value = f.width;
            height_inp.Value = f.height;

        }

        private void past_new_values()
        {
            add.Enabled = true;

            x_change.ValueChanged -= inp_ValueChanged;
            y_change.ValueChanged -= inp_ValueChanged;

            x_change.Value = 0;
            y_change.Value = 0;
            
            x_change.ValueChanged += inp_ValueChanged;
            y_change.ValueChanged += inp_ValueChanged;
            width_inp.Value = 100;
            height_inp.Value = 100;
        }



        private void inp_ValueChanged(object sender, EventArgs e)
        {
            if (now_elem != null)
            {
                now_elem.MoveTo(Convert.ToInt32(x_change.Value),
                                Convert.ToInt32(y_change.Value));
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