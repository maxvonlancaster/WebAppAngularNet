using EWebApp.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EWebApp.BLL.Services
{
    public class StreamingService: IStreamingService
    {
        private IPresentationService _presentationService;

        public StreamingService(IPresentationService presentationService)
        {
            _presentationService = presentationService;
        }
    }
}
