using FreeSql.DataAnnotations;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurionApi.Core.Entities
{
    [Table(Name = "Demo")]
    public class DemoEntity
    {
        /// <summary>
        /// id
        /// </summary>
        [Column(IsPrimary = true)]
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
