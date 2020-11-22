namespace ApiUsuariosClip.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class usuarios
    {
        [Key]
        public int id_usuario { get; set; }

        [Required]
        [StringLength(30)]
        public string nombre { get; set; }

        [Required]
        [StringLength(30)]
        public string apellido { get; set; }

        [Required]
        [StringLength(50)]
        public string foto_frente_dni { get; set; }

        [Required]
        [StringLength(50)]
        public string foto_reverso_dni { get; set; }

        public int dni { get; set; }

        [Required]
        [StringLength(50)]
        public string email { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha_nac { get; set; }

        public long cuilcuit { get; set; }

        [StringLength(20)]
        public string telefono { get; set; }

        [Required]
        [StringLength(30)]
        public string calle { get; set; }

        [Required]
        [StringLength(6)]
        public string numero_calle { get; set; }

        public bool? departamento { get; set; }

        public byte? piso { get; set; }

        [StringLength(10)]
        public string puerta { get; set; }

        [Required]
        [StringLength(20)]
        public string barrio { get; set; }

        [Required]
        [StringLength(9)]
        public string codigo_postal { get; set; }

        public int id_localidad { get; set; }
    }
}
