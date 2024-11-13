using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchRenamer
{
    public partial class FindAndReplace : Form
    {
        public FindAndReplace(string[] storage)
        {
            InitializeComponent();
            this.storage = storage;
        }

        private string[] ReturnResult()
        {
            return result;
        }

        public string[] result { get; set; }
        public string[] storage { get; set; }

        private void zastąp_Click(object sender, EventArgs e)
        {
            //check if textbox with searching and find string is not empty
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                result = new string[storage.Length];
                Array.Copy(storage, result, storage.Length);
                List<string> list = new List<string>();
                list = CheckString(textBox1.Text,list);
                list.OrderByDescending(s => s.Length);
                //Loop through every filename
                for (int i = 0; i < result.Length; i++)
                {
                    foreach (string s in list) 
                    {
                        if (result[i].Contains(s))
                        {
                            if (textBox2.Text != "")
                            {
                                result[i] = result[i].Replace(s, textBox2.Text);
                            }
                            else
                            {
                                result[i] = result[i].Replace(s, "");
                            }
                        }
                    }
                }
                ReturnResult();
                Close();
            }
            else
            {
                MessageBox.Show("Proszę wypełnić pierwsze pole");
            }
        }
        private static List<string> CheckString(string s, List<string> result)
        {
            int i = s.IndexOf(";");
            if (i == -1)
            {
                result.Add(s);
                return result;
            }
            else
            {
                string d = s.Substring(0, i);
                int length = s.Length - i;
                string e = s.Substring(d.Length + 1, length - 1);
                result.Add(d);
                return CheckString(e, result);
            }
        }
        private void textBox1_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
