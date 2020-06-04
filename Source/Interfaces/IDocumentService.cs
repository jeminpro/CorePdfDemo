using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDFDemo.Interfaces
{
    public interface IDocumentService
    {
        byte[] GeneratePdfFromString();

        byte[] GeneratePdfFromRazorView();
    }
}
