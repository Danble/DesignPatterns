using System;
using System.Collections.Generic;

namespace Flyweight
{
    class Program
    {
        // This is the forest
        static void Main(string[] args)
        {
            List<Tree> trees = new List<Tree>();
            void PlantTree(int x, int y, string name, string color, string texture)
            {
                TreeType type = TreeFactory.GetTreeType(name, color, texture);
                trees.Add(new Tree(x, y, type));
            }

            //Creation of 100 trees
            for(int i = 1; i <= 100; i++)
            {
                PlantTree(i, i + 1, "Abeto", "Verde pálido", "Rugoso");
            }

            foreach(Tree tree in trees)
            {
                tree.Draw("My canvas");
            }

        }
    }
}
