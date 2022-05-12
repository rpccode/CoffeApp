using CoffeApp.COMMON.Entidades;
using CoffeApp.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeApp.BIZ
{
    public abstract class GenericManager<T> : IGenericManager<T> where T : BaseDTO
    {
       protected readonly IGenericRepository<T> repository;
        public GenericManager(IGenericRepository<T> repository)
        {
            this.repository = repository;
        }
        public string Error { get; protected set; }

        public IEnumerable<T> ObtenerTodos => repository.Read;

        public T Actualizar(T entidad)
        {
            try
            {
                var r = repository.Update(entidad);
                Error = r != null ? "" : repository.Error;
                return r;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;
            }
        }

        public bool Eliminar(string id)
        {
            try
            {
                var r = repository.Delete(id);
                Error = r ? "" : repository.Error;
                return r;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return false;
            }
        }

        public T Insert(T entidad)
        {
            try
            {
                var r = repository.Create(entidad);
                Error = r != null ? "" : repository.Error;
                return r;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;
            }
        }
    }
}
