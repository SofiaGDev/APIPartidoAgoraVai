
using System.ComponentModel.DataAnnotations.Schema;


namespace partido.Data;

  [Table("Cidade")]

public record Cidade(int ID, string City, string Idade);