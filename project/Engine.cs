using System.Drawing;

namespace CarsProject
{
    public enum Type
    {
        DiselEngine,
        GasEngine,
        ElectricEngine 
    }
    public class Engine
    {
        public Color Color { get; set; }
        public Type Type { get; set; }
    }
}