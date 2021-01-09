using DesignPatternSamples.Application.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Repository
{
    public interface IDetranVerificadorDebitosRepository
    {
        //A interface diz: voce precisa implementar o metodo ConsultarDebitos recebendo um veiculo e voce vai me devolver uma lista de debitos de veiculo
        Task<IEnumerable<DebitoVeiculo>> ConsultarDebitos(Veiculo veiculo);
    }
}
