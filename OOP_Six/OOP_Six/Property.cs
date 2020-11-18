using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Six
{
    class Property<T, T1, T2>
    {
        public string Address { get; set; }
        public T2 Latitude { get; set; }
        public T2 Longtitude { get; set; }
        public T Length { get; set; }
        public T Width { get; set; }
        public T1 NumberOfFlats { get; set; }

        public Property(string address, T2 latitude, T2 longtitude, T length, T width, T1 numberofflats)
        {

            Address = address;
            Latitude = latitude;
            Longtitude = longtitude;
            Length = length;
            Width = width;
            NumberOfFlats = numberofflats;
            GetInfo();
        }

        public void GetInfo ()
        {

            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Широта: " + Latitude);
            Console.WriteLine("Долгота: " + Longtitude);
            Console.WriteLine("Длина: " + Length);
            Console.WriteLine("Ширина: " + Width);
            Console.WriteLine("Число этажей : " + NumberOfFlats);
            Console.WriteLine();
        }
    }
}
