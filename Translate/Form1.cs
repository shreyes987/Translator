using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Translate
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Translate
        {
            public int code { get; set; }
            public string lang { get; set; }
            public List<String> text { get; set; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (var wb = new WebClient())
            {
                
        var data = new NameValueCollection();
                if (comboBox1.Text == "Swedish")
                {
                    if (textBox1.Text != "")
                    {
                        data["text"] = textBox1.Text;
                        data["lang"] = "sv";
                        data["key"] = "API KEY COMES HERE";
                        var response = wb.UploadValues("https://translate.yandex.net/api/v1.5/tr.json/translate", "POST", data);
                        string responsestring = Encoding.UTF8.GetString(response);
                        var rootObj = JsonConvert.DeserializeObject<Translate>(responsestring);
                        textBox2.Text = rootObj.text[0];
                    }
                    else
                    {
                        textBox1.Text = "";
                    }
                }
                
                if (comboBox1.Text == "German")
                {
                    if (textBox1.Text != "")
                    {
                        data["text"] = textBox1.Text;
                        data["lang"] = "de";
                        data["key"] = "API KEY COMES HERE";
                        var response = wb.UploadValues("https://translate.yandex.net/api/v1.5/tr.json/translate", "POST", data);
                        string responsestring = Encoding.UTF8.GetString(response);
                        var rootObj = JsonConvert.DeserializeObject<Translate>(responsestring);
                        textBox2.Text = rootObj.text[0];
                    }
                    else
                    {
                        textBox1.Text = "";
                    }
                }
                
                if (comboBox1.Text == "Hindi")
                {
                    if (textBox1.Text != "")
                    {
                        data["text"] = textBox1.Text;
                        data["lang"] = "hi";
                        data["key"] = "API KEY COMES HERE";
                        var response = wb.UploadValues("https://translate.yandex.net/api/v1.5/tr.json/translate", "POST", data);
                        string responsestring = Encoding.UTF8.GetString(response);
                        var rootObj = JsonConvert.DeserializeObject<Translate>(responsestring);
                        textBox2.Text = rootObj.text[0];
                    }
                    else
                    {
                        textBox1.Text = "";
                    }
                }
                
                if (comboBox1.Text == "Marathi")
                {
                    if (textBox1.Text != "")
                    {
                        data["text"] = textBox1.Text;
                        data["lang"] = "mr";
                        data["key"] = "API KEY COMES HERE";
                        var response = wb.UploadValues("https://translate.yandex.net/api/v1.5/tr.json/translate", "POST", data);
                        string responsestring = Encoding.UTF8.GetString(response);
                        var rootObj = JsonConvert.DeserializeObject<Translate>(responsestring);
                        textBox2.Text = rootObj.text[0];
                    }
                    else
                    {
                        textBox1.Text = "";
                    }
                }
                
            }
        }
        public void Clear()
        {
            textBox1.Text = textBox2.Text  = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
