using CoffeApp.COMMON.Entidades;
using CoffeApp.COMMON.Interfaces;
using CoffeApp.DAL.MSSQL;
using Microsoft.AspNetCore.Authorization;
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
    //[Authorize]
    public class VentaController : GenericApiController<Venta>
    {
        public VentaController() : base(FabricRepository.Venta())
        {
        }
    }
}
