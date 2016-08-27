using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using LatestFollow_light.Properties;
using Newtonsoft.Json;

namespace LatestFollow_light
{
    public partial class Main : Form
    {
        public Main(String[] args)
        {
            InitializeComponent();
            txt_username.Text = Settings.Default.username;
            txt_path.Text = Settings.Default.path;
            num_interval.Value = Settings.Default.interval;
            num_spaces.Value = Settings.Default.spaces;
            if (args.Length> 0 && args[0] == "--active")
            {
                cb_active.Checked = true;
            }
        }

        private void btn_browser_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Filter = "Text File|*.txt";
            savedialog.ShowDialog();

            if (savedialog.FileName != "")
            {
                savedialog.OpenFile().Close();
                txt_path.Text = savedialog.FileName;
            }
        }

        private void timer_main_Tick(object sender, EventArgs e)
        {
            RootObject root =
                JsonConvert.DeserializeObject<RootObject>(
                    new WebClient().DownloadString(String.Format("https://api.twitch.tv/kraken/channels/{0}/follows",
                        txt_username.Text)));
            StreamWriter sw = new StreamWriter(File.Open(txt_path.Text, FileMode.Create));


            if (root.follows.Length > 0)
            {
                sw.Write(root.follows[0].user.display_name);
                for (int i = 0; i < num_spaces.Value; i++)
                {
                    sw.Write(" ");
                } 
            }
            
            
            sw.Close();
        }

        private void cb_active_CheckedChanged(object sender, EventArgs e)
        {
            txt_username.Enabled = !cb_active.Checked;
            txt_path.Enabled = !cb_active.Checked;
            num_spaces.Enabled = !cb_active.Checked;
            num_interval.Enabled = !cb_active.Checked;
            btn_browser.Enabled = !cb_active.Checked;
            if (cb_active.Checked)
            {
                timer_main.Interval = (int)num_interval.Value; 
            }
            timer_main.Enabled = cb_active.Checked;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.username = txt_username.Text;
            Settings.Default.path = txt_path.Text;
            Settings.Default.interval = num_interval.Value;
            Settings.Default.spaces = num_spaces.Value;
            Settings.Default.Save();
        }


    }
}
