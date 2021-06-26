using PrototipoAcerosSA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Data
{
    public class AlmacenService : IAlmacenService
    {

        public List<Almacenn> almacenes = new List<Almacenn>();

        public AlmacenService()
        {
            almacenes.Add(new Almacenn() { IdAlmacen = 1, Clave = "MP-ALM-001", Nombre = "MP", Alto = 50, Ancho = 30, Largo = 70, Estatus = "Activo", Descripcion = "Almacen para el guardado de MV" });
            almacenes.Add(new Almacenn() { IdAlmacen = 2, Clave = "VA-ALM-002", Nombre = "VA", Alto = 50, Ancho = 30, Largo = 70, Estatus = "Activo", Descripcion = "Almacen para el guardado de VA" });
            almacenes.Add(new Almacenn() { IdAlmacen = 3, Clave = "RF-ALM-003", Nombre = "RF", Alto = 50, Ancho = 30, Largo = 70, Estatus = "Activo", Descripcion = "Almacen para el guardado de RF" });
        }

        public async Task<List<Almacenn>> GetTodosAlmacenes()
        {
            return almacenes;
        }

        public async Task<Almacenn> GetAlmacenById(int IdAlmacen)
        {
            Almacenn almacen = null;
            foreach (var alm in almacenes)
            {
                if (alm.IdAlmacen == IdAlmacen)
                {
                    almacen = alm;
                }
            }
            return almacen;
        }

        public async Task<Almacenn> GetAlmacenByClave(string Clave)
        {
            Almacenn almacen = null;
            foreach (var alm in almacenes)
            {
                if (alm.Clave == Clave)
                {
                    almacen = alm;
                }
            }
            return almacen;
        }

        public async Task<Almacenn> AddAlmacen(string clave, string nombre, int alto, int ancho, int largo, string estatus,string descripcion)
        {
            var idIncrementable = almacenes.LastOrDefault().IdAlmacen + 1;
            var almacenNew = new Almacenn()
            {
                IdAlmacen = idIncrementable,
                Clave = clave,
                Nombre = nombre,
                Alto = alto,
                Ancho = ancho,
                Largo = largo,
                Estatus = estatus,
                Descripcion = descripcion
            };
            //Nombre = addDatos.Nombre, Alto = addDatos.Alto, Ancho = addDatos.Ancho, Largo = addDatos.Largo, Estatus = addDatos.Estatus, Descripcion = addDatos.Descripcion };
            almacenes.Add(almacenNew);
            Console.WriteLine("Almacenes",almacenes);
            return almacenNew;
        }

        public async Task<Almacenn> AddAlmacenModelo(Almacenn datos)
        {
            Console.WriteLine("Entro al servicio-------", datos);
            var idIncrementable = almacenes.Count + 1;
            var almacenNew = new Almacenn()
            {
                IdAlmacen = idIncrementable,
                Clave = datos.Clave,
                Nombre = datos.Nombre,
                Alto = datos.Alto,
                Ancho = datos.Ancho,
                Largo = datos.Largo,
                Estatus = datos.Estatus,
                Descripcion = datos.Descripcion
            };
            //Nombre = addDatos.Nombre, Alto = addDatos.Alto, Ancho = addDatos.Ancho, Largo = addDatos.Largo, Estatus = addDatos.Estatus, Descripcion = addDatos.Descripcion };
            almacenes.Add(almacenNew);
            Console.WriteLine("Almacenes", almacenes);
            return almacenNew;
        }

        public async Task<Almacenn> UpdateAlmacen(int IdAlmacen,string clave, string nombre, int alto, int ancho, int largo, string estatus, string descripcion)
        {
            var almacenNew = new Almacenn()
            {
                IdAlmacen = IdAlmacen,
                Clave = clave,
                Nombre = nombre,
                Alto = alto,
                Ancho = ancho,
                Largo = largo,
                Estatus = estatus,
                Descripcion = descripcion
            };
            almacenes[almacenes.FindIndex(index => index.IdAlmacen == almacenNew.IdAlmacen)] = almacenNew;            
            return almacenNew;
        }

        public async Task<Almacenn> EditarAlmacen(Almacenn almacen)
        {
            almacenes[almacenes.FindIndex(index => index.IdAlmacen == almacen.IdAlmacen)] = almacen;
            return almacen;
        }
    }
}
