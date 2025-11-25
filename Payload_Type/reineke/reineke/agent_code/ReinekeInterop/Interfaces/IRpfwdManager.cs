using ReinekeInterop.Structs.MythicStructs;
using System.Net.Sockets;
using ReinekeInterop.Classes;

namespace ReinekeInterop.Interfaces
{
    public interface IRpfwdManager
    {
        bool Route(SocksDatagram dg);
        bool AddConnection(TcpClient client, int ServerID, int port, int debugLevel, Tasking task);
        bool Remove(int id);
    }
}
