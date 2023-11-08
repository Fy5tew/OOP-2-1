namespace lab12 {
    internal class Program {
        static void Main(string[] args) {
            string labDirPath = @"D:\Study\2c1s\OOP\lab12\lab12\";
            string logFilePath = Path.Combine(labDirPath, "lab12.log");
            string managedDirPath = Path.Combine(labDirPath, "Managed");

            TNALog logger = new TNALog(logFilePath);
            TNADiskInfo diskInfo = new TNADiskInfo();
            TNAFileInfo fileInfo = new TNAFileInfo(logFilePath);
            TNADirInfo dirInfo = new TNADirInfo(labDirPath);
            TNAFileManager fileManager = new TNAFileManager(managedDirPath);

            diskInfo.Logger = logger;
            fileInfo.Logger = logger;
            dirInfo.Logger = logger;
            fileManager.Logger = logger;


            Console.WriteLine("\n\t\tDiskInfo");
            Console.WriteLine(diskInfo.GetFormattedDisksInfo());
            Console.WriteLine(diskInfo.GetFormattedDiskInfo(@"D:\"));
            Console.WriteLine(diskInfo.GetFormattedDiskFreeSpace(@"C:\"));
            Console.WriteLine(diskInfo.GetFormattedDiskFileSystem(@"C:\"));


            Console.WriteLine("\n\t\tFileInfo");
            Console.WriteLine(fileInfo.GetFormattedInfo());
            Console.WriteLine($"{fileInfo.GetName()}, {fileInfo.GetExtension()}, {fileInfo.GetFormattedSize()}");
            

            Console.WriteLine("\n\t\tDirInfo");
            Console.WriteLine(dirInfo.GetFormattedInfo());
            Console.WriteLine(dirInfo.GetFormattedFiles());
            Console.WriteLine(dirInfo.GetFormattedDirectories());


            Console.WriteLine("\n\t\tFileManager");

            try { fileManager.DeleteFile(Path.Combine("TNAInspect", "tnadirinfo.txt")); } catch { }
            try { fileManager.DeleteFile(Path.Combine("TNAInspect", "tnadirinfo_copy.txt")); } catch { }
            try { fileManager.DeleteDirectory("TNAInspect"); } catch { }

            try { fileManager.DeleteFile(Path.Combine("TNAFiles", "test.txt")); } catch { }
            try { fileManager.DeleteFile(Path.Combine("TNAFiles", "test2.txt")); } catch { }
            try { fileManager.DeleteDirectory("TNAFiles"); } catch { }

            try { fileManager.DeleteFile("TNAFilesArchive.zip"); } catch { }

            try { fileManager.DeleteFile(Path.Combine("TNAFilesExtracted", "test.txt")); } catch { }
            try { fileManager.DeleteFile(Path.Combine("TNAFilesExtracted", "test2.txt")); } catch { }
            try { fileManager.DeleteDirectory("TNAFilesExtracted"); } catch { }

            Console.WriteLine($"Directory: {fileManager.DirectoryPath}");

            fileManager.ChangeDirectory("Prepared");
            string[] preparedFiles = fileManager.Files;
            Console.WriteLine($"Directory: {fileManager.DirectoryPath}");
            Console.WriteLine($"Files: {string.Join(", ", fileManager.Files)}");
            Console.WriteLine($"Directories: {string.Join(", ", fileManager.Directories)}");

            fileManager.ChangeDirectory("..");
            Console.WriteLine($"Directory: {fileManager.DirectoryPath}");
            fileManager.CreateDirectory("TNAInspect");
            Console.WriteLine($"Objects: {string.Join(", ", fileManager.Objects)}");

            fileManager.ChangeDirectory("TNAInspect");
            Console.WriteLine($"Directory: {fileManager.DirectoryPath}");
            fileManager.CreateFile("tnadirinfo.txt");
            fileManager.WriteToFile("tnadirinfo.txt", "Hello, world!");
            fileManager.CopyFile(
                Path.Combine(fileManager.DirectoryPath, "tnadirinfo.txt"), 
                Path.Combine(fileManager.DirectoryPath, "tnadirinfo_copy.txt")
            );
            Console.WriteLine($"Objects: {string.Join(", ", fileManager.Objects)}");
            fileManager.DeleteFile("tnadirinfo.txt");

            fileManager.ChangeDirectory("..");
            Console.WriteLine($"Directory: {fileManager.DirectoryPath}");
            fileManager.CreateDirectory("TNAFiles");
            Console.WriteLine($"Objects: {string.Join(", ", fileManager.Objects)}");

            foreach (string fileName in preparedFiles) {
                if (fileName.EndsWith(".txt")) {
                    fileManager.CopyFile(
                        Path.Combine(fileManager.DirectoryPath, "Prepared", fileName),
                        Path.Combine(fileManager.DirectoryPath, "TNAFiles", fileName)
                    );
                }
            }

            fileManager.ChangeDirectory("TNAFiles");
            Console.WriteLine($"Directory: {fileManager.DirectoryPath}");
            Console.WriteLine($"Objects: {string.Join(", ", fileManager.Objects)}");

            fileManager.ChangeDirectory("..");
            fileManager.CreateArchive(
                "TNAFiles",
                Path.Combine(fileManager.DirectoryPath, "TNAFilesArchive.zip")
            );
            fileManager.CreateDirectory("TNAFilesExtracted");
            fileManager.ExtractArchive(
                "TNAFilesArchive.zip",
                "TNAFilesExtracted"
            );
            Console.WriteLine($"Directory: {fileManager.DirectoryPath}");
            Console.WriteLine($"Objects: {string.Join(", ", fileManager.Objects)}");

            fileManager.ChangeDirectory("TNAFilesExtracted");
            Console.WriteLine($"Directory: {fileManager.DirectoryPath}");
            Console.WriteLine($"Objects: {string.Join(", ", fileManager.Objects)}");

            fileManager.ChangeDirectory("..");


            Console.WriteLine("\n\t\tLogger");
            Console.WriteLine(logger.FindLogs($"{DateTime.Now.Day.ToString("D2")}." +
                                              $"{DateTime.Now.Month.ToString("D2")}." +
                                              $"{DateTime.Now.Year.ToString("D4")} " +
                                              $"{DateTime.Now.Hour.ToString("D2")}"));

            if (logger.GetLogs().Split(Environment.NewLine).Length > 2500) {
                logger.ClearLogs();
            }
        }
    }
}