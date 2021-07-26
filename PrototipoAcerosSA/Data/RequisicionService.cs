using Microsoft.AspNetCore.Components;
using PrototipoAcerosSA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Data
{
    public class RequisicionService : IRequisicionService
    {
        public readonly IProveedorService _proveedorService;
        public readonly IFormaPagoService _formaPagoService;
        public readonly IArticuloService _articuloService;
        public readonly IUnidadService _unidadService;
        public readonly IEmpleadosService _empleadoService;

        public List<Requisicion> requisiciones { get; set; } = new List<Requisicion>();

        public RequisicionService(IProveedorService proveedorService, IFormaPagoService formaPagoService, IArticuloService articuloService, IUnidadService unidadService, IEmpleadosService _empleadoService)
        {
            _proveedorService = proveedorService;
            _formaPagoService = formaPagoService;
            _articuloService = articuloService;
            _unidadService = unidadService;
            requisiciones = new List<Requisicion>();
            //InicializarFacturas();
        }

        private async Task InicializarFacturas()
        {
            /*facturas.Add(
                new Factura()
                {
                    IdFactura = 1,
                    FolioFactura = "FAC-0001",
                    Proveedor = await _proveedorService.GetProveedorById(1),
                    FechaCaptura = "17/06/21 15:30",
                    Comentarios = "",
                    Subtotal = 2000.00,
                    Descuento = 500.00,
                    IVA = 1.6,
                    TotalFactura = 1450.50,
                    FormaPago = await _formaPagoService.GetFormaPagoById(1),
                    DetallesFactura = new List<DetalleFactura>()
                    {
                        new DetalleFactura()
                        {
                            Articulo = await _articuloService.GetArticuloById(1),
                            Unidad = _unidadService.GetAlmacenById(3).Result.Descripcion,
                            Subtotal = 0,
                            IVA = 0,
                            TotalConIVA = 0
                        },
                        new DetalleFactura()
                        {
                            Articulo = await _articuloService.GetArticuloById(1),
                            Unidad = _unidadService.GetAlmacenById(1).Result.Descripcion,
                            Subtotal = 0,
                            IVA = 0,
                            TotalConIVA = 0
                        }
                        ,new DetalleFactura()
                        {
                            Articulo = await _articuloService.GetArticuloById(2),
                            Unidad = _unidadService.GetAlmacenById(1).Result.Descripcion,
                            Subtotal = 0,
                            IVA = 0,
                            TotalConIVA = 0
                        }
                    }
                }               
            );
            facturas.Add(
                new Factura()
                {
                    IdFactura = 2,
                    FolioFactura = "FAC-0002",
                    Proveedor = await _proveedorService.GetProveedorById(2),
                    FechaCaptura = "17/06/21 15:30",
                    Comentarios = "",
                    Subtotal = 2000.00,
                    Descuento = 500.00,
                    IVA = 1.6,
                    TotalFactura = 1450.50,
                    FormaPago = await _formaPagoService.GetFormaPagoById(2),
                    DetallesFactura = new List<DetalleFactura>()
                    {
                        new DetalleFactura()
                        {
                            Articulo = await _articuloService.GetArticuloById(2),
                            Unidad = _unidadService.GetAlmacenById(3).Result.Descripcion,
                            Subtotal = 0,
                            IVA = 0,
                            TotalConIVA = 0
                        },
                        new DetalleFactura()
                        {
                            Articulo = await _articuloService.GetArticuloById(2),
                            Unidad = _unidadService.GetAlmacenById(1).Result.Descripcion,
                            Subtotal = 0,
                            IVA = 0,
                            TotalConIVA = 0
                        }
                        ,new DetalleFactura()
                        {
                            Articulo = await _articuloService.GetArticuloById(3),
                            Unidad = _unidadService.GetAlmacenById(1).Result.Descripcion,
                            Subtotal = 0,
                            IVA = 0,
                            TotalConIVA = 0
                        }
                    }
                }
            );
            facturas.Add(
                new Factura()
                {
                    IdFactura = 3,
                    FolioFactura = "FAC-0003",
                    Proveedor = await _proveedorService.GetProveedorById(1),
                    FechaCaptura = "17/06/21 15:30",
                    Comentarios = "",
                    Subtotal = 2000.00,
                    Descuento = 500.00,
                    IVA = 1.6,
                    TotalFactura = 1450.50,
                    FormaPago = await _formaPagoService.GetFormaPagoById(1),
                    DetallesFactura = new List<DetalleFactura>()
                    {
                        new DetalleFactura()
                        {
                            Articulo = await _articuloService.GetArticuloById(3),
                            Unidad = _unidadService.GetAlmacenById(3).Result.Descripcion,
                            Subtotal = 0,
                            IVA = 0,
                            TotalConIVA = 0
                        },
                        new DetalleFactura()
                        {
                            Articulo = await _articuloService.GetArticuloById(3),
                            Unidad = _unidadService.GetAlmacenById(3).Result.Descripcion,
                            Subtotal = 0,
                            IVA = 0,
                            TotalConIVA = 0
                        }
                        ,new DetalleFactura()
                        {
                            Articulo = await _articuloService.GetArticuloById(2),
                            Unidad = _unidadService.GetAlmacenById(1).Result.Descripcion,
                            Subtotal = 0,
                            IVA = 0,
                            TotalConIVA = 0
                        }
                    }
                }
            ); */
        }

        public async Task<Requisicion> GetRequisicionById(int IdRequisicion)
        {
            Requisicion requisicion = null;
            foreach (var req in requisiciones)
            {
                if (req.IdRequisicion == IdRequisicion)
                {
                    requisicion = req;
                }
            }
            return requisicion;
        }

        public async Task<List<Requisicion>> GetTodasRequisiciones()
        {
            return requisiciones;
        }

        public async Task<string> GenerateFolioRequisicion()
        {
            int mes = DateTime.Now.Month;
            string folio = "REQ";
            string mesCadena = GetMes(mes);
            string numeroFactura = GenerarNumeroRequisicion();
            return folio + "-" + mesCadena + "-" + numeroFactura;
        }

        public async Task<Requisicion> GuardarRequisiciona(Requisicion requisicion)
        {
            requisicion.Subtotal = Math.Round(requisicion.Subtotal, 2);
            requisicion.TotalRequisicion = Math.Round(requisicion.TotalRequisicion, 2);
            requisiciones.Add(requisicion);
            return requisicion;
        }

        private string GetMes(int numeroMes)
        {
            string mes = "";
            switch (numeroMes)
            {
                case 1:
                    mes = "ENE";
                    break;
                case 2:
                    mes = "FEB";
                    break;
                case 3:
                    mes = "MAR";
                    break;
                case 4:
                    mes = "ABR";
                    break;
                case 5:
                    mes = "MAY";
                    break;
                case 6:
                    mes = "JUN";
                    break;
                case 7:
                    mes = "JUL";
                    break;
                case 8:
                    mes = "AGO";
                    break;
                case 9:
                    mes = "SEP";
                    break;
                case 10:
                    mes = "OCT";
                    break;
                case 11:
                    mes = "NOV";
                    break;
                case 12:
                    mes = "DEC";
                    break;
            }
            return mes;
        }

        private string GenerarNumeroRequisicion()
        {
            int ceros = 5;
            int totalRegistros = requisiciones.Count();
            string cadena = "";
            for (int i = totalRegistros; i < ceros; i++)
            {
                cadena += "0";
            }
            return cadena + totalRegistros;
        }

        public async Task<Requisicion> GetRequisicionByClave(string Clave)
        {
            Requisicion requisicion = null;
            foreach (var fact in requisiciones)
            {
                if (fact.FolioRequisicion == Clave)
                {
                    requisicion = fact;
                }
            }
            return requisicion;
        }

        public async Task<Requisicion> EditarRequisicion(Requisicion req)
        {
            requisiciones[requisiciones.FindIndex(index => index.FolioRequisicion == req.FolioRequisicion)] = req;
            return req;
        }
    }
}
