using CoreAndFood.Data.Models; // Context ve modelleri içeren namespace'i ekleyin
using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace CoreAndFood.Controllers
{
    public class CartController : Controller
    {
        private readonly CoreAndFood.Data.Models.Context _context;

        public CartController(CoreAndFood.Data.Models.Context context)
        {
            _context = context;
        }

        // Sepeti Görüntüleme
        public async Task<IActionResult> Index()
        {
            var userId = GetCurrentUserId(); // Kullanıcı ID'sini alacak bir metod
            var cart = await _context.Carts
                                     .Include(c => c.CartItems)
                                     .ThenInclude(ci => ci.Food)
                                     .FirstOrDefaultAsync(c => c.UserId == userId);

            if (cart == null)
            {
                cart = new Cart { UserId = userId, CreatedDate = DateTime.Now, CartItems = new List<CartItem>() };
                _context.Carts.Add(cart);
                await _context.SaveChangesAsync();
            }

            ViewBag.Foods = await _context.Foods.ToListAsync();
            return View(cart);
        }

        // Sepete Ürün Ekleme
        [HttpPost]
        public async Task<IActionResult> AddToCart(int foodId, int quantity)
        {
            var userId = GetCurrentUserId();
            var cart = await _context.Carts
                                     .Include(c => c.CartItems)
                                     .FirstOrDefaultAsync(c => c.UserId == userId);

            if (cart == null)
            {
                cart = new Cart { UserId = userId, CreatedDate = DateTime.Now, CartItems = new List<CartItem>() };
                _context.Carts.Add(cart);
                await _context.SaveChangesAsync();
            }

            var cartItem = cart.CartItems.FirstOrDefault(ci => ci.FoodID == foodId);

            if (cartItem == null)
            {
                cartItem = new CartItem { FoodID = foodId, Quantity = quantity };
                cart.CartItems.Add(cartItem);
            }
            else
            {
                cartItem.Quantity += quantity;
            }

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        // Sepetten Ürün Kaldırma
        [HttpPost]
        public async Task<IActionResult> RemoveFromCart(int cartItemId)
        {
            var cartItem = await _context.CartItems.FindAsync(cartItemId);

            if (cartItem != null)
            {
                _context.CartItems.Remove(cartItem);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }

        private int GetCurrentUserId()
        {
            // Kullanıcı ID'sini alacak metod
            return 1; // Örnek ID
        }
    }
}
