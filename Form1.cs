using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
            textBox2.ForeColor = Color.Red;
            textBox1.Text = "Введите минимальное значение придела генерации";
            textBox2.Text = "Введите максимальное значение придела генерации";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox00.Clear();
            dataGridView1.RowCount = 15;
            dataGridView1.ColumnCount = 15;
            int[,] A = new int[15, 15];
            int i, j;
            Random rand = new Random();
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            for (i=0; i<15; i++)
            {
                for(j=0; j<15; j++)
                {
                    A[i, j] = rand.Next(x, y);
                }
            }
            for(i=0; i<15; i++)
            {
                for(j=0;j<15;j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = A[i, j].ToString();
                }
            }
            int n=0;
            int max = A [0, 0];
            for (i = 0; i < 15; i++)
            {
                    if (A[i,i] > max)
                    {
                        max = A[i, i];
                        n = i;
                        
                    }
            }
            textBox0.Text=Convert.ToString(max);
            for( i=0; i<15; i++)
            {
                int m = A[n, i];
                textBox00.Text += m.ToString()+"; ";
            }
            textBox3.Text = Convert.ToString(n);
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Size = new Size(100, 20);
            textBox1.ForeColor = Color.Black;
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.Size = new Size(100, 20);
            textBox2.ForeColor = Color.Black;
        }
        private void условиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Найти наибольший элеиент главной диагонали матрицы A(15,15) и вывести всю строку в которой он находится");
        }
    }
}