using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockModel
{
    public static class NeracaAktiva
    {
        public static neraca_aktiva insertAktiva(DateTime timeEnd, string Product, string Kas,string Piutang,string invent)
        {
            neraca_aktiva newAktiva = new neraca_aktiva();
            newAktiva.tahun_aktiva = timeEnd;
            newAktiva.all_produk = Product;
            newAktiva.all_kas = Kas;
            newAktiva.all_piutang = Piutang;
            newAktiva.all_inventaris = invent;
            StockEntity.Entity.AddToneraca_aktiva(newAktiva);
            StockEntity.Entity.SaveChanges();
            return newAktiva;
        }

        public static IQueryable<neraca_aktiva> getAllAktiva()
        {
            var list = from e in StockEntity.Entity.neraca_aktiva
                       select e;
            return list;
        }
        /*
        public static neraca_aktiva_allproduct insertSupplier(string supplierName)
        {
            neraca_aktiva_allproduct newAktivaProduct = new neraca_aktiva_allproduct();
            newAktivaProduct.id_allproduct = supplierName;
            StockEntity.Entity.AddTosuppliers(newSupplier);
            StockEntity.Entity.SaveChanges();
            return newSupplier;
        }*/
        public static neraca_aktiva_allproduct insertAktivaProduct(string idProduct, string namaProduct, string BgProduct, Decimal jumlahHarga, DateTime yeartime)
        {
            neraca_aktiva_allproduct newProduct = new neraca_aktiva_allproduct();
            newProduct.id_allproduct = idProduct;
            newProduct.nama = namaProduct;
            newProduct.bg = BgProduct;
            newProduct.jumlah = jumlahHarga;
            newProduct.tahun_aktiva = yeartime;
            StockEntity.Entity.AddToneraca_aktiva_allproduct(newProduct);
            StockEntity.Entity.SaveChanges();
            return newProduct;
        }

        public static IQueryable<neraca_aktiva_allproduct> getIDProduct()
        {
            var list = (from e in StockEntity.Entity.neraca_aktiva_allproduct
                        orderby e.id_allproduct
                        select e).Distinct();
            return list;
            
        }

        public static IQueryable<neraca_aktiva_allproduct> getAllProduct()
        {
            var list = from e in StockEntity.Entity.neraca_aktiva_allproduct
                       //where e.id_allproduct == "A01"
                       select e;
            return list;
        }

        public static void deleteProduct(int productID)
        {
            var productNow = (from f in StockEntity.Entity.neraca_aktiva_allproduct
                                     where f.idneraca_aktiva_allproduct == productID
                                     select f).First();
   
            StockEntity.Entity.DeleteObject(productNow);
            StockEntity.Entity.SaveChanges();
        }

        public static neraca_aktiva_allkas insertAktivaKas(string idkas, string nama, Decimal dollar, Decimal rupiah, DateTime yeartime)
        {
            neraca_aktiva_allkas newKas = new neraca_aktiva_allkas();
            newKas.id_allkas = idkas;
            newKas.nama = nama;
            newKas.dollar = dollar;
            newKas.rupiah = rupiah;
            newKas.tahun_aktiva = yeartime;
            StockEntity.Entity.AddToneraca_aktiva_allkas(newKas);
            StockEntity.Entity.SaveChanges();
            return newKas;
        }

        public static IQueryable<neraca_aktiva_allkas> getIDKas()
        {
            var list = (from e in StockEntity.Entity.neraca_aktiva_allkas
                        orderby e.id_allkas
                        select e).Distinct();
            return list;
        }
        public static IQueryable<neraca_aktiva_allkas> getAllKas()
        {
            var list = from e in StockEntity.Entity.neraca_aktiva_allkas
                       select e;
            return list;
        }

        public static void deleteKas(int kasID)
        {
            var kasNow = (from f in StockEntity.Entity.neraca_aktiva_allkas
                              where f.idneraca_aktiva_allkas == kasID
                              select f).First();

            StockEntity.Entity.DeleteObject(kasNow);
            StockEntity.Entity.SaveChanges();
        }

        public static neraca_aktiva_allpiutang insertAktivaPiutang(string idpiutang, string nama, string nonota, Decimal rupiah, DateTime yeartime)
        {
            neraca_aktiva_allpiutang newPiutang = new neraca_aktiva_allpiutang();
            newPiutang.id_allpiutang = idpiutang;
            newPiutang.nama = nama;
            newPiutang.nota = nonota;
            newPiutang.jumlah = rupiah;
            newPiutang.tahun_aktiva = yeartime;
            StockEntity.Entity.AddToneraca_aktiva_allpiutang(newPiutang);
            StockEntity.Entity.SaveChanges();
            return newPiutang;
        }

        public static IQueryable<neraca_aktiva_allpiutang> getIDPiutang()
        {
            var list = (from e in StockEntity.Entity.neraca_aktiva_allpiutang
                        orderby e.id_allpiutang
                        select e).Distinct();
            return list;
        }
        public static IQueryable<neraca_aktiva_allpiutang> getAllPiutang()
        {
            var list = from e in StockEntity.Entity.neraca_aktiva_allpiutang
                       select e;
            return list;
        }

        public static void deletePiutang(int piutangID)
        {
            var piutangNow = (from f in StockEntity.Entity.neraca_aktiva_allpiutang
                          where f.idneraca_aktiva_allpiutang == piutangID
                          select f).First();

            StockEntity.Entity.DeleteObject(piutangNow);
            StockEntity.Entity.SaveChanges();
        }

        public static neraca_aktiva_allinventaris insertAktivainventaris(string idinvent, string nama, Decimal rupiah, int stat, DateTime yeartime)
        {
            neraca_aktiva_allinventaris newInventaris = new neraca_aktiva_allinventaris();
            newInventaris.id_allinventaris = idinvent;
            newInventaris.nama = nama;
            newInventaris.jumlah = rupiah;
            newInventaris.status = stat;
            newInventaris.tahun_aktiva = yeartime;
            StockEntity.Entity.AddToneraca_aktiva_allinventaris(newInventaris);
            StockEntity.Entity.SaveChanges();
            return newInventaris;
        }

        public static IQueryable<neraca_aktiva_allinventaris> getIDInventaris()
        {
            var list = (from e in StockEntity.Entity.neraca_aktiva_allinventaris
                        orderby e.id_allinventaris
                        select e).Distinct();
            return list;
        }
        public static IQueryable<neraca_aktiva_allinventaris> getAllInvetaris()
        {
            var list = from e in StockEntity.Entity.neraca_aktiva_allinventaris
                       select e;
            return list;
        }

        public static void deleteInventaris(int inventID)
        {
            var inventNow = (from f in StockEntity.Entity.neraca_aktiva_allinventaris
                          where f.idneraca_aktiva_allinventaris == inventID
                          select f).First();

            StockEntity.Entity.DeleteObject(inventNow);
            StockEntity.Entity.SaveChanges();
        }



        public static void insertAktiva(DateTime dateTime, object p, string p_2, string p_3, string p_4)
        {
            throw new NotImplementedException();
        }

        public static void insertAktiva(DateTime dateTime, object p, object p_2, string p_3, string p_4)
        {
            throw new NotImplementedException();
        }

        public static void insertAktiva(DateTime dateTime, object p, object p_2, object p_3, object p_4)
        {
            throw new NotImplementedException();
        }
    }
}
