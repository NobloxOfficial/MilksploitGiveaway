using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Guna;

namespace Milksploit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initially set the button color to red (Roblox not open)
            guna2CircleButton1.FillColor = Color.Red;
            CheckRobloxStatus();  // Check if Roblox is open when the form loads
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fullscreen system not integrated!");
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.ExecuteScript(Editor.Text);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Editor.Clear();
        }

        private void KillRoblox_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.KillRoblox();
        }

        private void Inject_Click(object sender, EventArgs e)
        {
            // Perform injection
            ForlornApi.Api.Inject();
            CheckRobloxStatus();  // Check if Roblox is open after injection
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            // Add any additional functionality for the button click if needed
        }

        private void CheckRobloxStatus()
        {
            // Check if any Roblox processes are running
            bool isRobloxRunning = false;

            // Get all processes running by name "Roblox"
            Process[] processes = Process.GetProcessesByName("RobloxPlayerBeta");

            if (processes.Length > 0)
            {
                // If there are any processes, Roblox is open
                isRobloxRunning = true;
            }

            // Change the button color based on whether Roblox is running or not
            if (isRobloxRunning)
            {
                guna2CircleButton1.FillColor = Color.LightGreen;  // Roblox is open
            }
            else
            {
                guna2CircleButton1.FillColor = Color.Red;    // Roblox is not open
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            settingsForm.Show();
        }
    }
}
