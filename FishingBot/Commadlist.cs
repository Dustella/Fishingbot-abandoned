using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using SDK;
using SDK.Events;
using SDK.Interface;
using SDK.Model;
namespace FishingBot
{

    public static class Commadlist
    {
        public static readonly Dictionary<string, GroupCommand> cmdss = new Dictionary<string, GroupCommand>
        {
            ["echo"] = new GroupCommand
            {
                Func = commad => commad
            },
            ["tbase64"] = new GroupCommand
            {
                Func = commad => Codehelper.EncodeBase64("utf-8", commad)
            },
            ["fbase64"] = new GroupCommand
            {
                Func=commad=>Codehelper.DecodeBase64("utf=8",commad)
            }
        };
        internal static void Isuue(GroupMessageEvent e)
        {

            try
            {
                var commad = (e.MessageContent.GetLeft(" ") == "" ? e.MessageContent.ToLower() : e.MessageContent.GetLeft(" ")).ToLower();
                var data = e.MessageContent.GetRight(" ");
                var command = commad.Trim(' ', '\n', '\n');
                data = data.Trim(' ', '\n', '\n');
                if (cmdss.ContainsKey(command))
                {
                    var m = cmdss[command];
                    var u = e.SenderQQ;
                    Common.xlzAPI.SendGroupMessage(e.ThisQQ, e.MessageGroupQQ, cmdss[command].Func(data));
                }
            }
            catch (Exception)
            {
                Common.xlzAPI.SendGroupMessage(e.ThisQQ, e.MessageGroupQQ, "Command Error");
            }
        }
    }
}
