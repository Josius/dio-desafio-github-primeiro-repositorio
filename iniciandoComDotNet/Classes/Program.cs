﻿using System;
using Classes.Herança;

namespace Classes{

    class Program{

        static void Main(string[] args)
        {
            Ponto p1 = new Ponto(10, 20);

            Ponto3D p2 = new Ponto3D(10, 20, 30);

            //Ponto3D.Calcular();//chamando o método estático, por ser estático ele pertence a classe
        }
    }
}