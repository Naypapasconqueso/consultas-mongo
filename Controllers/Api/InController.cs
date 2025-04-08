using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/in")]
public class InController : Controller {
    [HttpGet("tipo-terreno-casa")]
    public IActionResult TipoTerrenoCasa(){
        // 1- Buscar todas las propiedades que sean tipo terreno o casa.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<string> tipo = new List<string>();
        tipo.Add("Terreno");
        tipo.Add("Casa");

        var filtro = Builders<Inmueble>.Filter.In(x => x.Tipo, tipo);

        var lista = collection.Find(filtro).ToList();
        return Ok(lista);    
    }

    [HttpGet("casas-Juan-Pérez-Carlos-García")]
    public IActionResult CasasJuanPérezCarlosGarcía(){
        // Lista de las casas gestionadas por Juan Perez o Carlos García.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<string> tipo = new List<string>();
        tipo.Add("Juan Pérez");
        tipo.Add("Carlos García");

        var filtro = Builders<Inmueble>.Filter.In(x => x.Tipo, tipo);

        var lista = collection.Find(filtro).ToList();
        return Ok(lista);    
    }

[HttpGet("metros_terreno-310-235")]
    public IActionResult MetrosTerreno310235(){
        // Dime cuales terrenos en renta tienen 310 o 235 metros de terreno.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<int> tipo = new List<int>();
        tipo.Add(310);
        tipo.Add(235);

        var filtro = Builders<Inmueble>.Filter.In(x => x.MetrosTerreno, tipo);

        var lista = collection.Find(filtro).ToList();
        return Ok(lista);    
    }

[HttpGet("tipo-8833-7763")]
    public IActionResult Tipo88337763(){
        // Quiero un listado de todas las propiedades que tengan un costo de 8833 o 7763.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<int> tipo = new List<int>();
        tipo.Add(8833);
        tipo.Add(7763);

        var filtro = Builders<Inmueble>.Filter.In(x => x.Costo, tipo);

        var lista = collection.Find(filtro).ToList();
        return Ok(lista);    
    }

[HttpGet("pisos-0-2")]
    public IActionResult Pisos02(){
        // 5- Listar propiedades que tengan 0 o 2 pisos.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<int> tipo = new List<int>();
        tipo.Add(0);
        tipo.Add(2);

        var filtro = Builders<Inmueble>.Filter.In(x => x.Pisos, tipo);

        var lista = collection.Find(filtro).ToList();
        return Ok(lista);    
    }
}