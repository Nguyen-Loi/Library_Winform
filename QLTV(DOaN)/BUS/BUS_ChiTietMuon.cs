using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BUS
{
    public class BUS_ChiTietMuon
    {
        DAL_ChiTietMuon dalCTMuon = new DAL_ChiTietMuon();
        public DataTable getDaTaChiTietMuon()
        {
            return dalCTMuon.getDaTaFromChiTietMuon();
        }
        public DataTable getDaTaFromChiTietMuonByMaSach(string maSach)
        {
            return dalCTMuon.getDaTaFromChiTietMuonByMaSach(maSach);
        }
        public bool updateStatusFromDaTaFromSach(string maDG, string maSH, string ghiChu,string TinhTrang)
        {
            return dalCTMuon.updateDaTaStatusFromChiTietMuon(maDG, maSH, ghiChu,TinhTrang);
        }
        public bool addDataChiTietMuon(string maDG, string maSH, DateTime ngayThue, DateTime ngayTra, string ghiChu, string tinhTrang)
        {
            return dalCTMuon.addDataChiTietMuon(maDG, maSH, ngayThue, ngayTra, ghiChu, tinhTrang);
        }
        public DataTable searchAlmostRight(string bienTable, string timkiem)
        {
            return dalCTMuon.searchAlmostRight(bienTable, timkiem);
        }
        public bool payBookFromChiTietMuon(string maDG,string maSH)
        {
            return dalCTMuon.payBookFromChiTietMuon(maDG, maSH);
        }
        public bool deleteChiTietMuonByMaSach(string maSH)
        {
            return dalCTMuon.deleteChiTietMuonByMaSach(maSH);
        }
        public DataTable getDaTaChiTietMuontrehan()
        {
            return dalCTMuon.getDaTaChiTietMuontrehan();
        }
        public DataTable getDaTaChiTietMuonconhan()
        {
            return dalCTMuon.getDaTaChiTietMuonconhan();
        }      
        public DataTable getDaTaChiTietMuonFromDateStartAndEnd(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return dalCTMuon.getDaTaChiTietMuonFromDateStartAndEnd(ngayBatDau, ngayKetThuc);
        }
        public DataTable getDaTaChiTietMuonSachDaCu()
        {
            return dalCTMuon.getDATAChiTietMuonSachDaCu();
        }
    }
}
