using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PI_atv5_Juliano_araujo_de_oliveira.Models;


namespace PI_atv5_Juliano_araujo_de_oliveira.Models
{
    public static class BaseDados
{
 private static List<DetalheAgenda> dados= new List<DetalheAgenda>();
 
public static void Incluir(DetalheAgenda d)
{
 dados.Add(d);

}

public static List<DetalheAgenda> Listar()
{
    return dados;
}


    }

}