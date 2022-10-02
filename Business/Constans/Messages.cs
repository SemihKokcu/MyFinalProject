using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constans
{
    //new lememek için static yaptık, sabit bir şey olduğu için
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductsListedByCategoryId = "Ürünler kategoriye göre listelendi";
        public static string ProductCountOffCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductUpdated = "Ürün Güncellendi";
        public static string ProductNameAlreadyExist = "Böyle bir ürün zaten var";
    }
}
