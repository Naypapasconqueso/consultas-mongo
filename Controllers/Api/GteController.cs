using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/gte")]
public class GteController : Controller {
    [HttpGet("casas-baños-3")]
    public IActionResult CasasBaños3(){
        //  Dime cuántas casas tienen 3 baños.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gte(x => x.Banios, 3);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);    
    }


    [HttpGet("casas-metros-terreno-310")]
    public IActionResult CasasMetrosTerreno310(){
        // Lista de las casas que tengan 310 metros de terreno.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gte(x => x.MetrosTerreno, 310);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);    
    }

 [HttpGet("casas-costo-3600056")]
    public IActionResult CasasCosto3600056(){
        // Quiero un listado de las casas que su costo sea 3600056.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gte(x => x.Costo, 3600056);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);    
    }

[HttpGet("agencia-Fernández-Inmuebles")]
    public IActionResult AgenciaFernándezInmuebles(){
        //  Lista de las agencias que su nombre sea Fernández Inmuebles.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gte(x => x.Agencia, "Fernández Inmuebles");
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);    
    }

[HttpGet("casas-metros-construccion-746")]
    public IActionResult CasasMetrosConstruccion746(){
        //  Buscar todas las casas que tengan 746 metros de construcción.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gte(x => x.MetrosConstruccion, 746);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);    
    }
}