using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N29Backend.Model
{
    [Table("car")]
    internal class Car
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("year")]
        public int Year { get; set; }
        [Column("person_id")]
        public int UserId { get; set; }
    }
}
