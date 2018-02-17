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
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;

namespace doomlauncher
{
    public partial class About_window : Form
    {
        public string version = "1.0";

        public About_window()
        {
            InitializeComponent();
            About_label.Text += " " + version;
        }

        private void About_window_Load(object sender, EventArgs e)
        {
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OpenURL(string url)
        {
            // open http(s) link
            RegistryKey key = Registry.ClassesRoot.OpenSubKey(@"HTTP\shell\open\command", false);
            string browser = key.GetValue(null).ToString().Split('"')[1];

            Process p = new Process();
            p.StartInfo.FileName = browser;
            p.StartInfo.Arguments = url;
            p.Start();
        }

/*
 * This func works, but not very well in my opinion
 * 
        private string GetDefaultBrowser()
        {
            string browser = "iexplore.exe";
            using (RegistryKey userChoiceKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\Shell\Associations\UrlAssociations\http\UserChoice"))
            {
                if (userChoiceKey != null)
                {
                    object prog_id = userChoiceKey.GetValue("Progid");
                    if (prog_id != null)
                    {
                        string prog = prog_id.ToString().ToLower();
                        Console.WriteLine("default browser: [{0}]", prog);
                        if (prog.Contains("chrome"))
                        {
                            browser = "chrome.exe";
                        }
                        else if (prog.Contains("firefox"))
                        {
                            browser = "firefox.exe";
                        }
                        else if (prog.Contains("edge") || prog.Contains("appxq0"))
                        {
                            // edge.exe does not exist?
                            browser = "iexplore.exe";
                        }
                        else if (prog.Contains("safari"))
                        {
                            browser = "safari.exe";
                        }
                        else if (prog.Contains("opera"))
                        {
                            browser = "opera.exe";
                        }
                    }
                }
            }
            return browser;
        }
*/

private void License_linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                this.License_linklabel.LinkVisited = true;
                OpenURL(License_linklabel.Text);
            }
            catch (Exception exc)
            {
                string msg = String.Format("failed to open link: {0}", exc.Message);
                MessageBox.Show(msg, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
