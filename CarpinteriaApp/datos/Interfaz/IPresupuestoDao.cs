﻿using CarpinteriaApp.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaApp.datos.Interfaz
{
    public interface IPresupuestoDao
    {
        int ObtenerProximoPresupuesto();
        List<Producto> ObtenerProductos();
        bool Crear(Presupuesto oPresupuesto);
        //bool Actualizar(Presupuesto oPresupuesto);
        //bool Borrar(int numero);
        //List<Presupuesto> ObtenerPresupuestoPorFiltro(DateTime desde,DateTime hasta,string cliente);
        //Presupuesto ObtenerPresupuestoPorNro(int nro);
    }
}
