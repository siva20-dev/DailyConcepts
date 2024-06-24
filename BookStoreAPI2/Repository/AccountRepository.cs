using BookStoreAPI2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreAPI2.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _configuration;

        public AccountRepository(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager,
            IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }

        public async Task<IdentityResult> SignUPAsync(SignUPModel signUPModel)
        {
            var user = new ApplicationUser() 
            { 
                FirstName = signUPModel.FirstName,
                LastName = signUPModel.LastName,
                Email = signUPModel.Email,
                UserName = signUPModel.Email
            };

           return await _userManager.CreateAsync(user,signUPModel.Password);
        }

        public async Task<string> LoginAsync(SignInModel signInModel)
        {
            var result = await _signInManager.PasswordSignInAsync(signInModel.Email,signInModel.Password,false,false);
            if (!result.Succeeded)
            {
                return null;
            }

            var authClaims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, signInModel.Email),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
            };
            var authSigninKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddDays(1),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigninKey, SecurityAlgorithms.HmacSha256Signature)
                );

           return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
