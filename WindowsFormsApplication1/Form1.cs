using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string fName;
       
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;        //支持多文件选择
            openFileDialog.InitialDirectory = "c:\\"; //默认路径 c:\\而不是c:\
            openFileDialog.Filter = "CSV文件|*.csv";  //
            openFileDialog.RestoreDirectory = true;  
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                fName = openFileDialog.FileName;

                foreach (string s in openFileDialog.FileNames)
                {
                    var column1 = new List<string>();
                    var column2 = new List<string>();
                    var column3 = new List<string>();
                    using (var rd = new StreamReader(s))
                    {
                        while (!rd.EndOfStream)
                        {
                            var splits = rd.ReadLine().Split(';');
                            column1.Add(splits[0]);
                            column2.Add(splits[1]);
                            column3.Add(splits[2]);
                        }
                    }
                    // print column1
                    Console.WriteLine("Column 1:");
                    foreach (var element in column1)
                        Console.WriteLine(element);

                    // print column2
                    Console.WriteLine("Column 2:");
                    foreach (var element in column2)
                        Console.WriteLine(element);

                    // print column3
                    Console.WriteLine("Column 3:");
                    foreach (var element in column3)
                        Console.WriteLine(element);
                }
           
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

    }
}
