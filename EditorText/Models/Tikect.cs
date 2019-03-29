namespace EditorText.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public class Tikect
    {
        [Key]
        public int TikectId { get; set; }

        [Display(Name = "Tipo del incidencia")]
        public string TypeIncident { get; set; }

        [Display(Name = "Descripcion del problema")]
        [DataType(DataType.MultilineText)]
        [AllowHtml]
        public string DescriptionIncident { get; set; }

        [Display(Name = "Fecha de Incidencia")]
        [DataType(DataType.Date)]
        public DateTime? DateIncident { get; set; }

        [Display(Name = "Captura")]
        public string DocumentImage { get; set; }
    }
}