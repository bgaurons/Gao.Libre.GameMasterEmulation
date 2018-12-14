using Gao.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gao.Model.Libre
{
    public enum UnexpectedEventFocusType
    {
        [ExcludeElement]
        Foe = 0,
        [RepeatElement(2,3)]
        SelfOrRival = 1,
        [RepeatElement(5)]
        AllyOrPatron = 4,
        [RepeatElement(7)]
        PersonOrAlly = 6,
        [RepeatElement(9,10)]
        FoeOrRival = 8
    }
}
