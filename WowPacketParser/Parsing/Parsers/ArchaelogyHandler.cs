﻿using PacketParser.Enums;
using PacketParser.Misc;
using PacketParser.DataStructures;

namespace PacketParser.Parsing.Parsers
{
    public static class ArchaelogyHandler
    {
        [Parser(Opcode.SMSG_RESEARCH_SETUP_HISTORY)] // 4.3.4
        public static void HandleResearchSetupHistory(Packet packet)
        {
            var count = packet.ReadBits("Count", 22);

            packet.StoreBeginList("Researches");
            for (int i = 0; i < count; ++i)
            {
                packet.ReadInt32("ResearchProject.Id", i);
                packet.ReadInt32("Count", i);
                packet.ReadTime("Time", i);
            }
            packet.StoreEndList();
        }
    }
}
