using BackendTest.Models;
using BackendTest.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace BackendTest.Controllers
{
    [ApiController]
    [Route("api/empresa")]
    public class EmpresaController : Controller
    {
        [HttpGet("{numDoc}")]
        public ResponseEmpresa Get(string numDoc)
        {
            try
            {
                ResponseEmpresa result = new ResponseEmpresa("0", "Empresas consultadas exitosamente", new List<Empresa>());
                List<Empresa> empresas = EmpresaRepositorio.getEmpresas(numDoc);
                if(empresas != null && empresas.Count > 0) {
                    result.Empresas = empresas;
                } else {
                    result.Code = "1";
                    result.Message = "Se ha presentado un problema al realiza la consulta";
                }
                return result;
            } catch (Exception e) {
                Console.WriteLine(e);
                return new ResponseEmpresa();
            }
        }

        [HttpPut()]
        public ResponseEmpresa Update([FromBody] Empresa empresa)
        {
            return EmpresaRepositorio.updateCompany(empresa);               
        }
    }
}
