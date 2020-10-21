﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Financial.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaPFController : ControllerBase
    {
        private static readonly string[] TipoConta = new[]
        {
            "Poupança", "Conta Corrente", "Conta Salário", "Depósito Judicial"
        };

        private static readonly string[] Nome = new[]
{
            "João", "Maria", "Creuza", "José"
        };


        private List<ContaPF> GerarLista()
        {
            var rng = new Random();
            var lista = Enumerable.Range(1, 3).Select(index => new ContaPF //Arrow Function
            {
                Agencia = rng.Next(1111, 9999),
                Conta = rng.Next(111111, 999999),
                TipoConta = TipoConta[rng.Next(TipoConta.Length)],
                NomeCompleto = Nome[rng.Next(Nome.Length)],
            })
            .ToList();

            lista.Add(new ContaPF
            {
                Agencia = 1234,
                Conta = 123456,
                TipoConta = TipoConta[rng.Next(TipoConta.Length)],
                NomeCompleto = "Maria Antonieta da Silva"
            });

            lista.Add(new ContaPF
            {
                Agencia = 1235,
                Conta = 123457,
                TipoConta = TipoConta[rng.Next(TipoConta.Length)],
                NomeCompleto = "José Maria de Souza e Albuquerque de Medeiros e Sá"
            });

            var id = 1;
            foreach (var item in lista)
            {
                item.Id = id;
                id++;
            }

            return lista;
        }


        private readonly ILogger<ContaPFController> _logger;

        public ContaPFController(ILogger<ContaPFController> logger)
        {
            _logger = logger;
        }


        /// <summary>
        /// Lista de contas pessoa física
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<ContaPF> GetAll()
        {
            //var rng = new Random();
            //return Enumerable.Range(1, 1).Select(index => new ContaPF //Arrow Function
            //{
            //    Agencia = rng.Next(1111, 9999),
            //    Conta = rng.Next(111111, 999999),
            //    TipoConta = TipoConta[rng.Next(TipoConta.Length)],
            //    NomeCompleto = Nome[rng.Next(Nome.Length)],
            //})
            //.ToList();

            return GerarLista();
        }


        // GET api/<ContaPFController>/5
        [HttpGet("{id}")]
        public ContaPF GetById(int id)
        {
            return GerarLista()
                .FirstOrDefault(conta => conta.Id == id);
        }

        // POST api/<ContaPFController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ContaPFController>/5
        [HttpPut("{id}")]
        public ContaPF Put(int id, [FromBody] ContaPF contaPF)
        {
            var conta = GetById(id);

            conta.Agencia = contaPF.Agencia;
            conta.Conta = contaPF.Conta;
            conta.TipoConta = contaPF.TipoConta;
            conta.NomeCompleto = contaPF.NomeCompleto;

            return conta;
        }

        // DELETE api/<ContaPFController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}