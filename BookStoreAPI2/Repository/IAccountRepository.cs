using BookStoreAPI2.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace BookStoreAPI2.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> SignUPAsync(SignUPModel signUPModel);
        Task<string> LoginAsync(SignInModel signInModel);
    }
}