
using Dapper.Contrib.Extensions;
using partido.Data;
using static Partido.Data.MilitanteContext;

namespace Partido.Endpoints
{
    public static class MilitantesEndpoints
    {
        
        public static void MapmilitantesEndpoint(this WebApplication app){

//          GET todos os militantes

            app.MapGet("/militantes", async (GetConnection connectionGetter) =>
            {
                using var con = await connectionGetter();
                return con.GetAll<Militante>().ToList();
            });

//          GET Militante por ID
            app.MapGet("/militantes/{id}", async (GetConnection connectionGetter, int id) =>
            {
                using var con = await connectionGetter();
                return con.Get<Militante>(id);
            });

//          Criar Militante        

            app.MapPost("/militantes", async (GetConnection conectionGetter, Militante Militante) =>
            {
                using var con = await conectionGetter();
                var id = con.Insert(Militante);
                return Results.Created($"/militantes/{id}", Militante);
            });

//          Editar Militante


            app.MapPut("/militantes", async(GetConnection connectionGetter, Militante Militante) =>
            {
                using var con = await connectionGetter();
                var id = con.Update(Militante);
                return Results.Ok("Atualizado com sucesso");
            });

//          Deletar Militante

            app.MapDelete("/militantes/{id}", async (GetConnection connectionGetter, int id) =>
            {
                using var con = await connectionGetter();
                con.Delete(new Militante(id, "",""));
                return Results.Ok("Militante excluido com sucesso");
            });

//          Deletar tudo

              app.MapDelete("/militantes", async (GetConnection connectionGetter) =>
            {
                using var con = await connectionGetter();
                con.DeleteAll<Militante>();
                return Results.Ok("Nada para ver aqui não ABIN");
            });

        }
    }
}

