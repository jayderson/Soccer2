using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Soccer.Web.Data.Entities
{
    public class TeamEntity
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "el campo {0} no puede contener mas de {1} caracteres.")]
        [Required(ErrorMessage = "el campo {0} es obligatorio.")]
        public string Name { get; set; }

        [Display (Name = "logo")]
        public string LogoPath { get; set; }

        public ICollection<GroupDetailEntity> GroupDetails { get; set; }

        public ICollection<UserEntity> Users { get; set; }
    }
}
