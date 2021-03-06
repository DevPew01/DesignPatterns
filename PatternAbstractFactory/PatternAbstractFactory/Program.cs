﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAbstractFactory
{

/*Реализовать создание разных миров для компьютерной игры с
использованием подходящего паттера проектирования. В игре есть разные
континенты (планеты, миры). Мир на каждом континенте характеризуется
наличием пищевых цепочек (растения – травоядные – хищники), хотя
конкретные представители флоры и фауны в различных мирах
отличаются. Несмотря на различия между представителями миров,
характер взаимодействия между животными остается неизменным.*/
    class Program
    {
        static void Main(string[] args)
        {
            World world = new World(new MarsFactory());
            world.RunFoodChaine();
        }
    }
}
