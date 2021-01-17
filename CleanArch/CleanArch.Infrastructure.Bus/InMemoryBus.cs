using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Core.Events;
using MediatR;
using System.Threading.Tasks;

namespace CleanArch.Infrastructure.Bus
{
    public sealed class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            this._mediator = mediator;
        }

        public Task<T> SendCommand<T>(Message<T> command)
        {
            return this._mediator.Send(command);
        }
    }
}
