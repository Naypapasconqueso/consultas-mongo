using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/gt")]
public class GtController : Controller {
    [HttpGet("casas-baños-3")]
    public IActionResult CasasBaños3(){
        // Lista de todas las casas con más de 3 baños.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gt(x => x.Banios, 3);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);    
    }

 [HttpGet("casas-metros-terreno-500")]
    public IActionResult CasasMetrosTerreno500(){
        //  Listado de casas que tengan más de 500m de terreno.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gt(x => x.MetrosTerreno, 500);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);    
    }

[HttpGet("terreno-metros-construccion-700")]
    public IActionResult TerrenoMetrosConstruccion(){
        //  Dime los terrenos que tengan más de 700m de construcción.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gt(x => x.MetrosConstruccion, 700);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);    
    }

[HttpGet("casas-pisos-2")]
    public IActionResult CasasPisos2(){
        //  Lista de las casas que tengan más de 2 pisos.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gt(x => x.Pisos, 2);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);    
    }

[HttpGet("terreno-costo-19949")]
    public IActionResult TerrenoCosto19949(){
        //  Dame una lista de los terrenos que tengan un costo mayor de 19949.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gt(x => x.Costo, 19949);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);    
    }
}