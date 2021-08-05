using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurionApi.Application.Services.DemoService.Dtos
{
    /// <summary>
    /// demo
    /// </summary>
    public class DemoInput
    {
        /// <summary>
        /// id
        /// </summary>
        [JsonProperty("id")]
        [Required(ErrorMessage = "必填项")]
        public string Id { get; set; }
    }
}
