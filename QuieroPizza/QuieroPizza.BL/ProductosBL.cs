﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuieroPizza.BL
{
    public class ProductosBL
    {
        public List<Producto> ObtenerProductos ()
        {
            var producto1 = new Producto(); //se crean los objetos
            producto1.Id = 1;
            producto1.Descripción = "Pizza 6 quesos";
            producto1.Precio = 200;

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripción = "Pizza 4 Estaciones";
            producto2.Precio = 250;

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripción = "Pizza Jamón y Queso";
            producto3.Precio = 180;

            var listadeProductos = new List<Producto>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);

            return listadeProductos;
        }
    }
}
