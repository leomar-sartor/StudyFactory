using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletos
{
    public enum FormaPagamentoEnum : short
    {
        [Display(Name = "Selecionar")]
        Todas = 0,

        [Display(Name = "À Vista")]
        AVista = -1,

        [Display(Name = "1X")]
        UmaVez = 1,

        [Display(Name = "2X")]
        DuasVezes = 2,

        [Display(Name = "1+1X")]
        UmaEntradaMaisUma = -2,

        [Display(Name = "3X")]
        TresVezes = 3,

        [Display(Name = "1+2X")]
        UmaEntradaMaisDuas = -3,

        [Display(Name = "4X")]
        QuatroVezes = 4,

        [Display(Name = "1+3X")]
        UmaEntradaMaisTres = -4,

        [Display(Name = "5X")]
        CincoVezes = 5,

        [Display(Name = "1+4X")]
        UmaEntradaMaisQuatro = -5,

        [Display(Name = "6X")]
        SeisVezes = 6,

        [Display(Name = "1+5X")]
        UmaEntradaMaisCinco = -6,

        [Display(Name = "7X")]
        SeteVezes = 7,

        [Display(Name = "1+6X")]
        UmaEntradaMaisSeis = -7,

        [Display(Name = "8X")]
        OitoVezes = 8,

        [Display(Name = "1+7X")]
        UmaEntradaMaisSete = -8,

        [Display(Name = "9X")]
        NoveVezes = 9,

        [Display(Name = "1+8X")]
        UmaEntradaMaisOito = -9,

        [Display(Name = "10X")]
        dezVezes = 10,

        [Display(Name = "1+10X")]
        UmaEntradaMaisDez = -10,

        [Display(Name = "11X")]
        OnzeVezes = 11,

        [Display(Name = "1+11X")]
        UmaEntradaMaisOnze = -11,

        [Display(Name = "12X")]
        DozeVezes = 12,

        [Display(Name = "1+12X")]
        UmaEntradaMaisDoze = -12,

        [Display(Name = "Cheque")]
        Cheque = 50,

        [Display(Name = "PIX")]
        Pix = 60,

        [Display(Name = "Transf. Bancaria")]
        TransferenciaBancaria = 70,
    }
}
