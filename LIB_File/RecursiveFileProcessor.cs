// For Directory.GetFiles and Directory.GetDirectories
// For File.Exists, Directory.Exists
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace LIB_File
{
    public class RecursiveFileProcessor
    {
        private static List<string> ExcludeExtensions { get; set; }
        public static List<ProcessedFile> Main(string[] args, string[] exceptions = null)
        {
            if (exceptions != null) ExcludeExtensions = new List<string>(exceptions);
            List<ProcessedFile> files = new List<ProcessedFile>();

            foreach (string path in args)
            {
                if (File.Exists(path))
                {
                    // This path is a file
                    files.Add(ProcessFile(path));
                }
                else if (Directory.Exists(path))
                {
                    // This path is a directory
                    files.AddRange(ProcessDirectory(path));
                }
                else
                {
                    Console.WriteLine("{0} is not a valid file or directory.", path);
                }
            }
            return files;
        }


        // Process all files in the directory passed in, recurse on any directories 
        // that are found, and process the files they contain.
        public static List<ProcessedFile> ProcessDirectory(string targetDirectory)
        {
            List<ProcessedFile> files = new List<ProcessedFile>();

            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries) {
                var file = ProcessFile(fileName);
                if (file != null) files.Add(file);
            }

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                files.AddRange(ProcessDirectory(subdirectory));

            return files;
        }

        // Insert logic for processing found files here.
        public static ProcessedFile ProcessFile(string path, int package = 0)
        {
            ProcessedFile file = new ProcessedFile();
            file.Extension = Path.GetExtension(path);
            file.Path = path;
            file.Package = package;

            Console.WriteLine("Processed file '{0}'.", path);
            return ExcludeExtensions.Contains(file.Extension) ? null : file;
        }
    }
}
