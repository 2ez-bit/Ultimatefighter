﻿using Server.Utils;
using System.Collections.Generic;

namespace Server.Game.netty.commands.old_client
{
    class AbilityEffectDeActivationCommand
    {
        public const short ID = 1219;

        public static Command write(int selectedAbilityId, int activatorId, List<int> targetIds)
        {
            var cmd = new ByteArray(ID);
            cmd.Integer(selectedAbilityId);
            cmd.Integer(activatorId);
            cmd.Integer(targetIds.Count);
            foreach (var target in targetIds)
                cmd.Integer(target);
            return new Command(cmd.ToByteArray(), false);
        }
    }
}
