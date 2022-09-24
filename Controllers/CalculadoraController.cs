using Microsoft.AspNetCore.Mvc;

namespace Calculadora.Controllers;

public class CalculadoraController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Result(double num1, double num2, string operacao)
    {
        ViewBag.Num1 = num1;
        ViewBag.Num2 = num2;
        ViewBag.Operacao = operacao;

        switch (operacao)
        {
            case "Soma":
                ViewBag.Result = num1 + num2;
                ViewBag.Sinal = "+";
                break;

            case "Subtração":
                ViewBag.Result = num1 - num2;
                ViewBag.Sinal = "-";
                break;

            case "Multiplicação":
                ViewBag.Result = num1 * num2;
                ViewBag.Sinal = "*";
                break;
                
            case "Divisão":
                ViewBag.Result = num1 / num2;
                ViewBag.Sinal = "/";
                break;
             
        }
        return View();
    }
}