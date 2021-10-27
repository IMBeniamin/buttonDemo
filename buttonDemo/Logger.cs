using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttonDemo
{
    public partial class Logger : Form
    {
        public Logger()
        {
            InitializeComponent();
        }

        public void Log(string data)
        {
            var ending = "";
            if (!(data.Last() == '\n')) ending = "\r\n"; 
            this.log.AppendText($"({DateTime.Now.ToString("HH:mm:ss:ffffff")}): {data}{ending}");
        }

        private void Logger_Load(object sender, EventArgs e)
        {
            this.log.AppendText("Logger inizializzato!\r\n");
        }
    }
}
