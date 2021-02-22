using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoolRatings.Models
{
    public class TypeModel
    {

        public int Id { get; set; }

        public int Code { get; set; }


        public TypeModel(int Code)
        {
            this.Code = Code;
        }
    }
}
