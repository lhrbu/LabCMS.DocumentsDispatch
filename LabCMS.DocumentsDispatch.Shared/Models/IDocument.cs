using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCMS.DocumentsDispatch.Shared.Models
{
    public interface IDocument
    {
        string Name { get; }
        byte[] Content { get; }
    }
}
