﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestAspNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet("{primeiroNumero}/{segundoNumero}")]
        public IActionResult Sum(string primeiroNumero, string segundoNumero)
        {
            if(IsNumeric(primeiroNumero) && IsNumeric(segundoNumero))
            {

                var sum = ConvertToNumber(primeiroNumero) + ConvertToNumber(segundoNumero);
                return Ok(sum.ToString());
            }


            return BadRequest("deu merda na soma");
           
        }

        private decimal ConvertToNumber(string Numero)
        {

            decimal decimalValue;
            if(decimal.TryParse(Numero, out decimalValue))
            {
                return decimalValue;
            }

            return 0;
        }

        private bool IsNumeric(string numero)
        {
            double number;
            bool isNamber = double.TryParse(numero, System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo, out number);
            return isNamber;
        }
      
    }
}
