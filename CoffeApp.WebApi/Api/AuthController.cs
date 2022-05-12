using CoffeApp.BIZ;
using CoffeApp.COMMON.Entidades;
using CoffeApp.COMMON.Interfaces;
using CoffeApp.COMMON.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CoffeApp.WebApi.Api
{
    [Route("[controller]")]
    public class AuthController : Controller
    {
        private readonly IConfiguration configuration;
        private readonly IUsuarioManager manager;
        public AuthController(IConfiguration configuration)
        {
            this.configuration = configuration;
            manager = FabricManager.usuarioManager();

        }
        [HttpPost]
        [Route("[Action]")]
        public IActionResult Login([FromBody] LoginModel Model)
        {
           
            try
            {
                if (Model != null)
                {
                    Usuario u = manager.Login(Model);
                    if (u != null)
                    {
                        var Key = Encoding.ASCII.GetBytes(configuration.GetValue<string>("SecretKey"));
                        List<Claim> claims = new List<Claim>()
                        {
                            new Claim(ClaimTypes.NameIdentifier,u.id),
                            new Claim(ClaimTypes.Name,u.NombreUsuario),
                            new Claim(ClaimTypes.Email,u.Correo)
                        };
                        var tokenDescriptor = new SecurityTokenDescriptor
                        {
                            Subject = new ClaimsIdentity(claims),
                            Expires = DateTime.UtcNow.AddDays(1),
                            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Key), SecurityAlgorithms.HmacSha256Signature)
                        };
                        var tokenHandle = new JwtSecurityTokenHandler();
                        var token = tokenHandle.CreateToken(tokenDescriptor);
                        return Ok(new TokenModel()
                        {
                            Token = tokenHandle.WriteToken(token),
                            Usuario = u
                        });
                    }
                    else
                    {
                        
                        return Forbid();
                    }
                }
                else
                {
                   
                    return Forbid();
                }
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        
       
    }
}
