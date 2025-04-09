using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/lte")]
public class LteController : Controller {
    [HttpGet("casas-costo-46149")]
    public IActionResult CasasCosto46149(){
        // 1-Todas las casas con un costo de 46149 o menos.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroCosto = Builders<Inmueble>.Filter.Lte(x => x.Costo, 46149);
        var lista = collection.Find(filtroCosto).ToList();
        return Ok(lista);    
    }

    [HttpGet("casas-baños-3")]
    public IActionResult CasasBaños3(){
        // 2-Lista de las casas con 3 o menos baños.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroBanios = Builders<Inmueble>.Filter.Lte(x => x.Banios, 3);
        var lista = collection.Find(filtroBanios).ToList();
        return Ok(lista);    
    }
    
    [HttpGet("ventas-pisos-3")]
    public IActionResult VentasPisos3(){
        // 3-Dame las ventas con 3 o menos pisos.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroPisos = Builders<Inmueble>.Filter.Lte(x => x.Pisos, 3);
        var lista = collection.Find(filtroPisos).ToList();
        return Ok(lista);    
    }

    [HttpGet("casas-costo-4720907")]
    public IActionResult CasasCosto4720907(){
        // 4-Quiero todas las casas con un costo de 4720907 o menos.


        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroCosto = Builders<Inmueble>.Filter.Lte(x => x.Costo, 4720907);
        var lista = collection.Find(filtroCosto).ToList();
        return Ok(lista);    
    }

    [HttpGet("casas-metros-construccion-322")]
    public IActionResult CasasMetrosConstruccion322(){
        // 5-Casas con 322 o menos metros de construcción


        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroMetrosConstruccion = Builders<Inmueble>.Filter.Lte(x => x.MetrosConstruccion, 322);
        var lista = collection.Find(filtroMetrosConstruccion).ToList();
        return Ok(lista);    
    }
}     