using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendTest.Models
{
    public class Empresa
    {

        #region Fields & Properties

        protected string _tipoDocumento;
        public string TipoDocumento
        {
            get { return _tipoDocumento; }
            set { _tipoDocumento = value; }
        }

        protected string _numeroDocumento;
        public string NumeroDocumento
        {
            get { return _numeroDocumento; }
            set { _numeroDocumento = value; }
        }

        protected string _razonSocial;
        public string RazonSocial
        {
            get { return _razonSocial; }
            set { _razonSocial = value; }
        }

        protected string _primerNombre;
        public string PrimerNombre
        {
            get { return _primerNombre; }
            set { _primerNombre = value; }
        }

        protected string _segundoNombre;
        public string SegundoNombre
        {
            get { return _segundoNombre; }
            set { _segundoNombre = value; }
        }

        protected string _primerApellido;
        public string PrimerApellido
        {
            get { return _primerApellido; }
            set { _primerApellido = value; }
        }

        protected string _segundoApellido;
        public string SegundoApellido
        {
            get { return _segundoApellido; }
            set { _segundoApellido = value; }
        }

        protected string _correo;
        public string Correo
        {
            get { return _correo; }
            set { _correo = value; }
        }

        protected int _autCelular;
        public int AutCelular
        {
            get { return _autCelular; }
            set { _autCelular = value; }
        }

        protected int _autCorreo;
        public int AutCorreo
        {
            get { return _autCorreo; }
            set { _autCorreo = value; }
        }

        #endregion

        #region Builders

        public Empresa()
        {
            this._tipoDocumento = "";
            this._numeroDocumento = "";
            this._razonSocial = "";
            this._primerNombre = "";
            this._segundoNombre = "";
            this._primerApellido = "";
            this._segundoApellido = "";
            this._correo = "";
            this._autCorreo = 0;
            this._autCelular = 0;
        }

        public Empresa(Empresa obj)
        {
            this._tipoDocumento = obj.TipoDocumento;
            this._numeroDocumento = obj.NumeroDocumento;
            this._razonSocial = obj.RazonSocial;
            this._primerNombre = obj.PrimerNombre;
            this._segundoNombre = obj.SegundoNombre;
            this._primerApellido = obj.PrimerApellido;
            this._segundoApellido = obj.SegundoApellido;
            this._correo = obj.Correo;
            this._autCelular = obj.AutCelular;
            this._autCorreo = obj.AutCorreo;            
        }

        #endregion

    }
}
