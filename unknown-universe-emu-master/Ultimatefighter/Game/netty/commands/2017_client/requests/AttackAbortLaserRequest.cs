﻿using NettyBaseReloaded.Utils;

namespace NettyBaseReloaded.Game.netty.commands.new_client.requests
{
    public class AttackAbortLaserRequest
    {
        public const short ID = 4592;

        public void readCommand(byte[] bytes)
        {
            var parser = new ByteParser(bytes);
            parser.readShort();
            parser.readShort();
        }
    }
}