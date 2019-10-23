﻿// For Directory.GetFiles and Directory.GetDirectories
// For File.Exists, Directory.Exists
using System;
using System.IO;
using System.Collections.Generic;

namespace LIB_File
{
    public class RecursiveFileProcessor
    {
        private static string CurrentPath { get; set; }
        private static List<string> ExcludeExtensions { get; set; }
        private static List<string> ReplaceFolder { get; set; }

        public static List<ProcessedFile> Main(List<string> args, List<string> exceptions = null, List<string> replaces = null)
        {
            if (exceptions != null) ExcludeExtensions = new List<string>(exceptions);
            if (replaces != null) ReplaceFolder = new List<string>(replaces);

            List<ProcessedFile> files = new List<ProcessedFile>();
            int i = 0;

            foreach (string path in args)
            {
                CurrentPath = path;
                if (File.Exists(path))
                {
                    // This path is a file
                    files.Add(ProcessFile(path, i));
                }
                else if (Directory.Exists(path))
                {
                    // This path is a directory
                    files.AddRange(ProcessDirectory(path, i));
                }
                else
                {
                    throw new Exception(path + " is not a valid file or directory.");
                }
                i++;
            }
            return files;
        }


        // Process all files in the directory passed in, recurse on any directories 
        // that are found, and process the files they contain.
        public static List<ProcessedFile> ProcessDirectory(string targetDirectory, int package = 0)
        {
            List<ProcessedFile> files = new List<ProcessedFile>();

            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
            {
                var file = ProcessFile(fileName, package);
                if (file != null) files.Add(file);
            }

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                files.AddRange(ProcessDirectory(subdirectory, package));

            return files;
        }

        // Logic inserted for processing found files here.
        public static ProcessedFile ProcessFile(string path, int package = 0)
        {
            ProcessedFile file = new ProcessedFile
            {
                Extension = Path.GetExtension(path).ToUpper().Replace(".", ""),
                Path = path.Replace(CurrentPath, ReplaceFolder[package]).Replace(@"\", @"/"),
                Package = package
            };
            return ExcludeExtensions.Contains("." + file.Extension.ToLower()) ? null : file;
        }
    }
}
