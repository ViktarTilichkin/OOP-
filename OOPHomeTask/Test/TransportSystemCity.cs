﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPHomeTask.Test
{
    public class TransportSystemCity
    {
        private int CountPlane;
        private int CountBus;
        private int CountShip;
        private Transport[] TransportCity;

        public TransportSystemCity()
        {
            TransportCity = new Transport[33];
        }
        public void SetInAirport(Plane plane)
        {
            if (plane == null) throw new ArgumentNullException(nameof(plane));
            if (CountPlane == 11)
            {
                throw new Exception("нет места");

            }
            for (int i = 0; i < TransportCity.Length; i++)
            {
                if (TransportCity[i] == null)
                {
                    TransportCity[i] = plane;
                    plane.Posadka();
                    CountPlane++;
                    return;
                }
            }

        }
        public void SetInBusStation(Bus bus)
        {
            if (bus == null) throw new ArgumentNullException(nameof(bus));
            if (CountBus == 11)
            {
                throw new Exception("нет места");

            }
            for (int i = 0; i < TransportCity.Length; i++)
            {
                if (TransportCity[i] == null)
                {
                    TransportCity[i] = bus;
                    bus.Priehal();
                    CountBus++;
                    return;
                }
            }
        }
        public void SetInPort(Ship lodka)
        {
            if (lodka == null) throw new ArgumentNullException(nameof(lodka));
            if (CountShip == 11)
            {
                throw new Exception("нет места");

            }
            for (int i = 0; i < TransportCity.Length; i++)
            {
                if (TransportCity[i] == null)
                {
                    TransportCity[i] = lodka;
                    lodka.Pripliv();
                    CountShip++;
                    return;
                }
            }
        }

        public Plane GetFromAirport(int nameOfTransport)
        {
            for (int i = 0; i < TransportCity.Length; i++)
            {
                var transport = TransportCity[i];
                if (transport == null) continue;
                if (transport.NumberOfTransport == nameOfTransport && transport is Plane plane)
                {
                    TransportCity[i] = null;
                    plane.Vzlet();
                    CountPlane--;
                    return plane;
                }
            }
            throw new Exception($"нет самолета {nameOfTransport}");
        }

        public Bus? GetFromBusStation(int nameOfTransport)
        {
            for (int i = 0; i < TransportCity.Length; i++)
            {
                var transport = TransportCity[i];
                if (transport == null) continue;
                if (transport.NumberOfTransport == nameOfTransport && transport is Plane plane)
                {
                    Bus? temp = (Bus)TransportCity[i];
                    TransportCity[i] = null;
                    temp.Otehal();
                    CountBus--;
                    return temp;
                }
            }
            throw new Exception("нет такого автобуса");
        }

        public Ship? GetFromPort(int nameOfTransport)
        {
            for (int i = 0; i < TransportCity.Length; i++)
            {
                var transport = TransportCity[i];
                if (transport == null) continue;
                if (transport.NumberOfTransport == nameOfTransport && transport is Plane plane)
                {
                    Ship? temp = (Ship)TransportCity[i];
                    TransportCity[i] = null;
                    temp.Otpliv();
                    CountShip--;
                    return temp;
                }
            }
            throw new Exception(" нет такой лодки");
        }
        public void Print()
        {
            foreach (var item in TransportCity)
            {
                Console.WriteLine(item);
            }
        }
    }
}
