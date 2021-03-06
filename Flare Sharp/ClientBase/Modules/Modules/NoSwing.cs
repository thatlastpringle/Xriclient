﻿using Flare_Sharp.ClientBase.Categories;
using Flare_Sharp.ClientBase.Keybinds;
using Flare_Sharp.Memory;
using Flare_Sharp.Memory.CraftSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flare_Sharp.ClientBase.Modules.Modules
{
    public class NoSwing : Module
    {
        public NoSwing() : base("NoSwing", CategoryHandler.registry.categories[2], (char)0x07, false)
        {
        }

        public override void onEnable()
        {
            base.onEnable();
            MCM.writeBaseByte(Pointers.handSwingPacket, 1);
        }

        public override void onDisable()
        {
            base.onDisable();
            MCM.writeBaseByte(Pointers.handSwingPacket, 0);
        }
    }
}
