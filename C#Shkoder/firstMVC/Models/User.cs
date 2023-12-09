using System.ComponentModel.DataAnnotations;
#pragma warning disable CS8618
namespace firstMVC.Models;

public class User
{
    // string FirstName = null 
    // null=="null"
    [Required(ErrorMessage ="Emri eshte nje fushe qe duhet plotesuar me patjeter")]
    [MinLength(4,ErrorMessage ="Gjatesi e emrit duhet te jete me shume se 3 shkronja")]
    public string FirstName {get;set;}
    [Required]
    public string LastName {get;set;}
    public string Location {get;set;}
    [Required]
    [Range(13,120,ErrorMessage ="Duhet te jesh midis 13 dhe 120 vjec")]
    public int Age {get;set;}

}