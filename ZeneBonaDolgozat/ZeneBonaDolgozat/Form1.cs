using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeneBonaDolgozat
{
    public partial class MusicPlayer : Form
    {
        public MusicPlayer()
        {
            InitializeComponent();
        }
        String[] paths, files;

        private void MediaPlayer_Enter(object sender, EventArgs e)
        {

        }

        private void ListSong_SelectedIndexChanged(object sender, EventArgs e)
        {
            MediaPlayer.URL = paths[listSong.SelectedIndex];
        }

        private void BtnSong_Click(object sender, EventArgs e)
        { 
            OpenFileDialog zeneBe = new OpenFileDialog();

            
            zeneBe.Multiselect = true;

            if (zeneBe.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = zeneBe.SafeFileNames; 
                paths = zeneBe.FileNames;

                for (int i = 0; i < files.Length; i++)
                {
                    listSong.Items.Add(files[i]); 
                }

            }

        }
    }
}
