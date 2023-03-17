using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Практика_11_12
{
    public partial class Student_work : Form
    {
        public Student_work()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = Error(textBox1.Text);
            string error = name;
            if (error == "")
            {
                Student stud = new Student();
                stud.name = textBox1.Text;
                stud.rost = (int)numericUpDown1.Value;
                stud.ves = (int)numericUpDown2.Value;
                stud.eda = (int)numericUpDown3.Value;
                MessageBox.Show(string.Format("Студент: {0} \nрост: {1} \nвес: {2}", stud.name, stud.rost, stud.GetEat()));
                stud.SetEat(stud.eda); MessageBox.Show(string.Format("Студент: {0} \nСъел {3} кг\nрост: {1} \nвес: {2}", stud.name, stud.rost, stud.GetEat(), stud.eda));
                listBox1.Items.Add(textBox1.Text);
            }
            else
                MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string Error(string text)
        {
            string message = "";
            string name = textBox1.Text;
            if (name == "") message = message + "Поле имя пустое\n";
            if (listBox1.Items.Contains(textBox1.Text))
                message = message + "Такой студент уже есть\n";
            return message;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
