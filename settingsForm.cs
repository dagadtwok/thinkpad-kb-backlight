using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Windows.Input;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace thinkpad_kb
{
    public partial class settingsForm : Form
    {
        keyboardManager kbMg = new keyboardManager();
        GlobalKeyboardHook kbHook = new GlobalKeyboardHook();
        System.Timers.Timer turnOffTimer = new System.Timers.Timer(10000);
        int dimLevel = 0;
        int currentLevel = 0;

        String[] KeyboardModes = {
            "Off",
            "Dim",
            "Bright"
        };

        public settingsForm()
        {
            InitializeComponent();
            notifyIcon1.Visible = false;
            //kbHook.KeyboardPressed += kbPress;
            foreach (var item in KeyboardModes)
            {
                kbAutoDimLevel.Items.Add(item);
                kbAutoLightLevel.Items.Add(item);
            }
            kbAutoDimLevel.SelectedIndex = 0;
            kbAutoLightLevel.SelectedIndex = 1;
            kbAutoDimTime.Value = 1;
        }

        private void turnOffEvent(object sender, GlobalKeyboardHookEventArgs e) {
            turnOffTimer = new System.Timers.Timer(((double)kbAutoDimTime.Value)*1000);
            if (!turnOffTimer.Enabled) {
                turnOffTimer.Elapsed += turnOffTimerTick;
                turnOffTimer.Start();
            }
        }

        private void turnOnEvent(object sender, GlobalKeyboardHookEventArgs e)
        {
            if (kbMg.getKbLight() != kbAutoLightLevel.SelectedIndex) { 
                kbMg.setKbLight(kbAutoLightLevel.SelectedIndex);
            }
            if (turnOffTimer.Enabled) { 
                turnOffTimer.Stop();
            }
        }

        private void turnOffTimerTick(object sender, ElapsedEventArgs e) {
            kbMg.setKbLight(dimLevel);
            turnOffTimer.Stop();
            ((System.Timers.Timer)sender).Stop();
        }

        private void kbAutoDim_CheckedChanged(object sender, EventArgs e)
        {
            if (kbAutoDim.Checked)
            {
                kbHook.KeyboardPressed += turnOffEvent;
            }
            else
            {
                kbHook.KeyboardPressed -= turnOffEvent;
            }
        }

        private void kbAutoDimLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            dimLevel = kbAutoDimLevel.SelectedIndex;
        }

        private void kbAutoLight_CheckedChanged(object sender, EventArgs e)
        {
            if (kbAutoLight.Checked)
            {
                kbHook.KeyboardPressed += turnOnEvent;
            }
            else
            {
                kbHook.KeyboardPressed -= turnOnEvent;
            }
        }

        private void settingsForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }
    }
}
