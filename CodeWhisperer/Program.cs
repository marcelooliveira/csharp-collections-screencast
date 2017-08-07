using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWhisperer
{
    class Program
    {
        private const string CODE_SPACES = "            ";

        static void Main(string[] args)
        {
            string classFile = @"C:\Users\Alura\Documents\GitHub\csharp-collections-screencast\A22ListasDeObjetos\Program.cs";
            string fileContent = string.Empty;
            StringBuilder sbReader = new StringBuilder();
            string lastLine = string.Empty;
            bool imageCommentLineInserted = false;
            using (StreamReader sr = new StreamReader(classFile))
            {
                string line = string.Empty;
                int imageNumber = 1;
                while ((line = sr.ReadLine()) != null)
                {
                    if (!imageCommentLineInserted
                        && lastLine.StartsWith(CODE_SPACES)
                        && !line.StartsWith(CODE_SPACES)
                        && !string.IsNullOrEmpty(line)
                        && line.Trim() == "}")
                    {
                        sbReader.AppendLine(GetImageCommentLine(imageNumber));
                        sbReader.AppendLine(CODE_SPACES);
                        imageCommentLineInserted = true;
                    }
                    else
                    {
                        if (line.Contains($"image{(imageNumber):d2}.png"))
                        {
                            imageNumber++;
                        }
                    }
                    sbReader.AppendLine(line);

                    if (!string.IsNullOrEmpty(line))
                    {
                        lastLine = line;
                    }
                }
            }

            using (StreamWriter sw = new StreamWriter(classFile))
            {
                sw.WriteLine(sbReader.ToString());
            }
        }

        private static string GetImageCommentLine(int imageNumber)
        {
            return $"///<image url='$(ProjectDir)\\Slides\\image{imageNumber:d2}.png'/>";
        }
    }
}