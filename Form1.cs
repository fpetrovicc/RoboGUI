using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace RoboGUI
{
    public partial class robogui : Form
    {
        private String[] _ports;
        private SerialPort _port;

        private const int baudRate = 9600;

        private bool _isConnected; // connection to the Arduino

        public robogui()
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
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!_isConnected)
            {
                InitArduino();

                startButton.Enabled = false;
                stopButton.Enabled = true;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (_isConnected)
            {
                StopArduino();

                startButton.Enabled = true;
                stopButton.Enabled = false;
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
                sendComButton.PerformClick();
                comTextBox.Text = "";
            }
        }

        private void InitArduino()
        {
            _isConnected = true;

            string sel = portSelector.GetItemText(portSelector.SelectedItem);
            _port = new SerialPort(sel, baudRate, Parity.None, 8, StopBits.One);

            _port.Open();

            EnableControls();
        }

        private void StopArduino()
        {
            _isConnected = false;

            _port.Close();
        }

        private void GetAvailablePorts()
        {
            _ports = SerialPort.GetPortNames();
        }

        private void EnableControls()
        {
            // TO-DO - dodati ostale opcije uz novu dugmad
        }

        private void DisableControls()
        {
            stopButton.Enabled = false;
        }

        
    }
}