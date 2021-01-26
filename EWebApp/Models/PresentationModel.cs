using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EWebApp.Models
{
    public class PresentationModel
    {
        public int PresentationId { get; set; }
        public string PresentationName { get; set; }
        public string PresentationTopic { get; set; }
        public IFormFile File { get; set; }
    }
}
