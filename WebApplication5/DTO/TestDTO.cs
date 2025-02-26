using System.ComponentModel.DataAnnotations;

namespace WebApplication5.DTO;

public class TestDTO
{
    [Required] public int Id { get; set; }

    [Required] public string Name { get; set; }
}