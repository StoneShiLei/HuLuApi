using Furion;
using HuLuApi.Application.Services.DemoService.Dtos;
using HuLuApi.Core.Entities;
using HuLuApi.Core.Managers;
using HuLuApi.Core.Universal;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuLuApi.Application.Services.DemoService
{
    /// <summary>
    /// demo
    /// </summary>
    [AllowAnonymous,ApiDescriptionSettings("HuLuApi")]
    public class DemoService:BaseService
    {
        private readonly DemoManager demoManager = App.GetRequiredService<DemoManager>();

        /// <summary>
        /// 获取demo的list
        /// </summary>
        /// <returns></returns>
        [HttpGet,Route("demo/list")]
        public async Task<Container<DemoOutput>> GetDemoList(int index = 1,int size = 5)
        {
            var entitys = await demoManager.GetDemoListAsync(index,size);
            var dtos = Mapper.Map<Container<DemoOutput>>(entitys);
            return dtos;
        }

        /// <summary>
        /// 添加demo
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost,Route("demo/add")]
        public async Task<bool> AddDemo([Required,FromBody] DemoInput input)
        {
            var entity = Mapper.Map<DemoEntity>(input);
            return await demoManager.AddDemoAsync(entity);
        }
    }
}
