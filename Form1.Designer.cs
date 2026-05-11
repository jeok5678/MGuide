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
            label6 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            tabPage2 = new TabPage();
            label9 = new Label();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            cmbSongArtist = new ComboBox();
            txtSongTitle = new TextBox();
            btnAddSong = new Button();
            btnDeleteSong = new Button();
            btnEditSong = new Button();
            listBoxSongs = new ListBox();
            tabPage3 = new TabPage();
            label4 = new Label();
            label2 = new Label();
            groupBoxDiscs = new GroupBox();
            label1 = new Label();
            labelDiscs1 = new Label();
            txtDiscYear = new TextBox();
            btnAddDisc = new Button();
            txtDiscTitle = new TextBox();
            btnDeleteDisc = new Button();
            btnEditDisc = new Button();
            clbDiscSongs = new CheckedListBox();
            listBoxDiscs = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBoxDiscs.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxArtists
            // 
            listBoxArtists.FormattingEnabled = true;
            listBoxArtists.Location = new Point(10, 45);
            listBoxArtists.Name = "listBoxArtists";
            listBoxArtists.Size = new Size(735, 132);
            listBoxArtists.TabIndex = 2;
            // 
            // txtArtistName
            // 
            txtArtistName.Location = new Point(15, 65);
            txtArtistName.Name = "txtArtistName";
            txtArtistName.Size = new Size(705, 39);
            txtArtistName.TabIndex = 1;
            // 
            // btnAddArtist
            // 
            btnAddArtist.Location = new Point(15, 125);
            btnAddArtist.Name = "btnAddArtist";
            btnAddArtist.Size = new Size(200, 50);
            btnAddArtist.TabIndex = 0;
            btnAddArtist.Text = "Додати";
            btnAddArtist.UseVisualStyleBackColor = true;
            btnAddArtist.Click += btnAddArtist_Click;
            // 
            // btnDeleteArtist
            // 
            btnDeleteArtist.Location = new Point(520, 125);
            btnDeleteArtist.Name = "btnDeleteArtist";
            btnDeleteArtist.Size = new Size(200, 50);
            btnDeleteArtist.TabIndex = 3;
            btnDeleteArtist.Text = "Видалити";
            btnDeleteArtist.UseVisualStyleBackColor = true;
            btnDeleteArtist.Click += btnDeleteArtist_Click;
            // 
            // btnEditArtist
            // 
            btnEditArtist.Location = new Point(267, 125);
            btnEditArtist.Name = "btnEditArtist";
            btnEditArtist.Size = new Size(200, 50);
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
            tabControl1.Size = new Size(767, 448);
            tabControl1.TabIndex = 4;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(listBoxArtists);
            tabPage1.Location = new Point(4, 41);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(759, 403);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Виконавці";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 15);
            label6.Name = "label6";
            label6.Size = new Size(230, 32);
            label6.TabIndex = 5;
            label6.Text = "Список виконавців";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtArtistName);
            groupBox1.Controls.Add(btnEditArtist);
            groupBox1.Controls.Add(btnDeleteArtist);
            groupBox1.Controls.Add(btnAddArtist);
            groupBox1.Location = new Point(10, 195);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(735, 195);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Керування";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 35);
            label5.Name = "label5";
            label5.Size = new Size(227, 32);
            label5.TabIndex = 4;
            label5.Text = "Введіть виконавця";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(listBoxSongs);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(759, 410);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Пісні";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 15);
            label9.Name = "label9";
            label9.Size = new Size(173, 32);
            label9.TabIndex = 5;
            label9.Text = "Список пісень";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cmbSongArtist);
            groupBox2.Controls.Add(txtSongTitle);
            groupBox2.Controls.Add(btnAddSong);
            groupBox2.Controls.Add(btnDeleteSong);
            groupBox2.Controls.Add(btnEditSong);
            groupBox2.Location = new Point(10, 195);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(735, 195);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Керування";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(375, 35);
            label8.Name = "label8";
            label8.Size = new Size(231, 32);
            label8.TabIndex = 5;
            label8.Text = "Оберіть виконавця";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 35);
            label7.Name = "label7";
            label7.Size = new Size(226, 32);
            label7.TabIndex = 4;
            label7.Text = "Введіть назву пісні";
            // 
            // cmbSongArtist
            // 
            cmbSongArtist.FormattingEnabled = true;
            cmbSongArtist.Location = new Point(375, 65);
            cmbSongArtist.Name = "cmbSongArtist";
            cmbSongArtist.Size = new Size(345, 40);
            cmbSongArtist.TabIndex = 2;
            // 
            // txtSongTitle
            // 
            txtSongTitle.Location = new Point(15, 65);
            txtSongTitle.Name = "txtSongTitle";
            txtSongTitle.Size = new Size(345, 39);
            txtSongTitle.TabIndex = 1;
            // 
            // btnAddSong
            // 
            btnAddSong.Location = new Point(15, 125);
            btnAddSong.Name = "btnAddSong";
            btnAddSong.Size = new Size(200, 50);
            btnAddSong.TabIndex = 3;
            btnAddSong.Text = "Додати";
            btnAddSong.UseVisualStyleBackColor = true;
            btnAddSong.Click += btnAddSong_Click;
            // 
            // btnDeleteSong
            // 
            btnDeleteSong.Location = new Point(520, 125);
            btnDeleteSong.Name = "btnDeleteSong";
            btnDeleteSong.Size = new Size(200, 50);
            btnDeleteSong.TabIndex = 3;
            btnDeleteSong.Text = "Видалити";
            btnDeleteSong.UseVisualStyleBackColor = true;
            btnDeleteSong.Click += btnDeleteSong_Click;
            // 
            // btnEditSong
            // 
            btnEditSong.Location = new Point(267, 125);
            btnEditSong.Name = "btnEditSong";
            btnEditSong.Size = new Size(200, 50);
            btnEditSong.TabIndex = 3;
            btnEditSong.Text = "Редагувати";
            btnEditSong.UseVisualStyleBackColor = true;
            btnEditSong.Click += btnEditSong_Click;
            // 
            // listBoxSongs
            // 
            listBoxSongs.FormattingEnabled = true;
            listBoxSongs.Location = new Point(10, 45);
            listBoxSongs.Name = "listBoxSongs";
            listBoxSongs.Size = new Size(735, 132);
            listBoxSongs.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(groupBoxDiscs);
            tabPage3.Controls.Add(clbDiscSongs);
            tabPage3.Controls.Add(listBoxDiscs);
            tabPage3.Location = new Point(4, 41);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(759, 403);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Альбоми";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(385, 15);
            label4.Name = "label4";
            label4.Size = new Size(173, 32);
            label4.TabIndex = 8;
            label4.Text = "Список пісень";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 15);
            label2.Name = "label2";
            label2.Size = new Size(206, 32);
            label2.TabIndex = 6;
            label2.Text = "Список альбомів";
            // 
            // groupBoxDiscs
            // 
            groupBoxDiscs.Controls.Add(label1);
            groupBoxDiscs.Controls.Add(labelDiscs1);
            groupBoxDiscs.Controls.Add(txtDiscYear);
            groupBoxDiscs.Controls.Add(btnAddDisc);
            groupBoxDiscs.Controls.Add(txtDiscTitle);
            groupBoxDiscs.Controls.Add(btnDeleteDisc);
            groupBoxDiscs.Controls.Add(btnEditDisc);
            groupBoxDiscs.Location = new Point(10, 195);
            groupBoxDiscs.Name = "groupBoxDiscs";
            groupBoxDiscs.Size = new Size(735, 195);
            groupBoxDiscs.TabIndex = 5;
            groupBoxDiscs.TabStop = false;
            groupBoxDiscs.Text = "Керування";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(375, 35);
            label1.Name = "label1";
            label1.Size = new Size(133, 32);
            label1.TabIndex = 5;
            label1.Text = "Рік виходу";
            // 
            // labelDiscs1
            // 
            labelDiscs1.AutoSize = true;
            labelDiscs1.Location = new Point(15, 35);
            labelDiscs1.Name = "labelDiscs1";
            labelDiscs1.Size = new Size(186, 32);
            labelDiscs1.TabIndex = 4;
            labelDiscs1.Text = "Назва альбому";
            // 
            // txtDiscYear
            // 
            txtDiscYear.Location = new Point(375, 65);
            txtDiscYear.Name = "txtDiscYear";
            txtDiscYear.Size = new Size(345, 39);
            txtDiscYear.TabIndex = 2;
            // 
            // btnAddDisc
            // 
            btnAddDisc.Location = new Point(15, 125);
            btnAddDisc.Name = "btnAddDisc";
            btnAddDisc.Size = new Size(200, 50);
            btnAddDisc.TabIndex = 3;
            btnAddDisc.Text = "Додати";
            btnAddDisc.UseVisualStyleBackColor = true;
            btnAddDisc.Click += btnAddDisc_Click;
            // 
            // txtDiscTitle
            // 
            txtDiscTitle.Location = new Point(15, 65);
            txtDiscTitle.Name = "txtDiscTitle";
            txtDiscTitle.Size = new Size(345, 39);
            txtDiscTitle.TabIndex = 1;
            // 
            // btnDeleteDisc
            // 
            btnDeleteDisc.Location = new Point(520, 125);
            btnDeleteDisc.Name = "btnDeleteDisc";
            btnDeleteDisc.Size = new Size(200, 50);
            btnDeleteDisc.TabIndex = 3;
            btnDeleteDisc.Text = "Видалити";
            btnDeleteDisc.UseVisualStyleBackColor = true;
            btnDeleteDisc.Click += btnDeleteDisc_Click;
            // 
            // btnEditDisc
            // 
            btnEditDisc.Location = new Point(267, 125);
            btnEditDisc.Name = "btnEditDisc";
            btnEditDisc.Size = new Size(200, 50);
            btnEditDisc.TabIndex = 3;
            btnEditDisc.Text = "Редагувати";
            btnEditDisc.UseVisualStyleBackColor = true;
            btnEditDisc.Click += btnEditDisc_Click;
            // 
            // clbDiscSongs
            // 
            clbDiscSongs.FormattingEnabled = true;
            clbDiscSongs.Location = new Point(385, 45);
            clbDiscSongs.Name = "clbDiscSongs";
            clbDiscSongs.Size = new Size(360, 112);
            clbDiscSongs.TabIndex = 4;
            clbDiscSongs.Click += listBoxDiscs_SelectedIndexChanged;
            clbDiscSongs.SelectedIndexChanged += listBoxDiscs_SelectedIndexChanged;
            // 
            // listBoxDiscs
            // 
            listBoxDiscs.FormattingEnabled = true;
            listBoxDiscs.Location = new Point(10, 45);
            listBoxDiscs.Name = "listBoxDiscs";
            listBoxDiscs.Size = new Size(360, 132);
            listBoxDiscs.TabIndex = 0;
            // 
            // Form1
            // 
            AcceptButton = btnAddArtist;
            ClientSize = new Size(792, 472);
            Controls.Add(tabControl1);
            Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Довідник";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBoxDiscs.ResumeLayout(false);
            groupBoxDiscs.PerformLayout();
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
        private GroupBox groupBoxDiscs;
        private Label labelDiscs1;
        private Label label2;
        private Label label1;
        private Label label4;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private GroupBox groupBox2;
        private Label label8;
        private Label label7;
        private Label label9;
    }
}