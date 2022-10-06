
using System.ComponentModel.DataAnnotations.Schema;


namespace partido.Data;

  [Table("Tarefas")]

public record Tarefa(int IdTarefa, string Nome, string Descricao, Boolean feito);

    