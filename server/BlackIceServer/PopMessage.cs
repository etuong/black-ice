using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackIceServer
{
    public partial class PopMessage : Form
    {
        public PopMessage(string Message)
        {
            this.ShowInTaskbar = false;
            this.Focus();
            this.TopMost = true;
            this.BringToFront();
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            this.Message.Text = Message;
            Blink();
        }

        private async void Blink()
        {
            // Fade In
            for (int i = 0; i < 200; i += 5)
            {
                this.Opacity = (double)i / 100.00;
                await Task.Delay(100);
            }

            // Fade Out
            for (int i = 100; i > 0; i -= 5)
            {
                this.Opacity = Convert.ToDouble((double)i / 100.00);
                await Task.Delay(100);
            }
            this.Close();
        }
    }
}
