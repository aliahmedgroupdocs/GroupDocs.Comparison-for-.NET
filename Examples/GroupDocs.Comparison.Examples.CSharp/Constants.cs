﻿using System.IO;
using System.Runtime.CompilerServices;

namespace GroupDocs.Comparison.Examples.CSharp
{
    internal static class Constants
    {
        public const string LicensePath = "C://licenses//GroupDocs.Comparison.lic";
               
        public const string SamplesPath = "./Resources/SampleFiles";
        public const string OutputPath = "./Results/Output";

        public static string SOURCE_WORD => GetSampleFilePath("source.docx");
        public static string TARGET_WORD => GetSampleFilePath("target.docx");
        public static string TARGET2_WORD => GetSampleFilePath("target2.docx");
        public static string TARGET3_WORD => GetSampleFilePath("target3.docx");
        public static string SOURCE_WORD_PROTECTED => GetSampleFilePath("source_protected.docx");
        public static string TARGET_WORD_PROTECTED => GetSampleFilePath("target_protected.docx");
        public static string TARGET2_WORD_PROTECTED => GetSampleFilePath("target2_protected.docx");
        public static string TARGET3_WORD_PROTECTED => GetSampleFilePath("target3_protected.docx");

        public static string SOURCE_SLIDES => GetSampleFilePath("source.pptx");
        public static string TARGET_SLIDES => GetSampleFilePath("target.pptx");
        
        public static string SOURCE_TXT => GetSampleFilePath("source.txt");
        public static string TARGET_TXT => GetSampleFilePath("target.txt");
        public static string TARGET2_TXT => GetSampleFilePath("target2.txt");
        public static string TARGET3_TXT => GetSampleFilePath("target3.txt");

        public static string SOURCE_EMAIL => GetSampleFilePath("source.eml");
        public static string TARGET_EMAIL => GetSampleFilePath("target.eml");
        public static string TARGET2_EMAIL => GetSampleFilePath("target2.eml");
        public static string TARGET3_EMAIL => GetSampleFilePath("target3.eml");

        public static string SOURCE_WITH_FOOTER => GetSampleFilePath("sourceWithFooter.docx");
        public static string TARGET_WITH_FOOTER => GetSampleFilePath("targetWithFooter.docx");

        public static string RESULT_WORD => "result.docx";
        public static string RESULT_SLIDES => "result.pptx";
        public static string RESULT_TXT => "result.txt";
        public static string RESULT_EMAIL => "result.eml";
        

        private static string GetSampleFilePath(string filePath) => Path.Combine(SamplesPath, filePath);

        public static string GetOutputDirectoryPath([CallerFilePath] string callerFilePath = null)
        {
            string outputDirectory = Path.Combine(OutputPath, Path.GetFileNameWithoutExtension(callerFilePath));
            if (!Directory.Exists(outputDirectory))
                Directory.CreateDirectory(outputDirectory);

            string path = Path.GetFullPath(outputDirectory);
            return path;
        }
    }
}