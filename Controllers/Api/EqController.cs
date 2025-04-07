using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/eq")]
public class EqController : Controller {
    [HttpGet("listar-agentes")]
    public IActionResult ListarAgentes(){
        // Ventas donde el agente sea Juan Perez

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroNombreAgente = Builders<Inmueble>.Filter.Eq(x => x.NombreAgente, "Juan Pérez");
        var lista = collection.Find(filtroNombreAgente).ToList();
        return Ok(lista);    
    }


    [HttpGet("listar-tipo")]
    public IActionResult ListarTipo(){
        // Donde el tipo sea terreno.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.Tipo, "Terreno");
        var lista = collection.Find(FilterDefinition<Inmueble>.Empty).ToList();
        return Ok(lista);
    }


 [HttpGet("listar-metros_terreno")]
    public IActionResult ListarMetrosTerreno(){
        // listado de los metros del terreno que sea 958.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.MetrosTerreno, 958);
        var lista = collection.Find(FilterDefinition<Inmueble>.Empty).ToList();
        return Ok(lista);
    }
 
 [HttpGet("listar-pisos")]
    public IActionResult ListarPisos(){
        //  Dame una lista de las casas que tengan 3 pisos.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.Pisos, 3);
        var lista = collection.Find(FilterDefinition<Inmueble>.Empty).ToList();
        return Ok(lista);
    }

 [HttpGet("listar-costo")]
    public IActionResult ListarCosto(){
        //  Lista de los terrenos con el costo de 33421.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.Costo, 33421);
        var lista = collection.Find(FilterDefinition<Inmueble>.Empty).ToList();
        return Ok(lista);
    }
}


