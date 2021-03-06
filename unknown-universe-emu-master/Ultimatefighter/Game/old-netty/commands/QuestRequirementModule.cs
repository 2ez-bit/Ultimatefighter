﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NettyBaseReloaded.Utils;

namespace NettyBaseReloaded.Game.netty.commands
{
    class QuestRequirementModule
    {
        public const short LEVEL = 0;

        public const short NUMBER_OF_QUESTS_ACCEPTED = 1;

        public const short DATE = 2;

        public const short PRE_QUEST = 3;

        public const short ID = 8034;

        public short requirementType;
        public double minValue;
        public double maxValue;
        public List<int> matches;
        public List<int> missingMatches;

        public QuestRequirementModule(short requirementType, double minValue, double maxValue, List<int> matches, List<int> missingMatches )
        {
            this.requirementType = requirementType;
            this.minValue = minValue;
            this.maxValue = maxValue;
            this.matches = matches;
            this.missingMatches = missingMatches;
        }

        public byte[] write()
        {
            var cmd = new ByteArray(ID);
            cmd.Short(requirementType);
            cmd.Double(minValue);
            cmd.Double(maxValue);
            cmd.Integer(matches.Count);
            foreach (var loc0 in matches)
                cmd.Integer(loc0);
            cmd.Integer(missingMatches.Count);
            foreach (var loc1 in missingMatches)
                cmd.Integer(loc1);
            return cmd.Message.ToArray();
        }
    }
}
