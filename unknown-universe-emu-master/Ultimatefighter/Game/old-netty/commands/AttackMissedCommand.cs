﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NettyBaseReloaded.Utils;

namespace NettyBaseReloaded.Game.netty.commands
{
    class AttackMissedCommand
    {
        public const short ID = 25902;

        public static byte[] write(AttackTypeModule attackType, int targetUserId, int skillColorId)
        {
            var cmd = new ByteArray(ID);
            cmd.AddBytes(attackType.write());
            cmd.Integer(targetUserId);
            cmd.Integer(skillColorId);
            return cmd.ToByteArray();
        }
    }
}
