namespace ZeneBonaDolgozat
{
    partial class MusicPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.listSong = new System.Windows.Forms.ListBox();
            this.btnSong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(13, 13);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(595, 425);
            this.MediaPlayer.TabIndex = 0;
            this.MediaPlayer.Enter += new System.EventHandler(this.MediaPlayer_Enter);
            // 
            // listSong
            // 
            this.listSong.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSong.FormattingEnabled = true;
            this.listSong.ItemHeight = 17;
            this.listSong.Location = new System.Drawing.Point(614, 13);
            this.listSong.Name = "listSong";
            this.listSong.Size = new System.Drawing.Size(174, 378);
            this.listSong.TabIndex = 1;
            this.listSong.SelectedIndexChanged += new System.EventHandler(this.ListSong_SelectedIndexChanged);
            // 
            // btnSong
            // 
            this.btnSong.Location = new System.Drawing.Point(614, 391);
            this.btnSong.Name = "btnSong";
            this.btnSong.Size = new System.Drawing.Size(174, 47);
            this.btnSong.TabIndex = 2;
            this.btnSong.Text = "Zene választás";
            this.btnSong.UseMnemonic = false;
            this.btnSong.UseVisualStyleBackColor = true;
            this.btnSong.Click += new System.EventHandler(this.BtnSong_Click);
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSong);
            this.Controls.Add(this.listSong);
            this.Controls.Add(this.MediaPlayer);
            this.Name = "MusicPlayer";
            this.Text = "ZeneBona";
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private System.Windows.Forms.ListBox listSong;
        private System.Windows.Forms.Button btnSong;
    }
}

