using MusicGuide.Models;

namespace MusicGuide
{
    public partial class Form1 : Form
    {
        private MusicDatabase db = new MusicDatabase();

        public Form1()
        {
            InitializeComponent();
            db.Load(); // Завантаження данних
            UpdateList();

        }

        private void UpdateList()
        {
            // 1. Виконавці
            listBoxArtists.DataSource = null;
            listBoxArtists.DataSource = db.Artists;
            listBoxArtists.DisplayMember = "Name";

            // 2. Список для прив'язки до виконавців
            cmbSongArtist.DataSource = null;
            cmbSongArtist.DataSource = db.Artists;
            cmbSongArtist.DisplayMember = "Name";
            cmbSongArtist.ValueMember = "Id";

            // 3. Пісні
            listBoxSongs.DataSource = null;
            listBoxSongs.DataSource = db.Songs;
            listBoxSongs.DisplayMember = "Title";

            // 4. Альбоми
            listBoxDiscs.DataSource = null;
            listBoxDiscs.DataSource = db.Discs;
            listBoxDiscs.DisplayMember = "Title";

            // 5. Список пісень з галочками
            clbDiscSongs.Items.Clear();
            foreach (var song in db.Songs)
            {
                clbDiscSongs.Items.Add(song);
            }
            clbDiscSongs.DisplayMember = "Title";
        }

        // --- Управління виконавцями ---
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

        // --- Управління піснями ---
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
        private void btnEditSong_Click(object sender, EventArgs e)
        {
            if (listBoxSongs.SelectedItem is Song selected &&
                !string.IsNullOrWhiteSpace(txtSongTitle.Text) &&
                cmbSongArtist.SelectedItem is Artist art)
            {
                selected.Title = txtSongTitle.Text.Trim();
                selected.ArtistId = art.Id;
                db.Save();
                UpdateList();
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

        // --- Управління альбомами ---
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
                // 1. Запам'ятовуємо, на якому альбомі ми зараз стоїмо
                int currentIndex = listBoxDiscs.SelectedIndex;

                // 2. Оновлюємо дані
                selected.Title = txtDiscTitle.Text.Trim();
                selected.Year = year;

                // 3. Очищаємо старі пісні і записуємо нові (ті, що з галочками)
                selected.SongIds.Clear();
                foreach (var item in clbDiscSongs.CheckedItems)
                {
                    if (item is Song s) selected.SongIds.Add(s.Id);
                }

                db.Save();
                UpdateList();

                // 4. Повертаємо виділення назад на наш альбом, щоб не було "стрибка"
                if (currentIndex >= 0 && currentIndex < listBoxDiscs.Items.Count)
                {
                    listBoxDiscs.SelectedIndex = currentIndex;
                }
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
            // Якщо нічого не обрано (наприклад, під час UpdateList), просто виходимо
            if (listBoxDiscs.SelectedIndex == -1) return;

            if (listBoxDiscs.SelectedItem is Disc selected)
            {
                txtDiscTitle.Text = selected.Title;
                txtDiscYear.Text = selected.Year.ToString();

                // Жорстко перевіряємо кожну пісню: є в альбомі — ставимо галочку, немає — знімаємо
                for (int i = 0; i < clbDiscSongs.Items.Count; i++)
                {
                    if (clbDiscSongs.Items[i] is Song s)
                    {
                        bool isSongInAlbum = selected.SongIds.Contains(s.Id);
                        clbDiscSongs.SetItemChecked(i, isSongInAlbum);
                    }
                }
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Реалізація F1 – допомога
            if (keyData == Keys.F1)
            {
                ShowHelp();
                return true;
            }

            // Реалізація Esc – закриття або скасування
            if (keyData == Keys.Escape)
            {
                var result = MessageBox.Show("Ви впевнені, що хочете закрити програму?",
                    "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) this.Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ShowHelp()
        {
            string helpText = "";
            string title = "";

            // Визначаємо контекст довідки залежно від обраної вкладки
            switch (tabControl1.SelectedIndex)
            {
                case 0: // Вкладка "Виконавці"
                    title = "Довідка: Виконавці";
                    helpText = "На цій вкладці ви керуєте списком артистів:\n\n" +
                               "• Щоб додати: введіть ім'я у поле та натисніть Enter.\n" +
                               "• Щоб змінити: оберіть артиста у списку, відредагуйте текст і натисніть «Редагувати».\n" +
                               "• Щоб видалити: оберіть запис і натисніть клавішу «Видалити».";
                    break;

                case 1: // Вкладка "Пісні"
                    title = "Довідка: Пісні";
                    helpText = "Тут ви створюєте базу ваших треків:\n\n" +
                               "1. Оберіть виконавця зі списку (це обов'язково).\n" +
                               "2. Введіть назву пісні.\n" +
                               "3. Натисніть «Додати».\n\n" +
                               "Кожна пісня прив'язується до конкретного артиста через унікальний ідентифікатор (GUID).";
                    break;

                case 2: // Вкладка "Альбоми"
                    title = "Довідка: Альбоми";
                    helpText = "Ця вкладка реалізує логіку зв'язків:\n\n" +
                               "• Додавання: введіть назву та рік, позначте галочками потрібні пісні і натисніть «Додати».\n" +
                               "• Редагування: оберіть альбом, змініть склад пісень і ОБОВ'ЯЗКОВО натисніть «Редагувати», щоб зберегти нові галочки.\n" +
                               "• Видалення: оберіть альбом і натисніть «Видалити».";
                    break;

                default:
                    title = "Загальна довідка";
                    helpText = "Використовуйте Tab для навігації та Esc для виходу.";
                    break;
            }

            // Виводимо повідомлення з відповідною іконкою та заголовком
            MessageBox.Show(helpText, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }    
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Міняємо "головну кнопку" при переході на іншу вкладку
            switch (tabControl1.SelectedIndex)
            {
                case 0: this.AcceptButton = btnAddArtist; break;
                case 1: this.AcceptButton = btnAddSong; break;
                case 2: this.AcceptButton = btnAddDisc; break;
            }
        }
    }
}