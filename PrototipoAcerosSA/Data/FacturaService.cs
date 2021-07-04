using Microsoft.AspNetCore.Components;
using PrototipoAcerosSA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Data
{
    public class FacturaService : IFacturaService
    {
        public readonly IProveedorService _proveedorService;
        public readonly IFormaPagoService _formaPagoService;
        public readonly IArticuloService _articuloService;
        public readonly IUnidadService _unidadService;

        public List<Factura> facturas { get; set; } = new List<Factura>();

        public FacturaService(IProveedorService proveedorService, IFormaPagoService formaPagoService, IArticuloService articuloService, IUnidadService unidadService)
        {
            _proveedorService = proveedorService;
            _formaPagoService = formaPagoService;
            _articuloService = articuloService;
            _unidadService = unidadService;
            facturas = new List<Factura>();
            InicializarFacturas();
        }

        private async Task InicializarFacturas()
        {
            facturas.Add(
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
            );
        }

        public async Task<Factura> GetFacturaById(int IdFactura)
        {
            Factura factura = null;
            foreach (var fact in facturas)
            {
                if (fact.IdFactura == IdFactura)
                {
                    factura = fact;
                }
            }
            return factura;
        }

        public async Task<List<Factura>> GetTodasFacturas()
        {
            return facturas;
        }

        public async Task<string> GenerateFolioFactura()
        {
            int mes = DateTime.Now.Month;
            string folio = "FACT";
            string mesCadena = GetMes(mes);
            string numeroFactura = GenerarNumeroFactura();
            return folio + "-" + mesCadena + "-" + numeroFactura;
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

        private string GenerarNumeroFactura()
        {
            int ceros = 5;
            int totalRegistros = facturas.Count();
            string cadena = "";
            for (int i = totalRegistros; i < ceros; i++)
            {
                cadena += "0";
            }
            return cadena + totalRegistros;
        }
    }
}
