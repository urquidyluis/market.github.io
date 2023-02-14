﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Shopping.Data.Entities
{
    public class State
    {
        public int Id { get; set; }

        [Display(Name = "Estado/Departamento")]
        [MaxLength(50, ErrorMessage = "El campo {0} no debe tener máximo {1} caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }

        [JsonIgnore]
        public Country Country { get; set; }

        public ICollection<City> Cities { get; set; }

        [Display(Name = "Ciudades")]
        public int CitiesNumber => Cities == null ? 0 : Cities.Count;
    }
}
