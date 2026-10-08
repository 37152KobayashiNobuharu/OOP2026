using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcBasicSample.Data;

namespace MvcBasicSample.Controllers;
public class ProductsController :Controller{
    private readonly AppDbContext _db;

    public ProductsController(AppDbContext db) {
        _db = db;
    }

    //Products/Indexで商品一覧を取得する
    public async Task<IActionResult> Index() {

        //Idの昇順で取得し結果をList<Product>にする
        var products = await _db.Products
                                .Where(product => product.Price>500)
                                .OrderBy(product => product.Price)
                                .ToListAsync();

        //商品一覧をViewへ渡す
        return View(products);
    }
}

