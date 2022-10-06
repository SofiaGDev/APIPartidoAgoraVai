
using Dapper.Contrib.Extensions;
using partido.Data;
using static Partido.Data.MilitanteContext;

namespace Partido.Endpoints
{
    public static class PautasEndpoints
    {
        
        public static void MapPautasEndpoints(this WebApplication app){

//          GET all pautas

            app.MapGet("/pautas", async (GetConnection connectionGetter) =>
            {
                using var con = await connectionGetter();
                return con.GetAll<Pautas>().ToList();
            });



//          Criar pautas        

            app.MapPost("/pautas", async (GetConnection conectionGetter, Pautas Pautas) =>
            {
                using var con = await conectionGetter();
                var id = con.Insert(Pautas);
                return Results.Created($"/pautas/{id}", Pautas);
            });

        }
    }
}

