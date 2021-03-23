using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FireFlyFireworks.Models
{
        public class Color
        {
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            [Display(Name = "Number")]
            public int ColorID { get; set; }



            [StringLength(50, MinimumLength = 3)]
            public string ColorName { get; set; }



            [DataType(DataType.Currency)]
            public double Price { get; set; }


            public int ColorFamID { get; set; }
            public string ColorFamName { get; set; }




            public ICollection<Order> Orders { get; set; }
        }
    }



