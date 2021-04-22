using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyPortpolio.Data;
using MyPortpolio.Models;

namespace MyPortpolio.Controllers
{
    public class AccountsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
             var account = new Account();
             return View(account);
        }

        [HttpPost]
        public IActionResult Login([Bind("Email, Password")] Account account)
        {
            if (ModelState.IsValid)
            {
                var result = CheckAccount(account.Email, account.Password);
                if (result == null)
                {   // 계정이 없음 화면 전환 -> Home/Index
                    ViewBag.Message = "가입하지 않은 이메일이거나, 잘못된 비밀번호입니다.";
                    return View("Login");
                }
                else // 로그인
                {
                    HttpContext.Session.SetString("UserEmail", result.Email);
                }
                return RedirectToAction("Index", "Home");
            }
            return View("Login");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        private Account CheckAccount(string email, string password)
        {
            return _context.Account.SingleOrDefault(a => a.Email.Equals(email) && a.Password.Equals(password));
        }
        
    }
}
