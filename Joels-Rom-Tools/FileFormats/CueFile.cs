using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joels_Rom_Tools.FileFormats
{
    class IndexField
    {
        public string IndexIndex { get; set; } = "";
        public string Minutes { get; set; } = "";
        public string Seconds { get; set; } = "";
        public string Frames { get; set; } = "";//75 frames per second

        public override string ToString()
        {
            return $"\t\tINDEX {IndexIndex} {Minutes}:{Seconds}:{Frames}";
        }
    }
    class TrackField
    {
        public string TrackIndex { get; set; } = "";
        public string Mode { get; set; } = "";

        public List<IndexField> IndexFields = new List<IndexField>();

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"\tTRACK {TrackIndex} {Mode}");
            foreach (var field in IndexFields) { sb.AppendLine(field.ToString()); }

            return sb.ToString();
        }
    }
    class FileField
    {
        public string FileName { get; set; } = "";
        public string Type { get; set; } = "";

        public List<TrackField> Tracks = new List<TrackField>();

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"FILE {FileName} {Type}");
            foreach (var field in Tracks) { sb.Append(field.ToString()); }
            sb.AppendLine();
            return sb.ToString();
        }

    }
    internal class CueFile
    {
        public List<FileField> Fields = new List<FileField>();

        public CueFile() { }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var f in Fields)
            {
                sb.Append(f.ToString());
            }
            return sb.ToString();
        }

        public CueFile(string data)
        {

            FileField? currentFile = null;
            var currentTrack = new TrackField();

            foreach (var line in data.Split(Environment.NewLine))
            {
                if (line.Trim().StartsWith("FILE"))
                {
                    var bits = line.Split("\"", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
                    if (currentFile != null)
                    {
                        Fields.Add(currentFile);
                        currentFile = new FileField { FileName = bits[1], Type = bits[2] };
                    }
                    else
                    {
                        currentFile = new FileField { FileName = bits[1], Type = bits[2] };
                    }
                }

                if (line.Trim().StartsWith("TRACK"))
                {
                    var trackBits = line.Trim().Split(" ");
                    currentTrack = new TrackField { IndexFields = new List<IndexField>(), Mode = trackBits[2], TrackIndex = trackBits[1] };
                    currentFile?.Tracks.Append(currentTrack);
                }
                if (line.Trim().StartsWith("INDEX"))
                {
                    var indexBits = line.Trim().Split(" ");
                    var timestamp = indexBits.Last().Split(":");
                    var currentIndex = new IndexField
                    {
                        IndexIndex = indexBits[1],
                        Minutes = timestamp[0],
                        Seconds = timestamp[1],
                        Frames = timestamp[2]
                    };
                    currentTrack?.IndexFields.Append(currentIndex);
                }
            }

            Fields.Append(currentFile);
        }

    }
}
