using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/lt")]
public class LtController : Controller {
    [HttpGet("casas-metros_terreno-500")]
    public IActionResult CasasMetrosTerreno500(){
        // Quiero un listado de las casas en renta que tengan menos de 500 metros de terreno.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroMetrosTerreno = Builders<Inmueble>.Filter.Lt(x => x.MetrosTerreno, 500);
        var lista = collection.Find(filtroMetrosTerreno).ToList();
        return Ok(lista);    
    }

 [HttpGet("tipo-metros_construccion-551")]
    public IActionResult TipoMetrosConstruccion551(){
        // 2- Dame el nombre de las propiedades que tienen menos de 551 metros de construcción.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroMetrosConstruccion = Builders<Inmueble>.Filter.Lt(x => x.MetrosConstruccion, 551);
        var lista = collection.Find(filtroMetrosConstruccion).ToList();
        return Ok(lista);    
    }

 [HttpGet("casas-pisos-1")]
    public IActionResult CasasPisos1(){
        // 3- Dime cuantas casas en venta tienen menos de 1 piso.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroPisos = Builders<Inmueble>.Filter.Lt(x => x.Pisos, 1);
        var lista = collection.Find(filtroPisos).ToList();
        return Ok(lista);    
    }

[HttpGet("casas-baños-2")]
    public IActionResult CasasBaños2(){
        // 4- Listado de las casas en renta que tienen menos de 2 baños.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroBanios = Builders<Inmueble>.Filter.Lt(x => x.Banios, 2);
        var lista = collection.Find(filtroBanios).ToList();
        return Ok(lista);    
    }


[HttpGet("casas-costo-33421")]
    public IActionResult CasasCosto33421(){
        // 5- Casas en venta que cuesten menos de 33421.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroCosto = Builders<Inmueble>.Filter.Lt(x => x.Costo, 33421);
        var lista = collection.Find(filtroCosto).ToList();
        return Ok(lista);    
    }
}     