/*
 * Copyright 2018 Walter de Jong <walter@heiho.net>

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:

1. Redistributions of source code must retain the above copyright notice,
   this list of conditions and the following disclaimer.

2. Redistributions in binary form must reproduce the above copyright notice,
   this list of conditions and the following disclaimer in the documentation
   and/or other materials provided with the distribution.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO,
THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER
OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL,
EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO,
PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA,
OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF
LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE,
EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/

using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace doomlauncher
{
    public partial class main_window : Form
    {
        private Form about_window = null;

        public main_window()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ExePath_textbox.Text = Properties.Settings.Default.ExePath;
            Addons_textbox.Text = Properties.Settings.Default.Addons;
            ExtraArgs_textbox.Text = Properties.Settings.Default.ExtraArgs;
        }

        private void ExePath_button_Click(object sender, EventArgs e)
        {
            var filedialog = new OpenFileDialog();
            filedialog.Filter = "DOOM exe|*.exe;*.EXE";
            filedialog.Multiselect = false;
            filedialog.Title = "Select DOOM executable ...";
            if (filedialog.ShowDialog() == DialogResult.OK)
            {
                ExePath_textbox.Text = filedialog.FileName;
            }
        }

        private void Addons_button_Click(object sender, EventArgs e)
        {
            var filedialog = new OpenFileDialog();
            filedialog.Filter = "WAD files|*.wad;*.WAD;*.pk3;*.PK3";
            filedialog.Multiselect = true;
            filedialog.Title = "Select add-ons ...";
            if (filedialog.ShowDialog() == DialogResult.OK && filedialog.FileNames.Length > 0)
            {
                Addons_textbox.Text = "-file " + String.Join(" ", filedialog.FileNames);
            }
        }

        private void Launch_button_Click(object sender, EventArgs e)
        {
            // launch DOOM executable
            // TODO if no cmd, disable Launch button
            string cmd = ExePath_textbox.Text;
            string args = Addons_textbox.Text;
            if (!String.IsNullOrEmpty(ExtraArgs_textbox.Text))
            {
                if (!String.IsNullOrEmpty(args))
                {
                    args += " ";
                }
                args += ExtraArgs_textbox;
            }

            bool err = false;
            Process proc;
            try
            {
                if (String.IsNullOrEmpty(args))
                {
                    proc = Process.Start(cmd);
                }
                else
                {
                    proc = Process.Start(cmd, args);
                }
                proc.WaitForExit();
                proc.Close();
            } catch (Exception exc)
            {
                err = true;
                string msg = "Oh no! Failed to launch DOOM :(" + Environment.NewLine +
                    Environment.NewLine +
                    "error: " + exc.Message;
                MessageBox.Show(msg, "DOOM Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!err)
            {
                // save last good settings
                Properties.Settings.Default.ExePath = ExePath_textbox.Text;
                Properties.Settings.Default.Addons = Addons_textbox.Text;
                Properties.Settings.Default.ExtraArgs = ExtraArgs_textbox.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void About_button_Click(object sender, EventArgs e)
        {
            if (about_window == null)
            {
                about_window = new About_window();
            }
            about_window.ShowDialog();
        }

    }
}
