using CarsRental.Application.Interfaces;
using CarsRental.Domain;
using Microsoft.Azure.Cosmos;

namespace CarsRental.Application.Services
{
    public abstract class CosmosDbService<T> : IAsyncRepository<T> where T : BaseEntity
    {
        protected Container _container;
        protected readonly ICosmosDbClientFactory _cosmosDbClientFactory;
        public abstract string ContainerName { get; }

        public CosmosDbService(ICosmosDbClientFactory cosmosDbClientFactory)
        {
            _cosmosDbClientFactory = cosmosDbClientFactory;
            var dbId = _cosmosDbClientFactory.Settings.DatabaseName;
            _container = _cosmosDbClientFactory.CosmosClient.GetContainer(dbId, ContainerName);
        }

        public async Task<T> AddAsync(T entity)
        {
            var response = await _container.CreateItemAsync<T>(entity, new PartitionKey(entity.id));

            return response.Resource;
        }

        public async Task DeleteAsync(T entity)
        {
            await _container.DeleteItemAsync<T>(entity.id, new PartitionKey(entity.id));
        }

        public async Task<T> GetByIdAsync(string id)
        {
            try
            {
                ItemResponse<T> response = await _container.ReadItemAsync<T>(id, new PartitionKey(id));
                return response.Resource;
            }
            catch (CosmosException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null!;
            }
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            FeedIterator<T> feed = _container.GetItemQueryIterator<T>(new QueryDefinition("Select * from c"));

            List<T> entities = new List<T>();

            while (feed.HasMoreResults)
            {
                FeedResponse<T> reponse = await feed.ReadNextAsync();

                foreach (var entity in reponse)
                {
                    entities.Add(entity);
                }
            }

            return entities;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            return await _container.UpsertItemAsync<T>(entity, new PartitionKey(entity.id));
        }
    }
}