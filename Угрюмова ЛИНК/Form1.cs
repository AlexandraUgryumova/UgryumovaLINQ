using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace Угрюмова_ЛИНК
{
    public partial class Form1 : Form
    {
        List<Department> department = new List<Department>();
        List<People> people = new List<People>();
        List<Employ> employ = new List<Employ>();
        public Form1()
        {
            InitializeComponent();
            string[] peoples = File.ReadAllLines("Depart.txt");
            foreach (string i in peoples)
            {
                string[] infoPerson = i.Split(' ');
                people.Add(new People(infoPerson[0], infoPerson[1], infoPerson[2], int.Parse(infoPerson[3]), double.Parse(infoPerson[4])));
            }
            department.Add(new Department("Отдел закупок", "Германия"));
            department.Add(new Department("Отдел продаж", "Испания"));
            department.Add(new Department("Отдел маркетинга", "Испания"));
            employ.Add(new Employ("Иванов", "Отдел закупок"));
            employ.Add(new Employ("Петров", "Отдел закупок"));
            employ.Add(new Employ("Сидоров", "Отдел продаж"));
            employ.Add(new Employ("Лямин", " Отдел продаж"));
            employ.Add(new Employ("Сидоренко", "Отдел маркетинга"));
            employ.Add(new Employ("Кривоносов", "Отдел продаж"));
            foreach(People i in people)
            {
                listBox1.Items.Add(i.Info());
            }
            var result = from i in employ
                         join j in department on i.Department equals j.Name
                         select new { Name = i.Name, depart = j.Name, country = j.Reg };
            foreach(var i in result)
            {
                listBox2.Items.Add(i);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var ages = from i in people
                       where i.Age < 40
                       select i;
            foreach(People i in ages)
            {
                listBox1.Items.Add(i.Info());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            var result = from i in employ
                         join j in department on i.Department equals j.Name
                         where j.Reg.Contains("И")
                         select new { Name = i.Name, depart = j.Name, country = j.Reg };
            foreach (var i in result)
            {
                listBox2.Items.Add(i);
            }
        }
    }
}
