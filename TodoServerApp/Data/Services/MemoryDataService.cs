﻿  using TodoServerApp.Data.Interfaces;

namespace TodoServerApp.Data.Services
{
    public class MemoryDataService : IDataService
    { 
        private static IEnumerable<TaskItem> tasks { get; } =
         [
        new () {Id = 1, Title = "Задача 1", Description = "описание задачи 1",CreatedDate = DateTime.Now},
        new () {Id = 2, Title = "Задача 2", Description = "описание задачи 2",CreatedDate = DateTime.Now},
        new () {Id = 3, Title = "Задача 3", Description = "описание задачи 3",CreatedDate = DateTime.Now},
        ];

 

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TaskItem> GetTaskAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TaskItem>> GetAllAsync()
        {
            return await Task.FromResult(tasks);
        }

        public Task SaveAsync(TaskItem item)
        {
            throw new NotImplementedException();
        }
    }
}
