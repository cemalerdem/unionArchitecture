using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnionArcDemo.Domain.Entities;

namespace UnionArcDemo.ApplicationCore.Entities
{
    public class EmployeeTerritory
    {
        [Key]
        [Column("EmployeeID")]
        public int EmployeeId { get; set; }
        [Key]
        [Column("TerritoryID")]
        [StringLength(20)]
        public string TerritoryId { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty(nameof(ApplicationCore.Entities.Employee.EmployeeTerritories))]
        public virtual Employee Employee { get; set; }
        [ForeignKey(nameof(TerritoryId))]
        [InverseProperty(nameof(Entities.Territory.EmployeeTerritories))]
        public virtual Territory Territory { get; set; }
    }
}
