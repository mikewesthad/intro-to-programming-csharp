using System;
using System.Collections.Generic;
using System.Text;

namespace ListsDemo
{
    class PartyMember
    {
        string Name;
        string Type;

        public PartyMember(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public string GetDescription()
        {
            // String interpolation: 
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
            return $"{Name} is a {Type} type.";
        }
    }
}
