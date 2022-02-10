using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Desafio8QualiV2.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime Create { get; set; }
        public DateTime Change { get; set; }
    }
}
