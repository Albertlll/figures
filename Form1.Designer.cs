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
            imageList1 = new ImageList(components);
            tools_list = new ListView();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            numericUpDown2 = new NumericUpDown();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            label6 = new Label();
            numericUpDown3 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            button1 = new Button();
            saveFileDialog1 = new SaveFileDialog();
            tableLayoutPanel2 = new TableLayoutPanel();
            comboBox2 = new ComboBox();
            label4 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            workplace = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            tableLayoutPanel2.SuspendLayout();
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
            // 
            // tools_list
            // 
            tools_list.Alignment = ListViewAlignment.Left;
            tools_list.BackColor = SystemColors.WindowFrame;
            tools_list.BorderStyle = BorderStyle.None;
            tools_list.Dock = DockStyle.Fill;
            tools_list.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5 });
            tools_list.LargeImageList = imageList1;
            tools_list.Location = new Point(3, 29);
            tools_list.MultiSelect = false;
            tools_list.Name = "tools_list";
            tools_list.Size = new Size(224, 545);
            tools_list.TabIndex = 3;
            tools_list.TileSize = new Size(64, 64);
            tools_list.UseCompatibleStateImageBehavior = false;
            tools_list.SelectedIndexChanged += tools_list_SelectedIndexChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.WindowFrame;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(numericUpDown2, 3, 2);
            tableLayoutPanel1.Controls.Add(label3, 2, 2);
            tableLayoutPanel1.Controls.Add(numericUpDown1, 1, 2);
            tableLayoutPanel1.Controls.Add(comboBox1, 2, 1);
            tableLayoutPanel1.Controls.Add(label6, 2, 3);
            tableLayoutPanel1.Controls.Add(numericUpDown3, 0, 4);
            tableLayoutPanel1.Controls.Add(numericUpDown4, 2, 4);
            tableLayoutPanel1.Controls.Add(button1, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(300, 604);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 2);
            label1.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(19, 177);
            label1.Margin = new Padding(10, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(128, 50);
            label1.TabIndex = 0;
            label1.Text = "Элемент";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(43, 227);
            label2.Name = "label2";
            label2.Size = new Size(29, 50);
            label2.TabIndex = 2;
            label2.Text = "x";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label5, 2);
            label5.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(24, 277);
            label5.Margin = new Padding(10, 0, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(123, 50);
            label5.TabIndex = 6;
            label5.Text = "Ширина";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown2.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDown2.Location = new Point(228, 233);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(69, 37);
            numericUpDown2.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(193, 227);
            label3.Name = "label3";
            label3.Size = new Size(29, 50);
            label3.TabIndex = 3;
            label3.Text = "y";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown1.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(78, 233);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(69, 37);
            numericUpDown1.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(comboBox1, 2);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(153, 190);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(144, 23);
            comboBox1.TabIndex = 1;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label6, 2);
            label6.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(186, 277);
            label6.Name = "label6";
            label6.Size = new Size(111, 50);
            label6.TabIndex = 8;
            label6.Text = "Высота";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(numericUpDown3, 2);
            numericUpDown3.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDown3.Location = new Point(10, 333);
            numericUpDown3.Margin = new Padding(10, 3, 3, 3);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(137, 37);
            numericUpDown3.TabIndex = 9;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(numericUpDown4, 2);
            numericUpDown4.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDown4.Location = new Point(153, 333);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(144, 37);
            numericUpDown4.TabIndex = 10;
            // 
            // button1
            // 
            tableLayoutPanel1.SetColumnSpan(button1, 4);
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(10, 380);
            button1.Margin = new Padding(10, 3, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(287, 44);
            button1.TabIndex = 11;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.WindowFrame;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(comboBox2, 1, 1);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(103, 48);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(94, 23);
            comboBox2.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(14, 0);
            label4.Name = "label4";
            label4.Size = new Size(83, 100);
            label4.TabIndex = 0;
            label4.Text = "Элемент";
            label4.TextAlign = ContentAlignment.MiddleCenter;
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
            Controls.Add(tableLayoutPanel1);
            Controls.Add(workplace);
            Name = "Form1";
            StartPosition = FormStartPosition.Manual;
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)workplace).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private ListView tools_list;
        private TableLayoutPanel tableLayoutPanel1;
        private SaveFileDialog saveFileDialog1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown2;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox comboBox2;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button1;
        private PictureBox workplace;
    }
}