using System;
using System.Collections.Generic;
using System.Text;

namespace LineMessagingAPI
{
    public interface IFlexComponent
    {
        FlexComponentType Type { get; }
    }
}
