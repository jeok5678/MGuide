using MusicGuide.Models;

namespace MusicGuide
{
    public partial class Form1 : Form
    {
        private MusicDatabase db = new MusicDatabase();

        public Form1()
        {
            InitializeComponent();
            db.Load(); // Загрузка данных из файла data.json 
            UpdateList();
        }

        private void UpdateList()
        {
            // 1. Исполнители
            listBoxArtists.DataSource = null;
            listBoxArtists.DataSource = db.Artists;
            listBoxArtists.DisplayMember = "Name";

            // 2. Выпадающий список для привязки песен к артистам
            cmbSongArtist.DataSource = null;
            cmbSongArtist.DataSource = db.Artists;
            cmbSongArtist.DisplayMember = "Name";
            cmbSongArtist.ValueMember = "Id";

            // 3. Песни
            listBoxSongs.DataSource = null;
            listBoxSongs.DataSource = db.Songs;
            listBoxSongs.DisplayMember = "Title";

            // 4. Альбомы
            listBoxDiscs.DataSource = null;
            listBoxDiscs.DataSource = db.Discs;
            listBoxDiscs.DisplayMember = "Title";

            // 5. Список песен с галочками для формирования альбома [cite: 263]
            clbDiscSongs.Items.Clear();
            foreach (var song in db.Songs)
            {
                clbDiscSongs.Items.Add(song);
            }
            clbDiscSongs.DisplayMember = "Title";
        }

        // --- УПРАВЛЕНИЕ ИСПОЛНИТЕЛЯМИ ---
        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtArtistName.Text))
            {
                db.Artists.Add(new Artist { Name = txtArtistName.Text.Trim() });
                db.Save();
                UpdateList();
                txtArtistName.Clear();
            }
        }

        private void btnEditArtist_Click(object sender, EventArgs e)
        {
            if (listBoxArtists.SelectedItem is Artist selected && !string.IsNullOrWhiteSpace(txtArtistName.Text))
            {
                selected.Name = txtArtistName.Text.Trim();
                db.Save();
                UpdateList();
            }
        }

        private void btnDeleteArtist_Click(object sender, EventArgs e)
        {
            if (listBoxArtists.SelectedItem is Artist selected)
            {
                db.Artists.Remove(selected);
                db.Save();
                UpdateList();
            }
        }

        // --- УПРАВЛЕНИЕ ПЕСНЯМИ ---
        private void btnAddSong_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSongTitle.Text) && cmbSongArtist.SelectedItem is Artist art)
            {
                db.Songs.Add(new Song { Title = txtSongTitle.Text.Trim(), ArtistId = art.Id });
                db.Save();
                UpdateList();
                txtSongTitle.Clear();
            }
        }

        private void btnDeleteSong_Click(object sender, EventArgs e)
        {
            if (listBoxSongs.SelectedItem is Song selected)
            {
                db.Songs.Remove(selected);
                db.Save();
                UpdateList();
            }
        }

        // --- УПРАВЛЕНИЕ АЛЬБОМАМИ ---
        private void btnAddDisc_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDiscTitle.Text) && int.TryParse(txtDiscYear.Text, out int year))
            {
                var newDisc = new Disc { Title = txtDiscTitle.Text.Trim(), Year = year };

                // Собираем ID всех песен, отмеченных галочками [cite: 263]
                foreach (var item in clbDiscSongs.CheckedItems)
                {
                    if (item is Song s) newDisc.SongIds.Add(s.Id);
                }

                db.Discs.Add(newDisc);
                db.Save();
                UpdateList();
                txtDiscTitle.Clear();
                txtDiscYear.Clear();
            }
        }

        private void btnEditDisc_Click(object sender, EventArgs e)
        {
            if (listBoxDiscs.SelectedItem is Disc selected && !string.IsNullOrWhiteSpace(txtDiscTitle.Text) && int.TryParse(txtDiscYear.Text, out int year))
            {
                selected.Title = txtDiscTitle.Text.Trim();
                selected.Year = year;
                selected.SongIds.Clear();

                foreach (var item in clbDiscSongs.CheckedItems)
                {
                    if (item is Song s) selected.SongIds.Add(s.Id);
                }

                db.Save();
                UpdateList();
            }
        }

        private void btnDeleteDisc_Click(object sender, EventArgs e)
        {
            if (listBoxDiscs.SelectedItem is Disc selected)
            {
                db.Discs.Remove(selected);
                db.Save();
                UpdateList();
            }
        }

        // Синхронизация полей и галочек при выборе альбома из списка
        private void listBoxDiscs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDiscs.SelectedItem is Disc selected)
            {
                txtDiscTitle.Text = selected.Title;
                txtDiscYear.Text = selected.Year.ToString();

                // Проставляем галочки только тем песням, которые входят в альбом
                for (int i = 0; i < clbDiscSongs.Items.Count; i++)
                {
                    if (clbDiscSongs.Items[i] is Song s)
                    {
                        clbDiscSongs.SetItemChecked(i, selected.SongIds.Contains(s.Id));
                    }
                }
            }
        }

    }
}