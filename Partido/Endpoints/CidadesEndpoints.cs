
using Dapper.Contrib.Extensions;
using partido.Data;
using static Partido.Data.MilitanteContext;

namespace Partido.Endpoints
{
    public static class MapcidadesEndpoint
    {
        
        public static void MapcidadesEndpoint(this WebApplication app){

//          GET todas as cidades

            app.MapGet("/cidades", async (GetConnection connectionGetter) =>
            {
                using var con = await connectionGetter();
                return con.GetAll<Cidade>().ToList();
            });


//          Criar Militante        

            app.MapPost("/cidades", async (GetConnection conectionGetter, Cidade Cidade) =>
            {
                using var con = await conectionGetter();
                var id = con.Insert(Cidade);
                return Results.Created($"/cidades/{id}", Cidade);
            });

        }
    }
}

