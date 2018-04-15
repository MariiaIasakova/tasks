using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Observation
    {
        static string path, pathObservation;

        FileSystemWatcher watcher = new FileSystemWatcher(path)
        {
            NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                | NotifyFilters.FileName | NotifyFilters.DirectoryName
        };

        public Observation(string _mainPath, string _path, int i)
        {
            PathDirectory = _path;
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            pathObservation = Directory.CreateDirectory(Path.Combine(_mainPath, $"observation{i}")).ToString();

        }

        public string PathDirectory
        {
            get => path;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    path = value;
                }
            }
        }

        #region FunctionsForWork
        public void StartObservation()
        {
            watcher.EnableRaisingEvents = true;
        }

        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            if (!Directory.Exists(path))
            {
                DateTime dateTimeNow = DateTime.Now;
                var newPath = Directory.CreateDirectory(Path.Combine(pathObservation, dateTimeNow.ToString())).ToString();
                CopyDirectoriesAndFiles(dateTimeNowб newPath);
            }
        }

        public List<DateTime> WriteCopies()
        {
            List<DateTime> dateTimes = new List<DateTime>();
            foreach (var file in Directory.EnumerateDirectories(pathObservation))
            {
                dateTimes.Add(Directory.GetCreationTime(file));
            }
            return dateTimes;
        }

        public void RollbackChanges(DateTime dateTimeOfChange)
        {
            Directory.Delete(path);
            CopyDirectoriesAndFiles(path, );
        }

        public void EndObservation(string value)
        {
            watcher.EnableRaisingEvents = false;
            if (value != "Y" | value != "N")
            {
                throw new Exception("Entered the wrong value");
            }
            else if (value == "Y")
            {
                Directory.Delete(pathObservation);
            }
        }
        #endregion

        #region SecondaryFunctions
        static void CopyDirectoriesAndFiles( string newPath, string oldPath)
        {
            string[] files = Directory.GetFiles(oldPath);
            if (files.Length != 0)
            {
                CopyFiles(files, newPath);
            }
            string[] directories = Directory.GetDirectories(oldPath);
            if (directories.Length != 0)
            {
                foreach (var item in directories)
                {
                    var newPathInDir = Directory.CreateDirectory(Path.Combine(newPath, Path.GetDirectoryName(item))).ToString();
                    string[] filesInDir = Directory.GetFiles(item);
                    if (files.Length != 0)
                    {
                        CopyFiles(filesInDir, newPathInDir);
                    }
                }
            }
        }

        static void CopyFiles(string[] files, string path)
        {
            foreach (var item in files)
            {
                File.Copy(item, path, true);
            }
        }
        #endregion
    }
}
