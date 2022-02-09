using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Desafio8QualiV2.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Changed { get; set; }

        public BaseModel()
        {
            if (!Created.HasValue)
                Created = DateTime.Now;
            Changed = DateTime.Now;
        }
    }
}
