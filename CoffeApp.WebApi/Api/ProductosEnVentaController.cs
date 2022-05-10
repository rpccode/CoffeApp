using CoffeApp.COMMON.Entidades;
using CoffeApp.COMMON.Interfaces;
using CoffeApp.DAL.MSSQL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeApp.WebApi.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosEnVentaController : GenericApiController<ProductosEnVenta>
    {
        public ProductosEnVentaController() : base(FabricRepository.ProductosEnVenta())
        {
        }
    }
}
