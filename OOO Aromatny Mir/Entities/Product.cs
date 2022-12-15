namespace OOO_Aromatny_Mir.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        [StringLength(30)]
        public string ProductArticle { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }

        public int ProductUnit { get; set; }

        public decimal ProductCost { get; set; }

        public int ProductManufacturer { get; set; }

        public int ProductProvider { get; set; }

        public int ProductCategory { get; set; }

        public int? ProductDiscount { get; set; }

        public int? ProductMaxDiscount { get; set; }

        public int ProductQuantity { get; set; }

        [Required]
        public string ProductDescription { get; set; }

        [Column(TypeName = "image")]
        public byte[] ProductPhoto { get; set; }

        public virtual Category Category { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        public virtual Provider Provider { get; set; }

        public virtual Unit Unit { get; set; }
    }
}
