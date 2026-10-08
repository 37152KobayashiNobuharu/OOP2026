using System.ComponentModel.DataAnnotations;

namespace MvcBasicSample.Models {
   
    //商品１件の名前と価格をまとめる
    public class Product {
        public int Id { get; set; }//主キー

        [Required]
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; }
        public int Stock { get; set; }
    }
}
