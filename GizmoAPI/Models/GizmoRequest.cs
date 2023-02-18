namespace GizmoAPI.Models;

public class GizmoRequest
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string StartDate { get; set; }
    public string EndDate { get; set; }
    public int GizmoId { get; set; }
    public string RequestBody { get; set; }
    public bool IsAccpted { get; set; }

}
