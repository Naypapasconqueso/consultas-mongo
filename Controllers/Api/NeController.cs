using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/ne")]
public class NeController : Controller {
    [HttpGet("casas-ana-torres")]
    public IActionResult CasasAnaTorres(){
        // 1-Todas las casas que no sean rentadas por Ana Torres.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<string> tipo = new List<string>();
        tipo.Add("Tipo");
        tipo.Add("Casa");

        var filtro = Builders<Inmueble>.Filter.Ne(x => x.Tipo, "AnaTorres");

        var lista = collection.Find(filtro).ToList();
        return Ok(lista);    
    }
    [HttpGet("casas-fecha_publicacion-2025-01-04")]
    public IActionResult CasasFechasPublicacion20250104(){
        // 2-Registros de casas que no fueron publicadas el 2025-01-04.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<string> tipo = new List<string>();
        tipo.Add("Tipo");
        tipo.Add("FechaPublicacion");

        var filtro = Builders<Inmueble>.Filter.Ne(x => x.FechaPublicacion, "2025-01-04");

        var lista = collection.Find(filtro).ToList();
        return Ok(lista);    
    }
    [HttpGet("casas-costo-4720907")]
    public IActionResult CasasCosto4720907(){
        // 3-Rentas con un costo diferente a 4720907.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<string> tipo = new List<string>();
        tipo.Add("Costo");

        var filtro = Builders<Inmueble>.Filter.Ne(x => x.Costo, 4720907);

        var lista = collection.Find(filtro).ToList();
        return Ok(lista);    
    }
     [HttpGet("tipo-edificio")]
    public IActionResult TipoCasa(){
        // 4-Lista de todas las propiedades que no sean de tipo Edificio.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<string> tipo = new List<string>();
        tipo.Add("Tipo");

        var filtro = Builders<Inmueble>.Filter.Ne(x => x.Tipo, "Edifcio");

        var lista = collection.Find(filtro).ToList();
        return Ok(lista);    
    }

    [HttpGet("casas-metros_terreno-958")]
    public IActionResult CasasMetrosTerreno958(){
        // 5-Busca todas las casas con un terreno diferente a 958 metros.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<string> tipo = new List<string>();
        tipo.Add("Tipo");

        var filtro = Builders<Inmueble>.Filter.Ne(x => x.MetrosTerreno, 958);

        var lista = collection.Find(filtro).ToList();
        return Ok(lista);    
    }
}