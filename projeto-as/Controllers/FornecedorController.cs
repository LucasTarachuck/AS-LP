using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]

public class FornecedorController : ControllerBase
{
    private readonly IFornecedorRepository _repository;
    public FornecedorController(IFornecedorRepository repository)
    {
        _repository = repository;
    }
    [HttpGet]
    public ActionResult<List<Fornecedor>> GetAll()
    {
        return Ok(_repository.GetAll());
    }

    [HttpGet("{id}")]
    public ActionResult Post(Fornecedor fornecedor)
    {
        _repository.Post(fornecedor);
        return Created();
    }

    [HttpPut("{id}")]
    public ActionResult Put(int id, Fornecedor fornecedorAtualizado)
    {
        var fornecedorEncontrado = _repository.Put(id, fornecedorAtualizado);

        if (fornecedorEncontrado == null)
            return NotFound();

        return Ok(fornecedorEncontrado);
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var fornecedorEncontrado = _repository.Delete(id);

        if (fornecedorEncontrado == null)
            return NotFound();

        return NoContent();
    }
}