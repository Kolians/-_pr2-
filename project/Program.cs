using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsProject
{
    class Program
    {
        private static Car GetNissanSkylineGTRR34()
        {
            Car NissanSkylineGTRR34 = new Car();
            NissanSkylineGTRR34.Body = new Body
            {
                Steel = "стеклоплатика",
                СarRoof = true
            };
            NissanSkylineGTRR34.Mark = "Nissan";
            NissanSkylineGTRR34.Color = Color.White;
            NissanSkylineGTRR34.Model = "Skyline";
            NissanSkylineGTRR34.Box = new Box()
            {
                Transmission = "механика",
                Mechanics  = 5
            };
            NissanSkylineGTRR34.Engines = new List<Engine>()
            {
                new Engine() {Color = Color.White, Type = Type.GasEngine},
            };
            NissanSkylineGTRR34.Wheels = new List<Wheel>()
            {
                new Wheel() {WheelRims = "Литые диски", DiskSize = 7 },
                new Wheel() {WheelRims = "Литые диски", DiskSize = 7 },
                new Wheel() {WheelRims = "Литые диски", DiskSize = 7 },
                new Wheel() {WheelRims = "Литые диски", DiskSize = 7 }
            };
            NissanSkylineGTRR34.Type = CarType.NissanSkylineGTRR34;

            return NissanSkylineGTRR34;
        }

        private static Car GetInfinitiQX80()
        {
            Car InfinitiQX80 = new Car();
            InfinitiQX80.Body = new Body
            {
                Steel = "алюминий",
                СarRoof = false
            };
            InfinitiQX80.Mark = "Infinity";
            InfinitiQX80.Color = Color.Green;
            InfinitiQX80.Model = "QX80";
            InfinitiQX80.Box = new Box()
            {
                Transmission = "автомат"
                
            };
          InfinitiQX80.Engines = new List<Engine>()
            {
                new Engine() {Color = Color.Green, Type = Type.DiselEngine},
            };
            InfinitiQX80.Wheels = new List<Wheel>()
            {
                new Wheel() {WheelRims = "Кованые диски", DiskSize = 8 },
                new Wheel() {WheelRims = "Кованые диски", DiskSize = 8 },
                new Wheel() {WheelRims = "Кованые диски", DiskSize = 8 },
            };
            InfinitiQX80.Type = CarType.InfinitiQX80;

            return InfinitiQX80;
        }

        private static Car GetBMWI8()
        {
            Car BMWI8 = new Car();
            BMWI8.Body = new Body
            {
                Steel = "сталь",
                СarRoof = false
            };
            BMWI8.Mark = "BMWI8";
            BMWI8.Color = Color.Black;
            BMWI8.Model = "I8";
            BMWI8.Box = new Box()
            {
                Transmission = "автомат"
                
            };
          BMWI8.Engines = new List<Engine>()
            {
                new Engine() {Color = Color.Black, Type = Type.ElectricEngine},
            };
            BMWI8.Wheels = new List<Wheel>()
            {
                new Wheel() {WheelRims = "Штампованные", DiskSize = 9 },
                new Wheel() {WheelRims = "Штампованные", DiskSize = 9 },
                new Wheel() {WheelRims = "Штампованные", DiskSize = 9 },
                new Wheel() {WheelRims = "Штампованные", DiskSize = 9 },
                new Wheel() {WheelRims = "Штампованные", DiskSize = 9 },
                new Wheel() {WheelRims = "Штампованные", DiskSize = 9 },
            };
            BMWI8.Type = CarType.BMWI8;

            return BMWI8;
        }

        static void Main(string[] args)
        {
            Car NissanSkylineGTRR34 = GetNissanSkylineGTRR34();
            Car InfinitiQX80 = GetInfinitiQX80();
            Car BMWI8 = GetBMWI8();

            List<Car> cars = new List<Car>
            {
                NissanSkylineGTRR34,
                InfinitiQX80,
                BMWI8
                
            };

            WriteCarsInfo(cars);
            Console.WriteLine("Выберите номер сортировки:\n1)По количеству колёс;\n" +
                "2)По марке машины\r\n" +
                "3)По названию материала изготовления\r\n");
            int s = Convert.ToInt32(Console.ReadLine());
            bool isOkInput = true;
            if (s == 1)
            {
                SortByFretsCount(cars, true);
                Console.WriteLine("После сортировки по количеству колёс:");
            }
            else if (s == 2)
            {
                cars.Sort();
                Console.WriteLine("После сортировки по марке машин:");
            }
            else if (s == 3)
            {
                cars.Sort(new BodySteelComparer());
                Console.WriteLine("После сортировки по названию материала изготовления :");
            }
            else
            {
                isOkInput = false;
                Console.WriteLine("Неверный метод сортировки");
            }
            if (isOkInput)
            {
                WriteCarsInfo(cars);
            }   

            Console.ReadKey();
        }

        /// <summary>
        ///  Сортировка по количеству колёс
        /// </summary>
        /// <param name="cars">список машин</param>
        /// <param name="isAscending">сортировка по возрастанию</param>
        private static void SortByFretsCount(List<Car> cars, bool isAscending)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                for (int j = 0; j < cars.Count - i - 1; j++)
                {
                    if (isAscending)
                    {
                        if (cars[j].Wheels[0].DiskSize > cars[j + 1].Wheels[0].DiskSize)
                        {
                            Car temp = cars[j];
                            cars[j] = cars[j + 1];
                            cars[j + 1] = temp;
                        }
                    }
                    else
                    {
                        if (cars[j].Wheels[0].DiskSize > cars[j + 1].Wheels[0].DiskSize)
                        {
                            Car temp = cars[j];
                            cars[j] = cars[j + 1];
                            cars[j + 1] = temp;
                        }
                    }
                }
            }
        }

        private static void WriteCarsInfo(List<Car> cars)
        {
            Console.WriteLine("Список машин:\r\n");
            int n = 1;
            foreach(var car in cars)
            {
                Console.WriteLine($"Машина {n}:\r\n");
                n++;
                string carInfo = $"Марка: {car.Mark}\r\n" +
                    $"Модель: {car.Model}\r\n" +
                    $"Тип: {car.Type}\r\n" +
                    $"Цвет: {car.Color}\r\n" +
                    $"Материал изготовления: {car.Body.Steel}\r\n" +
                    $"Крыша: {(car.Body.СarRoof  == true ? "есть" : "нет")}\r\n" +
                    $"Диски: {car.Wheels[0].WheelRims}\r\n" +
                    $"Размер дисков: {car.Wheels[0].DiskSize}\r\n" +
                    $"Двигатель\r\n";
                int i = 1;
                foreach(var engine in car.Engines)
                {
                    carInfo += $"Двигатель {i}\r\n" +
                        $"Тип: {engine.Type}\r\n" +
                        $"Цвет: {engine.Color}\r\n";
                    i++;
                }
                i = 1;
                foreach (var wheels in car.Wheels)
                {
                    carInfo += $"Колесо {i}\r\n" +
                        $"Тип колёс: {wheels.WheelRims}\r\n" +
                        $"Размер дисков: {wheels.DiskSize}\r\n";
                    i++;
                }

                Console.WriteLine(carInfo);
            }
        }
    }
}