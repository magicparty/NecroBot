using System.Threading.Tasks;
using PoGo.NecroBot.Logic.State;
using SuperSocket.WebSocket;

namespace PoGo.NecroBot.CLI.WebSocketHandler.ActionCommands
{
    public class AssignFortTargetHandler : IWebSocketRequestHandler
    {
        public string Command { get; private set;}

        public AssignFortTargetHandler()
        {
            Command = "AssignFortTarget";
        }

        public async Task Handle(ISession session, WebSocketSession webSocketSession, dynamic message)
        {
            await Logic.Tasks.AssignFortTargetTask.Execute(session, (string)message.FortId);
        }
    }
}
