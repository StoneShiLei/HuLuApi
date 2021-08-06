using HuLuApi.Core.Entities;
using HuLuApi.Core.Universal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuLuApi.Core.Managers
{
    public class DemoManager:BaseManager
    {
        private static readonly List<DemoEntity> demoEntities = new();

        public DemoManager() : base() { }

        public Task<Container<DemoEntity>> GetDemoListAsync(int index,int size)
        {
            if (index < 1) index = 1;
            Container<DemoEntity> result = new();
            result.Items = demoEntities.Skip((index - 1) * size).Take(size);
            result.Total = demoEntities.Count;
            return Task.FromResult(result);
        }

        public Task<bool> AddDemoAsync(DemoEntity entity)
        {
            demoEntities.Add(entity);
            return Task.FromResult(true);
        }
    }
}
