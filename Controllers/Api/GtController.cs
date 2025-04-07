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
}