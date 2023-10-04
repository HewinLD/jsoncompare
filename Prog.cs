using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Bra
{
    public partial class Prog : Form
    {
        public string 文件1,文件2;
        IEnumerable<JProperty> json1 = new JObject().Properties();
        IEnumerable<JProperty> json2 = new JObject().Properties();
        public Prog()
        {
            InitializeComponent();
        }
        private void Json1_Click(object sender, EventArgs e)
        {
            try
            {
            json1 = ReadJson(out string 文1);
            文件1 = 文1;
            if(文件1!=null)
            Json1.Text = 文件1;
            }
            catch { }
        }

        private void Json2_Click(object sender, EventArgs e)
        {
            try
            {
                json2 = ReadJson(out string 文2);
                文件2 = 文2;
                if (文件2 != null)
                    Json2.Text = 文件2;
            }
            catch { }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (json1.Any()&&json2.Any())
            {
                List<string> strList = new List<string>();
                Json.Items.Clear();
                textBox1.Text = string.Empty;
                foreach (JProperty JP in json2)
                {
                    if (!namefind(JP.Name, json1))
                    {
                        strList.Add( JP.Name + "               " + 文件1 + " 中不存在该条目");                       
                        Addlist(JP.Name, " "+文件1+" 中不存在该条目");
                    }
                }
                foreach (JProperty JP in json1)
                {
                    if(!namefind(JP.Name,json2))
                    {
                        strList.Add(JP.Name + "               " + 文件2 + " 中不存在该条目");
                        Addlist(JP.Name, " " + 文件2 + " 中不存在该条目");
                    }
                }
                textBox1.Lines = strList.ToArray();
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            Json.Items.Clear();
            textBox1.Text = null;
        }
        void Addlist(string name, string Error)
        {
            ListViewItem item = new ListViewItem();
            item.Text = (Json.Items.Count + 1).ToString();
            item.SubItems.Add(name);
            item.SubItems.Add(Error);
            Json.Items.Add(item);
        }
        IEnumerable<JProperty> ReadJson(out string wjm)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "(*.json)|*.json";
            if(file.ShowDialog() == DialogResult.OK)
            {
                wjm = Path.GetFileName(file.FileName);
                return JObject.Parse(File.ReadAllText(file.FileName)).Properties();
            }
            wjm = null;
            return null;
        }
        bool namefind(string name,IEnumerable<JProperty> json)
        {
            foreach(JProperty JP in json)
            {
                if (JP.Name == name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
