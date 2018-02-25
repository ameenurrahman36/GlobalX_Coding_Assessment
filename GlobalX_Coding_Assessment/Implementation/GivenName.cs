using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalX_Coding_Assessment.Implementation
{
    public class GivenName : IComparable<GivenName>
    {
        public string Name { get; set; }

        public int CompareTo(GivenName x)
        {
            return string.Compare(this.Name, x.Name);
        }
    }
}
