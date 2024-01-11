using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppListCreater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;

            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            listBox1.Items.AddRange(fileName);
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void buttonClearSelected_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void buttonWriteList_Click(object sender, EventArgs e)
        {
            const string sPath = "dir_list.txt";

            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            foreach (var item in listBox1.Items)
            {
                SaveFile.WriteLine(item);
            }

            SaveFile.Close();

            this.Text = "Dir List Creator : dir_list.txtに保存しました";
            //MessageBox.Show("Programs saved!");
        }
    }
}
