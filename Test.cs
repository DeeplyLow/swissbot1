using Discord.Commands;
using System.Threading.Tasks;

namespace Swiss2.Modules
{
    public class Test : ModuleBase<SocketCommandContext>
    {
        [Command("botstatus")]
        public async Task fjvidfjv()
        {
            await Context.Channel.SendMessageAsync("This discord bot is up and running!")
        }
    }
}