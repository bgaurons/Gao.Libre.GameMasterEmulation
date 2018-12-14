using System;
using System.Collections.Generic;
using System.Text;

namespace Gao.Model.Libre
{
    /// <summary>
    /// Generic freeform comment that can be associated to, and better describe another element.
    /// </summary>
    public class Comment
    {
        public long Id { get; set; }
        public string Value { get; set; }
    }
}
