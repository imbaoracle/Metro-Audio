﻿namespace MetroAudio
{
    partial class MetroAudioForm
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
            this.MetroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.LabelCurrentMedia = new MetroFramework.Controls.MetroLabel();
            this.TrackBarProgress = new MetroFramework.Controls.MetroTrackBar();
            this.LabelCurrentlyPlaying = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.TabControlMedia = new MetroFramework.Controls.MetroTabControl();
            this.TabPlayerOptions = new MetroFramework.Controls.MetroTabPage();
            this.ComboBoxOptionsTheme = new MetroFramework.Controls.MetroComboBox();
            this.LabelOptionsTheme = new MetroFramework.Controls.MetroLabel();
            this.LabelOptionsShuffle = new MetroFramework.Controls.MetroLabel();
            this.ToggleOptionsShuffle = new MetroFramework.Controls.MetroToggle();
            this.LabelOptionsRepeat = new MetroFramework.Controls.MetroLabel();
            this.ToggleOptionsRepeat = new MetroFramework.Controls.MetroToggle();
            this.TabMediaInfo = new MetroFramework.Controls.MetroTabPage();
            this.TabMediaOptions = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.ButtonNext = new MetroFramework.Controls.MetroButton();
            this.ButtonPrevious = new MetroFramework.Controls.MetroButton();
            this.ButtonRemove = new MetroFramework.Controls.MetroButton();
            this.ButtonSave = new MetroFramework.Controls.MetroButton();
            this.ButtonStop = new MetroFramework.Controls.MetroButton();
            this.ButtonPause = new MetroFramework.Controls.MetroButton();
            this.ButtonPlay = new MetroFramework.Controls.MetroButton();
            this.ButtonOpen = new MetroFramework.Controls.MetroButton();
            this.ListBoxPlayList = new System.Windows.Forms.ListBox();
            this.LabelFilter = new MetroFramework.Controls.MetroLabel();
            this.LabelVolume = new MetroFramework.Controls.MetroLabel();
            this.TextBoxFilter = new MetroFramework.Controls.MetroTextBox();
            this.TrackBarVolume = new MetroFramework.Controls.MetroTrackBar();
            this.TimerUpdate = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MetroStyleManager)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.TabControlMedia.SuspendLayout();
            this.TabPlayerOptions.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MetroStyleManager
            // 
            this.MetroStyleManager.Owner = this;
            this.MetroStyleManager.Style = MetroFramework.MetroColorStyle.Red;
            this.MetroStyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroPanel4);
            this.metroPanel1.Controls.Add(this.metroPanel3);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(760, 520);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.LabelCurrentMedia);
            this.metroPanel4.Controls.Add(this.TrackBarProgress);
            this.metroPanel4.Controls.Add(this.LabelCurrentlyPlaying);
            this.metroPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(0, 0);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(494, 100);
            this.metroPanel4.TabIndex = 6;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // LabelCurrentMedia
            // 
            this.LabelCurrentMedia.Location = new System.Drawing.Point(6, 33);
            this.LabelCurrentMedia.Name = "LabelCurrentMedia";
            this.LabelCurrentMedia.Size = new System.Drawing.Size(477, 23);
            this.LabelCurrentMedia.TabIndex = 4;
            this.LabelCurrentMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelCurrentMedia.UseStyleColors = true;
            // 
            // TrackBarProgress
            // 
            this.TrackBarProgress.BackColor = System.Drawing.Color.Transparent;
            this.TrackBarProgress.Enabled = false;
            this.TrackBarProgress.Location = new System.Drawing.Point(8, 64);
            this.TrackBarProgress.MouseWheelBarPartitions = 100;
            this.TrackBarProgress.Name = "TrackBarProgress";
            this.TrackBarProgress.Size = new System.Drawing.Size(479, 23);
            this.TrackBarProgress.TabIndex = 0;
            this.TrackBarProgress.Text = "Progress Track Bar";
            this.TrackBarProgress.Value = 0;
            this.TrackBarProgress.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TrackBarProgress_Scroll);
            // 
            // LabelCurrentlyPlaying
            // 
            this.LabelCurrentlyPlaying.AutoSize = true;
            this.LabelCurrentlyPlaying.Location = new System.Drawing.Point(4, 6);
            this.LabelCurrentlyPlaying.Name = "LabelCurrentlyPlaying";
            this.LabelCurrentlyPlaying.Size = new System.Drawing.Size(111, 19);
            this.LabelCurrentlyPlaying.TabIndex = 2;
            this.LabelCurrentlyPlaying.Text = "Currently Playing:";
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.TabControlMedia);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(0, 101);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(494, 419);
            this.metroPanel3.TabIndex = 5;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // TabControlMedia
            // 
            this.TabControlMedia.Controls.Add(this.TabPlayerOptions);
            this.TabControlMedia.Controls.Add(this.TabMediaInfo);
            this.TabControlMedia.Controls.Add(this.TabMediaOptions);
            this.TabControlMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabControlMedia.Location = new System.Drawing.Point(0, 0);
            this.TabControlMedia.Name = "TabControlMedia";
            this.TabControlMedia.SelectedIndex = 0;
            this.TabControlMedia.Size = new System.Drawing.Size(494, 383);
            this.TabControlMedia.TabIndex = 1;
            // 
            // TabPlayerOptions
            // 
            this.TabPlayerOptions.Controls.Add(this.ComboBoxOptionsTheme);
            this.TabPlayerOptions.Controls.Add(this.LabelOptionsTheme);
            this.TabPlayerOptions.Controls.Add(this.LabelOptionsShuffle);
            this.TabPlayerOptions.Controls.Add(this.ToggleOptionsShuffle);
            this.TabPlayerOptions.Controls.Add(this.LabelOptionsRepeat);
            this.TabPlayerOptions.Controls.Add(this.ToggleOptionsRepeat);
            this.TabPlayerOptions.HorizontalScrollbarBarColor = true;
            this.TabPlayerOptions.Location = new System.Drawing.Point(4, 35);
            this.TabPlayerOptions.Name = "TabPlayerOptions";
            this.TabPlayerOptions.Size = new System.Drawing.Size(486, 344);
            this.TabPlayerOptions.TabIndex = 2;
            this.TabPlayerOptions.Text = "Player Options";
            this.TabPlayerOptions.ToolTipText = "Player options such as repeat, shuffle, and more.";
            this.TabPlayerOptions.VerticalScrollbarBarColor = true;
            // 
            // ComboBoxOptionsTheme
            // 
            this.ComboBoxOptionsTheme.FormattingEnabled = true;
            this.ComboBoxOptionsTheme.ItemHeight = 23;
            this.ComboBoxOptionsTheme.Location = new System.Drawing.Point(7, 83);
            this.ComboBoxOptionsTheme.Name = "ComboBoxOptionsTheme";
            this.ComboBoxOptionsTheme.Size = new System.Drawing.Size(172, 29);
            this.ComboBoxOptionsTheme.TabIndex = 7;
            this.ComboBoxOptionsTheme.SelectedIndexChanged += new System.EventHandler(this.ComboBoxOptionsTheme_SelectedIndexChanged);
            // 
            // LabelOptionsTheme
            // 
            this.LabelOptionsTheme.AutoSize = true;
            this.LabelOptionsTheme.Location = new System.Drawing.Point(4, 61);
            this.LabelOptionsTheme.Name = "LabelOptionsTheme";
            this.LabelOptionsTheme.Size = new System.Drawing.Size(92, 19);
            this.LabelOptionsTheme.TabIndex = 6;
            this.LabelOptionsTheme.Text = "Player Theme:";
            // 
            // LabelOptionsShuffle
            // 
            this.LabelOptionsShuffle.AutoSize = true;
            this.LabelOptionsShuffle.Location = new System.Drawing.Point(4, 40);
            this.LabelOptionsShuffle.Name = "LabelOptionsShuffle";
            this.LabelOptionsShuffle.Size = new System.Drawing.Size(94, 19);
            this.LabelOptionsShuffle.TabIndex = 5;
            this.LabelOptionsShuffle.Text = "Shuffle Playlist:";
            // 
            // ToggleOptionsShuffle
            // 
            this.ToggleOptionsShuffle.AutoSize = true;
            this.ToggleOptionsShuffle.Location = new System.Drawing.Point(99, 42);
            this.ToggleOptionsShuffle.Name = "ToggleOptionsShuffle";
            this.ToggleOptionsShuffle.Size = new System.Drawing.Size(80, 17);
            this.ToggleOptionsShuffle.TabIndex = 4;
            this.ToggleOptionsShuffle.Text = "Off";
            this.ToggleOptionsShuffle.UseVisualStyleBackColor = true;
            // 
            // LabelOptionsRepeat
            // 
            this.LabelOptionsRepeat.AutoSize = true;
            this.LabelOptionsRepeat.Location = new System.Drawing.Point(4, 17);
            this.LabelOptionsRepeat.Name = "LabelOptionsRepeat";
            this.LabelOptionsRepeat.Size = new System.Drawing.Size(96, 19);
            this.LabelOptionsRepeat.TabIndex = 3;
            this.LabelOptionsRepeat.Text = "Repeat Playlist:";
            // 
            // ToggleOptionsRepeat
            // 
            this.ToggleOptionsRepeat.AutoSize = true;
            this.ToggleOptionsRepeat.Checked = true;
            this.ToggleOptionsRepeat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToggleOptionsRepeat.Location = new System.Drawing.Point(99, 19);
            this.ToggleOptionsRepeat.Name = "ToggleOptionsRepeat";
            this.ToggleOptionsRepeat.Size = new System.Drawing.Size(80, 17);
            this.ToggleOptionsRepeat.TabIndex = 2;
            this.ToggleOptionsRepeat.Text = "On";
            this.ToggleOptionsRepeat.UseVisualStyleBackColor = true;
            // 
            // TabMediaInfo
            // 
            this.TabMediaInfo.HorizontalScrollbarBarColor = true;
            this.TabMediaInfo.Location = new System.Drawing.Point(4, 35);
            this.TabMediaInfo.Name = "TabMediaInfo";
            this.TabMediaInfo.Size = new System.Drawing.Size(486, 344);
            this.TabMediaInfo.TabIndex = 0;
            this.TabMediaInfo.Text = "Media Info";
            this.TabMediaInfo.ToolTipText = "Information on the current song or media playing.";
            this.TabMediaInfo.VerticalScrollbarBarColor = true;
            // 
            // TabMediaOptions
            // 
            this.TabMediaOptions.HorizontalScrollbarBarColor = true;
            this.TabMediaOptions.Location = new System.Drawing.Point(4, 35);
            this.TabMediaOptions.Name = "TabMediaOptions";
            this.TabMediaOptions.Size = new System.Drawing.Size(486, 344);
            this.TabMediaOptions.TabIndex = 1;
            this.TabMediaOptions.Text = "Media Options";
            this.TabMediaOptions.ToolTipText = "Information on options for the currently playing media such as conversion options" +
    ".";
            this.TabMediaOptions.VerticalScrollbarBarColor = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.ButtonNext);
            this.metroPanel2.Controls.Add(this.ButtonPrevious);
            this.metroPanel2.Controls.Add(this.ButtonRemove);
            this.metroPanel2.Controls.Add(this.ButtonSave);
            this.metroPanel2.Controls.Add(this.ButtonStop);
            this.metroPanel2.Controls.Add(this.ButtonPause);
            this.metroPanel2.Controls.Add(this.ButtonPlay);
            this.metroPanel2.Controls.Add(this.ButtonOpen);
            this.metroPanel2.Controls.Add(this.ListBoxPlayList);
            this.metroPanel2.Controls.Add(this.LabelFilter);
            this.metroPanel2.Controls.Add(this.LabelVolume);
            this.metroPanel2.Controls.Add(this.TextBoxFilter);
            this.metroPanel2.Controls.Add(this.TrackBarVolume);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(494, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(266, 520);
            this.metroPanel2.TabIndex = 4;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // ButtonNext
            // 
            this.ButtonNext.Location = new System.Drawing.Point(177, 141);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(75, 23);
            this.ButtonNext.TabIndex = 12;
            this.ButtonNext.Text = "Next";
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonPrevious
            // 
            this.ButtonPrevious.Location = new System.Drawing.Point(13, 141);
            this.ButtonPrevious.Name = "ButtonPrevious";
            this.ButtonPrevious.Size = new System.Drawing.Size(75, 23);
            this.ButtonPrevious.TabIndex = 11;
            this.ButtonPrevious.Text = "Prev";
            this.ButtonPrevious.Click += new System.EventHandler(this.ButtonPrevious_Click);
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.Location = new System.Drawing.Point(95, 84);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(75, 23);
            this.ButtonRemove.TabIndex = 10;
            this.ButtonRemove.Text = "Remove";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(177, 84);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 9;
            this.ButtonSave.Text = "Save";
            // 
            // ButtonStop
            // 
            this.ButtonStop.Location = new System.Drawing.Point(177, 112);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(75, 23);
            this.ButtonStop.TabIndex = 7;
            this.ButtonStop.Text = "Stop";
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // ButtonPause
            // 
            this.ButtonPause.Location = new System.Drawing.Point(95, 112);
            this.ButtonPause.Name = "ButtonPause";
            this.ButtonPause.Size = new System.Drawing.Size(75, 23);
            this.ButtonPause.TabIndex = 6;
            this.ButtonPause.Text = "Pause";
            this.ButtonPause.Click += new System.EventHandler(this.ButtonPause_Click);
            // 
            // ButtonPlay
            // 
            this.ButtonPlay.Location = new System.Drawing.Point(13, 112);
            this.ButtonPlay.Name = "ButtonPlay";
            this.ButtonPlay.Size = new System.Drawing.Size(75, 23);
            this.ButtonPlay.TabIndex = 5;
            this.ButtonPlay.Text = "Play";
            this.ButtonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.Location = new System.Drawing.Point(13, 84);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(75, 23);
            this.ButtonOpen.TabIndex = 4;
            this.ButtonOpen.Text = "Open";
            this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // ListBoxPlayList
            // 
            this.ListBoxPlayList.FormattingEnabled = true;
            this.ListBoxPlayList.Location = new System.Drawing.Point(13, 171);
            this.ListBoxPlayList.Name = "ListBoxPlayList";
            this.ListBoxPlayList.ScrollAlwaysVisible = true;
            this.ListBoxPlayList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBoxPlayList.Size = new System.Drawing.Size(239, 342);
            this.ListBoxPlayList.TabIndex = 8;
            this.ListBoxPlayList.SelectedIndexChanged += new System.EventHandler(this.ListBoxPlayList_SelectedIndexChanged);
            // 
            // LabelFilter
            // 
            this.LabelFilter.AutoSize = true;
            this.LabelFilter.Location = new System.Drawing.Point(10, 33);
            this.LabelFilter.Name = "LabelFilter";
            this.LabelFilter.Size = new System.Drawing.Size(42, 19);
            this.LabelFilter.TabIndex = 6;
            this.LabelFilter.Text = "Filter:";
            // 
            // LabelVolume
            // 
            this.LabelVolume.AutoSize = true;
            this.LabelVolume.Location = new System.Drawing.Point(10, 8);
            this.LabelVolume.Name = "LabelVolume";
            this.LabelVolume.Size = new System.Drawing.Size(56, 19);
            this.LabelVolume.TabIndex = 5;
            this.LabelVolume.Text = "Volume:";
            // 
            // TextBoxFilter
            // 
            this.TextBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxFilter.Location = new System.Drawing.Point(13, 55);
            this.TextBoxFilter.Name = "TextBoxFilter";
            this.TextBoxFilter.Size = new System.Drawing.Size(241, 23);
            this.TextBoxFilter.TabIndex = 3;
            // 
            // TrackBarVolume
            // 
            this.TrackBarVolume.BackColor = System.Drawing.Color.Transparent;
            this.TrackBarVolume.Location = new System.Drawing.Point(75, 8);
            this.TrackBarVolume.Name = "TrackBarVolume";
            this.TrackBarVolume.Size = new System.Drawing.Size(177, 23);
            this.TrackBarVolume.TabIndex = 2;
            this.TrackBarVolume.Text = "Volume Control";
            this.TrackBarVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TrackBarVolume_Scroll);
            // 
            // TimerUpdate
            // 
            this.TimerUpdate.Enabled = true;
            this.TimerUpdate.Interval = 20;
            this.TimerUpdate.Tick += new System.EventHandler(this.TimerUpdate_Tick);
            // 
            // MetroAudioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.Name = "MetroAudioForm";
            this.Resizable = false;
            this.Text = "Metro Audio:";
            this.Load += new System.EventHandler(this.MetroAudioForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MetroStyleManager)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.TabControlMedia.ResumeLayout(false);
            this.TabPlayerOptions.ResumeLayout(false);
            this.TabPlayerOptions.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTrackBar TrackBarVolume;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTextBox TextBoxFilter;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroLabel LabelCurrentlyPlaying;
        private MetroFramework.Controls.MetroTrackBar TrackBarProgress;
        private MetroFramework.Controls.MetroLabel LabelVolume;
        private MetroFramework.Controls.MetroLabel LabelFilter;
        private MetroFramework.Controls.MetroLabel LabelCurrentMedia;
        private System.Windows.Forms.ListBox ListBoxPlayList;
        private MetroFramework.Controls.MetroButton ButtonStop;
        private MetroFramework.Controls.MetroButton ButtonPause;
        private MetroFramework.Controls.MetroButton ButtonPlay;
        private MetroFramework.Controls.MetroButton ButtonOpen;
        private MetroFramework.Controls.MetroTabControl TabControlMedia;
        private MetroFramework.Controls.MetroTabPage TabMediaInfo;
        private MetroFramework.Controls.MetroTabPage TabMediaOptions;
        private MetroFramework.Controls.MetroTabPage TabPlayerOptions;
        private MetroFramework.Controls.MetroLabel LabelOptionsRepeat;
        private MetroFramework.Controls.MetroToggle ToggleOptionsRepeat;
        private MetroFramework.Controls.MetroLabel LabelOptionsShuffle;
        private MetroFramework.Controls.MetroToggle ToggleOptionsShuffle;
        private MetroFramework.Controls.MetroComboBox ComboBoxOptionsTheme;
        private MetroFramework.Controls.MetroLabel LabelOptionsTheme;
        internal MetroFramework.Components.MetroStyleManager MetroStyleManager;
        private MetroFramework.Controls.MetroButton ButtonSave;
        private MetroFramework.Controls.MetroButton ButtonRemove;
        private MetroFramework.Controls.MetroButton ButtonNext;
        private MetroFramework.Controls.MetroButton ButtonPrevious;
        private System.Windows.Forms.Timer TimerUpdate;
    }
}

