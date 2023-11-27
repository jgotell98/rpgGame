using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    public enum ElementType { Physical, Fire, Water, Light, Earth }
    public interface Powers
    {
        
        string name { set; get; }
        int damage { set; get; }
        int magicDrain { set; get; }
        ElementType type { get; }
        
    }
}
