using CoffeApp.COMMON.Entidades;
using CoffeApp.DAL.MSSQL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CoffeApp.Test.DALL.MSSQL
{
    [TestClass]
    public class PruebasDalSQL
    {
        [TestMethod]
        public void TestTipoUsuario()
        {
            try
            {
                var repositorio = FabricRepository.TipoUsuario();
                int numAntes = repositorio.Read.Count();
                var dato = repositorio.Create(new TipoUsuario()
                {
                    Nombre="test",
                    Descripcion="Prueba unitaria"
                });
                Assert.IsNotNull(dato, "No se Pudo Crear el Objeto: "+ repositorio.Error);
                dato.Nombre = "Modificado";
                dato.Descripcion = "Modificada";
                var datoModifiacado = repositorio.Update(dato);
                Assert.IsNotNull(datoModifiacado, "No se Pudo modificar el dato: " + repositorio.Error);
                Assert.AreEqual(dato.Nombre, datoModifiacado.Nombre);
                Assert.IsTrue(repositorio.Delete(datoModifiacado.id));
                Assert.AreEqual(numAntes, repositorio.Read.Count(),"La Cantidad de registro despues del crud no es igual");
            }
            catch (System.Exception ex)
            {

                Assert.Fail(ex.Message);
            }
        }
    }
}
