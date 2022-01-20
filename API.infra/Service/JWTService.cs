using API.core.Data;
using API.core.Repoisitory;
using API.core.Service;
using MailKit.Net.Smtp;
using Microsoft.IdentityModel.Tokens;
using MimeKit;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace API.infra.Service
{
    public class JWTService : IJWTService
    {

        private readonly IJWTRepository _JWT;
        public JWTService(IJWTRepository JWT)
        {

            _JWT = JWT;
        }
        public string Auth(LOGIN_TABLE login)
        {

            var result = _JWT.Auth(login);
            if (result == null)
            {
                return null;
            }
            else
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenKey = Encoding.ASCII.GetBytes("[SECRET Used To Sign And Verify Jwt Token, It can be any string]");
                var tokenDescriptor = new SecurityTokenDescriptor
                {

                Subject = new ClaimsIdentity(
                new Claim[]
                {
                new Claim(ClaimTypes.Name, result.USERNAME),
                new Claim(ClaimTypes.Role, result.ROLNAME)
                }
                ),
                    Expires = DateTime.UtcNow.AddHours(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);
            }
        }
        //montheral1499@gmail.com
        public bool emaill()
        {

            MimeMessage message = new MimeMessage();

            MailboxAddress from = new MailboxAddress("LILIA","liliatubbsh@gmail.com");
            message.From.Add(from);

            MailboxAddress to = new MailboxAddress("Monther", "montheral499@gmail.com");
            message.To.Add(to);

            message.Subject = "Reset Password";

            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = "<h3>hi</h3>";
            message.Body = bodyBuilder.ToMessageBody();

            using (var clint = new SmtpClient())
            {
                clint.Connect("smtp.gmail.com", 587, false);


                clint.Authenticate("liliatubbsh@gmail.com", "Lili1234&&");

                clint.Send(message);
                clint.Disconnect(true);

            }

            return true;

        }





}
}
