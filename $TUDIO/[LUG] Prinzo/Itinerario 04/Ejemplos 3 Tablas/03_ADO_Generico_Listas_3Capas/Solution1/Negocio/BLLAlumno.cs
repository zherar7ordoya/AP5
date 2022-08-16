using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Negocio
{
    public class BLLAlumno
    {
        //propiedades de la clase Alumno
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI{ get; set; }
        public DateTime FechaNac { get; set; }
        public int Edad { get; set; }
        public BLLLocalidad oLocalidad { get; set; }
        public List<BLLMateria>ListaMaterias { get; set; }


        //Metodos de Alumno
        public int Calcular_Edad()
        {
            Edad = DateTime.Now.Year - FechaNac.Year;
            if (DateTime.Now.Month < FechaNac.Month)
                Edad -= 1;
            if (DateTime.Now.Month == FechaNac.Month && DateTime.Now.Day < FechaNac.Day)
                Edad -= 1;

            return Edad;
        }


        //defino el obejto datos que voy a llamar luego
        Acceso oDatos;
        //convierto a Lista lo que traigo del Dataset
        public List<BLLAlumno> CargarListaAlumnos()
        {  //Declaro el objeto DataSet para guardar los datos y luego pasarlos a lista
            DataSet Ds;
            oDatos = new Acceso();
            string Consulta = "Select Alumno.Codigo,Alumno.Nombre,Apellido,DNI,FechaNac,Localidad.Codigo as CodLoc,Localidad.Nombre as Localidad from Alumno, Localidad where Alumno.CodLocalidad = Localidad.Codigo";
            Ds = oDatos.Leer2(Consulta);
            List<BLLAlumno> ListaAlumnos = new List<BLLAlumno>();

            //rcorro la tabla dentro del Dataset y la paso a lista
            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in Ds.Tables[0].Rows)
                {
                    BLLAlumno oBLLAlumno = new BLLAlumno();
                    oBLLAlumno.Codigo = Convert.ToInt32(fila[0]);
                    oBLLAlumno.Nombre = fila[1].ToString();
                    oBLLAlumno.Apellido = fila["Apellido"].ToString();
                    oBLLAlumno.DNI = Convert.ToInt32(fila["DNI"]);
                    oBLLAlumno.FechaNac = Convert.ToDateTime(fila["FechaNac"]);
                    oBLLAlumno.Edad = oBLLAlumno.Calcular_Edad();
                        BLLLocalidad oBLLLoc = new BLLLocalidad();
                        oBLLLoc.Codigo = Convert.ToInt32(fila["CodLoc"]);
                        oBLLLoc.Localidad = fila["Localidad"].ToString();
                    oBLLAlumno.oLocalidad = oBLLLoc;
                    string Consulta2 = @"Select Materia.Codigo, Materia.Nombre from Materia,Alumno_Materia
                      where Materia.Codigo = Alumno_Materia.CodMat and
                      Alumno_Materia.codAlu = " + oBLLAlumno.Codigo + "";
                      //paso la 2da consulta y me traigo los datos de las materias del alumno
                      Acceso oDatos2 = new Acceso();
                      DataSet Ds2 = new DataSet();
                      Ds2 = oDatos.Leer2(Consulta2);
                       List<BLLMateria> ListaMateria = new List<BLLMateria>();
                    if (Ds2.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow fila2 in Ds2.Tables[0].Rows)
                        {
                            BLLMateria oBLLMat = new BLLMateria();
                            oBLLMat.Codigo = Convert.ToInt32(fila2[0]);
                            oBLLMat.Materia = fila2["Nombre"].ToString();
                            ListaMateria.Add(oBLLMat);
                        }
                        //lleno la lista de materias del alumno
                        oBLLAlumno.ListaMaterias = ListaMateria;

                    }

                    ListaAlumnos.Add(oBLLAlumno);

                }
            }
            else
            { ListaAlumnos = null; }
            return ListaAlumnos;
        }

        public bool AltaAlumno(BLLAlumno oBLLAlu)
        {//instancio un objeto de la clase datos para operar con la BD
            oDatos = new Acceso();
            string Consulta_SQL = "Insert into Alumno (Nombre, Apellido,DNI, FechaNac,CodLocalidad) values('" + oBLLAlu.Nombre + "', '" + oBLLAlu.Apellido + "', " + oBLLAlu.DNI + ",'"+(oBLLAlu.FechaNac).ToString("MM/dd/yyyy")+"',"+oBLLAlu.oLocalidad.Codigo+") ";
            //opcion 2
            // string Consulta_SQL = string.Format("Insert into Alumno(Nombre, Apellido,DNI, FechaNac,CodLocalidad) values ('{0}','{1}',{2},'{3}',{4})", oBLLAlu.Nombre,oBLLAlu.Apellido, oBLLAlu.DNI,(oBLLAlu.FechaNac).ToString("MM/dd/yyyy"),oBLLAlu.oLocalidad.Codigo);
            return oDatos.Escribir(Consulta_SQL);
        }

        public bool ModifAlumno(BLLAlumno oBLLAlu)
        {//instancio un objeto de la clase datos para operar con la BD
            oDatos = new Acceso();
            string Consulta_SQL = "Update Alumno SET Nombre = '" + oBLLAlu.Nombre + "', Apellido = '" + oBLLAlu.Apellido + "', DNI = " + oBLLAlu.DNI + ", FechaNac ='"+(oBLLAlu.FechaNac).ToString("MM/dd/yyyy") + "', CodLocalidad = "+oBLLAlu.oLocalidad.Codigo+" where codigo = " + oBLLAlu.Codigo + "";
            // string COnsulta_SQL2= string.Format("update Alumno set Nombre = '{0}', Apellido = '{1}', DNI = {2} , FechaNac = '{3}', CodLocalidad = {4} where Codigo = {5}", oBLLAlu.Nombre, oBLLAlu.Apellido,oBLLAlu.DNI,(oBLLAlu.FechaNac).ToString("MM/dd/yyyy"),oBLLAlu.oLocalidad.Codigo, oBLLAlu.Codigo);
            return oDatos.Escribir(Consulta_SQL);
        }

        public bool BajaAlumno(BLLAlumno oBLLAlu)
        {
              if (Existe_Materia_Asociada(oBLLAlu) == false)
                {
                    string Consulta_SQL = "DELETE FROM Alumno where Codigo = " + oBLLAlu.Codigo + "";
                    oDatos = new Acceso();
                    return oDatos.Escribir(Consulta_SQL);
                }
                else
                { return false; }
        }

        public bool AgregarAlumno_Materia(BLLAlumno oBLLAlu, BLLMateria oBLLMat)
        {
            string Consulta = " INSERT INTO Alumno_Materia (codAlu, CodMat) values(" + oBLLAlu.Codigo + "," + oBLLMat.Codigo + ")";
            oDatos = new Acceso();
            return oDatos.Escribir(Consulta);

        }

        public bool QuitarAlumno_Materia(BLLAlumno oBLLAlu, BLLMateria oBLLMat)
        {
            string Consulta = " Delete from Alumno_Materia where codAlu = " + oBLLAlu.Codigo + "  and CodMat =" + oBLLMat.Codigo + "";
            oDatos = new Acceso();
            return oDatos.Escribir(Consulta);
        }

        //busco si existe alguna materia asociada a 1 o varios alumnos
        public bool Existe_Materia_Asociada(BLLAlumno oBLLAlu)
        {  //instancio un objeto de la clase datos para operar con la BD
            oDatos = new Acceso();
            return oDatos.LeerScalar("select count(codAlu) from Alumno_Materia where codAlu =" + oBLLAlu.Codigo + "");

        }
    }
}
