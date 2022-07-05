using Joels_Rom_Tools.FileFormats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joels_Rom_Tools.Workflows
{
    public class CombineBinsWorkflow : IWorkflow
    {
        private List<string> _binPaths;
        private string _newCueFile;
        private string _newBinFile;
        private bool _rmOldFiles;

        public CombineBinsWorkflow(List<string> binFilePaths, string newCueFile, string newBinFile, bool rmOldFiles)
        {
            _binPaths = binFilePaths;
            _newCueFile = newCueFile;
            _newBinFile = newBinFile;
            _rmOldFiles = rmOldFiles;
        }

        private IndexField FramesToIndexField(int frames)
        {
            int minutes = 0;
            int seconds = 0;

            int accum = frames;

            while (accum > (60 * 75))
            {
                accum -= (60 * 75);
                minutes++;
            }

            while (accum > (75))
            {
                accum -= (75);
                seconds++;
            }

            int fx = accum;

            return new IndexField
            {
                IndexIndex = "01",
                Frames = fx.ToString("00"),
                Seconds = seconds.ToString("00"),
                Minutes = minutes.ToString("00"),
            };
        }

        public async Task StartAsync(Action<WorkflowProgressUpdate>? onProgressUpdate, Action? onWorkflowComplete, Action<string,Exception>? onWorkflowFailed)
        {
            await Task.Run(() =>
            {
                var trackFields = new List<TrackField> { };
                // step 1 -- build out the cue file.
                int count = 1;
                int runningFrames = 0;
                var bins = _binPaths;
                var newTracks = new List<TrackField> { };
                try
                {
                    var newBinStream = File.Create(_newBinFile);

                    onProgressUpdate?.Invoke(new WorkflowProgressUpdate("Starting Task", 0));

                    var firstBin = bins[0];
                    byte[] bits = File.ReadAllBytes(firstBin);
                    onProgressUpdate?.Invoke(new WorkflowProgressUpdate($"Read {bits.Length}", 100 * count / bins.Count));
                    newBinStream.Write(bits, 0, bits.Length);
                    onProgressUpdate?.Invoke(new WorkflowProgressUpdate($"Wrote {bits.Length}", 100 * count / bins.Count));

                    newTracks = new List<TrackField>{ new TrackField {
                            TrackIndex="01",
                            Mode= "MODE2/2352",
                            IndexFields =new List<IndexField> {
                                new IndexField{IndexIndex = "01",
                                    Frames="00",
                                    Minutes="00",
                                    Seconds="00"  } } } };


                    for (int i = 1; i < bins.Count; i++)

                    {
                        runningFrames += (bits.Length / (2352));
                        var bin = bins[i];
                        bits = File.ReadAllBytes(bin);
                        var tx = new TrackField
                        {
                            TrackIndex = (i + 1).ToString("00"),
                            Mode = "AUDIO",
                            IndexFields = new List<IndexField> {
                            FramesToIndexField(runningFrames)
                        }
                        };
                        newTracks.Add(tx);
                        onProgressUpdate?.Invoke(new WorkflowProgressUpdate($"Read {bits.Length}", 100 * count / bins.Count));
                        newBinStream.Write(bits, 0, bits.Length);
                        onProgressUpdate?.Invoke(new WorkflowProgressUpdate($"Wrote {bits.Length}", 100 * count / bins.Count));
                        count++;

                    }

                    newBinStream.Close();
                }
                catch (Exception ex){
                    onWorkflowFailed?.Invoke($"Unable to write {_newBinFile}", ex);
                    return;

                }

                var newCF = new CueFile()
                {
                    Fields = new List<FileField>{ new FileField {
                        FileName = "\""+_newBinFile+"\"",
                        Type = "BINARY",
                        Tracks =newTracks
                        }
                    }
                };

                File.WriteAllText(_newCueFile, newCF.ToString());

                if (_rmOldFiles)
                {
                    try
                    {
                        onProgressUpdate?.Invoke(new WorkflowProgressUpdate($"Removing old bins", 100));
                        foreach (var b in bins)
                        {

                            File.Delete(b);
                        }
                    }
                    catch (Exception ex) {
                        onWorkflowFailed?.Invoke($"Unable to remove old bins.", ex);
                        return;
                    }
                }
                onProgressUpdate?.Invoke(new WorkflowProgressUpdate($"Done.", 100));


                onWorkflowComplete?.Invoke();

            });
        }
    }
}
