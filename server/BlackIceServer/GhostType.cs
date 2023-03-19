using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackIceServer
{
    public partial class GhostType : Form
    {
        private string m_Code = string.Empty;
        private int m_ShowLength = 0;

        public GhostType(string Message)
        {
            this.ShowInTaskbar = false;
            this.Focus();
            this.TopMost = true;
            this.BringToFront();
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            if (Message.StartsWith("BlackIceServer.Resources."))
                SketchGhost(Message);
            else
                WriteGhost(Message);
        }

        private async void WriteGhost(string Message)
        {
            m_Code = Message;
            while (m_ShowLength < m_Code.Length)
            {
                Random rnd = new Random();
                int space = rnd.Next(20, 35); // Creates a random between 5 and 15
                if (m_ShowLength + space < m_Code.Length)
                    m_ShowLength += space;
                else
                    m_ShowLength = m_Code.Length;

                await Task.Delay(150);
                ghostBox.Text = m_Code.Substring(0, m_ShowLength);
                ghostBox.SelectionStart = ghostBox.Text.Length;
                ghostBox.ScrollToCaret();
            }
            await Task.Delay(2000);
            this.Close();
        }

        private async void SketchGhost(string ImagePath)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            string line;
            // Read category
            using (Stream stream = assembly.GetManifestResourceStream(ImagePath))
            using (StreamReader reader = new StreamReader(stream))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    m_Code += line + "\r\n";
                }

                ghostBox.ForeColor = System.Drawing.Color.Black;
                ghostBox.BackColor = System.Drawing.Color.White;
                ghostBox.Text = m_Code;
                ghostBox.SelectionStart = ghostBox.Text.Length;
                ghostBox.ScrollToCaret();

            }
            await Task.Delay(4000);
            this.Close();
        }
    }
}
