using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polindromos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Resultados : ControllerBase
    {
        [HttpGet]
        public IActionResult PalindromoResultado(string guardar)
        {
            var P = new Palindromo();
            P.palindromo = guardar;
            var PFinal = string.Empty;
            var Pcontar = guardar;
            int i = Pcontar.Length;
            var PalindrFinal = "";

            for (int n = i - 1; n >= 0; n--)
            {

            }

            for (int j = i - 1; j >= 0; j--)
            {
                PFinal = PFinal + Pcontar[j];
            }
            if (PFinal.ToLower().Replace(" ", string.Empty) == Pcontar.ToLower().Replace(" ", string.Empty))
            {
                PalindrFinal = (Pcontar + ": es palindrome");
            }
            else
            {
                PalindrFinal = (Pcontar + ": no es palindrome");
            }
            int Palabras = Pcontar.Length - Pcontar.Replace(" ", string.Empty).Count() + 1;
            var ResultadoInvert = ("Palabra: " + PalindrFinal.ToLower() + ", Invertido: " + PFinal.ToLower() + "y Numero de palabra: " + Palabras);
            return Ok(ResultadoInvert.ToLower());

        }
    }
}

/*
 * Universidad Tecnologica Metropolitana
Mat: Aplicaciones Web Orientadas a Objetos
Mae: Chuc Uc Joel Ivan
Actividad: Palindromos
Alu: Joatan de Jesus Lopez Canul
4-B
Parcial 1
*/