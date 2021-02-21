using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace Scripting_FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Button to connect the Arduino to the C# IDE via a Port.
        private void connectButton_Click(object sender, EventArgs e)
        {
            Init();
        }

        private SerialPort myPort;
        // Port to open up Arduino so that C# and Arduino can exchange data.
        bool connectCheck = false;

        // Init Method allows the Arduino to connect to the C# IDE to exchange values.
        private void Init()
        {
            try
            {
                if (connectCheck == false)
                {
                    // Connection to Arduino is Established here.
                    myPort = new SerialPort();
                    myPort.BaudRate = 9600;
                    myPort.PortName = "COM" + comboBox2.Text + ""; // modify to your local COM
                    myPort.RtsEnable = true;
                    connectCheck = true;
                    myPort.Open();
                    myPort.DataReceived += myPort_DataReceived; // call method
                    MessageBox.Show("Connection Established");
                }
                // If the Arduino is already connected then this message appeard on button click.
                else if (connectCheck == true)
                {
                    MessageBox.Show("Already Connected");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Not connected");
                connectCheck = false;
            }
        }

        //Red Light Toggle Functionality.


        bool redLED = true;
        private void lightRedButton_Click(object sender, EventArgs e)
        {

            if (redLED)
            {
                myPort.WriteLine("100");
                redLED = false;
            }
            else
            {
                myPort.WriteLine("101");
                redLED = true;
            }

        }
        // Allows the Data from the Arduino to be manipulated by c#
        private void myPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string line = myPort.ReadLine(); // read data from Arduino
            BeginInvoke(new LineReceivedEvent(LineReceived), line);
        }
        private delegate void LineReceivedEvent(string line);

        private void LineReceived(string line)
        {

            try
            {
                // A sync function Method ---- await Task


                //Clears text boxes to accept new values.
                tempOutTB.Clear();
                tempInTB.Clear();
                humTB.Clear();
                String[] data = line.Split(',');// Array to seperate and print out data into text boxes.

                // Takes the data from the arduino and puts them into text boxes.
                tempOutTB.Text = data[0];
                tempInTB.Text = data[1];
                humTB.Text = data[2];

                
            }
            catch (IndexOutOfRangeException)
            {

            }

        }

        // Max Temp button. Sends the contents of the drop down box to the Arduino.

        private void maxTempButton_Click(object sender, EventArgs e)
        {
            myPort.WriteLine(comboBox1.Text);
        }
    }
}
