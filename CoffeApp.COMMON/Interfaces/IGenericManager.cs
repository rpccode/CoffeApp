using CoffeApp.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeApp.COMMON.Interfaces
{
    public  interface IGenericManager<T> where T:BaseDTO
    {
        /// <summary>
        /// 
        /// </summary>
        string Error { get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entidad"></param>
        /// <returns></returns>
        T Insert(T entidad);
        /// <summary>
        /// 
        /// </summary>
        IEnumerable<T> ObtenerTodos { get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entidad"></param>
        /// <returns></returns>
        T Actualizar(T entidad);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Eliminar(string id);
     
    }
}
