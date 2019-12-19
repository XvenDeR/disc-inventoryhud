﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disc_inventoryhud_common.Inv
{
    public class InventorySlot
    {
        public string Id { get; set; }
        public int Count { get; set; }
        public IDictionary<string, dynamic> MetaData { get; set; }
    }
}
