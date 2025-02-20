using System;
using System.IO.Pipes;
using System.IO;
using System.Threading;

namespace PP_20_02_25
{
    class PipedStreams
    {
        static void WriterThread(AnonymousPipeServerStream pipeServer)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(pipeServer))
                {
                    // Ensure immediate data flush
                    writer.AutoFlush = true;

                    for (int i = 1; i <= 5; i++)
                    {
                        string message = $"Message {i} from Writer";
                        writer.WriteLine(message);
                        Console.WriteLine($"Writer: Sent -> {message}");
                        Thread.Sleep(1000); // Simulate processing delay
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Writer encountered an error: {ex.Message}");
            }
        }

        static void ReaderThread(string pipeHandle)
        {
            try
            {
                using (AnonymousPipeClientStream pipeClient = new AnonymousPipeClientStream(PipeDirection.In, pipeHandle))
                using (StreamReader reader = new StreamReader(pipeClient))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine($"Reader: Received -> {line}");
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Reader encountered an error: {ex.Message}");
            }
        }
        public static void Main8()
        {
            using (AnonymousPipeServerStream pipeServer = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable))
            {
                Thread readerThread = new Thread(() => ReaderThread(pipeServer.GetClientHandleAsString()));
                readerThread.Start();

                // Run writer in the main thread
                WriterThread(pipeServer);

                // Wait for the reader to complete
                readerThread.Join();
            }
            Console.WriteLine("Communication complete.");
        }
    }
}
