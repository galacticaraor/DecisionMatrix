using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class FileResult
    {
        public bool Successful { get; set; }
        public string Error { get; set; }
        public FileResult(bool successful, string error)
        {
            Successful = successful;
            Error = error;
        }
    }
}
