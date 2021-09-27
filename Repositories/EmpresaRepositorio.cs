using BackendTest.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BackendTest.Repositories
{
    public class EmpresaRepositorio
    {

        public static List<Empresa> getEmpresas(string numDocumento = "")
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=backend;Trusted_Connection=True;");
                string where = "";
                if (numDocumento != "") where = " WHERE emp_num_doc=" + numDocumento;
                List<Empresa> result = new List<Empresa>();
                using (conexion)
                {
                    String sql = "SELECT " +
                            "emp_tipo_doc" +
                            ",emp_num_doc" +
                            ",emp_razon_soc" +
                            ",emp_pri_nombre" +
                            ",emp_seg_nombre" +
                            ",emp_pri_apellido" +
                            ",emp_seg_apellido" +
                            ",emp_correo" +
                            ",emp_aut_cel" +
                            ",emp_aut_correo " +
                        "FROM empresas " + where;
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(sql, conexion);
                    SqlDataReader registros = comando.ExecuteReader();
                    while (registros.Read())
                    {
                        Empresa emp = new Empresa();
                        emp.TipoDocumento = registros["emp_tipo_doc"].ToString();
                        emp.NumeroDocumento = registros["emp_num_doc"].ToString();
                        emp.RazonSocial = registros["emp_razon_soc"].ToString();
                        emp.PrimerNombre = registros["emp_pri_nombre"].ToString();
                        emp.SegundoNombre = registros["emp_seg_nombre"].ToString();
                        emp.PrimerApellido = registros["emp_pri_apellido"].ToString();
                        emp.SegundoApellido = registros["emp_seg_apellido"].ToString();
                        emp.Correo = registros["emp_correo"].ToString();
                        emp.AutCelular = Convert.ToInt32(registros["emp_aut_cel"]);
                        emp.AutCorreo = Convert.ToInt32(registros["emp_aut_correo"]);
                        result.Add(emp);
                    }
                    conexion.Close();
                }
                return result;
            } catch (Exception e) {
                Console.WriteLine(e);
                return null;
            }
        }

        public static ResponseEmpresa updateCompany(Empresa empresa)
        {
            try
            {
                ResponseEmpresa result = new ResponseEmpresa("0", "Se ha actualizado la empresa correctamente", new List<Empresa>());
                SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=backend;Trusted_Connection=True;");
                using (conexion)
                {
                    string update = "UPDATE empresas " +
                                      " SET emp_tipo_doc = '" + empresa.TipoDocumento + "' " +
                                          ",emp_num_doc = " + empresa.NumeroDocumento +
                                          ",emp_razon_soc = '" + empresa.RazonSocial + "' " +
                                          ",emp_pri_nombre = '" + empresa.PrimerNombre + "' " +
                                          ", emp_seg_nombre = '" + empresa.SegundoNombre + "' " +
                                          ", emp_pri_apellido = '" + empresa.PrimerApellido + "' " +
                                          ", emp_seg_apellido = '" + empresa.SegundoApellido + "' " +
                                          ", emp_correo = '" + empresa.Correo + "' " +
                                          ",emp_aut_cel = " + empresa.AutCelular +
                                          ", emp_aut_correo = " + empresa.AutCorreo +
                                      "WHERE emp_num_doc = " + empresa.NumeroDocumento;
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(update, conexion);
                    int i = comando.ExecuteNonQuery();
                    if(i <= 0)
                    {
                        result.Code = "1";
                        result.Message = "Se ha presentado un error al actualizar la informacion";
                    }
                    conexion.Close();
                }
                return result;
            } catch (Exception e)
            {
                Console.WriteLine(e);
                return new ResponseEmpresa();
            }
        }
       
    }
}
