using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class CompoundGraphic : Graphic
    {
        private List<Graphic> children = new List<Graphic>();

        public void AddG(Graphic child)
        {
            children.Add(child);
        }

        public void RemoveG(Graphic child)
        {
            children.Remove(child);
        }

        public void Move(int x, int y)
        {
            foreach(Graphic child in children)
            {
                child.Move(x, y);
            }
        }

        public string Draw()
        {
            string result = "";
            foreach(Graphic child in children)
            {
                result += $"{child.Draw()} ";
            }

            return result;
        }
    }
}
