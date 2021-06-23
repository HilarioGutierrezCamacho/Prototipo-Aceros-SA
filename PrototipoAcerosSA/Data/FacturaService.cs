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

        public List<Factura> facturas { get; set; } = new List<Factura>();

        public FacturaService(IProveedorService proveedorService, IFormaPagoService formaPagoService, IArticuloService articuloService)
        {
            _proveedorService = proveedorService;
            _formaPagoService = formaPagoService;
            _articuloService = articuloService;
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
                            IdUnidad = 3,
                            Subtotal = 0,
                            IVA = 0,
                            TotalConIVA = 0
                        },
                        new DetalleFactura()
                        {
                            Articulo = await _articuloService.GetArticuloById(1),
                            IdUnidad = 1,
                            Subtotal = 0,
                            IVA = 0,
                            TotalConIVA = 0
                        }
                        ,new DetalleFactura()
                        {
                            Articulo = await _articuloService.GetArticuloById(2),
                            IdUnidad = 1,
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
                            IdUnidad = 3,
                            Subtotal = 0,
                            IVA = 0,
                            TotalConIVA = 0
                        },
                        new DetalleFactura()
                        {
                            Articulo = await _articuloService.GetArticuloById(2),
                            IdUnidad = 1,
                            Subtotal = 0,
                            IVA = 0,
                            TotalConIVA = 0
                        }
                        ,new DetalleFactura()
                        {
                            Articulo = await _articuloService.GetArticuloById(3),
                            IdUnidad = 1,
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
                            IdUnidad = 3,
                            Subtotal = 0,
                            IVA = 0,
                            TotalConIVA = 0
                        },
                        new DetalleFactura()
                        {
                            Articulo = await _articuloService.GetArticuloById(3),
                            IdUnidad = 3,
                            Subtotal = 0,
                            IVA = 0,
                            TotalConIVA = 0
                        }
                        ,new DetalleFactura()
                        {
                            Articulo = await _articuloService.GetArticuloById(2),
                            IdUnidad = 1,
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
    }
}
