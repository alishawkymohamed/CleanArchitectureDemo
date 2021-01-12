using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Core.Commands;
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

        public Task SendCommand<T>(T command) where T : Command
        {
            return this._mediator.Send(command);
        }
    }
}
