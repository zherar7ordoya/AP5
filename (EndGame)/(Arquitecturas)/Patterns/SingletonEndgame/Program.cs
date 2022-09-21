using static System.Console;

namespace SingletonEndgame
{
    internal class Program
    {
        private static readonly TableServers host1List = TableServers.GetTableServers();
        private static readonly TableServers host2List = TableServers.GetTableServers();

        private static void Main()
        {
            for (int i = 0; i < 4; i++)
            {
                Host1GetNextServer();
                Host2GetNextServer();
            }
            ReadLine();
        }

        private static void Host1GetNextServer() => WriteLine("Host 1: " + host1List.GetNextServer());
        private static void Host2GetNextServer() => WriteLine("Host 2: " + host2List.GetNextServer());
    }
}
