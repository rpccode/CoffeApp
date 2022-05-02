using CoffeApp.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// 
/// </summary>
namespace CoffeApp.COMMON.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
   public interface IGenericRepository<T> where T:BaseDTO 
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
        T Create(T entidad);
        /// <summary>
        /// 
        /// </summary>
        IEnumerable<T> Read { get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entidad"></param>
        /// <returns></returns>
        T Update(T entidad);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(string id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="querySql"></param>
        /// <returns></returns>
        IEnumerable<T> Query(string querySql);
    }
}
