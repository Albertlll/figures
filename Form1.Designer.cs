namespace figures
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ListViewItem listViewItem1 = new ListViewItem("", 0);
            ListViewItem listViewItem2 = new ListViewItem("", 1);
            ListViewItem listViewItem3 = new ListViewItem("", 2);
            ListViewItem listViewItem4 = new ListViewItem("", 3);
            ListViewItem listViewItem5 = new ListViewItem("", 4);
            ListViewItem listViewItem6 = new ListViewItem("", 5);
            ListViewItem listViewItem7 = new ListViewItem("", 6);
            imageList1 = new ImageList(components);
            tools_list = new ListView();
            properties = new TableLayoutPanel();
            elem_lbl = new Label();
            x_lbl = new Label();
            width_lbl = new Label();
            y_change = new NumericUpDown();
            y_lbl = new Label();
            x_change = new NumericUpDown();
            select_elem = new ComboBox();
            width_inp = new NumericUpDown();
            height_inp = new NumericUpDown();
            add = new Button();
            height_lbl = new Label();
            saveFileDialog1 = new SaveFileDialog();
            tableLayoutPanel3 = new TableLayoutPanel();
            workplace = new PictureBox();
            properties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)y_change).BeginInit();
            ((System.ComponentModel.ISupportInitialize)x_change).BeginInit();
            ((System.ComponentModel.ISupportInitialize)width_inp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)height_inp).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)workplace).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "круг.png");
            imageList1.Images.SetKeyName(1, "элипс.png");
            imageList1.Images.SetKeyName(2, "треугольник.png");
            imageList1.Images.SetKeyName(3, "квадрат.png");
            imageList1.Images.SetKeyName(4, "прямоуг.png");
            imageList1.Images.SetKeyName(5, "многоугольник.png");
            imageList1.Images.SetKeyName(6, "розетка норм.png");
            // 
            // tools_list
            // 
            tools_list.Activation = ItemActivation.OneClick;
            tools_list.Alignment = ListViewAlignment.Left;
            tools_list.BackColor = SystemColors.WindowFrame;
            tools_list.BorderStyle = BorderStyle.None;
            tools_list.Dock = DockStyle.Fill;
            tools_list.HeaderStyle = ColumnHeaderStyle.None;
            tools_list.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6, listViewItem7 });
            tools_list.LargeImageList = imageList1;
            tools_list.Location = new Point(3, 29);
            tools_list.MultiSelect = false;
            tools_list.Name = "tools_list";
            tools_list.Size = new Size(224, 545);
            tools_list.TabIndex = 3;
            tools_list.TileSize = new Size(64, 64);
            tools_list.UseCompatibleStateImageBehavior = false;
            tools_list.ItemSelectionChanged += tools_list_ItemSelectionChanged;
            tools_list.Click += tools_list_SelectedIndexChanged;
            // 
            // properties
            // 
            properties.BackColor = SystemColors.WindowFrame;
            properties.ColumnCount = 4;
            properties.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            properties.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            properties.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            properties.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            properties.Controls.Add(elem_lbl, 0, 1);
            properties.Controls.Add(x_lbl, 0, 2);
            properties.Controls.Add(width_lbl, 0, 3);
            properties.Controls.Add(y_change, 3, 2);
            properties.Controls.Add(y_lbl, 2, 2);
            properties.Controls.Add(x_change, 1, 2);
            properties.Controls.Add(select_elem, 2, 1);
            properties.Controls.Add(width_inp, 0, 4);
            properties.Controls.Add(height_inp, 2, 4);
            properties.Controls.Add(add, 0, 5);
            properties.Controls.Add(height_lbl, 2, 3);
            properties.Dock = DockStyle.Left;
            properties.Location = new Point(0, 0);
            properties.Name = "properties";
            properties.RowCount = 7;
            properties.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            properties.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            properties.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            properties.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            properties.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            properties.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            properties.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            properties.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            properties.Size = new Size(300, 604);
            properties.TabIndex = 4;
            // 
            // elem_lbl
            // 
            elem_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            elem_lbl.AutoSize = true;
            properties.SetColumnSpan(elem_lbl, 2);
            elem_lbl.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            elem_lbl.ForeColor = Color.White;
            elem_lbl.Location = new Point(19, 177);
            elem_lbl.Margin = new Padding(10, 0, 3, 0);
            elem_lbl.Name = "elem_lbl";
            elem_lbl.Size = new Size(128, 50);
            elem_lbl.TabIndex = 0;
            elem_lbl.Text = "Элемент";
            elem_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // x_lbl
            // 
            x_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            x_lbl.AutoSize = true;
            x_lbl.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            x_lbl.ForeColor = Color.White;
            x_lbl.Location = new Point(43, 227);
            x_lbl.Name = "x_lbl";
            x_lbl.Size = new Size(29, 50);
            x_lbl.TabIndex = 2;
            x_lbl.Text = "x";
            x_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // width_lbl
            // 
            width_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            width_lbl.AutoSize = true;
            properties.SetColumnSpan(width_lbl, 2);
            width_lbl.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            width_lbl.ForeColor = Color.White;
            width_lbl.Location = new Point(10, 277);
            width_lbl.Margin = new Padding(10, 0, 3, 0);
            width_lbl.Name = "width_lbl";
            width_lbl.Size = new Size(137, 50);
            width_lbl.TabIndex = 6;
            width_lbl.Text = "Ширина";
            width_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // y_change
            // 
            y_change.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            y_change.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            y_change.Location = new Point(228, 233);
            y_change.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            y_change.Name = "y_change";
            y_change.Size = new Size(69, 37);
            y_change.TabIndex = 5;
            y_change.ValueChanged += inp_ValueChanged;
            // 
            // y_lbl
            // 
            y_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            y_lbl.AutoSize = true;
            y_lbl.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            y_lbl.ForeColor = Color.White;
            y_lbl.Location = new Point(193, 227);
            y_lbl.Name = "y_lbl";
            y_lbl.Size = new Size(29, 50);
            y_lbl.TabIndex = 3;
            y_lbl.Text = "y";
            y_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // x_change
            // 
            x_change.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            x_change.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            x_change.Location = new Point(78, 233);
            x_change.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            x_change.Name = "x_change";
            x_change.Size = new Size(69, 37);
            x_change.TabIndex = 7;
            x_change.ValueChanged += inp_ValueChanged;
            // 
            // select_elem
            // 
            select_elem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            properties.SetColumnSpan(select_elem, 2);
            select_elem.DisplayMember = "Новый";
            select_elem.DropDownStyle = ComboBoxStyle.DropDownList;
            select_elem.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            select_elem.FormattingEnabled = true;
            select_elem.Items.AddRange(new object[] { "Новый" });
            select_elem.Location = new Point(153, 181);
            select_elem.Name = "select_elem";
            select_elem.Size = new Size(144, 41);
            select_elem.TabIndex = 1;
            select_elem.SelectedIndexChanged += select_elem_SelectedIndexChanged;
            // 
            // width_inp
            // 
            width_inp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            properties.SetColumnSpan(width_inp, 2);
            width_inp.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            width_inp.Location = new Point(10, 333);
            width_inp.Margin = new Padding(10, 3, 3, 3);
            width_inp.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            width_inp.Name = "width_inp";
            width_inp.Size = new Size(137, 37);
            width_inp.TabIndex = 9;
            width_inp.ValueChanged += inp_ValueChanged;
            // 
            // height_inp
            // 
            height_inp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            properties.SetColumnSpan(height_inp, 2);
            height_inp.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            height_inp.Location = new Point(153, 333);
            height_inp.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            height_inp.Name = "height_inp";
            height_inp.Size = new Size(144, 37);
            height_inp.TabIndex = 10;
            // 
            // add
            // 
            properties.SetColumnSpan(add, 4);
            add.Dock = DockStyle.Fill;
            add.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            add.Location = new Point(10, 380);
            add.Margin = new Padding(10, 3, 3, 3);
            add.Name = "add";
            add.Size = new Size(287, 44);
            add.TabIndex = 11;
            add.Text = "Добавить";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // height_lbl
            // 
            height_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            height_lbl.AutoSize = true;
            properties.SetColumnSpan(height_lbl, 2);
            height_lbl.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            height_lbl.ForeColor = Color.White;
            height_lbl.Location = new Point(153, 277);
            height_lbl.Name = "height_lbl";
            height_lbl.Size = new Size(144, 50);
            height_lbl.TabIndex = 12;
            height_lbl.Text = "Высота";
            height_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = SystemColors.WindowFrame;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tools_list, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Right;
            tableLayoutPanel3.Location = new Point(964, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 551F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(230, 604);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // workplace
            // 
            workplace.Anchor = AnchorStyles.None;
            workplace.BackColor = Color.White;
            workplace.Location = new Point(316, 29);
            workplace.Name = "workplace";
            workplace.Size = new Size(594, 545);
            workplace.TabIndex = 1;
            workplace.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1194, 604);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(properties);
            Controls.Add(workplace);
            Name = "Form1";
            StartPosition = FormStartPosition.Manual;
            Text = "Form1";
            properties.ResumeLayout(false);
            properties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)y_change).EndInit();
            ((System.ComponentModel.ISupportInitialize)x_change).EndInit();
            ((System.ComponentModel.ISupportInitialize)width_inp).EndInit();
            ((System.ComponentModel.ISupportInitialize)height_inp).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)workplace).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private ListView tools_list;
        private TableLayoutPanel properties;
        private SaveFileDialog saveFileDialog1;
        private Label elem_lbl;
        private ComboBox select_elem;
        private Label x_lbl;
        private Label y_lbl;
        private NumericUpDown y_change;
        private Label width_lbl;
        private NumericUpDown x_change;
        private NumericUpDown width_inp;
        private NumericUpDown height_inp;
        private TableLayoutPanel tableLayoutPanel3;
        private Button add;
        private PictureBox workplace;
        private Label height_lbl;
    }
}