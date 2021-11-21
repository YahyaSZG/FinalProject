using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        //tüm product kayıtlarını listele
        IDataResult<List<Product>> GetAll();
        //CategoryID değerine göre tüm Product kayıtlarını listele
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        //UnitPrice değerine göre tüm Product kayıtlarını listele
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        //bu kompleks bir tiptir. Product tablosundaki foreing key alanlarının karşılıklarını getir
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        //Id değerine göre tek bir Product kaydı getir
        IDataResult<Product> GetById(int productId);
        //Product kaydı ekle
        IResult Add(Product product);
        IResult AddTransactionalTest(Product product);
    }
}