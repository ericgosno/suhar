using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockModel
{
    public static class ControllerBiayaLain
    {
        public static kategori_biaya_lain insertBiayaLain(string NamaBiayaLain)
        {
            kategori_biaya_lain newBiayaLain = new kategori_biaya_lain();
            newBiayaLain.nama_biaya_lain = NamaBiayaLain;
            StockEntity.Entity.AddTokategori_biaya_lain(newBiayaLain);
            StockEntity.Entity.SaveChanges();
            return newBiayaLain;
        }

        public static supplier_biaya_lain insertSupBiayaLain(int kategori,string NamaBiayaLain, decimal harga)
        {
            supplier_biaya_lain newBiayaLain = new supplier_biaya_lain();
            newBiayaLain.Kategori_lain_ID = kategori;
            newBiayaLain.Supplier_Transaction_ID = NamaBiayaLain;
            newBiayaLain.Harga_Biaya = harga;
            StockEntity.Entity.AddTosupplier_biaya_lain(newBiayaLain);
            StockEntity.Entity.SaveChanges();
            return newBiayaLain;
        }

        public static IQueryable<kategori_biaya_lain> getKategori()
        {
            var list = from f in StockEntity.Entity.kategori_biaya_lain
                       select f;
            return list;
        }

        public static IQueryable<supplier_biaya_lain> getsupKategori()
        {
            var list = from f in StockEntity.Entity.supplier_biaya_lain
                       select f;
            return list;
        }

        public static IQueryable<supplier_biaya_lain> getsupKategoriSpec()
        {
            var list = from f in StockEntity.Entity.supplier_biaya_lain
                        where f.Supplier_Transaction_ID == "Null1"
                       select f;
            return list;
        }

        public static void deleteKategoriBiaya(int supplierId)
        {
            supplier_biaya_lain supplierNows = (from f in StockEntity.Entity.supplier_biaya_lain
                                                where f.supplier_biaya_laincol == supplierId
                                                select f).First();
            StockEntity.Entity.supplier_biaya_lain.DeleteObject(supplierNows);
            StockEntity.Entity.SaveChanges();
        }


        public static void deleteKategori(int supplierId)
        {
            kategori_biaya_lain  supplierNows = (from f in StockEntity.Entity.kategori_biaya_lain
                                     where f.Kategori_lain_ID == supplierId
                                     select f).First();
            StockEntity.Entity.kategori_biaya_lain.DeleteObject(supplierNows);
            StockEntity.Entity.SaveChanges();
        }

        public static void UpdateIdBiaya(String suppliertransId)
        {
            var supplierNows = (from f in StockEntity.Entity.supplier_biaya_lain
                                     where f.Supplier_Transaction_ID == "Null1" 
                                    select f).ToList();

            foreach (var kat in supplierNows)
            {
                kat.Supplier_Transaction_ID = suppliertransId;
            }
            StockEntity.Entity.SaveChanges();
        }



    }
}

