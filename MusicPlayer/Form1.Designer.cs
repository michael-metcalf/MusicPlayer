
namespace MusicPlayer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.p_bar = new System.Windows.Forms.ProgressBar();
            this.track_list = new System.Windows.Forms.ListBox();
            this.pic_art = new System.Windows.Forms.PictureBox();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.track_volume = new System.Windows.Forms.TrackBar();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.lbl_vol_percent = new System.Windows.Forms.Label();
            this.lbl_track_start = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_previous
            // 
            this.btn_previous.BackColor = System.Drawing.Color.Black;
            this.btn_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_previous.ForeColor = System.Drawing.Color.LightGreen;
            this.btn_previous.Location = new System.Drawing.Point(12, 211);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(83, 41);
            this.btn_previous.TabIndex = 1;
            this.btn_previous.Text = "Previous";
            this.btn_previous.UseVisualStyleBackColor = false;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Black;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.ForeColor = System.Drawing.Color.LightGreen;
            this.btn_next.Location = new System.Drawing.Point(279, 211);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(83, 41);
            this.btn_next.TabIndex = 4;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.Black;
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.ForeColor = System.Drawing.Color.LightGreen;
            this.btn_stop.Location = new System.Drawing.Point(368, 211);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(83, 41);
            this.btn_stop.TabIndex = 5;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.Black;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.ForeColor = System.Drawing.Color.LightGreen;
            this.btn_play.Location = new System.Drawing.Point(101, 211);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(83, 41);
            this.btn_play.TabIndex = 2;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.BackColor = System.Drawing.Color.Black;
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pause.ForeColor = System.Drawing.Color.LightGreen;
            this.btn_pause.Location = new System.Drawing.Point(190, 211);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(83, 41);
            this.btn_pause.TabIndex = 3;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = false;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.Color.Black;
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open.ForeColor = System.Drawing.Color.LightGreen;
            this.btn_open.Location = new System.Drawing.Point(457, 211);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(85, 41);
            this.btn_open.TabIndex = 6;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // p_bar
            // 
            this.p_bar.Location = new System.Drawing.Point(274, 39);
            this.p_bar.Name = "p_bar";
            this.p_bar.Size = new System.Drawing.Size(137, 10);
            this.p_bar.TabIndex = 6;
            this.p_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_bar_MouseDown);
            // 
            // track_list
            // 
            this.track_list.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.track_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.track_list.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.track_list.ForeColor = System.Drawing.Color.LightGreen;
            this.track_list.FormattingEnabled = true;
            this.track_list.ItemHeight = 17;
            this.track_list.Location = new System.Drawing.Point(12, 274);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(530, 427);
            this.track_list.TabIndex = 7;
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
            // 
            // pic_art
            // 
            this.pic_art.Image = global::MusicPlayer.Properties.Resources.panda;
            this.pic_art.Location = new System.Drawing.Point(12, 39);
            this.pic_art.Name = "pic_art";
            this.pic_art.Size = new System.Drawing.Size(188, 157);
            this.pic_art.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_art.TabIndex = 8;
            this.pic_art.TabStop = false;
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(205, 55);
            this.player.Margin = new System.Windows.Forms.Padding(2);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(196, 101);
            this.player.TabIndex = 9;
            this.player.UseWaitCursor = true;
            // 
            // track_volume
            // 
            this.track_volume.Location = new System.Drawing.Point(213, 55);
            this.track_volume.Maximum = 100;
            this.track_volume.Name = "track_volume";
            this.track_volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.track_volume.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.track_volume.Size = new System.Drawing.Size(56, 130);
            this.track_volume.TabIndex = 0;
            this.track_volume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.track_volume.Scroll += new System.EventHandler(this.track_volume_Scroll);
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_volume.ForeColor = System.Drawing.Color.LightGreen;
            this.lbl_volume.Location = new System.Drawing.Point(214, 188);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(40, 17);
            this.lbl_volume.TabIndex = 11;
            this.lbl_volume.Text = "VOL";
            // 
            // lbl_vol_percent
            // 
            this.lbl_vol_percent.AutoSize = true;
            this.lbl_vol_percent.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_vol_percent.ForeColor = System.Drawing.Color.LightGreen;
            this.lbl_vol_percent.Location = new System.Drawing.Point(210, 39);
            this.lbl_vol_percent.Name = "lbl_vol_percent";
            this.lbl_vol_percent.Size = new System.Drawing.Size(0, 17);
            this.lbl_vol_percent.TabIndex = 12;
            // 
            // lbl_track_start
            // 
            this.lbl_track_start.AutoSize = true;
            this.lbl_track_start.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_track_start.ForeColor = System.Drawing.Color.LightGreen;
            this.lbl_track_start.Location = new System.Drawing.Point(407, 19);
            this.lbl_track_start.Name = "lbl_track_start";
            this.lbl_track_start.Size = new System.Drawing.Size(138, 42);
            this.lbl_track_start.TabIndex = 13;
            this.lbl_track_start.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(553, 713);
            this.Controls.Add(this.lbl_track_start);
            this.Controls.Add(this.lbl_vol_percent);
            this.Controls.Add(this.lbl_volume);
            this.Controls.Add(this.track_volume);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pic_art);
            this.Controls.Add(this.track_list);
            this.Controls.Add(this.p_bar);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_previous);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.ProgressBar p_bar;
        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.PictureBox pic_art;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.TrackBar track_volume;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.Label lbl_vol_percent;
        private System.Windows.Forms.Label lbl_track_start;
        private System.Windows.Forms.Timer timer1;
    }
}

