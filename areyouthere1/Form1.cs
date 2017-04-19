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

            //set the string 'url' to the value of the urltetinput value
            url = urltestinput.Text;

            //if the string 'url' is not null then run this
            if (url !=null)
            {
                responsebox.Text = url; //url is displayed in responsebox
                statustextbox.Text = "P00001";
                Console.WriteLine("P00001" + " " + url); //url is displayed in console

            }
            //if the string 'url' is null then run thi
            else
            {
                responsebox.Text = "Nothing Selected";
                statustextbox.Text = "E00001";
                Console.WriteLine("E00001" + " " + "Nothing Selected");
            }
        }
    }
}
