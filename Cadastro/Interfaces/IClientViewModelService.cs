using Cadastro.ViewModels;
using System.Collections.Generic;


namespace Cadastro.Interfaces
{
    public interface IClientViewModelService
    {
        ClientViewModel Get(int id);
        IEnumerable<ClientViewModel> GetAll();
        void Insert(ClientViewModel viewModel);
        void Update(ClientViewModel viewModel);
        void Delete(int id);
    }
}
