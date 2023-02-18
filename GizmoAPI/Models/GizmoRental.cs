namespace GizmoAPI.Models;

public class GizmoRental
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int GizmoId { get; set; }
    public string RentalStartDate { get; set; }
    public string RentalEndDate { get;set; }
    public bool RentalComplete { get; set; }
}
