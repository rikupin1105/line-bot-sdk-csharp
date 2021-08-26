﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LineMessagingAPI
{
    public static class BoxComponentExtensions
    {
        /// <summary>
        /// Add a flex component to the Box component.
        /// </summary>
        /// <param name="self">BoxComponent</param>
        /// <param name="component">Flex Component</param>
        /// <returns>BoxComponent</returns>
        public static BoxComponent AddContents(this BoxComponent self, IFlexComponent component)
        {
            self.Contents.Add(component);
            return self;
        }
    }
}
