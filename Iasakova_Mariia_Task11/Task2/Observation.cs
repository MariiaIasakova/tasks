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
        static int countForm;

        FileSystemWatcher watcher;

        public Observation(string _mainPath, string _path)
        {
            PathDirectory = _path;

            watcher = new FileSystemWatcher(path)
            {
                NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                | NotifyFilters.FileName | NotifyFilters.DirectoryName
            };

            watcher.IncludeSubdirectories = true;
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            pathObservation = _mainPath;
            countForm++;
        }

        public string PathDirectory
        {
            get => path;
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    path = value;
                }
            }
        }

        #region FunctionsForWork
        public void StartObservation()
        {
            countForm = TestForm();
            pathObservation = Path.Combine(pathObservation, $"observation{countForm}");
            Directory.CreateDirectory(pathObservation);
            var newPath1 = Path.Combine(pathObservation, DateTime.Now.ToString("yyyyMMddHH_mm_ss"));
            Directory.CreateDirectory(newPath1);
            CopyDirectoriesAndFiles(newPath1, path);
            watcher.EnableRaisingEvents = true;
        }

        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            if (Directory.Exists(path))
            {
                var newPath = Path.Combine(pathObservation, DateTime.Now.ToString("yyyyMMddHH_mm_ss"));
                Directory.CreateDirectory(newPath);
                CopyDirectoriesAndFiles(newPath, path);
            }
        }

        public List<string> WriteCopies()
        {
            List<string> dateTimes = new List<string>();
            foreach (var dir in Directory.EnumerateDirectories(pathObservation))
            {
                dateTimes.Add(new DirectoryInfo(dir).Name.ToString());
            }
            return dateTimes;
        }

        public void RollbackChanges(string dateTimeOfChange)
        {
            DeleteDirectoriesAndFiles(path);
            var newPath = Path.Combine(pathObservation, dateTimeOfChange);
            CopyDirectoriesAndFiles(path, newPath);
        }

        public void EndObservation()
        {
            watcher.EnableRaisingEvents = false;
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
                    var newPathInDir = Path.Combine(newPath, new DirectoryInfo(item).Name.ToString());
                    Directory.CreateDirectory(newPathInDir);
                    CopyDirectoriesAndFiles(newPathInDir, item);
                }
            }
        }

        static void CopyFiles(string[] files, string pathObject)
        {
            foreach (var item in files)
            {
                var newPath = Path.Combine(pathObject, new FileInfo(item).Name.ToString());
                File.Copy(item, newPath, true);
            }
        }

        static void DeleteDirectoriesAndFiles(string pathObject)
        {
            string[] files = Directory.GetFiles(pathObject);
            if (files.Length != 0)
            {
                foreach (var item in files)
                {
                    File.Delete(item);
                }
            }
            string[] directories = Directory.GetDirectories(pathObject);
            if (directories.Length != 0)
            {
                foreach (var item in directories)
                {
                    Directory.Delete(item, true);
                }
            }
        }

        static int TestForm()
        {
            var newPath = Path.Combine(pathObservation, $"observation{countForm}");
            if (Directory.Exists(newPath))
            {
                countForm++;
                TestForm();
            }
            return countForm;
        }
        #endregion
    }
}
