using Microsoft.AspNetCore.Mvc;

namespace Calculadora.Controllers; 

public class OperacaoController : Controller
{
    public IActionResult Soma() => View();

    public IActionResult ResultSoma(double n1, double n2)
    {
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;
        ViewBag.Result = n1 + n2;
        return View();
    }

    public IActionResult Subtracao() => View();

    public IActionResult ResultSubtracao(double n1, double n2)
    {
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;
        ViewBag.Result = n1 - n2;
        return View();
    }

    public IActionResult Multiplicacao() => View();

    public IActionResult ResultMultiplicacao(double n1, double n2)
    {
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;
        ViewBag.Result = n1 * n2;
        return View();
    }

    public IActionResult Divisao() => View();

    public IActionResult ResultDivisao(double n1, double n2)
    {
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;
        ViewBag.Result = n1 / n2;
        return View();
    }
}