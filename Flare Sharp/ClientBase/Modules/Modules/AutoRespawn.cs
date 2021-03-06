﻿using Flare_Sharp.ClientBase.Categories;
using Flare_Sharp.Memory;
using Flare_Sharp.Memory.CraftSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flare_Sharp.ClientBase.Modules.Modules
{
    public class AutoRespawn : Module
    {

        public static byte savedImmediateSpawnGameRule;
        public AutoRespawn() : base("AutoRespawn", CategoryHandler.registry.categories[2], (char)0x07, false)
        {
        }

        public override void onEnable()
        {
            base.onEnable();
            savedImmediateSpawnGameRule = Pointers.doImmediateRespawnGamerule;
        }

        public override void onTick()
        {
            base.onTick();
            Pointers.doImmediateRespawnGamerule = 1;
        }

        public override void onDisable()
        {
            base.onDisable();
            Pointers.doImmediateRespawnGamerule = savedImmediateSpawnGameRule;
        }
    }
}
