using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BE;
using DAL;
//referencia a la capa de abstraacion
using Abstraccion;

namespace MPP
{
    public class MPPAlumno:IGestor<BEAlumno>
    {
        //defino el obejto datos que voy a llamar luego
        Acceso oDatos;
        //convierto a Lista lo que traigo del Dataset
        public List<BEAlumno> ListarTodo()
        {  //Declaro el objeto DataSet para guardar los datos y luego pasarlos a lista
            DataSet Ds;
            oDatos = new Acceso();
            string Consulta = "Select Alumno.Codigo,Alumno.Nombre,Apellido,DNI,FechaNac,Localidad.Codigo as CodLoc,Localidad.Nombre as Localidad from Alumno, Localidad where Alumno.CodLocalidad = Localidad.Codigo";
            Ds = oDatos.Leer2(Consulta);
            List<BEAlumno> ListaAlumnos = new List<BEAlumno>();

            //rcorro la tabla dentro del Dataset y la paso a lista
            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in Ds.Tables[0].Rows)
                {
                    BEAlumno oBEAlumno = new BEAlumno();
                    oBEAlumno.Codigo = Convert.ToInt32(fila[0]);
                    oBEAlumno.Nombre = fila[1].ToString();
                    oBEAlumno.Apellido = fila["Apellido"].ToString();
                    oBEAlumno.DNI = Convert.ToInt32(fila["DNI"]);
                    oBEAlumno.FechaNac = Convert.ToDateTime(fila["FechaNac"]);
                    oBEAlumno.Edad = oBEAlumno.Calcular_Edad();
                    BELocalidad oBELoc = new BELocalidad();
                    oBELoc.Codigo = Convert.ToInt32(fila["CodLoc"]);
                    oBELoc.Localidad = fila["Localidad"].ToString();
                    oBEAlumno.oBELocalidad = oBELoc;
                    string Consulta2 = @"Select Materia.Codigo, Materia.Nombre from Materia,Alumno_Materia
                      where Materia.Codigo = Alumno_Materia.CodMat and
                      Alumno_Materia.codAlu = " + oBEAlumno.Codigo + "";
                    //paso la 2da consulta y me traigo los datos de las materias del alumno
                    Acceso oDatos2 = new Acceso();
                    DataSet Ds2 = new DataSet();
                    Ds2 = oDatos.Leer2(Consulta2);
                    List<BEMateria> ListaMateria = new List<BEMateria>();
                    if (Ds2.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow fila2 in Ds2.Tables[0].Rows)
                        {
                            BEMateria oBEMat = new BEMateria();
                            oBEMat.Codigo = Convert.ToInt32(fila2[0]);
                            oBEMat.Materia = fila2["Nombre"].ToString();
                            ListaMateria.Add(oBEMat);
                        }
                        //lleno la lista de materias del alumno
                        oBEAlumno.ListaMaterias = ListaMateria;

                    }

                    ListaAlumnos.Add(oBEAlumno);

                }
            }
            else
            { ListaAlumnos = null; }
            return ListaAlumnos;
        }

        public bool Guardar(BEAlumno oBEAlu)
        {//instancio un objeto de la clase datos para operar con la BD
            string Consulta_SQL = string.Empty;
            if (oBEAlu.Codigo != 0)
            {
                Consulta_SQL = "Update Alumno SET Nombre = '" + oBEAlu.Nombre + "', Apellido = '" + oBEAlu.Apellido + "', DNI = " + oBEAlu.DNI + ", FechaNac ='" + (oBEAlu.FechaNac).ToString("MM/dd/yyyy") + "', CodLocalidad = " + oBEAlu.oBELocalidad.Codigo + " where codigo = " + oBEAlu.Codigo + "";
                // string COnsulta_SQL2= string.Format("update Alumno set Nombre = '{0}', Apellido = '{1}', DNI = {2} , FechaNac = '{3}', CodLocalidad = {4} where Codigo = {5}", oBLLAlu.Nombre, oBLLAlu.Apellido,oBLLAlu.DNI,(oBLLAlu.FechaNac).ToString("MM/dd/yyyy"),oBLLAlu.oLocalidad.Codigo, oBLLAlu.Codigo);
            }

            else
            {
                Consulta_SQL = "Insert into Alumno (Nombre, Apellido,DNI, FechaNac,CodLocalidad) values('" + oBEAlu.Nombre + "', '" + oBEAlu.Apellido + "', " + oBEAlu.DNI + ",'" + (oBEAlu.FechaNac).ToString("MM/dd/yyyy") + "'," + oBEAlu.oBELocalidad.Codigo + ") ";
                //opcion 2
                // Consulta_SQL = string.Format("Insert into Alumno(Nombre, Apellido,DNI, FechaNac,CodLocalidad) values ('{0}','{1}',{2},'{3}',{4})", oBLLAlu.Nombre,oBLLAlu.Apellido, oBLLAlu.DNI,(oBLLAlu.FechaNac).ToString("MM/dd/yyyy"),oBLLAlu.oLocalidad.Codigo);
            }
            oDatos = new Acceso();
            return oDatos.Escribir(Consulta_SQL);
        }


        public bool Baja(BEAlumno oBEAlu)
        {
            if (Existe_Materia_Asociada(oBEAlu) == false)
            {
                string Consulta_SQL = "DELETE FROM Alumno where Codigo = " + oBEAlu.Codigo + "";
                oDatos = new Acceso();
                return oDatos.Escribir(Consulta_SQL);
            }
            else
            { return false; }
        }

        public bool AgregarAlumno_Materia(BEAlumno oBEAlu, BEMateria oBEMat)
        {
            string Consulta = " INSERT INTO Alumno_Materia (codAlu, CodMat) values(" + oBEAlu.Codigo + "," + oBEMat.Codigo + ")";
            oDatos = new Acceso();
            return oDatos.Escribir(Consulta);

        }

        public bool QuitarAlumno_Materia(BEAlumno oBEAlu, BEMateria oBEMat)
        {
            string Consulta = " Delete from Alumno_Materia where codAlu = " + oBEAlu.Codigo + "  and CodMat =" + oBEMat.Codigo + "";
            oDatos = new Acceso();
            return oDatos.Escribir(Consulta);
        }

        //busco si existe alguna materia asociada a 1 o varios alumnos
        public bool Existe_Materia_Asociada(BEAlumno oBEAlu)
        {  //instancio un objeto de la clase datos para operar con la BD
            oDatos = new Acceso();
            return oDatos.LeerScalar("select count(codAlu) from Alumno_Materia where codAlu =" + oBEAlu.Codigo + "");

        }

        public BEAlumno ListarObjeto(BEAlumno Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
