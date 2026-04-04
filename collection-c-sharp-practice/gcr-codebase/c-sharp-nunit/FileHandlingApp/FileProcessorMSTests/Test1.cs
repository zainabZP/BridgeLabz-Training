using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using FileProcessorApp;

namespace FileProcessorMSTests
{
    [TestClass]
    public class FileProcessorTests
    {
        private FileProcessor? processor; // mark nullable to avoid CS8618
        private string testFile = "testfile.txt";

        [TestInitialize]
        public void Setup()
        {
            processor = new FileProcessor();
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (File.Exists(testFile))
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                File.Delete(testFile);
            }
        }

        [TestMethod]
        public void Test_FileExistsAfterWrite()
        {
            processor!.WriteToFile(testFile, "Hello MSTest");
            Assert.IsTrue(File.Exists(testFile)); // Correct MSTest method
        }

        [TestMethod]
        public void Test_ReadNonExistentFile_ThrowsFileNotFoundException()
        {
            // Fixed syntax for MSTest in .NET 10
            Assert.ThrowsException<FileNotFoundException>(() =>
            {
                processor!.ReadFile("nonexistent.txt");
            });
        }
    }
}
