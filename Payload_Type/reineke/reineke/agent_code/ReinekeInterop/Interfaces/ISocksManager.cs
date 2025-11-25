using ReinekeInterop.Structs.MythicStructs;

namespace ReinekeInterop.Interfaces
{
    public interface ISocksManager
    {
        bool Route(SocksDatagram dg);

        bool Remove(int id);
    }
}
