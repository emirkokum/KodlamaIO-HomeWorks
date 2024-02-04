using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    public class Discount: IEntity
    {
        public int Id { get; set; }
        public float DiscountAmount { get; set; }
        public string Name { get; set; }

    }
}
