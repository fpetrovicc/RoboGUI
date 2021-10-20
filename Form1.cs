using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace RoboGUI
{
    public partial class Robogui : Form
    {
        private string[] _ports;
        private SerialPort _port;

        private const int BaudRate = 9600;
        private bool _isConnected; // connection to the Arduino
        
        private readonly String[] _letters =
        {
            "letterA", "letterB", "letterC", "letterD", "letterE",
            "letterF", "letterG", "letterH", "letteri", "letterJ",
            "letterK", "letterL", "letterM", "letterN", "letterO",
            "letterP", "letterQ", "letterS", "letterT", "letterU", 
            "letterV", "letterW", "letterX", "letterY", "letterZ"
        };

        private static readonly char[] Alpha = "abcdefghijklmnopqstuvwxyz".ToCharArray();
        
        public Robogui()
        {
            InitializeComponent();
            DisableControls(); // disabling controls for better UI
            GetAvailablePorts(); // getting available ports from system

            foreach (string port in _ports)
            {
                portSelector.Items.Add(port);
                if (_ports[0] != null)
                {
                    portSelector.SelectedItem = _ports[0];
                }
            }
            
            stopButton.Click += stopButton_Click;
            startButton.Click += startButton_Click;
            comTextBox.KeyDown += comTextBox_KeyDown;
            sendComButton.Click += sendComButton_Click;
            
            foreach (Control c in groupBox3.Controls)
            {
                c.Click += LetterClicks;
            }
            
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!_isConnected)
            {
                InitArduino();

                startButton.Enabled = false;
                stopButton.Enabled = true;
                
                EnableControls();
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (_isConnected)
            {
                StopArduino();

                startButton.Enabled = true;
                stopButton.Enabled = false;
                
                DisableControls();
            }
        }

        private void sendComButton_Click(object sender, EventArgs e)
        {
            if (_isConnected)
            {
                _port.Write(comTextBox.Text);
            }
        }

        private void comTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                sendComButton.PerformClick();
                comTextBox.Text = "";
            }
        }
        
        private void LetterClicks(object sender, EventArgs e)
        {
            for (int j = 0; j < _letters.Length; j++)
            {
                if (Equals((sender as Button)?.Name, _letters[j]))
                {
                    _port.Write(Alpha[j].ToString());
                }
            }
        }
        
        private void InitArduino()
        {
            _isConnected = true;

            string sel = portSelector.GetItemText(portSelector.SelectedItem);
            _port = new SerialPort(sel, BaudRate, Parity.None, 8, StopBits.One);

            _port.Open();

            EnableControls();
        }

        private void StopArduino()
        {
            _port.Write("@");
            
            _isConnected = false;
            _port.Close();
        }

        private void GetAvailablePorts()
        {
            _ports = SerialPort.GetPortNames();
        }

        private void EnableControls()
        {
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
        }

        private void DisableControls()
        {
            stopButton.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
        }
    }
}