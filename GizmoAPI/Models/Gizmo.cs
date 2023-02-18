namespace GizmoAPI.Models;

public class Gizmo
{
    public int Id { get; set; }
    public int userId { get; set; }
    public string NickName { get; set; }
    public string Model { get; set; }
    public string Manufacturer { get; set; }
    public int GizmoCategoryId { get; set; }
    public string PurchaseDate { get; set; }
    public int AmountPaid { get; set; }
    public int EstimatedValue { get; set; }
    public string Img { get; set; }

    public bool IsPublic { get; set; }  

}
