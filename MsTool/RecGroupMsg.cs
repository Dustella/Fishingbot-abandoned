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

namespace MsTool
{
    public class RecGroupMsg : IGroupMessage
    {
        public void ReceviceGroupMsg(GroupMessageEvent e)
        {
            if (e.SenderQQ == 1000032 || e.ThisQQ == e.SenderQQ)//不处理匿名信息和自己
            {
                return;
            }
            if (e.MessageGroupQQ== 1053741842)
            {

            }

           
           
        }



        }
    }
