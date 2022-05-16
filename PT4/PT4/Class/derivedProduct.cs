using System.Collections.Generic;

namespace PT4
{
    internal class DerivedProduct
    {
        public produit produit { get; set; }
        public int boughtQuantity { get; set; }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                var dp = (DerivedProduct)obj;
                return this.produit.Equals(dp.produit);
            }
        }

        public override int GetHashCode()
        {
            int hashCode = 1416600421;
            hashCode = hashCode * -1521134295 + EqualityComparer<produit>.Default.GetHashCode(produit);
            hashCode = hashCode * -1521134295 + boughtQuantity.GetHashCode();
            return hashCode;
        }
    }

}
