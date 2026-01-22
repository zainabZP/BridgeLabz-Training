using System;
using System.IO.Pipes;
using System.Text;
using System.Threading;

class PipeExample
{
    static void Main()
    {
        AnonymousPipeServerStream server =
            new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable);

        Thread writer = new Thread(() =>
        {
            using (StreamWriter sw = new StreamWriter(server))
            {
                sw.WriteLine("Hello from Writer Thread");
                sw.Flush();
            }
        });

        Thread reader = new Thread(() =>
        {
            AnonymousPipeClientStream client =
                new AnonymousPipeClientStream(PipeDirection.In, server.GetClientHandleAsString());

            using (StreamReader sr = new StreamReader(client))
            {
                Console.WriteLine(sr.ReadLine());
            }
        });

        writer.Start();
        reader.Start();
    }
}
