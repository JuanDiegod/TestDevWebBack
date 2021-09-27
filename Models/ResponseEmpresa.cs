using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendTest.Models
{
    public class ResponseEmpresa
    {

        #region Fields & Properties

        private String _code;
        public String Code
        {
            get { return _code; }
            set { _code = value; }
        }

        private String _message;
        public String Message
        {
            get { return _message; }
            set { _message = value; }
        }

        private List<Empresa> _empresas;
        public List<Empresa> Empresas
        {
            get { return _empresas; }
            set { _empresas = value; }
        }

        #endregion

        #region Builders

        public ResponseEmpresa()
        {
            this._code = "1";
            this._message = "Error al consultar empresa";
            this._empresas = new List<Empresa>();
        }

        public ResponseEmpresa(String code, String message, List<Empresa> categorias)
        {
            this._code = code;
            this._message = message;
            this._empresas = categorias;
        }

        public ResponseEmpresa(ResponseEmpresa obj)
        {
            this._code = obj.Code;
            this._message = obj.Message;
            this._empresas = obj.Empresas;
        }

        #endregion

    }
}
