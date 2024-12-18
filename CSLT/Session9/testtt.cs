using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT.Session9
{
    internal class testtt
    {
        public static void Main()
        {
            // 1. Create a blank file on the disk
            string blankFilePath = "blank.txt";
            File.Create(blankFilePath).Close();
            Console.WriteLine("Blank file created.");

            // 2. Remove a file from the disk
            File.Delete(blankFilePath);
            Console.WriteLine("Blank file deleted.");

            // 3. Create a file and add some text
            string filePath = "example.txt";
            File.WriteAllText(filePath, "Hello, this is some text.");
            Console.WriteLine("File created and text added.");

            // 4. Create a text file and read it
            string content = File.ReadAllText(filePath);
            Console.WriteLine("Content of the file: " + content);

            // 5. Create a file and write an array of strings to the file
            string[] lines = { "Line 1", "Line 2", "Line 3" };
            File.WriteAllLines("array.txt", lines);
            Console.WriteLine("Array of strings written to file.");

            // 6. Append some text to an existing file
            File.AppendAllText(filePath, "\nAppended text.");
            Console.WriteLine("Text appended to file.");

            // 7. Create and copy the file to another name and display the content
            string copyPath = "copy.txt";
            File.Copy(filePath, copyPath, true);
            Console.WriteLine("File copied to 'copy.txt'.");
            Console.WriteLine("Content of the copied file: " + File.ReadAllText(copyPath));

            // 8. Create a file and move it into the same directory with another name
            string movedPath = "moved.txt";
            File.Move(copyPath, movedPath);
            Console.WriteLine("File moved to 'moved.txt'.");

            // 9. Read the first line of a file
            string firstLine = File.ReadLines(filePath).First();
            Console.WriteLine("First line of the file: " + firstLine);

            // 10. Create and read the last line of a file
            string[] lastLineArray = { "Last Line" };
            File.WriteAllLines("lastline.txt", lastLineArray);
            string lastLine = File.ReadLines("lastline.txt").Last();
            Console.WriteLine("Last line of the file: " + lastLine);

            // 11. Create and read the last n lines of a file
            string[] multiLineContent = { "Line A", "Line B", "Line C", "Line D" };
            File.WriteAllLines("multiline.txt", multiLineContent);
            int n = 2;
            string[] lastNLines = File.ReadLines("multiline.txt").Reverse().Take(n).Reverse().ToArray();
            Console.WriteLine("Last " + n + " lines of the file:");
            foreach (string line in lastNLines) Console.WriteLine(line);

            // 12. Read a specific line from a file
            int specificLine = 3;
            string specificContent = File.ReadLines("multiline.txt").Skip(specificLine - 1).First();
            Console.WriteLine("Line " + specificLine + " of the file: " + specificContent);

            // 13. Count the number of lines in a file
            int lineCount = File.ReadLines("multiline.txt").Count();
            Console.WriteLine("Number of lines in the file: " + lineCount);

            // 14. Print the structure of a specific folder (include files)
            string folderPath = ".";
            Console.WriteLine("Folder structure:");
            foreach (string file in Directory.GetFiles(folderPath)) Console.WriteLine(file);
            foreach (string dir in Directory.GetDirectories(folderPath)) Console.WriteLine(dir);

            // 15. Read a text file, then statistic the appearance of characters and numbers
            string statContent = File.ReadAllText(filePath);
            var characterStats = statContent.GroupBy(c => c).Select(g => new { Character = g.Key, Count = g.Count() });
            Console.WriteLine("Character statistics:");
            foreach (var stat in characterStats) Console.WriteLine(stat.Character + ": " + stat.Count);
        }
    }
}
