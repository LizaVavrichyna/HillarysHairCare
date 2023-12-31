namespace HillarysHairCare.Models;
public class Appointment
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    public int StylistId { get; set; }
    public Stylist Stylist { get; set; }
    public List<Service> Services { get; set; }
    public DateTime AppointmentTime { get; set; }
    public bool IsAppointmentFinished { get; set; }
    public bool IsAppointmentCanceled { get; set; }
    public decimal TotalCost
    {
        get
        {   
            decimal charge = 0.0M;
            if (IsAppointmentFinished == true)
            {
                foreach (Service s in Services)
                {
                    charge += s.CostOfService; 
                }
            }
            return charge;
        }
    }
}