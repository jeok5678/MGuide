using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace MusicGuide.Models
{
    public class Artist
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = "";

        public override string ToString() => Name;
    }

    public class Song
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = "";
        public Guid ArtistId { get; set; }

        public override string ToString() => Title;
    }

    public class Disc
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = "";
        public int Year { get; set; }
        public List<Guid> SongIds { get; set; } = new();

        public override string ToString() => $"{Title} ({Year})";
    }

    public class MusicDatabase
    {
        public List<Artist> Artists { get; set; } = new();
        public List<Song> Songs { get; set; } = new();
        public List<Disc> Discs { get; set; } = new();

        private readonly string path = "data.json";

        public void Save()
        {
            File.WriteAllText(path, JsonSerializer.Serialize(this));
        }

        public void Load()
        {
            if (File.Exists(path))
            {
                var d = JsonSerializer.Deserialize<MusicDatabase>(File.ReadAllText(path));

                if (d != null)
                {
                    Artists = d.Artists;
                    Songs = d.Songs;
                    Discs = d.Discs;
                }
            }
        }
    }
}
