namespace _8xml.Forms
{
    partial class MyForm
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
            menuStrip1 = new MenuStrip();
            fileToolStrip = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            вихідToolStripMenuItem = new ToolStripMenuItem();
            contentTextBox = new RichTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            transformButton = new Button();
            teacherComboBox = new ComboBox();
            userComboBox = new ComboBox();
            classnameComboBox = new ComboBox();
            clearButton = new Button();
            groupByLabel = new Label();
            FilteredItemsDeleteButton = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            AddScheduleItemButton = new Button();
            AddScheduleItemWorkingSpaceCapacity = new TextBox();
            label9 = new Label();
            AddScheduleItemTeacher = new TextBox();
            label8 = new Label();
            AddScheduleItemFreeAccessTime = new TextBox();
            AddScheduleItemUser = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            AddScheduleItemClass = new TextBox();
            tabpage3 = new TabPage();
            EditScheduleItemButton = new Button();
            EditScheduleItemWorkingSpaceCapacity = new TextBox();
            label12 = new Label();
            EditScheduleItemTeacher = new TextBox();
            label13 = new Label();
            EditScheduleItemFreeAccessTime = new TextBox();
            EditScheduleItemUser = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            EditScheduleItemClass = new TextBox();
            label10 = new Label();
            EditScheduleItemIdComboBox = new ComboBox();
            label11 = new Label();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabpage3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStrip });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1156, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStrip
            // 
            fileToolStrip.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, вихідToolStripMenuItem });
            fileToolStrip.Name = "fileToolStrip";
            fileToolStrip.Size = new Size(59, 24);
            fileToolStrip.Text = "Файл";
            fileToolStrip.Click += fileToolStrip_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(194, 26);
            openToolStripMenuItem.Text = "Читати JSON";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(194, 26);
            saveToolStripMenuItem.Text = "Зберегти JSON";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // вихідToolStripMenuItem
            // 
            вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            вихідToolStripMenuItem.Size = new Size(194, 26);
            вихідToolStripMenuItem.Text = "Вихід";
            вихідToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // contentTextBox
            // 
            contentTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            contentTextBox.ForeColor = Color.Blue;
            contentTextBox.Location = new Point(21, 34);
            contentTextBox.Margin = new Padding(3, 4, 3, 4);
            contentTextBox.Name = "contentTextBox";
            contentTextBox.Size = new Size(697, 765);
            contentTextBox.TabIndex = 2;
            contentTextBox.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 151);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 19;
            label3.Text = "Вчитель";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 104);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 18;
            label2.Text = "Користувач";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 60);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 17;
            label1.Text = "Назва класу";
            // 
            // transformButton
            // 
            transformButton.BackColor = Color.LightGreen;
            transformButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            transformButton.Location = new Point(738, 644);
            transformButton.Margin = new Padding(3, 4, 3, 4);
            transformButton.Name = "transformButton";
            transformButton.Size = new Size(394, 63);
            transformButton.TabIndex = 16;
            transformButton.Text = "Зберегти до";
            transformButton.UseVisualStyleBackColor = false;
            transformButton.Click += xsltButton_Click;
            // 
            // teacherComboBox
            // 
            teacherComboBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            teacherComboBox.FormattingEnabled = true;
            teacherComboBox.Location = new Point(135, 145);
            teacherComboBox.Margin = new Padding(3, 4, 3, 4);
            teacherComboBox.Name = "teacherComboBox";
            teacherComboBox.Size = new Size(245, 33);
            teacherComboBox.TabIndex = 15;
            teacherComboBox.SelectedIndexChanged += teacherComboBox_SelectedIndexChanged;
            // 
            // userComboBox
            // 
            userComboBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userComboBox.FormattingEnabled = true;
            userComboBox.Location = new Point(135, 101);
            userComboBox.Margin = new Padding(3, 4, 3, 4);
            userComboBox.Name = "userComboBox";
            userComboBox.Size = new Size(245, 33);
            userComboBox.TabIndex = 14;
            userComboBox.SelectedIndexChanged += userComboBox_SelectedIndexChanged;
            // 
            // classnameComboBox
            // 
            classnameComboBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            classnameComboBox.FormattingEnabled = true;
            classnameComboBox.Location = new Point(135, 57);
            classnameComboBox.Margin = new Padding(3, 4, 3, 4);
            classnameComboBox.Name = "classnameComboBox";
            classnameComboBox.Size = new Size(245, 33);
            classnameComboBox.TabIndex = 13;
            classnameComboBox.SelectedIndexChanged += classnameComboBox_SelectedIndexChanged;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Red;
            clearButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            clearButton.ForeColor = Color.White;
            clearButton.Location = new Point(738, 724);
            clearButton.Margin = new Padding(3, 4, 3, 4);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(394, 63);
            clearButton.TabIndex = 20;
            clearButton.Text = "Очистити";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // groupByLabel
            // 
            groupByLabel.AutoSize = true;
            groupByLabel.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupByLabel.ForeColor = Color.Black;
            groupByLabel.Location = new Point(72, 16);
            groupByLabel.Name = "groupByLabel";
            groupByLabel.Size = new Size(187, 31);
            groupByLabel.TabIndex = 21;
            groupByLabel.Text = "Фільтрування";
            // 
            // FilteredItemsDeleteButton
            // 
            FilteredItemsDeleteButton.BackColor = Color.LightCoral;
            FilteredItemsDeleteButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FilteredItemsDeleteButton.ForeColor = Color.Black;
            FilteredItemsDeleteButton.Location = new Point(10, 199);
            FilteredItemsDeleteButton.Margin = new Padding(3, 4, 3, 4);
            FilteredItemsDeleteButton.Name = "FilteredItemsDeleteButton";
            FilteredItemsDeleteButton.Size = new Size(370, 45);
            FilteredItemsDeleteButton.TabIndex = 22;
            FilteredItemsDeleteButton.Text = "Видалити виділені";
            FilteredItemsDeleteButton.UseVisualStyleBackColor = false;
            FilteredItemsDeleteButton.Click += FilteredItemsDelete;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabpage3);
            tabControl1.Location = new Point(724, 34);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(408, 479);
            tabControl1.TabIndex = 23;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupByLabel);
            tabPage1.Controls.Add(FilteredItemsDeleteButton);
            tabPage1.Controls.Add(classnameComboBox);
            tabPage1.Controls.Add(userComboBox);
            tabPage1.Controls.Add(teacherComboBox);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(400, 446);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Фільтрування";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(AddScheduleItemButton);
            tabPage2.Controls.Add(AddScheduleItemWorkingSpaceCapacity);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(AddScheduleItemTeacher);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(AddScheduleItemFreeAccessTime);
            tabPage2.Controls.Add(AddScheduleItemUser);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(AddScheduleItemClass);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(400, 446);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Додавання";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // AddScheduleItemButton
            // 
            AddScheduleItemButton.BackColor = Color.LightGreen;
            AddScheduleItemButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddScheduleItemButton.Location = new Point(15, 339);
            AddScheduleItemButton.Margin = new Padding(3, 4, 3, 4);
            AddScheduleItemButton.Name = "AddScheduleItemButton";
            AddScheduleItemButton.Size = new Size(371, 47);
            AddScheduleItemButton.TabIndex = 24;
            AddScheduleItemButton.Text = "Додати";
            AddScheduleItemButton.UseVisualStyleBackColor = false;
            AddScheduleItemButton.Click += AddScheduleItem;
            // 
            // AddScheduleItemWorkingSpaceCapacity
            // 
            AddScheduleItemWorkingSpaceCapacity.Location = new Point(140, 107);
            AddScheduleItemWorkingSpaceCapacity.Name = "AddScheduleItemWorkingSpaceCapacity";
            AddScheduleItemWorkingSpaceCapacity.Size = new Size(245, 27);
            AddScheduleItemWorkingSpaceCapacity.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(15, 106);
            label9.Name = "label9";
            label9.Size = new Size(78, 25);
            label9.TabIndex = 33;
            label9.Text = "Розмір";
            label9.Click += label9_Click;
            // 
            // AddScheduleItemTeacher
            // 
            AddScheduleItemTeacher.Location = new Point(140, 203);
            AddScheduleItemTeacher.Name = "AddScheduleItemTeacher";
            AddScheduleItemTeacher.Size = new Size(245, 27);
            AddScheduleItemTeacher.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(15, 202);
            label8.Name = "label8";
            label8.Size = new Size(91, 25);
            label8.TabIndex = 31;
            label8.Text = "Вчитель";
            // 
            // AddScheduleItemFreeAccessTime
            // 
            AddScheduleItemFreeAccessTime.Location = new Point(24, 285);
            AddScheduleItemFreeAccessTime.Name = "AddScheduleItemFreeAccessTime";
            AddScheduleItemFreeAccessTime.Size = new Size(245, 27);
            AddScheduleItemFreeAccessTime.TabIndex = 30;
            // 
            // AddScheduleItemUser
            // 
            AddScheduleItemUser.Location = new Point(140, 154);
            AddScheduleItemUser.Name = "AddScheduleItemUser";
            AddScheduleItemUser.Size = new Size(245, 27);
            AddScheduleItemUser.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(15, 247);
            label5.Name = "label5";
            label5.Size = new Size(206, 25);
            label5.TabIndex = 28;
            label5.Text = "Час вільного доступу";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(15, 62);
            label6.Name = "label6";
            label6.Size = new Size(122, 25);
            label6.TabIndex = 26;
            label6.Text = "Назва класу";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(15, 153);
            label7.Name = "label7";
            label7.Size = new Size(119, 25);
            label7.TabIndex = 27;
            label7.Text = "Користувач";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(77, 15);
            label4.Name = "label4";
            label4.Size = new Size(155, 31);
            label4.TabIndex = 22;
            label4.Text = "Додавання";
            label4.Click += label4_Click;
            // 
            // AddScheduleItemClass
            // 
            AddScheduleItemClass.Location = new Point(140, 62);
            AddScheduleItemClass.Name = "AddScheduleItemClass";
            AddScheduleItemClass.Size = new Size(245, 27);
            AddScheduleItemClass.TabIndex = 0;
            // 
            // tabpage3
            // 
            tabpage3.Controls.Add(EditScheduleItemButton);
            tabpage3.Controls.Add(EditScheduleItemWorkingSpaceCapacity);
            tabpage3.Controls.Add(label12);
            tabpage3.Controls.Add(EditScheduleItemTeacher);
            tabpage3.Controls.Add(label13);
            tabpage3.Controls.Add(EditScheduleItemFreeAccessTime);
            tabpage3.Controls.Add(EditScheduleItemUser);
            tabpage3.Controls.Add(label14);
            tabpage3.Controls.Add(label15);
            tabpage3.Controls.Add(label16);
            tabpage3.Controls.Add(EditScheduleItemClass);
            tabpage3.Controls.Add(label10);
            tabpage3.Controls.Add(EditScheduleItemIdComboBox);
            tabpage3.Controls.Add(label11);
            tabpage3.Location = new Point(4, 29);
            tabpage3.Name = "tabpage3";
            tabpage3.Padding = new Padding(3);
            tabpage3.Size = new Size(400, 446);
            tabpage3.TabIndex = 2;
            tabpage3.Text = "Редагування";
            tabpage3.UseVisualStyleBackColor = true;
            // 
            // EditScheduleItemButton
            // 
            EditScheduleItemButton.BackColor = Color.LightSkyBlue;
            EditScheduleItemButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EditScheduleItemButton.Location = new Point(11, 380);
            EditScheduleItemButton.Margin = new Padding(3, 4, 3, 4);
            EditScheduleItemButton.Name = "EditScheduleItemButton";
            EditScheduleItemButton.Size = new Size(371, 47);
            EditScheduleItemButton.TabIndex = 45;
            EditScheduleItemButton.Text = "Зберегти";
            EditScheduleItemButton.UseVisualStyleBackColor = false;
            EditScheduleItemButton.Click += EditScheduleItem;
            // 
            // EditScheduleItemWorkingSpaceCapacity
            // 
            EditScheduleItemWorkingSpaceCapacity.Location = new Point(136, 153);
            EditScheduleItemWorkingSpaceCapacity.Name = "EditScheduleItemWorkingSpaceCapacity";
            EditScheduleItemWorkingSpaceCapacity.Size = new Size(245, 27);
            EditScheduleItemWorkingSpaceCapacity.TabIndex = 44;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(11, 152);
            label12.Name = "label12";
            label12.Size = new Size(78, 25);
            label12.TabIndex = 43;
            label12.Text = "Розмір";
            // 
            // EditScheduleItemTeacher
            // 
            EditScheduleItemTeacher.Location = new Point(136, 249);
            EditScheduleItemTeacher.Name = "EditScheduleItemTeacher";
            EditScheduleItemTeacher.Size = new Size(245, 27);
            EditScheduleItemTeacher.TabIndex = 42;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(11, 248);
            label13.Name = "label13";
            label13.Size = new Size(91, 25);
            label13.TabIndex = 41;
            label13.Text = "Вчитель";
            // 
            // EditScheduleItemFreeAccessTime
            // 
            EditScheduleItemFreeAccessTime.Location = new Point(20, 331);
            EditScheduleItemFreeAccessTime.Name = "EditScheduleItemFreeAccessTime";
            EditScheduleItemFreeAccessTime.Size = new Size(245, 27);
            EditScheduleItemFreeAccessTime.TabIndex = 40;
            // 
            // EditScheduleItemUser
            // 
            EditScheduleItemUser.Location = new Point(136, 200);
            EditScheduleItemUser.Name = "EditScheduleItemUser";
            EditScheduleItemUser.Size = new Size(245, 27);
            EditScheduleItemUser.TabIndex = 39;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(11, 293);
            label14.Name = "label14";
            label14.Size = new Size(206, 25);
            label14.TabIndex = 38;
            label14.Text = "Час вільного доступу";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(11, 108);
            label15.Name = "label15";
            label15.Size = new Size(122, 25);
            label15.TabIndex = 36;
            label15.Text = "Назва класу";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(11, 199);
            label16.Name = "label16";
            label16.Size = new Size(119, 25);
            label16.TabIndex = 37;
            label16.Text = "Користувач";
            // 
            // EditScheduleItemClass
            // 
            EditScheduleItemClass.Location = new Point(136, 108);
            EditScheduleItemClass.Name = "EditScheduleItemClass";
            EditScheduleItemClass.Size = new Size(245, 27);
            EditScheduleItemClass.TabIndex = 35;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(73, 17);
            label10.Name = "label10";
            label10.Size = new Size(176, 31);
            label10.TabIndex = 24;
            label10.Text = "Редагування";
            label10.Click += label10_Click;
            // 
            // EditScheduleItemIdComboBox
            // 
            EditScheduleItemIdComboBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EditScheduleItemIdComboBox.FormattingEnabled = true;
            EditScheduleItemIdComboBox.Location = new Point(115, 58);
            EditScheduleItemIdComboBox.Margin = new Padding(3, 4, 3, 4);
            EditScheduleItemIdComboBox.Name = "EditScheduleItemIdComboBox";
            EditScheduleItemIdComboBox.Size = new Size(266, 33);
            EditScheduleItemIdComboBox.TabIndex = 22;
            EditScheduleItemIdComboBox.Leave += EditScheduleItemIdLeave;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(11, 61);
            label11.Name = "label11";
            label11.Size = new Size(98, 25);
            label11.TabIndex = 23;
            label11.Text = "ID запису";
            label11.Click += label11_Click;
            // 
            // MyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 812);
            Controls.Add(tabControl1);
            Controls.Add(clearButton);
            Controls.Add(transformButton);
            Controls.Add(contentTextBox);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "8 варіант";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabpage3.ResumeLayout(false);
            tabpage3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStrip;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private RichTextBox contentTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button transformButton;
        private ComboBox teacherComboBox;
        private ComboBox userComboBox;
        private ComboBox classnameComboBox;
        private Button clearButton;
        private Label groupByLabel;
        private ToolStripMenuItem вихідToolStripMenuItem;
        private Button FilteredItemsDeleteButton;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label4;
        private TextBox AddScheduleItemClass;
        private TextBox AddScheduleItemUser;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox AddScheduleItemTeacher;
        private Label label8;
        private TextBox AddScheduleItemFreeAccessTime;
        private TextBox AddScheduleItemWorkingSpaceCapacity;
        private Label label9;
        private Button AddScheduleItemButton;
        private TabPage tabpage3;
        private Label label10;
        private ComboBox EditScheduleItemIdComboBox;
        private Label label11;
        private Button EditScheduleItemButton;
        private TextBox EditScheduleItemWorkingSpaceCapacity;
        private Label label12;
        private TextBox EditScheduleItemTeacher;
        private Label label13;
        private TextBox EditScheduleItemFreeAccessTime;
        private TextBox EditScheduleItemUser;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox EditScheduleItemClass;
    }
}