using System;
using DAl;
using Entidad;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class CategoryService{

        private readonly PulpFreshContext _context;
        public CategoryService(PulpFreshContext context){
            _context = context;
        }


        public Response<Category> save(Category category){

            try
            {

                _context.Categories.Add(category);
                _context.SaveChanges();
                return new Response<Category>(category);
            }
            catch (System.Exception error)
            {
                
                return new Response<Category>("Error:"+error);
            }
            
        }
        public Response<Category> Find(int categoryId){

            try
            {
                var _category = _context.Categories.Find(categoryId);
                if(_category == null)return new Response<Category>("No se encontro ninguna categoria");
                return new Response<Category>(_category);
            }
            catch (System.Exception error)
            {
                
                return new Response<Category>("Error:"+error);
            }
            
        }
    }
}