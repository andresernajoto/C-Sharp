using System;
using System.Globalization;

namespace ProductTag.Entities {
    // herdado da Product
    class UsedProduct : Product {

        // declaração das propriedades da classe
        public DateTime ManufactureDate { get; set; }

        // construtor padrão
        public UsedProduct() { }

        /* construtor que recebe os dados de 
         Product e inclui o ManufactureDate */
        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price) {

            ManufactureDate = manufactureDate;
        }

        // override do PriceTag
        public override string PriceTag() {
            return Name
                + " (used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: "
                + ManufactureDate.ToString("dd/MM/yyyy")
                + ")";
        }
    }
}
