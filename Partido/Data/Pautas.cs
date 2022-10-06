
using System.ComponentModel.DataAnnotations.Schema;


namespace partido.Data;

  [Table("Pautas")]

public record Pautas(int ID, string Nome, string Descricao);