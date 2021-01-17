using CleanArch.Domain.Core.Commands;
using CleanArch.Domain.Core.Events;
using System.Threading.Tasks;

namespace CleanArch.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task<T> SendCommand<T>(Message<T> command);
    }
}
