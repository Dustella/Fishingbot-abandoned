using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using SDK;
using SDK.Events;
using SDK.Interface;
using SDK.Model;
using Telegram.Bot;
using Telegram.Bot.Args;
using System.Diagnostics;


namespace FishingBot
{

    public class RecGroupMsg : IGroupMessage
    {

        public const long insider = 980330782;
        public const long testG = 1053741842;
        public const long darkG = 907283835;
        public const long me = 2285047281;
        public void ReceviceGroupMsg(GroupMessageEvent e)

        {
            if (e.SenderQQ == 1000032 || e.ThisQQ == e.SenderQQ)//不处理匿名信息和自己
            {
                return;
            }
            if (e.MessageGroupQQ == insider)
            {
                Commadlist.Isuue(e);
            }
            if (e.MessageContent == "来份色图")

            {
                Common.xlzAPI.SendGroupImage(e.ThisQQ, e.MessageGroupQQ, "https://cdn.jsdelivr.net/gh/uxiaohan/GitImgTypecho/Acg/api.vvhan.com[403].jpg", false);
            }
        }







    }
}
