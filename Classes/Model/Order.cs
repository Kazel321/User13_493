namespace OOOSportProducts.Classes.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderProduct = new HashSet<OrderProduct>();
        }

        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        public int StatusId { get; set; }

        public DateTime OrderDeliveryDate { get; set; }

        public int PickupPointId { get; set; }

        public string OrderClientName { get; set; }

        public int OrderCode { get; set; }

        public virtual PickupPoint PickupPoint { get; set; }

        public virtual Status Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
    }
}
