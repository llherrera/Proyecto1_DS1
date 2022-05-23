using MongoDB.Bson;
using MongoDB.Driver;
using Proyecto1_DS1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_DS1
{
    public class Repositorio<T> where T:AireBNB
    {
        public MongoClient cli;
        public IMongoDatabase db;
        public bool res;
        public string Error { get; set; }
        public Repositorio()
        {
            cli= new MongoClient("mongodb+srv://llherrera:disenosw1@ds1.hyigj.mongodb.net/?retryWrites=true&w=majority");
            db = cli.GetDatabase("DS1");
        }
        private IMongoCollection<T> Collection() => db.GetCollection<T>(typeof(T).Name);

        public T Create(T entidad)
        {
            entidad.Id = ObjectId.GenerateNewId().ToString();
            try
            {
                Collection().InsertOne(entidad);
                Error = "";
                res = true;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                res = false;
            }
            return res ? entidad:null;
        }

        public IEnumerable<T> Read 
        { 
            get
            {
                try
                {
                    Error = "";
                    return Collection().AsQueryable();
                }
                catch (Exception ex)
                {
                    Error =ex.Message;
                    return null;
                }
                
            } 
        }

        public T Update(T entidad)
        {
            //entidad.jefe = ;
            try
            {
                int r = (int)Collection().ReplaceOne(e => e.Id == entidad.Id, entidad).ModifiedCount;
                Error = r == 1 ? "Elemento modificado" : "Error de modificado";
                res = r==1;
            }catch(Exception ex)
            {
                Error = ex.Message;
                res= false;
            }
            return res ? entidad : null;
        }

        public bool Delete(T entidad)
        {
            try
            {
                int r = (int)Collection().DeleteOne(e => e.Id == entidad.Id).DeletedCount;
                res = r==1;
                Error = res ? "Elemento eliminado":"No se pudo eliminar el elemento";
            }catch(Exception ex)
            {
                Error = ex.Message;
            }
            return res;
        }

        public T findById(string id)
        {
            return Collection().Find(e => e.Id==id).SingleOrDefault();
        }

        public IEnumerable<T> Query(Expression<Func<T,bool>> predicado)
        {
            //return Collection().Find(predicado.Compile());
            return Read.Where(predicado.Compile());
        }

        public async Task<List<T>> GetAllItems()
        {
            var allItems = await Collection()
                .Find(new BsonDocument())
                .ToListAsync();

            return allItems;
        }

        public List<T> listCol()
        {
            var list = new List<T>();
            list.Add(Collection().Find(e=>e.Id==null).SingleOrDefault());
            return list;
        }
    }
}
