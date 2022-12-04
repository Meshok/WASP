using System;
using System.Collections.Generic;
using System.Text;

namespace WASP_PR_3
{
    class Audio : Disk
    {
        private string _artist;
        private string _recordingStudio;
        private int _songsNumber;

        public override int DiskSize { get => _songsNumber * 8; }

        public Audio(string artist, string recordingStudio, int songsNumber, string name, string genre) : base(name, genre)
        {
            _artist = artist;
            _recordingStudio = recordingStudio;
            _songsNumber = songsNumber;
        }

        public override void Burn(params string[] values)
        {
            _artist = values[0];
            _recordingStudio = values[1];
            _songsNumber = Convert.ToInt32(values[2]);
            _birnCount++;
        }

        public override string ToString()
        {
            return
                base.ToString() +
                $", исполнитель: {_artist}, студия звукозаписи: {_recordingStudio}" +
                $", количество песен: {_songsNumber}, количество прожигов: {_birnCount}";
        }
    }
}
