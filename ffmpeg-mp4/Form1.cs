using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ffmpeg_mp4
{

    public partial class Form1 : Form
    {
        public static string dosyayolu;

        public static string dosyaadi;
        public static string qualityselected;
        public static string resolutionWselected;
        public static string resolutionHselected;
        public static string codecselected;
        public static string ffmpegyol;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Video you choose must be in the same folder as the program.");
            res();
            codec();
            quality();
            resolutionBox.Text = "Select a Resolution";
            codecBox.Text = "Select a Codec";
            qualityBox.Text = "Select a Quality";
            string ss = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
            System.IO.File.WriteAllBytes(ss + @"\ffmpeg.exe", Properties.Resources.ffmpeg);
            ffmpegyol = ss + @"\ffmpeg.exe";
        }
        void res()
        {
            resolutionBox.Items.Add("7680x4320 [8K]");
            resolutionBox.Items.Add("3840x2160 [4K]");
            resolutionBox.Items.Add("2560x1440 [2K]");
            resolutionBox.Items.Add("1920x1080");
            resolutionBox.Items.Add("1280x720");
        }
        void codec()
        {
            codecBox.Items.Add("Nvdia");
            codecBox.Items.Add("AMD");
            codecBox.Items.Add("x264 [CPU]");
        }
        void quality()
        {
            qualityBox.Items.Add("High");
            qualityBox.Items.Add("Above Normal");
            qualityBox.Items.Add("Normal");
            qualityBox.Items.Add("Below Normal");
        }
        void start()
        {

            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = string.Concat(new string[]
            {
                @"/K "+ffmpegyol+" -i ",
                Form1.dosyaadi,
                " -vf scale=",
                Form1.resolutionWselected,
                "x",
                Form1.resolutionHselected,
                ":flags=neighbor -preset fast -c:v ",
                Form1.codecselected,
                " -qmin ",
                Form1.qualityselected,
                " -qmax ",
                Form1.qualityselected,
                " -2pass 1 -c:a:0 copy -b:a 384k Converted_",
                Form1.dosyaadi
            });
            process.Start();
            process.WaitForExit();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP4 Video File | *.mp4";
            openFileDialog.ShowDialog();
            dosyayolu = openFileDialog.FileName;
            dosyaadi = openFileDialog.SafeFileName;
            selectButton.Text = dosyaadi;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (dosyayolu == null)
            {
                MessageBox.Show("Select a Video");
            }
            else
            {
                if (resolutionWselected == null || resolutionHselected == null)
                {
                    MessageBox.Show("Select a Resolution");
                }
                else
                {
                    if (codecselected == null)
                    {
                        MessageBox.Show("Select a Codec");
                    }
                    else
                    {
                        if (qualityselected == null)
                        {
                            MessageBox.Show("Select a Quality");
                        }
                        else
                        {
                            start();
                        }
                    }
                }
            }
        }

        private void resolutionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (resolutionBox.SelectedIndex == 0)
            {
                resolutionWselected = "7680";
                resolutionHselected = "4320";
            }
            else if (resolutionBox.SelectedIndex == 1)
            {
                resolutionWselected = "3840";
                resolutionHselected = "2160";
            }
            else if (resolutionBox.SelectedIndex == 2)
            {
                resolutionWselected = "2560";
                resolutionHselected = "1440";
            }
            else if (resolutionBox.SelectedIndex == 3)
            {
                resolutionWselected = "1920";
                resolutionHselected = "1080";
            }
            else if (resolutionBox.SelectedIndex == 4)
            {
                resolutionWselected = "1280";
                resolutionHselected = "720";
            }
            else
            {
                MessageBox.Show("Error please restart.");
            }
        }

        private void codecBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (codecBox.SelectedIndex == 0)
            {
                codecselected = "h264_nvenc";
            }
            else if (codecBox.SelectedIndex == 1)
            {
                codecselected = "h264_amf";
            }
            else if (codecBox.SelectedIndex == 2)
            {
                codecselected = "libx264";
            }
            else
            {
                codecselected = "libx264";
            }
        }

        private void qualityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (qualityBox.SelectedIndex == 0)
            {
                qualityselected = "7";
            }
            else if (qualityBox.SelectedIndex == 1)
            {
                qualityselected = "15";
            }
            else if (qualityBox.SelectedIndex == 2)
            {
                qualityselected = "22";
            }
            else if (qualityBox.SelectedIndex == 3)
            {
                qualityselected = "32";
            }
        }
    }
}
