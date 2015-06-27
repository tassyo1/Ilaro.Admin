﻿using System.Collections.Generic;
using Ilaro.Admin.Core;

namespace Ilaro.Admin.ViewModels
{
    public class GroupPropertiesViewModel
    {
        public string GroupName { get; set; }

        public IEnumerable<Property> Properties { get; set; }

        public bool IsCollapsed { get; set; }
    }
}