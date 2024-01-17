using _8xml.Strategy;
using _8xml.Strategy.Interfaces;
using System.Xml.Serialization; /* Удалить */

using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace _8xml.Forms
{
    public partial class MyForm : Form
    {
        private IXSLTService xsltService;
        private IEnumerable<ScheduleItem> items;
        private IEnumerable<ScheduleItem> itemsToDisplay;

        private string xmlFilePath;

        public MyForm()
        {
            this.xsltService = new XSLTService();
            this.items = new List<ScheduleItem>();
            this.itemsToDisplay = new List<ScheduleItem>();
            InitializeComponent();
            this.xmlFilePath = default;
        }


        private void xsltButton_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON Files|*.json|All Files|*.*";
            saveFileDialog.DefaultExt = "json";
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var jsonFilePath = saveFileDialog.FileName;
                var jsonData = JsonConvert.SerializeObject(items, Formatting.Indented);
                File.WriteAllText(jsonFilePath, jsonData);
                MessageBox.Show("Успіх!");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON Files|*.json|All Files|*.*";
            openFileDialog.Title = "Select a JSON File";
            this.RefreshAllControls();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var jsonFilePath = openFileDialog.FileName;
                this.Load(openFileDialog.FileName);
                this.RefreshTextBox();
            }
        }

        private void RefreshAllControls()
        {
            this.contentTextBox.Clear();
            this.items = new List<ScheduleItem>();
            this.itemsToDisplay = new List<ScheduleItem>();
            
            this.classnameComboBox.Items.Clear();
            this.userComboBox.Items.Clear();
            this.teacherComboBox.Items.Clear();
            this.classnameComboBox.SelectedIndex = -1;
            this.userComboBox.SelectedIndex = -1;
            this.teacherComboBox.SelectedIndex = -1;
            this.classnameComboBox.Text = "";
            this.userComboBox.Text = "";
            this.teacherComboBox.Text = "";

            this.AddScheduleItemClass.Text = "";
            this.AddScheduleItemWorkingSpaceCapacity.Text = "";
            this.AddScheduleItemUser.Text = "";
            this.AddScheduleItemTeacher.Text = "";
            this.AddScheduleItemFreeAccessTime.Text = "";
        }

        private void Load(string jsonPath)
        {
            IEnumerable<ScheduleItem> items;
            using (StreamReader file = File.OpenText(jsonPath))
            {
                JsonSerializer serializer = new JsonSerializer();
                items = (IEnumerable<ScheduleItem>)serializer.Deserialize(file, typeof(IEnumerable<ScheduleItem>));
            }
            this.Update(items, firstTimeRender: true);
        }

        private void Update(IEnumerable<ScheduleItem> scheduleItems, bool firstTimeRender = false)
        {
            if (firstTimeRender)
                this.items = scheduleItems;

            this.contentTextBox.Text = "";

            foreach (var item in scheduleItems)
            {
                string itemInTextbox = "";

                itemInTextbox += $"Ідентифікатор = {item.Id}\n";
                itemInTextbox += $"Назва класу = {item.ClassName}\n";
                itemInTextbox += $"Розмір класу = {item.WorkingSpaceCapacity}\n";
                itemInTextbox += $"Користувач = {item.User}\n";
                itemInTextbox += $"Вчитель = {item.Teacher}\n";
                itemInTextbox += $"Час вільного доступу = {item.FreeAccessTime}\n\n";

                this.contentTextBox.Text += itemInTextbox;
            }
        }

        private void RefreshTextBox()
        {
            this.classnameComboBox.Items.Clear();
            this.userComboBox.Items.Clear();
            this.teacherComboBox.Items.Clear();
            this.classnameComboBox.SelectedIndex = -1;
            this.userComboBox.SelectedIndex = -1;
            this.teacherComboBox.SelectedIndex = -1;
            this.classnameComboBox.Text = "";
            this.userComboBox.Text = "";
            this.teacherComboBox.Text = "";

            var classnames = this.items.Select(x => x.ClassName).Distinct().ToList();
            this.classnameComboBox.Items.Add("");
            this.classnameComboBox.Items.AddRange(classnames.ToArray());

            var users = this.items.Select(x => x.User).Distinct().ToList();
            this.userComboBox.Items.Add("");
            this.userComboBox.Items.AddRange(users.ToArray());

            var teachers = this.items.Select(x => x.Teacher).Distinct().ToList();
            this.teacherComboBox.Items.Add("");
            this.teacherComboBox.Items.AddRange(teachers.ToArray());

            var itemIds = this.items.Select(x => x.Id.ToString()).Distinct().ToList();
            this.EditScheduleItemIdComboBox.Items.Add("");
            this.EditScheduleItemIdComboBox.Items.AddRange(itemIds.ToArray());
        }

        private void Save(string filePath)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON Files|*.json|All Files|*.*";
            saveFileDialog.DefaultExt = "json";
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var jsonFilePath = saveFileDialog.FileName;
                var jsonData = JsonConvert.SerializeObject(items, Formatting.Indented);
                File.WriteAllText(jsonFilePath, jsonData);
                MessageBox.Show("Успіх!");
            }
        }

        private void classnameComboBox_SelectedIndexChanged(object sender, EventArgs e) => this.Filter();

        private void Filter()
        {
            var classname = classnameComboBox.SelectedItem?.ToString();
            var user = userComboBox.SelectedItem?.ToString();
            var teacher = teacherComboBox.SelectedItem?.ToString();

            this.itemsToDisplay = this.items;

            if (!string.IsNullOrEmpty(classname) || !string.IsNullOrEmpty(user) || !string.IsNullOrEmpty(teacher))
            {
                this.itemsToDisplay = this.items.Where(x =>
                        (string.IsNullOrEmpty(classname) || x.ClassName == classname) &&
                        (string.IsNullOrEmpty(user) || x.User == user) &&
                        (string.IsNullOrEmpty(teacher) || x.Teacher == teacher)).ToList();
            }

            this.Update(this.itemsToDisplay);
        }



        private void FilteredItemsDelete(object sender, EventArgs e)
        {
            var classname = classnameComboBox.SelectedItem?.ToString();
            var user = userComboBox.SelectedItem?.ToString();
            var teacher = teacherComboBox.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(classname) || !string.IsNullOrEmpty(user) || !string.IsNullOrEmpty(teacher))
            {
                // Convert to List if it's not already a List
                var itemsList = this.items as List<ScheduleItem> ?? this.items.ToList();

                itemsList.RemoveAll(x =>
                    (string.IsNullOrEmpty(classname) || x.ClassName == classname) &&
                    (string.IsNullOrEmpty(user) || x.User == user) &&
                    (string.IsNullOrEmpty(teacher) || x.Teacher == teacher));

                // Update the original items collection if necessary
                this.items = itemsList;
            }

            this.Update(this.items);
        }


        private void userComboBox_SelectedIndexChanged(object sender, EventArgs e) => this.Filter();

        private void teacherComboBox_SelectedIndexChanged(object sender, EventArgs e) => this.Filter();

        private void clearButton_Click(object sender, EventArgs e) => RefreshAllControls();

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON Files|*.json|All Files|*.*";
            saveFileDialog.DefaultExt = "json";
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var jsonFilePath = saveFileDialog.FileName;
                var jsonData = JsonConvert.SerializeObject(items, Formatting.Indented);
                File.WriteAllText(jsonFilePath, jsonData);
                MessageBox.Show("Успіх!");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void fileToolStrip_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddScheduleItem(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrEmpty(AddScheduleItemClass.Text) || string.IsNullOrEmpty(AddScheduleItemUser.Text) || string.IsNullOrEmpty(AddScheduleItemTeacher.Text))
            {
                MessageBox.Show("Поля не можуть бути порожніми!");
                return;
            }

            if (!int.TryParse(AddScheduleItemWorkingSpaceCapacity.Text, out int capacity))
            {
                MessageBox.Show("Неправильний розмір класу");
                return;
            }

            if (!DateTime.TryParse(AddScheduleItemFreeAccessTime.Text, out DateTime freeAccessTime))
            {
                MessageBox.Show("Неправильний час вільного доступу");
                return;
            }

            // Assuming other fields are just strings, so no need for type validation
            string className = AddScheduleItemClass.Text;
            string user = AddScheduleItemUser.Text;
            string teacher = AddScheduleItemTeacher.Text;

            // Creating new ScheduleItem
            ScheduleItem newItem = new ScheduleItem
            {
                ClassName = className,
                WorkingSpaceCapacity = capacity.ToString(),
                User = user,
                Teacher = teacher,
                FreeAccessTime = freeAccessTime
            };

            var itemsList = this.items as List<ScheduleItem> ?? this.items.ToList();
            newItem.Id = itemsList.Any() ? itemsList.Max(x => x.Id) + 1 : 1;
            itemsList.Add(newItem);

            this.items = itemsList;

            this.Update(this.items);
            this.RefreshTextBox();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void EditScheduleItemIdLeave(object sender, EventArgs e)
        {
            if (int.TryParse(EditScheduleItemIdComboBox.SelectedItem?.ToString(), out int selectedId))
            {
                var matchingItem = items.FirstOrDefault(item => item.Id == selectedId);

                if (matchingItem != null)
                {
                    string user = matchingItem.User;

                    EditScheduleItemClass.Text = matchingItem.ClassName;
                    EditScheduleItemWorkingSpaceCapacity.Text = matchingItem.WorkingSpaceCapacity;
                    EditScheduleItemUser.Text = matchingItem.User;
                    EditScheduleItemTeacher.Text = matchingItem.Teacher;
                    EditScheduleItemFreeAccessTime.Text = $"{matchingItem.FreeAccessTime}";
                }
                else
                {
                    MessageBox.Show("Такого запису не існує");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Потрібно вписати ID запису");
                return;
            }
        }

        private void EditScheduleItem(object sender, EventArgs e)
        {
            if (int.TryParse(EditScheduleItemIdComboBox.SelectedItem?.ToString(), out int selectedId))
            {
                // Validation
                if (string.IsNullOrEmpty(EditScheduleItemClass.Text) || string.IsNullOrEmpty(EditScheduleItemUser.Text) || string.IsNullOrEmpty(EditScheduleItemTeacher.Text))
                {
                    MessageBox.Show("Поля не можуть бути порожніми!");
                    return;
                }

                if (!int.TryParse(EditScheduleItemWorkingSpaceCapacity.Text, out int capacity))
                {
                    MessageBox.Show("Неправильний розмір класу");
                    return;
                }

                if (!DateTime.TryParse(EditScheduleItemFreeAccessTime.Text, out DateTime freeAccessTime))
                {
                    MessageBox.Show("Неправильний час вільного доступу");
                    return;
                }

                var matchingItem = items.FirstOrDefault(item => item.Id == selectedId);

                if (matchingItem != null)
                {

                    matchingItem.ClassName = EditScheduleItemClass.Text;
                    matchingItem.WorkingSpaceCapacity = capacity.ToString();
                    matchingItem.User = EditScheduleItemUser.Text;
                    matchingItem.Teacher = EditScheduleItemTeacher.Text;
                    matchingItem.FreeAccessTime = freeAccessTime;

                    this.Update(this.items);
                    this.RefreshTextBox();

                    MessageBox.Show("Збережено!");
                    return;
                }
                else
                {
                    MessageBox.Show("Такого запису не існує");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Потрібно вписати ID запису");
                return;
            }
        }
    }
}