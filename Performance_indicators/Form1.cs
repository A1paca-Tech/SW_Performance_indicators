using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Performance_indicators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb_show.Text = "";
            tb_name.Text = "input1.txt";
        }

        private void bt_run_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs_file = new FileStream(tb_name.Text, FileMode.Open, FileAccess.Read);
                StreamReader fs_reader = new StreamReader(fs_file);
                string f_read = fs_reader.ReadToEnd();  //read all line
                string my_read = f_read.Split('\n')[1]; //抓取第二行
                string[] my_result = my_read.Split(' '); //空格間格 to array
                my_result = bubble_sort(my_result);       //泡沫排序
                lb_show.Text = "";
                
                foreach (var my_string in my_result)
                {
                    lb_show.Text += my_string + ", ";
                }
                lb_show.Text = lb_show.Text.Substring(0, lb_show.Text.Length - 2) + "\r\n";

                my_result = my_hl_s(my_result);
                switch (my_result[2])
                {
                    case "0":   //最低及格my_result[0];   最高不及格my_result[1]
                        lb_show.Text += "最高不及格分數：" + my_result[1] + "\r\n最低及格分數：" + my_result[0];
                        break;

                    case "-1":  //全部不及格
                        lb_show.Text += "最高不及格分數：" + my_result[1] + "\r\n" + "最低及格分數：無\r\n笑死，全班不及格";
                        break;

                    case "-2":  //全部及格
                        lb_show.Text += "最高不及格分數：無\r\n" + "最低及格分數：" + my_result[0]+"\r\n很棒喔，居然都及格了";
                        break;

                    default:
                        break;
                }



            }
            catch { MessageBox.Show("Error!", "Error!"); }
        }

        string[] bubble_sort(string[] my_result)
        {
            int arr_len = my_result.Length;
            int i, j, temp;
            int[] my_result_i = Array.ConvertAll<string, Int32>(my_result, value => Int32.Parse(value));    //轉換array字串自int
            
            for (i=0; i<(arr_len - 1); i++)
            {
                for (j=0; j<(arr_len - 1-i); j++)
                {
                    if (my_result_i[j] > my_result_i[j + 1])
                    {
                        temp = my_result_i[j]; my_result_i[j] = my_result_i[j + 1]; my_result_i[j + 1] = temp;
                    }
                }
            }
            my_result = Array.ConvertAll<Int32, string>(my_result_i, value => value.ToString());    //轉換array數字自string
            return my_result;
        }/**/

        string[] my_hl_s(string[] my_result)
        {
            int arr_len = my_result.Length;
            int[] my_result_i = Array.ConvertAll<string, Int32>(my_result, value => Int32.Parse(value));    //轉換array字串自int
            int[] owo = new int[3] { -1, -1, 0}; //一個用於存放return值的廢物容器OuO     owo[0]=最低及格; owo[1]=最高不及格;  owo[2]=例外;

            for (int i=0; i<arr_len; i++)
            {
                if(my_result_i[(arr_len-1-i)] >= 60) { owo[0] = my_result_i[(arr_len - 1 - i)]; }   //最低及格
                if (my_result_i[i] < 60) { owo[1] = my_result_i[i]; }                               //最高不及格
            }
            

            if(owo[0] == -1) { owo[2] = -1; /*全部不及格*/}
            if (owo[1] == -1) { owo[2] = -2; /*全部及格*/}
            /* owo[2]=0 */

            my_result = Array.ConvertAll<Int32, string>(owo, value => value.ToString());    //轉換array字串自int
            return my_result;
        }
    }
}
