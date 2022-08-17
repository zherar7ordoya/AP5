using System;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Metodos
    {

        SqlDataAdapter DATA_ADAPTER;

        public DataSet ArmarDataSet()
        {
            DataSet dataset = new DataSet();

            // *--------------------------------------------------=> 1ER MÉTODO
            //EN ADO.NET SE PUEDE INSTANCIAR UN DATATABLE FUERA DE UN DATASET.
            DataTable Tabla = new DataTable("Persona");

            //LAS COLUMNAS SE PUEDEN INSTANCIAR FUERA DEL DATATABLE Y AGREGAR LUEGO
            DataColumn Clave = new DataColumn
            {
                ColumnName = "Codigo_Persona",
                DataType = typeof(Int32),
                AutoIncrement = true,
                AutoIncrementSeed = 1,
                AutoIncrementStep = 1,
                AllowDBNull = false,
                Unique = true
            };
            Tabla.Columns.Add(Clave);

            //CLAVE DE LA TABLA.
            Tabla.PrimaryKey = new DataColumn[] { Clave };

            //...O SE PUEDEN AGREGAR DIRECTAMENTE USANDO EL CONSTRUCTOR.
            Tabla.Columns.Add("Nombre", typeof(String));
            Tabla.Columns.Add("Apellido", typeof(String));
            Tabla.Columns.Add("FechaNac", typeof(DateTime));
            Tabla.Columns.Add("Persona_Pais_Id", typeof(Int32)); //Clave foránea

            //SE PODRIA TRABAJAR DIRECTAMENTE CON EL DATATABLE, PERO LO
            //AGREGAMOS AL DATASET PORQUE QUEREMOS AGREGAR OTRA TABLA
            //RELACIONADA.
            dataset.Tables.Add(Tabla);


            // *--------------------------------------------------=> 2DO MÉTODO
            //UNA TABLA SE PUEDE INSTANCIAR FUERA Y LUEGO AGREGAR
            //AGREGAMOS OTRA TABLA PARA LOS PAISES
            dataset.Tables.Add("Pais");

            //UNA TABLA TAMBIEN SE PUEDE CREAR Y AGREGAR DIRECTAMENTE EN LA
            //MISMA LINEA. 
            //AGREGAMOS LAS COLUMNAS PARA LA TABLA PAIS.
            DataColumnCollection columnas = dataset.Tables["Pais"].Columns;
            columnas.Add("Codigo_Pais", typeof(Int32));
            columnas.Add("Pais_Nombre", typeof(String));

            //GENERAMOS LA CLAVE PRIMARIA PARA LA TABLA PAIS. LA CLAVE PRIMARIA
            //ES UN ARRAY DE DATACOLUMN (PORQUE PODRIA SER UNA CLAVE COMPUESTA)
            //EN LA MISMA LINEA SE CREA EL ARRAY CON UN SOLO ELEMENTO (COLUMNA
            //PAIS_ID) Y SE AGREGA A LA TABLA EN SU ATRIBUTO PRIMARYKEY. NOTAR
            //QUE LA TABLA PUEDE ACCEDERSE TANTO CON SU NOMBRE (PAIS) COMO POR
            //SU INDICE EN LA COLECCION TABLES (1).
            dataset.Tables["Pais"].PrimaryKey = new DataColumn[] { dataset.Tables[1].Columns["Codigo_Pais"] };

            //POR ULTIMO CREAMOS LA RELACION ENTRE LA FOREIGNKEY
            //"PERSONA_PAIS_ID" DE LA TABLA PERSONA Y LA CLAVE PRIMARIA
            //"PAIS_ID" DE LA TABLA PAIS.
            dataset.Relations.Add(
                "Relacion_Persona_Pais",
                dataset.Tables[1].Columns["Codigo_Pais"],
                dataset.Tables[0].Columns["Persona_Pais_Id"]);

            return dataset;
        }


        public void CargarDataSet(DataSet dataset)
        {
            //LLENAMOS LA TABLA PAIS
            DataRowCollection filas = dataset.Tables["Pais"].Rows;
            filas.Add(1, "Argentina");
            filas.Add(2, "Chile");
            filas.Add(3, "Brasil");
            filas.Add(4, "Peru");
            filas.Add(5, "Paraguay");
            filas.Add(6, "Bolivia");
            filas.Add(7, "Venezuela");
            filas.Add(8, "Ecuador");
            filas.Add(9, "Uruguay");
            filas.Add(10, "Colombia");

            //LLENAMOS LA TABLA PERSONA
            LlenarTabla(dataset, "Persona");
        }


        public static void LlenarTabla(DataSet dataset, string tabla)
        {
            for (int i=0; i<=9; i++)
            {
                DataRow fila = dataset.Tables[tabla].NewRow();
                fila["Nombre"] = NombreAleatorio();
                fila["Apellido"] = ApellidoAleatorio();
                fila["FechaNac"] = Convert.ToDateTime(FechaAleatoria());
                fila["Persona_Pais_Id"] = PaisAleatorio();
                dataset.Tables[tabla].Rows.Add(fila);
            }
        }

        //RANDOM:
        //Do: Create a Random instance once, and use it multiple times.
        //Don't: new a Random instance and use it in place.
        static readonly Random aleatorio = new Random();

        static string NombreAleatorio()
        {
            string nombre = String.Empty;
            int caso = aleatorio.Next(1, 10);

            switch (caso)
            {
                case 1:
                    nombre = "Ángel";
                    break;
                case 2:
                    nombre = "Juan";
                    break;
                case 3:
                    nombre = "Gerardo";
                    break;
                case 4:
                    nombre = "Nicolás";
                    break;
                case 5:
                    nombre = "José";
                    break;
                case 6:
                    nombre = "María";
                    break;
                case 7:
                    nombre = "Stella";
                    break;
                case 8:
                    nombre = "Belén";
                    break;
                case 9:
                    nombre = "Micaela";
                    break;
                case 10:
                    nombre = "Mía";
                    break;
            }
            return nombre;
        }

        static string ApellidoAleatorio()
        {
            string apellido = String.Empty;
            int caso = aleatorio.Next(1, 10);

            switch (caso)
            {
                case 1:
                    apellido = "González";
                    break;
                case 2:
                    apellido = "Gómez";
                    break;
                case 3:
                    apellido = "Tordoya";
                    break;
                case 4:
                    apellido = "Martínez";
                    break;
                case 5:
                    apellido = "Romero";
                    break;
                case 6:
                    apellido = "García";
                    break;
                case 7:
                    apellido = "Sosa";
                    break;
                case 8:
                    apellido = "Benítez";
                    break;
                case 9:
                    apellido = "Ramírez";
                    break;
                case 10:
                    apellido = "Torres";
                    break;
            }
            return apellido;
        }

        static string FechaAleatoria()
        {
            return _ = aleatorio.Next(1, 31) + "/" + aleatorio.Next(1, 12) + "/" + aleatorio.Next(1960, 2020);
        }

        static int PaisAleatorio()
        {
            return aleatorio.Next(1, 10);
        }


        //*********************************************************************
        //                                                           ABM SIMPLE
        //*********************************************************************


        public void DescartarCambios(DataSet dataset)
        {
            // SE DESCARTAN TODOS LOS CAMBIOS DEL DATASET
            dataset.RejectChanges();
        }


        public void GrabarCambios(string tabla, DataSet dataset)
        {
            string conexion =
                @"Data Source=(LocalDB)\MSSQLLocalDB;
                Initial Catalog=Ejemplos_LUG;
                Integrated Security=True";

            DATA_ADAPTER = new SqlDataAdapter(("SELECT * FROM " + tabla), conexion);

            //SE DEFINEN LOS METODOS PARA GUARDAR DATOS EN BASE DE DATOS
            SqlCommandBuilder COMMAND_BUILDER = new SqlCommandBuilder(DATA_ADAPTER);

            DATA_ADAPTER.UpdateCommand = COMMAND_BUILDER.GetUpdateCommand();
            DATA_ADAPTER.DeleteCommand = COMMAND_BUILDER.GetDeleteCommand();
            DATA_ADAPTER.InsertCommand = COMMAND_BUILDER.GetInsertCommand();
            DATA_ADAPTER.ContinueUpdateOnError = true;
            DATA_ADAPTER.Fill(dataset);

            //SE INTENTAN PERSISTIR LOS CAMBIOS EN LA BASE DE DATOS
            DATA_ADAPTER.Update(dataset.Tables[0]);
        }


    }
}
