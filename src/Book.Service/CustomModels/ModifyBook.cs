using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book.Service.CustomModels
{
    public class ModifyBook : RegisterBook
    {
        public Guid Id { get; set; }
    }
}