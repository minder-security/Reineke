using System.Threading.Tasks;
namespace ReinekeInterop.Interfaces
{
    public interface ITask
    {
        string ID();
        void Start();
        Task CreateTasking();
        void Kill();
    }
}
