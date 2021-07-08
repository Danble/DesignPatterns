using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    //Implementing a little about Abstract Factory for convenience
    public interface IEngine
    {
        int GetHP();
    }

    public class SportEngine : IEngine
    {
        public int GetHP()
        {
            return 450;
        }
    }
    public class ClassicEngine : IEngine
    {
        public int GetHP()
        {
            return 200;
        }
    }
    public class SUVEngine : IEngine
    {
        public int GetHP()
        {
            return 144;
        }
    }
}
