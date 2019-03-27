using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CarsProject
{
    public enum CarType
    {
        NissanSkylineGTRR34,
        InfinitiQX80,
        BMWI8

    }

    public class Car : IComparable<Car>
    {
        public string Mark { get; set; } //марка (Nissan, Toyota)
        public string Model { get; set; } //модель (skyline r32-r35, Supra)
        public CarType Type{ get; set; } //тип машины(модель, марка)
        public Color Color { get; set; } // цвет машины(розовый, красный, синий)
        public Box Box { get; set; } //коробка(Автомат, Механика)
        public Body Body { get; set; } //кузов автомабиля(Кроссовер, Хэтчбек, Седан, Купе)
        public List<Wheel> Wheels { get; set; } //колёса
        public List<Engine> Engines { get; set; } //двигатели
    
        // <summary>
        // Сравнение по марке
        // </summary>
        // <param name="car"></param>
        // <returns></returns>

       public int CompareTo(Car car)
        {
            return this.Mark.CompareTo(car.Mark);
        }
    }

    public class BodySteelComparer : IComparer<Car>
    {
        public int Compare(Car car1, Car car2)
        {
            if (car1.Body.Steel.ToLower()[0] > car2.Body.Steel.ToLower()[0])
                return 1;
            else if (car1.Body.Steel.ToLower()[0] < car2.Body.Steel.ToLower()[0])
                return -1;
            else
                return 0;
        }
    } 
}

