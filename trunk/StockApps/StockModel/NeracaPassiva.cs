﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockModel
{
    public static class NeracaPassiva
    {
        public static neraca_passiva_usaha insertPassivaHU(string nurut, string nnota, string nnama, Decimal jumlahHarga, DateTime yeartime)
        {
            neraca_passiva_usaha newHU = new neraca_passiva_usaha();
            newHU.nourut_usaha = nurut;
            newHU.nota_usaha = nnota;
            newHU.nama_usaha = nnama;
            newHU.jumlah_usaha = jumlahHarga;
            newHU.tahun_passiva = yeartime;
            StockEntity.Entity.AddToneraca_passiva_usaha(newHU);
            StockEntity.Entity.SaveChanges();
            return newHU;
        }


        public static IQueryable<neraca_passiva_usaha> getIDUsaha()
        {
            var list = (from e in StockEntity.Entity.neraca_passiva_usaha
                        orderby e.nourut_usaha
                        select e).Distinct();
            return list;

        }
        public static IQueryable<neraca_passiva_usaha> getAllPassivaUsaha()
        {
            var list = from e in StockEntity.Entity.neraca_passiva_usaha
                       select e;
            return list;
        }

        public static void deleteHUsaha(int HusahaID)
        {
            var HusahaNow = (from f in StockEntity.Entity.neraca_passiva_usaha
                              where f.idneraca_passiva_usaha == HusahaID
                              select f).First();

            StockEntity.Entity.DeleteObject(HusahaNow);
            StockEntity.Entity.SaveChanges();
        }

        public static neraca_passiva_ppjk insertPassivaPPJK(string nurut, string nnota, string nnama, Decimal jumlahHarga, DateTime yeartime)
        {
            neraca_passiva_ppjk newPPJK = new neraca_passiva_ppjk();
            newPPJK.nourut_ppjk = nurut;
            newPPJK.nota_ppjk = nnota;
            newPPJK.nama_ppjk = nnama;
            newPPJK.jumlah_ppjk = jumlahHarga;
            newPPJK.tahun_passiva = yeartime;
            StockEntity.Entity.AddToneraca_passiva_ppjk(newPPJK);
            StockEntity.Entity.SaveChanges();
            return newPPJK;
        }


        public static IQueryable<neraca_passiva_ppjk> getAllPassivaPPJK()
        {
            var list = from e in StockEntity.Entity.neraca_passiva_ppjk
                       select e;
            return list;
        }

        public static void deletePPJK(int HusahaID)
        {
            var HusahaNow = (from f in StockEntity.Entity.neraca_passiva_ppjk
                             where f.idneraca_passiva_ppjk== HusahaID
                             select f).First();

            StockEntity.Entity.DeleteObject(HusahaNow);
            StockEntity.Entity.SaveChanges();
        }


        public static neraca_passiva_pajak insertPassivaHPajak(string nurut, string nket,  Decimal jumlahHarga, DateTime yeartime)
        {
            neraca_passiva_pajak newHPajak = new neraca_passiva_pajak();
            newHPajak.nourut_pajak = nurut;
            newHPajak.keterangan_pajak = nket;
            newHPajak.jumlah_pajak = jumlahHarga;
            newHPajak.tahun_passiva = yeartime;
            StockEntity.Entity.AddToneraca_passiva_pajak(newHPajak);
            StockEntity.Entity.SaveChanges();
            return newHPajak;
        }


        public static IQueryable<neraca_passiva_pajak> getAllPassivaPajak()
        {
            var list = from e in StockEntity.Entity.neraca_passiva_pajak
                       select e;
            return list;
        }

        public static void deleteHPajak(int HusahaID)
        {
            var HusahaNow = (from f in StockEntity.Entity.neraca_passiva_pajak
                             where f.idneraca_passiva_pajak == HusahaID
                             select f).First();

            StockEntity.Entity.DeleteObject(HusahaNow);
            StockEntity.Entity.SaveChanges();
        }

        public static neraca_passiva_saham insertPassivaSaham(string nurut, string nnama, Decimal jumlahHarga, DateTime yeartime)
        {
            neraca_passiva_saham newHSaham = new neraca_passiva_saham();
            newHSaham.nourut_saham = nurut;
            newHSaham.nama_saham = nnama;
            newHSaham.jumlah_saham = jumlahHarga;
            newHSaham.tahun_passiva = yeartime;
            StockEntity.Entity.AddToneraca_passiva_saham(newHSaham);
            StockEntity.Entity.SaveChanges();
            return newHSaham;
        }


        public static IQueryable<neraca_passiva_saham> getAllPassivaSaham()
        {
            var list = from e in StockEntity.Entity.neraca_passiva_saham
                       select e;
            return list;
        }

        public static void deleteSaham(int HusahaID)
        {
            var HusahaNow = (from f in StockEntity.Entity.neraca_passiva_saham
                             where f.idneraca_passiva_saham == HusahaID
                             select f).First();

            StockEntity.Entity.DeleteObject(HusahaNow);
            StockEntity.Entity.SaveChanges();
        }

    }
}
