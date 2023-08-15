using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N24HomeTask1.Services
{
    abstract class FilterModel
    {
        public int PageSize { get; set; }
        public int PageToken { get; set; }
    }
}
