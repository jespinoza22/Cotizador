using Cotizador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cotizador.Common
{
    public class Constantes
    {
        public static List<Rol> listaRol()
        {
            var listaRoles = new List<Rol>();
            listaRoles.Add(new Rol()
            {
                idRol = "01",
                descripcionRol = "Analista Programador .NET"
            });
            listaRoles.Add(new Rol()
            {
                idRol = "02",
                descripcionRol = "Analista Programador JAVA"
            });
            listaRoles.Add(new Rol()
            {
                idRol = "03",
                descripcionRol = "Analista Programador BD"
            });
            listaRoles.Add(new Rol()
            {
                idRol = "04",
                descripcionRol = "Analista Funcional"
            });
            listaRoles.Add(new Rol()
            {
                idRol = "05",
                descripcionRol = "Lider de proyectos"
            });
            listaRoles.Add(new Rol()
            {
                idRol = "06",
                descripcionRol = "Analista de Calidad"
            });
            listaRoles.Add(new Rol()
            {
                idRol = "07",
                descripcionRol = "Arquitecto de Sistemas"
            });
            listaRoles.Add(new Rol()
            {
                idRol = "08",
                descripcionRol = "Scrum Master"
            });
            return listaRoles;
        }

        public static List<Categoria> listaCategoria()
        {
            var listaCategoria = new List<Categoria>();
            listaCategoria.Add(new Categoria()
            {
                idCategoria = "01",
                descripcionCategoria = "Junior"
            });
            listaCategoria.Add(new Categoria()
            {
                idCategoria = "02",
                descripcionCategoria = "Semi Senior"
            });
            listaCategoria.Add(new Categoria()
            {
                idCategoria = "03",
                descripcionCategoria = "Senior"
            });
            return listaCategoria;
        }

        public static List<EquipoServicio> listaEquipoServicio(){
            var listaEquipoServicio = new List<EquipoServicio>();
            listaEquipoServicio.Add(new EquipoServicio()
            {
                idMiembro = "01",
                Descripcion = "Analista Programador .NET",
                precioJunior = 27.20m,
                precioSemiSenior = 31.73m,
                precioSenior = 36.27m,
                fechaVigencia = DateTime.Now
            });
            listaEquipoServicio.Add(new EquipoServicio()
            {
                idMiembro = "01",
                Descripcion = "Analista Programador JAVA",
                precioJunior = 28.20m,
                precioSemiSenior = 32.73m,
                precioSenior = 37.27m,
                fechaVigencia = DateTime.Now
            });
            listaEquipoServicio.Add(new EquipoServicio()
            {
                idMiembro = "01",
                Descripcion = "Analista Programador BD",
                precioJunior = 26.70m,
                precioSemiSenior = 31.23m,
                precioSenior = 35.77m,
                fechaVigencia = DateTime.Now
            });
            listaEquipoServicio.Add(new EquipoServicio()
            {
                idMiembro = "01",
                Descripcion = "Analista Funcional",
                precioJunior = 36.27m,
                precioSemiSenior = 40.80m,
                precioSenior = 45.33m,
                fechaVigencia = DateTime.Now
            });
            listaEquipoServicio.Add(new EquipoServicio()
            {
                idMiembro = "01",
                Descripcion = "Lider de proyectos",
                precioJunior = 45.33m,
                precioSemiSenior = 54.40m,
                precioSenior = 68.00m,
                fechaVigencia = DateTime.Now
            });
            listaEquipoServicio.Add(new EquipoServicio()
            {
                idMiembro = "01",
                Descripcion = "Analista de Calidad",
                precioJunior = 26.10m,
                precioSemiSenior = 30.63m,
                precioSenior = 35.17m,
                fechaVigencia = DateTime.Now
            });
            listaEquipoServicio.Add(new EquipoServicio()
            {
                idMiembro = "01",
                Descripcion = "Arquitecto de Sistemas",
                precioJunior = 49.87m,
                precioSemiSenior = 54.40m,
                precioSenior = 70.00m,
                fechaVigencia = DateTime.Now
            });
            listaEquipoServicio.Add(new EquipoServicio()
            {
                idMiembro = "01",
                Descripcion = "Scrum Master",
                precioJunior = 47.38m,
                precioSemiSenior = 55.48m,
                precioSenior = 69.02m,
                fechaVigencia = DateTime.Now
            });
            return listaEquipoServicio;
        }
    }
}
