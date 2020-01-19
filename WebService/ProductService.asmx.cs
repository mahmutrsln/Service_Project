using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace WebService
{

    /// <summary>
    /// Summary description for ProductService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ProductService : System.Web.Services.WebService
    {

        NorthwindEntities entities = new NorthwindEntities();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        public Pasaport PasaportInformation { get; set; }

        [WebMethod]
        [SoapHeader("PasaportInformation")]
        public List<ProductDTO> ProductList()
        {

            if (PasaportInformation.UserName == "admin" && PasaportInformation.Password == "123")
            {
                return entities.Products.Select(x => new ProductDTO
                {
                    CategoryID = x.CategoryID,
                    Discontinued = x.Discontinued,
                    ProductID = x.ProductID,
                    ProductName = x.ProductName,
                    QuantityPerUnit = x.QuantityPerUnit,
                    ReorderLevel = x.ReorderLevel,
                    SupplierID = x.SupplierID,
                    UnitPrice = x.UnitPrice,
                    UnitsInStock = x.UnitsInStock,
                    UnitsOnOrder = x.UnitsOnOrder
                }).ToList();
            }
            else
            {
                return null;
            }
        }


    }
}
