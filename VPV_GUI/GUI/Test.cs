using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPV_GUI
{
    /// <summary>
    /// Форма создания новой задачи
    /// </summary>
    public partial class Task : Form
    {
        // Данные задачи
        private TestTask result;

        public Task()
        {
            InitializeComponent();
        }

        /// <summary> Событие выбора исходного файла </summary>
        private void buttonSource_Click(object sender, EventArgs e)
        {
            openSource.ShowDialog();
            editSourcePath.Text = openSource.FileName;
        }

        /// <summary> Событие выбора файла с входными данными</summary>
        private void buttonInput_Click(object sender, EventArgs e)
        {
            openInput.ShowDialog();
            editInputPath.Text = openInput.FileName;
        }

        /// <summary> Подтверждение создания задачи </summary>
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            result = new TestTask();
            result.Source = editSourcePath.Text;
            result.Input = editInputPath.Text;
            result.Name = editName.Text;
            result.Language = "С/С++";
            Close();
        }

        /// <summary> Возращает созданную задачу </summary>
        public TestTask getTest()
        {
            return result;
        }
    }
}
