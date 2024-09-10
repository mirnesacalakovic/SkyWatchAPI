﻿using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using SkyWatch_API.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SkyWatch_API.Services
{
    public class TokenService
    {
        private readonly UserManager<User> userManager;
        private readonly IConfiguration config;

        public TokenService(UserManager<User> userManager, IConfiguration config)
        {
            this.userManager = userManager;
            this.config = config;
        }

        public async Task<string> GenerateToken(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Name, user.UserName),
            };

            var roles = await userManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["JWTSettings:TokenKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512);

            var tokenOptions = new JwtSecurityToken(
                issuer: null, audience: null, claims: claims, expires: DateTime.Now.AddDays(7), signingCredentials: creds
             );

            return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        }
    }
}
