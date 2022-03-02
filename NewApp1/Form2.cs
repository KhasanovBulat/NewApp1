using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

namespace NewApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
                string path_121 = $"{Environment.CurrentDirectory}\\09-121.txt";
                string path_122 = $"{Environment.CurrentDirectory}\\09-122.txt";

            switch ((e.Node.Name))
                {
                    case "09-121":
                    dataGridView1.Rows.Clear();
                    StreamReader reader = new StreamReader(path_121);
                        string rows = reader.ReadLine();
                        while (rows != null)
                        {
                            string[] studentinfo = rows.Split(' ');
                            dataGridView1.Rows.Add(studentinfo);
                            rows = reader.ReadLine();
                        }
                    break;
                case "09-122":
                    dataGridView1.Rows.Clear();
                    StreamReader reader1 = new StreamReader(path_122);
                    string rows1 = reader1.ReadLine();
                    while (rows1 != null)
                    {
                        string[] studentinfo = rows1.Split(' ');
                        dataGridView1.Rows.Add(studentinfo);
                        rows1 = reader1.ReadLine();
                    }
                    break;
            }



                

            }

        private void MoreInfo_Click(object sender, EventArgs e)
        {
            StudentCard student = new StudentCard();
            student.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentCard student_card = new StudentCard();
            student_card.textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            student_card.textBox2.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            student_card.textBox3.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            student_card.ShowDialog();
        }
    }
}
