using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_JogueFacil.Models;

namespace Sistema_JogueFacil.Command
{
    public interface ICommand
    {
        void Execute(EntidadeDominio entidade);
    }
}
