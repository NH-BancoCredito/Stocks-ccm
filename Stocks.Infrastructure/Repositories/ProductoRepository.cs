﻿using MongoDB.Driver;
using Stocks.Domain.Models;
using Stocks.Domain.Repositories;

namespace Stocks.Infrastructure.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly IMongoDatabase _mongoDatabase;

        public ProductoRepository(IMongoDatabase mongoDatabase)
        {
            _mongoDatabase = mongoDatabase;
        }

        public Task<bool> Adicionar(Producto entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Producto> Consultar(int id)
        {
            return await GetMongoCollection().FindAsync<Producto>(item => item.IdProducto == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Producto>> Consultar(string nombre)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(Producto entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Modificar(Producto entity)
        {
            throw new NotImplementedException();
        }

        private IMongoCollection<Producto> GetMongoCollection() => _mongoDatabase.GetCollection<Producto>(nameof(Producto));
    }
}
