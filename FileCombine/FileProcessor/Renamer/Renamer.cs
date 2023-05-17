using FileProcessor.Renamer.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor.Renamer
{
    public class Renamer
    {
        private IStringGenerator generator;
        public List<FileInfo> Files { get; set; }
        public int AIStartValue { get; set; } = 0;
        public int AIStep { get; set; } = 1;

        public Renamer(List<FileInfo> files, RenamerMode mode)      // TODO: List<FileInfo>  ---> IEnumerable<FileInfo>
        {
            Files = files;

            SetMode(mode);
        }

        public void SetMode(RenamerMode mode)
        {
            generator = mode switch 
            {
                RenamerMode.UUID => new UuidGenerator(),
                RenamerMode.AUTOINCREMENT => new AutoincrementGenerator(AIStartValue, AIStep),

                _ => throw new InvalidOperationException(),
            };
        }

        public Report Rename(string prefix)
        {
            Report report = new Report();

            Files.ForEach(f => 
            {
                try
                {
                    //if (f.Name == "1.jpg")
                    //    throw new Exception("test message");

                    string ext = f.Extension;

                    string randomChunk = generator.GetNext();

                    string newTitle = $"{prefix}{randomChunk}{ext}";

                    string path = Path.Combine(f.Directory.FullName, newTitle); // TODO: ???

                    f.MoveTo(path);

                    report.PushSuccess(f);
                }
                catch (Exception ex)
                {
                    report.PushError(f, ex);
                    
                }
            });

            return report;
        }
    }
}
