﻿using System;
using Terraria_Server;

namespace Terraria_Utilities
{
    /**
     * I needed a place to keep my utility functions that I was using to deconstruct the server. I am placing them within
     * this project so they can be documented, should the need to reuse them ever occur. Please be aware that much of the
     * documentation for included functionality will likely be poor as these functions may survive a single commit before
     * needing to be removed as much of this will lead to dramatic refactorings in the code base.
     */
    class Program
    {
        private const String WELCOME_MESSAGE = "This application exists to provide utility functionality for breaking "
            + "down the\nTerraria Server. Please be aware that many of the facilities existing within\nthis application "
            + "will quickly become outdated and are not intended for long\nterm usage.\n\nPlease enter the namespace "
            + "of the existing utilty you would like to run.";

        static void Main(string[] args)
        {
            Console.WriteLine(WELCOME_MESSAGE);
            Registry<NPC> npcRegistry = new Registry<NPC>("NPCs.xml");
            //Terraria_Utilities.Serialize.SerializeNPC.Start();
        }
    }
}
