using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace areyouthere1
{
    public partial class urlping : Form
    {
        

        public urlping()
        {
            InitializeComponent();
        }

        private void clearallbutton_Click(object sender, EventArgs e)
        {
            urltestinput.Clear();
            responsebox.Clear();
            statustextbox.Clear();
        }

        private void quitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void testbutton_Click(object sender, EventArgs e)
        {
            //declerations
            string url;
            string content;
            string stCode;
            string stResponse;

            //set the string 'url' to the value of the urltetinput value
            url = urltestinput.Text;

            //Check the lenght of the string 'url'. If this returns <=0 then the string is empty, This code is then run.
            if (url.Length <=0)
            {
                urltestinput.Text = "Please enter a website to check";
                responsebox.Text = "Nothing Selected";
                statustextbox.Text = "E00001";
                Console.WriteLine("$output > " + "E00001" + " --> " + urltestinput.Text +  " --> " + responsebox.Text);
            }
            //if the string 'url' is not null then run this
            else
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";

                HttpStatusCode statusCode;
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    var contentType = response.ContentType;
                    Encoding encoding = null;

                    if (contentType != null)
                    {
                        var match = Regex.Match(contentType, @"(?<=charset\=).*");
                        if (match.Success)
                            encoding = Encoding.GetEncoding(match.ToString());
                    }

                    encoding = encoding ?? Encoding.UTF8;

                    statusCode = ((HttpWebResponse)response).StatusCode;

                    using (var reader = new StreamReader(stream, encoding))
                        content = reader.ReadToEnd();

                    stResponse = content;
                    stCode = statusCode.ToString();

                    statustextbox.Text = stCode;
                    responsebox.Text = stResponse;
                }

            }
        }
    }
}