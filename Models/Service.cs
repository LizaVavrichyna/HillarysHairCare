using System.ComponentModel.DataAnnotations;

namespace HillarysHairCare.Models;
public class Service
{
    public int Id { get; set; }

    [Required]
    public string ServiceType { get; set; }
    public decimal CostOfService { get; set; }
    public List<Appointment>? Appointments { get; set; }
}