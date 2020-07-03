﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NettyBaseReloaded.Utils;

namespace NettyBaseReloaded.Game.netty.commands.old_client
{
    class AttributeBoosterUpdateCommand
    {
        public const short ID = 13651;

        public static Command write(List<BoosterUpdateModule> boostedAttributes)
        {
            var cmd = new ByteArray(ID);
            cmd.Integer(boostedAttributes.Count);
            foreach (var booster in boostedAttributes)
            {
                cmd.AddBytes(booster.write());
            }
            return new Command(cmd.ToByteArray(), false);
        }
    }
}
