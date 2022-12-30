using System;
using CommandSystem;
using PlayerRoles;
using PluginAPI.Core;
using RemoteAdmin;

namespace SuicideCommand.Commands
{
    [CommandHandler(typeof(ClientCommandHandler))]
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class Suicide : ICommand
    {
        public string Command { get; } = "suicide";
        public string[] Aliases { get; } = {"kill"};
        public string Description { get; } = "Command to kill yourself";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            var pl = Player.Get(((PlayerCommandSender)sender).ReferenceHub);
            if (sender is PlayerCommandSender && pl.Role != RoleTypeId.Spectator && pl.Role != RoleTypeId.Overwatch)
            { 
                pl.Kill("Skill issue");
                response = "L";
                return true;
                
            }
            else
            {
                response = "You cannot run this command!";
                return false;
            }
        }
    }
}