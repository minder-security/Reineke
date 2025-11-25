using ReinekeInterop.Classes.P2P;
using ReinekeInterop.Structs.MythicStructs;
namespace ReinekeInterop.Interfaces
{
    public interface IPeerManager
    {
        Peer AddPeer(PeerInformation info);
        bool Remove(string uuid);
        bool Remove(IPeer peer);
        bool Route(DelegateMessage msg);
    }
}
