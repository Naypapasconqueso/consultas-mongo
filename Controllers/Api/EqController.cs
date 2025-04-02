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

        var filtroNombreAgente = Builders<Inmueble>.Filter.Eq(x => x.NombreAgente, "Juan Perez");
        var lista = collection.Find(filtroNombreAgente).ToList();
        return Ok(lista);    
    }
}

