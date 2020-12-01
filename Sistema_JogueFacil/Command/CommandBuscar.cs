using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sistema_JogueFacil.Command;

namespace Sistema_JogueFacil.Command
{
    public class CommandBuscar : ICommand
    {
        //Facade fachada;


        public sealed class HttpResponse<EntidadeDominio> execute(EntidadeDominio entidade)
        {
            return fachada.save(entidade);
        }
    }
}