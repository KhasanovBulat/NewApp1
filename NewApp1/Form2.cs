using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        //{
        //    string path = $"{Environment.CurrentDirectory}\\09-121.txt";
        //    StreamReader reader = new StreamReader(path);
        //    string[] data = reader.ReadToEnd().Split(' ');
        //    int i;
        //    string[] names;// массив имен из прочитанного файла
        //    string[] surnames; // массив фамилий из прочитанного файла
        //    for (i = 0; i < data.Length; i++)
        //    {
        //        dataGridView1.Rows.Add(names[i], surnames[i],09-121);
        //    }

        //}

        private void button1_Click(object sender, EventArgs e)
        {
            StudentCard studentCard = new StudentCard();
            studentCard.Show();
        }
    }
}
