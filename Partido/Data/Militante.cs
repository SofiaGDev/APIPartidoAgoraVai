
using System.ComponentModel.DataAnnotations.Schema;


namespace partido.Data;

  [Table("Militante")]

public record Militante(int ID, string Nome, string Idade);