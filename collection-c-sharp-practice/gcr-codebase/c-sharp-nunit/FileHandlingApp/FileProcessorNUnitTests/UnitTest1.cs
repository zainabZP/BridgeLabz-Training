using NUnit.Framework;
using System;
using System.IO;
using FileProcessorApp;

namespace FileProcessorNUnitTests
{
    [TestFixture]
    public class FileProcessorTests
    {
        private FileProcessor? processor; // mark nullable
        private string testFile = "testfile.txt";

        [SetUp]
        public void Setup()
        {
            processor = new FileProcessor();
        }

        [TearDown]
        public void Cleanup()
        {
            if (File.Exists(testFile))
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                File.Delete(testFile);
            }
        }

        [Test]
        public void Test_FileExistsAfterWrite()
        {
            processor!.WriteToFile(testFile, "Hello NUnit");
            Assert.That(File.Exists(testFile), Is.True); // NUnit syntax
        }

        [Test]
        public void Test_ReadNonExistentFile_ThrowsFileNotFoundException()
        {
            var ex = Assert.Throws<FileNotFoundException>(() =>
                processor!.ReadFile("nonexistent.txt"));
            Assert.That(ex, Is.TypeOf<FileNotFoundException>());
        }
    }
}
