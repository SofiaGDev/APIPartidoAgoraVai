
using Dapper.Contrib.Extensions;
using partido.Data;
using static Partido.Data.TarefaContext;

namespace Partido.Endpoints
{
    public static class TarefasEndpoints
    {
        
        public static void MapTarefasEndpoints(this WebApplication app){

//          GET todas as tarefas

            app.MapGet("/tarefas", async (GetConnection connectionGetter) =>
            {
                using var con = await connectionGetter();
                return con.GetAll<Tarefa>().ToList();
            });

//          GET tarefas por ID
            app.MapGet("/tarefas/{id}", async (GetConnection connectionGetter, int id) =>
            {
                using var con = await connectionGetter();
                return con.Get<Tarefa>(id);
            });

//          Criar tarefa        

            app.MapPost("/tarefas", async (GetConnection conectionGetter, Tarefa Tarefa) =>
            {
                using var con = await conectionGetter();
                var id = con.Insert(Tarefa);
                return Results.Created($"/tarefas/{id}", Tarefa);
            });

//          Editar Tarefa


            app.MapPut("/tarefas", async(GetConnection connectionGetter, Tarefa Tarefa) =>
            {
                using var con = await connectionGetter();
                var id = con.Update(Tarefa);
                return Results.Ok("Atualizado com sucesso");
            });



            app.MapGet("/tarefas/{id}", async (GetConnection connectionGetter, int id) =>
            {
                using var con = await connectionGetter();
                return con.Get<Tarefa>(id);
            });



//          Deletar Tarefa

            app.MapDelete("/tarefas/{id}", async (GetConnection connectionGetter, int id) =>
            {
                using var con = await connectionGetter();
                con.Delete(new Tarefa(id, "", "", false));
                return Results.Ok("Excluido com sucesso");
            });

  

        }
    }
}