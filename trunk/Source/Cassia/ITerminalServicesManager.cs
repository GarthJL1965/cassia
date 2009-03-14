using System.Collections.Generic;

namespace Cassia
{
    public interface ITerminalServicesManager
    {
        ITerminalServicesSession CurrentSession { get; }
        IList<ITerminalServicesSession> GetSessions(string serverName);
        IList<ITerminalServicesSession> GetSessions();
        ITerminalServer GetRemoteServer(string serverName);
        ITerminalServer GetLocalServer();
        IList<ITerminalServer> GetServers(string domainName);
    }
}