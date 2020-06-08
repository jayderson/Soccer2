using Microsoft.AspNetCore.Mvc.Rendering;
using Soccer.Web.Data.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Soccer.Web.Models
{
    public class GroupDetailViewModel : GroupDetailEntity
    {
        public int GroupId { get; set; }

        [Required(ErrorMessage = "el campo {0} es obligatorio.")]
        [Display(Name = "Equipo")]
        [Range(1, int.MaxValue, ErrorMessage = "debe seleccionar un equipo.")]
        public int TeamId { get; set; }

        public IEnumerable<SelectListItem> Teams { get; set; }

    }
}
