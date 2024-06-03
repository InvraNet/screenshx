using System;
using System.IO;
using System.Windows.Forms;

namespace screenshx
{
    public partial class Form1 : Form
    {
        string boxName;
        string boxLocation;
        string boxVersion;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            boxStatus.Text = "Loading...";
            LoadConfiguration();
            GiveCode();
        }

        private void LoadConfiguration()
        {
            string configFilePath = "config.shxc";
            try
            {
                if (File.Exists(configFilePath))
                {
                    string[] lines = File.ReadAllLines(configFilePath);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('=');
                        if (parts.Length == 2)
                        {
                            string key = parts[0].Trim();
                            string value = parts[1].Trim();
                            ApplyConfiguration(key, value);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Configuration file not found!");
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading configuration: " + ex.Message);
            }
        }

        private void ApplyConfiguration(string key, string value)
        {
            switch (key)
            {
                case "boxName":
                    boxName = value;
                    break;
                case "roomName":
                    boxLocation = value ;
                    break;
            }
            boxInfo.Text = boxName + " - " + boxLocation;
        }
        private void GiveCode()
        {
            Random random = new Random();
            int randomNumber = random.Next(1000, 10000);
            roomCode.Text = randomNumber.ToString();
            roomCode.Show();
        }
    }
}
