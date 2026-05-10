namespace MusicGuide
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            listBoxArtists = new ListBox();
            txtArtistName = new TextBox();
            btnAddArtist = new Button();
            btnDeleteArtist = new Button();
            btnEditArtist = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            btnAddSong = new Button();
            btnEditSong = new Button();
            btnDeleteSong = new Button();
            cmbSongArtist = new ComboBox();
            txtSongTitle = new TextBox();
            listBoxSongs = new ListBox();
            tabPage3 = new TabPage();
            clbDiscSongs = new CheckedListBox();
            btnDeleteDisc = new Button();
            btnEditDisc = new Button();
            btnAddDisc = new Button();
            txtDiscYear = new TextBox();
            txtDiscTitle = new TextBox();
            listBoxDiscs = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxArtists
            // 
            listBoxArtists.Location = new Point(14, 16);
            listBoxArtists.Name = "listBoxArtists";
            listBoxArtists.Size = new Size(593, 254);
            listBoxArtists.TabIndex = 2;
            // 
            // txtArtistName
            // 
            txtArtistName.Location = new Point(14, 292);
            txtArtistName.Name = "txtArtistName";
            txtArtistName.Size = new Size(593, 31);
            txtArtistName.TabIndex = 1;
            // 
            // btnAddArtist
            // 
            btnAddArtist.Location = new Point(14, 346);
            btnAddArtist.Name = "btnAddArtist";
            btnAddArtist.Size = new Size(143, 42);
            btnAddArtist.TabIndex = 0;
            btnAddArtist.Text = "Додати";
            btnAddArtist.Click += btnAddArtist_Click;
            // 
            // btnDeleteArtist
            // 
            btnDeleteArtist.Location = new Point(464, 346);
            btnDeleteArtist.Name = "btnDeleteArtist";
            btnDeleteArtist.Size = new Size(143, 42);
            btnDeleteArtist.TabIndex = 3;
            btnDeleteArtist.Text = "Видалити";
            btnDeleteArtist.UseVisualStyleBackColor = true;
            btnDeleteArtist.Click += btnDeleteArtist_Click;
            // 
            // btnEditArtist
            // 
            btnEditArtist.Location = new Point(238, 346);
            btnEditArtist.Name = "btnEditArtist";
            btnEditArtist.Size = new Size(143, 42);
            btnEditArtist.TabIndex = 3;
            btnEditArtist.Text = "Редагувати";
            btnEditArtist.UseVisualStyleBackColor = true;
            btnEditArtist.Click += btnEditArtist_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(636, 448);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnEditArtist);
            tabPage1.Controls.Add(txtArtistName);
            tabPage1.Controls.Add(btnAddArtist);
            tabPage1.Controls.Add(listBoxArtists);
            tabPage1.Controls.Add(btnDeleteArtist);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(628, 410);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Виконавці";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnAddSong);
            tabPage2.Controls.Add(btnEditSong);
            tabPage2.Controls.Add(btnDeleteSong);
            tabPage2.Controls.Add(cmbSongArtist);
            tabPage2.Controls.Add(txtSongTitle);
            tabPage2.Controls.Add(listBoxSongs);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(628, 410);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Пісні";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddSong
            // 
            btnAddSong.Location = new Point(24, 352);
            btnAddSong.Name = "btnAddSong";
            btnAddSong.Size = new Size(112, 34);
            btnAddSong.TabIndex = 3;
            btnAddSong.Text = "Додати";
            btnAddSong.UseVisualStyleBackColor = true;
            btnAddSong.Click += btnAddSong_Click;
            // 
            // btnEditSong
            // 
            btnEditSong.Location = new Point(183, 352);
            btnEditSong.Name = "btnEditSong";
            btnEditSong.Size = new Size(112, 34);
            btnEditSong.TabIndex = 3;
            btnEditSong.Text = "Редагувати";
            btnEditSong.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSong
            // 
            btnDeleteSong.Location = new Point(331, 352);
            btnDeleteSong.Name = "btnDeleteSong";
            btnDeleteSong.Size = new Size(112, 34);
            btnDeleteSong.TabIndex = 3;
            btnDeleteSong.Text = "Видалити";
            btnDeleteSong.UseVisualStyleBackColor = true;
            // 
            // cmbSongArtist
            // 
            cmbSongArtist.FormattingEnabled = true;
            cmbSongArtist.Location = new Point(24, 214);
            cmbSongArtist.Name = "cmbSongArtist";
            cmbSongArtist.Size = new Size(394, 33);
            cmbSongArtist.TabIndex = 2;
            // 
            // txtSongTitle
            // 
            txtSongTitle.Location = new Point(24, 315);
            txtSongTitle.Name = "txtSongTitle";
            txtSongTitle.Size = new Size(394, 31);
            txtSongTitle.TabIndex = 1;
            // 
            // listBoxSongs
            // 
            listBoxSongs.FormattingEnabled = true;
            listBoxSongs.Location = new Point(24, 19);
            listBoxSongs.Name = "listBoxSongs";
            listBoxSongs.Size = new Size(394, 179);
            listBoxSongs.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(clbDiscSongs);
            tabPage3.Controls.Add(btnDeleteDisc);
            tabPage3.Controls.Add(btnEditDisc);
            tabPage3.Controls.Add(btnAddDisc);
            tabPage3.Controls.Add(txtDiscYear);
            tabPage3.Controls.Add(txtDiscTitle);
            tabPage3.Controls.Add(listBoxDiscs);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(628, 410);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Альбоми";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // clbDiscSongs
            // 
            clbDiscSongs.FormattingEnabled = true;
            clbDiscSongs.Location = new Point(390, 13);
            clbDiscSongs.Name = "clbDiscSongs";
            clbDiscSongs.Size = new Size(180, 144);
            clbDiscSongs.TabIndex = 4;
            // 
            // btnDeleteDisc
            // 
            btnDeleteDisc.Location = new Point(499, 287);
            btnDeleteDisc.Name = "btnDeleteDisc";
            btnDeleteDisc.Size = new Size(112, 34);
            btnDeleteDisc.TabIndex = 3;
            btnDeleteDisc.Text = "Видалити";
            btnDeleteDisc.UseVisualStyleBackColor = true;
            btnDeleteDisc.Click += btnDeleteDisc_Click;
            // 
            // btnEditDisc
            // 
            btnEditDisc.Location = new Point(221, 287);
            btnEditDisc.Name = "btnEditDisc";
            btnEditDisc.Size = new Size(112, 34);
            btnEditDisc.TabIndex = 3;
            btnEditDisc.Text = "Редагувати";
            btnEditDisc.UseVisualStyleBackColor = true;
            btnEditDisc.Click += btnEditDisc_Click;
            // 
            // btnAddDisc
            // 
            btnAddDisc.Location = new Point(51, 287);
            btnAddDisc.Name = "btnAddDisc";
            btnAddDisc.Size = new Size(112, 34);
            btnAddDisc.TabIndex = 3;
            btnAddDisc.Text = "Додати";
            btnAddDisc.UseVisualStyleBackColor = true;
            btnAddDisc.Click += btnAddDisc_Click;
            // 
            // txtDiscYear
            // 
            txtDiscYear.Location = new Point(51, 250);
            txtDiscYear.Name = "txtDiscYear";
            txtDiscYear.Size = new Size(451, 31);
            txtDiscYear.TabIndex = 2;
            // 
            // txtDiscTitle
            // 
            txtDiscTitle.Location = new Point(51, 148);
            txtDiscTitle.Name = "txtDiscTitle";
            txtDiscTitle.Size = new Size(150, 31);
            txtDiscTitle.TabIndex = 1;
            // 
            // listBoxDiscs
            // 
            listBoxDiscs.FormattingEnabled = true;
            listBoxDiscs.Location = new Point(51, 13);
            listBoxDiscs.Name = "listBoxDiscs";
            listBoxDiscs.Size = new Size(333, 129);
            listBoxDiscs.TabIndex = 0;
            // 
            // Form1
            // 
            ClientSize = new Size(660, 472);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Довідник";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox listBoxArtists;
        private System.Windows.Forms.TextBox txtArtistName;
        private System.Windows.Forms.Button btnAddArtist;
        private Button btnDeleteArtist;
        private Button btnEditArtist;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button btnAddSong;
        private Button btnEditSong;
        private Button btnDeleteSong;
        private ComboBox cmbSongArtist;
        private TextBox txtSongTitle;
        private ListBox listBoxSongs;
        private Button btnDeleteDisc;
        private Button btnEditDisc;
        private Button btnAddDisc;
        private TextBox txtDiscYear;
        private TextBox txtDiscTitle;
        private ListBox listBoxDiscs;
        private CheckedListBox clbDiscSongs;
    }
}