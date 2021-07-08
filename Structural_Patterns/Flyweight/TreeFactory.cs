using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class TreeFactory
    {
        static List<TreeType> treeTypes = new List<TreeType>();
        public static TreeType GetTreeType(string name, string color, string texture)
        {
            //Mocking the searching of fields. A new TreeType shouldn't be created!
            TreeType other = new TreeType(name, color, texture);
            TreeType selected = treeTypes.Find(x => x.GetFields() == other.GetFields());

            if(selected == null)
            {
                treeTypes.Add(other);
                return other;
            }
            return selected;
        }
    }
}
