using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace GizmoAPI.Models;

[BindProperties]
public class User
{
    public int Id { get; set; }
    public string Uid { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Pronouns { get; set; }
    public int Zipcode { get; set;  }
    public string ProfileImg { get; set; }
    public string UserCaption { get; set; }
    public object Geocode { get; set; }



}
