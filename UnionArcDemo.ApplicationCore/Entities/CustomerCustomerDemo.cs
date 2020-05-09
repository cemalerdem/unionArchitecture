﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnionArcDemo.Domain.Entities;

namespace UnionArcDemo.ApplicationCore.Entities
{
    public class CustomerCustomerDemo
    {
        [Key]
        [Column("CustomerID")]
        [StringLength(5)]
        public string CustomerId { get; set; }
        [Key]
        [Column("CustomerTypeID")]
        [StringLength(10)]
        public string CustomerTypeId { get; set; }

        [ForeignKey(nameof(CustomerId))]
        [InverseProperty(nameof(ApplicationCore.Entities.Customer.CustomerCustomerDemo))]
        public virtual Customer Customer { get; set; }
        [ForeignKey(nameof(CustomerTypeId))]
        [InverseProperty(nameof(CustomerDemographics.CustomerCustomerDemo))]
        public virtual CustomerDemographics CustomerType { get; set; }
    }
}
