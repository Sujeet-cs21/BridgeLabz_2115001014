using System;
using System.Diagnostics;
using System.IO;

namespace PP_20_02_25
{
    class BufferedStreams
    {
        public static void Main2()
        {
            string sourceFile = "largefile.dat"; // Ensure this file exists (100MB or more)
            string destFileBuffered = "copy_buffered.dat";
            string destFileUnbuffered = "copy_unbuffered.dat";

            // Measure time for unbuffered copy
            Stopwatch stopwatch = Stopwatch.StartNew();
            CopyFileUnbuffered(sourceFile, destFileUnbuffered);
            stopwatch.Stop();
            Console.WriteLine("Unbuffered Copy Time: " + stopwatch.ElapsedMilliseconds + " ms");

            // Measure time for buffered copy
            stopwatch.Restart();
            CopyFileBuffered(sourceFile, destFileBuffered);
            stopwatch.Stop();
            Console.WriteLine("Buffered Copy Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }

        static void CopyFileUnbuffered(string source, string destination)
        {
            using (FileStream sourceStream = new FileStream(source, FileMode.Open, FileAccess.Read))
            using (FileStream destStream = new FileStream(destination, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[4096]; // 4 KB chunks
                int bytesRead;
                while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    destStream.Write(buffer, 0, bytesRead);
                }
            }
        }

        static void CopyFileBuffered(string source, string destination)
        {
            using (FileStream sourceStream = new FileStream(source, FileMode.Open, FileAccess.Read))
            using (FileStream destStream = new FileStream(destination, FileMode.Create, FileAccess.Write))
            using (BufferedStream bufferedSource = new BufferedStream(sourceStream, 4096))
            using (BufferedStream bufferedDest = new BufferedStream(destStream, 4096))
            {
                byte[] buffer = new byte[4096]; // 4 KB chunks
                int bytesRead;
                while ((bytesRead = bufferedSource.Read(buffer, 0, buffer.Length)) > 0)
                {
                    bufferedDest.Write(buffer, 0, bytesRead);
                }
            }
        }
    }


}
