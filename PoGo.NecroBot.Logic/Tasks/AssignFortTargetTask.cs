#region using directives

using System.Linq;
using System.Threading.Tasks;
using PoGo.NecroBot.Logic.State;
using PoGo.NecroBot.Logic.Utils;
using PoGo.NecroBot.Logic.Event;

#endregion

namespace PoGo.NecroBot.Logic.Tasks
{
    public class AssignFortTargetTask
    {
        private static string TargetFortId = "";

        private static void SetTargetFortId(string FortId)
        {
            TargetFortId = FortId;
        }
        public static string getTargetFortId()
        {
            string temp = "";
            if (TargetFortId != "")
            {
                temp = TargetFortId;
                TargetFortId = "";
            }
            return temp;
        }
        public static async Task Execute(ISession session, string FortId)
        {
            SetTargetFortId(FortId);
        }
    }
}