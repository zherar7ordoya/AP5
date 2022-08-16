﻿using CosmosDbPeliculas.Models;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CosmosDbPeliculas.Services
{
    public class ServiceCosmosDb
    {
        //todo funciona con un client de cosmos
        //hemos creado una cuenta en un endpoint llamada cochescls
        readonly DocumentClient client;
        readonly String bbdd;
        readonly String collection;
        public ServiceCosmosDb(IConfiguration configuration)
        {
            String endpoint = configuration["CosmosDb:endPoint"];
            String primarykey = configuration["CosmosDb:primaryKey"];
            this.bbdd = "Peliculas BBDD";
            this.collection = "PeliculasCollection";
            this.client = new DocumentClient(new Uri(endpoint), primarykey);
        }
        public async Task CrearBbddPeliculaAsync()
        {
            Database bbdd = new Database() { Id = this.bbdd };
            await this.client.CreateDatabaseAsync(bbdd);
        }
        public async Task CrearColeccionPeliculasAsync()
        {
            DocumentCollection coleccion = new DocumentCollection() { Id = this.collection };
            //Factory es para recuperar de cosmos la base de datos
            await this.client.CreateDocumentCollectionAsync(UriFactory.CreateDatabaseUri(this.bbdd), coleccion);
        }
        public async Task InsertarPelicula(Pelicula pelicula)
        {
            //recuperamos la URI para la coleccion donde ira el vehiculo
            Uri uri = UriFactory.CreateDocumentCollectionUri(this.bbdd, this.collection);
            await this.client.CreateDocumentAsync(uri, pelicula);
        }
        public List<Pelicula> GetPeliculas()
        {
            // debemos indicar el numero de peliculas a recuperar
            FeedOptions options = new FeedOptions() { MaxItemCount = -1 };
            String sql = "SELECT * FROM C"; // a todo lo llama 'c'
            Uri uri = UriFactory.CreateDocumentCollectionUri(this.bbdd, this.collection);
            IQueryable<Pelicula> consulta = this.client.CreateDocumentQuery<Pelicula>(uri, sql, options);
            return consulta.ToList();
        }

        public async Task<Pelicula> FindPeliculaAsyn(String id)
        {
            Uri uri = UriFactory.CreateDocumentUri(this.bbdd, this.collection, id);
            //lo que recupera es de la clase document

            Document document = await this.client.ReadDocumentAsync(uri);
            //este documento es un stream
            //guardamos en el objeto stream en memoria lo que recuperamos, para luego leerlo en memoria
            MemoryStream memory = new MemoryStream();
            using var stream = new StreamReader(memory);
            document.SaveTo(memory);
            memory.Position = 0;
            //deserializamos con JsonConvert
            Pelicula pelicula = JsonConvert.DeserializeObject<Pelicula>(await stream.ReadToEndAsync());
            return pelicula;
        }
        public async Task ModificarPelicula(Pelicula pelicula)
        {
            Uri uri = UriFactory.CreateDocumentUri(this.bbdd, this.collection, pelicula.Id);
            await this.client.ReplaceDocumentAsync(uri, pelicula);
        }

        public async Task EliminarPelicula(String id)
        {
            Uri uri = UriFactory.CreateDocumentUri(this.bbdd, this.collection, id);
            await this.client.DeleteDocumentAsync(uri);
        }

        public List<Pelicula> BuscarPeliculas(String categoria)
        {
            FeedOptions options = new FeedOptions() { MaxItemCount = -1 };
            Uri uri = UriFactory.CreateDocumentCollectionUri(this.bbdd, this.collection);
            String sql = "select * from c where c.Categoria='" + categoria + "'";
            IQueryable<Pelicula> query = this.client.CreateDocumentQuery<Pelicula>(uri, sql, options);
            IQueryable<Pelicula> querylambda = this.client.CreateDocumentQuery<Pelicula>(uri, options)
                    .Where(z => z.Categoria == categoria);

            return query.ToList();
        }

        public List<Pelicula> CrearPeliculas()
        {
            List<Pelicula> peliculas = new List<Pelicula>() {
            new Pelicula
            {
                Id="1",Categoria="Romántica", Titulo="La Mujer Maravilla",
                Director= "Orsingher, Pamela", Estreno = "2019"
            },
            new Pelicula
            {
                Id="2",Categoria="Acción", Titulo="Iron Man",
                Director= "Pereiro, Rodrigo", Estreno = "2020"
            },
            new Pelicula
            {
                Id="3",Categoria="Animación", Titulo="El Increíble Hulk",
                Director= "Riviello, Eugenio", Estreno = "2021"
            },
             new Pelicula
            {
               Id="4",Categoria="Thriller", Titulo="El Caballero de la Noche",
                Director= "Tordoya, Gerardo", Estreno = "2022"
            }
            };
            return peliculas;

            //}
        }
    }
}
