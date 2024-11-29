using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormMethod
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //txt_result.Text = Triangle(5);
            //txt_result.Text = Triangle("A", 9);
            //txt_result.Text = Triangle("B");
            txt_result.Text = Triangle("R");
        }

        string Triangle(int size)
        {
            string txt_result = "";
            for (int i = 0; i <size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    txt_result += "*";
                }
                txt_result += Environment.NewLine;
            }
            return txt_result;
        }
        string Triangle(string letter, int size=5)
        {
            string txt_result = "";
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    txt_result += letter;
                }
                txt_result += Environment.NewLine;
            }
            return txt_result;
        }
        //string Triangle(string letter)
        //{
        //    string txt_result = "";
        //    for (int i = 0; i < 5; i++)
        //    {
        //        for (int j = 0; j < i; j++)
        //        {
        //            txt_result += letter;
        //        }
        //        txt_result += Environment.NewLine;
        //    }
        //    return txt_result;
        //}
        string Triangle()
        {
            string txt_result = "";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    txt_result += "*";
                }
                txt_result += Environment.NewLine;
            }
            return txt_result;
        }
    }
}
