using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace VPV_GUI
{
    /// <summary>Главная форма со списком уже созданных тестов </summary>
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadTests();
        }

        /// <summary>Загружает список тестов из директории /tests </summary>
        private void loadTests()
        {
            String[] paths = Directory.GetFiles("tests\\", "*.test", SearchOption.TopDirectoryOnly);
            for (int i = 0; i < paths.Length; i++)
            {
                addTaskToList(TestTask.load(paths[i]));
            }
        }

        /// <summary>
        /// Событие отпускания кнопки мыши над областью с тестами
        /// Если это правая кнопка - показывает контекстовое меню
        /// </summary>
        private void listTests_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                startToolStripMenuItem.Visible = listTests.SelectedItems.Count == 1;
                contextMenuStrip.Show(new Point(this.Location.X + listTests.Location.X + e.X + 11, this.Location.Y + listTests.Location.Y + e.Y + 31));
            }
        }

        /// <summary>
        /// Срабатывает при нажатии пункта "Добавить задачу"
        /// Открывает форму ее создания (Test)
        /// Также сохраняет созданную задачу в директорию /test
        /// </summary>
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task dialog = new Task();
            dialog.ShowDialog();
            TestTask test = dialog.getTest();
            if (test != null)
            {
                test.save("tests\\" + test.Name + ".test");
                addTaskToList(test);
            }
        }

        /// <summary>
        /// Срабатывает при нажатии пункта "Запустить"
        /// Открывает форму тестирования задачи (StartTask)
        /// </summary>
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StartTask((TestTask)listTests.SelectedItems[0].Tag).Show();
        }

        /// <summary> Добавляет задачу на форму (в список) </summary>
        private void addTaskToList(TestTask test)
        {
            ListViewItem lvi = new ListViewItem(test.Name);
            lvi.SubItems.Add(test.Language);
            lvi.SubItems.Add(test.Date);
            lvi.Tag = test;
            listTests.Items.Add(lvi);
        }
    }
}
