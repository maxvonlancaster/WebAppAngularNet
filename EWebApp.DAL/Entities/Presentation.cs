using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EWebApp.DAL.Entities
{
    public class Presentation
    {
        [Key]
        public long PresentationId { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(100)")]
        public string PresentationName { get; set; }
        public string PresentationTopic { get; set; }
        public byte[] File { get; set; }
    }
}
