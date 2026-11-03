using System;

class Program
{
    static void Main(string[] args)
    {
        Emprego emprego1 = new Emprego();
        emprego1._empresa = "Antunes Jardinagem";
        emprego1._cargo = "Jardineiro";
        emprego1._anoInicio = 2013;
        emprego1._anoFim = 2018;

        Emprego emprego2 = new Emprego();
        emprego2._empresa = "Pizzaria Papaléguas";
        emprego2._cargo = "Gerente";
        emprego2._anoInicio = 2023;
        emprego2._anoFim = 2026;

        Curriculo curriculo1 = new Curriculo();
        curriculo1._nome = "Júlio César Moreira Antunes";
        curriculo1._empregos.Add(emprego1);
        curriculo1._empregos.Add(emprego2);

        curriculo1.Exibir();
    }
}