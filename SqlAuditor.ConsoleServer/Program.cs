using SqlAuditor.Config;
using SqlAuditor.Trace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SqlAuditor.ConsoleServer
{

    class Program
    {
        static SqlAuditor auditor;
        [STAThread]
        static void Main(string[] args)
        {
            System.Console.WriteLine(EncryptionUtils.GetMachineID());

            System.Console.CancelKeyPress += Console_CancelKeyPress;
            Console.WriteLine("SqlAuditor: Reading Config...");
            var config = AuditConfig.Load("Config.xml");
            auditor = new SqlAuditor(config);
            Console.WriteLine("SqlAuditor: Registering Observers...");
            auditor.RegisterObserver(new GenericTraceObserverFactory((context)=> new ConsoleTrace()));
            auditor.RegisterObserver(new GenericTraceObserverFactory((context) => new DBLogger()));
            auditor.Start();
            Console.WriteLine("SqlAuditor: Started.");
            Console.WriteLine("Press CTR+C to exit.");
            auditor.WaitAll();
        }

        static void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e)
        {
            Console.WriteLine("SqlAuditor: Stopping...");
            auditor.Stop();

        }

    }
}
