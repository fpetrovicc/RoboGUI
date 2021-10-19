using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace RoboGUI
{
    public partial class Robogui : Form
    {
        private String[] _ports;
        private SerialPort _port;

        private const int BaudRate = 9600;

        private bool _isConnected; // connection to the Arduino

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

            startButton.Click += startButton_Click;
            stopButton.Click += stopButton_Click;
            sendComButton.Click += sendComButton_Click;
            comTextBox.KeyDown += comTextBox_KeyDown;

            letterA.Click += LetterClicks;
            letterB.Click += LetterClicks;
            letterC.Click += LetterClicks;
            letterD.Click += LetterClicks;
            letterE.Click += LetterClicks;
            
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
            switch ((sender as Button)?.Name)
            {
                case "letterA":
                    _port.Write("a");
                    break;
                case "letterB":
                    _port.Write("b");
                    break;
                case "letterC":
                    _port.Write("c");
                    break;
                case "letterD":
                    _port.Write("d");
                    break;
                case "letterE":
                    _port.Write("e");
                    break;
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
            sendComButton.Enabled = true;
            letterA.Enabled = true;
            letterB.Enabled = true;
            letterC.Enabled = true;
            letterD.Enabled = true;
            letterE.Enabled = true;
        }

        private void DisableControls()
        {
            stopButton.Enabled = false;
            sendComButton.Enabled = false;
            letterA.Enabled = false;
            letterB.Enabled = false;
            letterC.Enabled = false;
            letterD.Enabled = false;
            letterE.Enabled = false;
        }
    }
}