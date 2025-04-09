using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/nin")]
public class NinController : Controller {
    [HttpGet("casas-agente-Ana-Torres-Juan-Perez")]
    public IActionResult NombreAgenteAnaTorresJuanPerez(){
        // 1-Dame todas las casas en donde el agente no sea Ana Torres ni Juan Perez.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<string> nombreagente = new List<string>();
        nombreagente.Add("Juan Pérez");
        nombreagente.Add("Ana Torres");

        var filtro = Builders<Inmueble>.Filter.Nin(x => x.NombreAgente, nombreagente);

        var lista = collection.Find(filtro).ToList();
        return Ok(lista);    
    }

    [HttpGet("casas-baños-2-3")]
    public IActionResult CasasBaños23(){
        // 2-Lista de casas que no tengan 2 ni 3 baños.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<int> baños = new List<int>();
        baños.Add(2);
        baños.Add(3);

        var filtro = Builders<Inmueble>.Filter.Nin(x => x.Banios, baños);

        var lista = collection.Find(filtro).ToList();
        return Ok(lista);    
    }

    [HttpGet("tipo-metros_construccion-600-800")]
    public IActionResult TipoMetrosCostruccin600800(){
        // 3-Propiedades que no tengan 600 ni 800 metros de construcción.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<int> numeros = new List<int>();
        numeros.Add(600);
        numeros.Add(800);

        var filtro = Builders<Inmueble>.Filter.Nin(x => x.MetrosConstruccion, numeros);

        var lista = collection.Find(filtro).ToList();
        return Ok(lista);    
    }

    [HttpGet("operacion-costo-885107-19949")]
    public IActionResult OperacionCosto88510719949(){
        // 4-Busca las rentas cuyo costo no sea 885107 ni 19949.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<int> numeros = new List<int>();
        numeros.Add(885107);
        numeros.Add(19949);

        var filtro = Builders<Inmueble>.Filter.Nin(x => x.Costo, numeros);

        var lista = collection.Find(filtro).ToList();
        return Ok(lista);    
    }

    [HttpGet("casas-pisos-3-4")]
    public IActionResult CasasPisos34(){
        // 5-Casas que no tengan 3 ni 4 pisos.

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<int> numeros = new List<int>();
        numeros.Add(3);
        numeros.Add(4);

        var filtro = Builders<Inmueble>.Filter.Nin(x => x.Pisos, numeros);

        var lista = collection.Find(filtro).ToList();
        return Ok(lista);    
    }
}    