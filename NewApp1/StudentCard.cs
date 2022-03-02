using System;
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
    public partial class StudentCard : Form
    {
        public StudentCard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Изображение (*.JPG;*PNG;*.BMP;*GIF)|*.JPG;*PNG;*.BMP;*GIF| Все файлы (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно загрузить выбранное изображение", "Ошибка", MessageBoxButtons.OK);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            
            Close();
        }
    }
}
