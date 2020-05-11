﻿/**************************************************************************** 
** 	 	 	 	 	      SAKARYA ÜNİVERSİTESİ 
** 	 	 	     BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ 
** 	 	 	 	   BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ 
** 	 	 	 	      NESNEYE DAYALI PROGRAMLAMA DERSİ 
** 	 	 	 	 	     2019-2020 BAHAR DÖNEMİ 
** 	 
** 	 	 	 	PROJE NUMARASI.........: ISE102 	 	
**              ÖĞRENCİ ADI............: SANEM KOCA
** 	 	 	 	ÖĞRENCİ NUMARASI.......: B191200302
** 	 	 	 	DERSİN ALINDIĞI GRUP...: A 
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOtomasyon
{
    interface IMusteriOzellikleri
    {
        void HesapAc(int ekBakiye);
        void HesapSil(int hesapNo);
        void HesapParaYatir(Hesap h, decimal miktar);
        void HesapParaCek(Hesap h, decimal miktar);
    }
}
