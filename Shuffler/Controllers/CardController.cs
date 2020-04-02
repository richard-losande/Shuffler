using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shuffler.Business.LogicCollection;

namespace Shuffler.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly ICardBusiness _cardBusiness;

        public CardController(ICardBusiness cardBusiness)
        {
            _cardBusiness = cardBusiness;
        }
        /// <summary>
        /// This end point returns all the card before shuffling
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var result = _cardBusiness.GetInitialCardArrangement();
            return Ok(result);
        }

        /// <summary>
        /// This end point returns all the card after shuffling
        /// </summary>
        /// <returns></returns>
        [HttpGet("shuffle")]
        public IActionResult GetShuffledCards()
        {
            var result = _cardBusiness.ShuffleCards();
            return Ok(result);
        }
    }
}