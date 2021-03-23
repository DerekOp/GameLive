
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FireFlyFireworks.Models
{
    public class Chem
    {

            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            [Display(Name = "Chemistry ID")]
            public int ChemID { get; set; }

            [Required]
            [Display(Name = "Chemical Composition")]
            [StringLength(255)]
            public string ChemComp { get; set; }

            [Required]
            [Display(Name = "Chemical Abbreviation")]
            [StringLength(50)]
            public string ChemAbbrev { get; set; }

           // [Required]
           // public int ColorID { get; set; }


            public int ColorID { get; set; }

        [Required]
            [Range(0, 4)]
            public int WarehouseLocationID { get; set; }


            //  public WarehouseLocation WarehouseLocation { get; set; }






        }
    }



