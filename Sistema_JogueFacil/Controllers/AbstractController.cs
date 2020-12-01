using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sistema_JogueFacil.Command;

namespace Sistema_JogueFacil.Controllers
{
    public abstract class AbstractController<EntidadeDominio entidadeDominio>
    {
		// GET: Abstract
		
	//CommandSalvar commandSalvar;
	
	CommandBuscar commandBuscar;
	
	//CommandExcluir commandExcluir;
	
	//CommandAtualizar commandAtualizar;

	[HttpPost]
	public ResponseEntity<EntidadeDominio> save(@RequestBody T entidade)
		{
			return commandSalvar.execute(entidade);
		}
	
	
	public class HttpResponse(T, EntidadeDominio)
		{
			return commandBuscar.execute(entidade);
		}

	[HttpDelete]
	public ResponseEntity<EntidadeDominio> delete(@RequestBody(required = true) T entidade) {
		return commandExcluir.execute(entidade);
	}

	[HttpPut]
	public ResponseEntity<EntidadeDominio> update(@RequestBody(required = true) T entidade) {
		return commandAtualizar.execute(entidade);
	}
    
}