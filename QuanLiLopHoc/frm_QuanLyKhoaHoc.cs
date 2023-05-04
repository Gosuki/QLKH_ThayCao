using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiLopHoc
{
    public partial class frm_QuanLyKhoaHoc : Form
    {
        int currentPageIndex = 1;
        int pageSize = 2;
        int pageNumber = 0;
        int rows;
        void pageTotal()
        {
            pageNumber = rows % pageSize !=0 ? rows / pageSize + 1 : rows / pageSize;
            totalPage_lbl.Text = " / " + pageNumber.ToString();
            Page_cmb.Items.Clear();
            for (int i = 1; i <= pageNumber ; i++)
            {
                Page_cmb.Items.Add(i + "");
            }
            Page_cmb.SelectedIndex = 0;
        }

        DatabaseDataContext db = new DatabaseDataContext();
        public frm_QuanLyKhoaHoc()
        {
            InitializeComponent();
        }

        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");
            return regex.IsMatch(pText);
        }
        private void frm_QuanLyKhoaHoc_Load(object sender, EventArgs e)
        {
            var dskh = db.tbl_KhoaHocs.ToList();
            DSKhoaHoc_dgv.DataSource = dskh;
            DSKhoaHoc_dgv.FirstDisplayedScrollingColumnIndex = DSKhoaHoc_dgv.ColumnCount - 1;
            SuaKhoaHoc_btn.Enabled = false;
            XoaKhoaHoc_btn.Enabled = false;
            rows = dskh.ToList().Count();
            pageSize_num.Value = pageSize;
            pageTotal();


        }
        public void ReLoad()
        {
            var dskh = db.tbl_KhoaHocs.ToList();
            DSKhoaHoc_dgv.DataSource = dskh;
        }

        private void ThemKhoaHoc_btn_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_KhoaHoc newobj = new tbl_KhoaHoc();
                if (MaKhoaHoc_txt.Text != "")
                {
                    newobj.MaKhoaHoc = MaKhoaHoc_txt.Text.ToString();
                } else
                {
                    MessageBox.Show("Mã khóa học trống");
                }
                if (!IsNumber(TenKhoaHoc_txt.Text))
                {
                    newobj.TenKhoaHoc = TenKhoaHoc_txt.Text.ToString();
                }
                else
                {
                    MessageBox.Show("Tên khóa học phải là chữ hoặc bị trống");
                }
                if (ThoiGian_txt.Text != "")
                {
                    newobj.ThoiGian = ThoiGian_txt.Text.ToString();
                }
                else
                {
                    MessageBox.Show("Mã khóa học trống");
                }
                if (GioiHanSinhVien_num.Value!=0)
                {
                    newobj.GioiHanSinhVien = Convert.ToInt32(GioiHanSinhVien_num.Value);
                }
                else
                {
                    MessageBox.Show("Giới hạn sinh viên bị trống");
                }
                newobj.GioiHanSinhVien = Convert.ToInt32(GioiHanSinhVien_num.Value);
                newobj.GioiHanGiangVien = Convert.ToInt32(GioiHanGiangVien_num.Value);
                newobj.KinhPhiDongGop = Convert.ToInt32(KinhPhiDongGop_num.Value);
                newobj.SoBuoiLyThuyet = Convert.ToInt32(SoBuoiLyThuyet_num.Value);
                newobj.SoBuoiThucHanh = Convert.ToInt32(SoBuoiThucHanh_num.Value);
                db.tbl_KhoaHocs.InsertOnSubmit(newobj);
                db.SubmitChanges();
                MessageBox.Show("Thêm khóa học thành công");
                ReLoad();
                LamMoiKhoaHoc_btn_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm khóa học không thành công");
            }
        }

        private void XoaKhoaHoc_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var mkh = MaKhoaHoc_txt.Text;
                tbl_KhoaHoc delObj = db.tbl_KhoaHocs.Where(o => o.MaKhoaHoc.Equals(mkh)).FirstOrDefault();
                db.tbl_KhoaHocs.DeleteOnSubmit(delObj);
                db.SubmitChanges();

            }
            catch (Exception)
            {

                throw;
            }
            ReLoad();
            LamMoiKhoaHoc_btn_Click(sender, e);
        }

        private void LamMoiKhoaHoc_btn_Click(object sender, EventArgs e)
        {
            MaKhoaHoc_txt.ReadOnly = false;
            MaKhoaHoc_txt.Text = "";
            TenKhoaHoc_txt.Text = "";
            ThoiGian_txt.Text = "";
            GioiHanGiangVien_num.Value = 0;
            GioiHanSinhVien_num.Value = 0;
            KinhPhiDongGop_num.Value = 0;
            SoBuoiLyThuyet_num.Value = 0;
            SoBuoiThucHanh_num.Value = 0;

            ThemKhoaHoc_btn.Enabled = true;
            SuaKhoaHoc_btn.Enabled = false;
            XoaKhoaHoc_btn.Enabled = false;
        }

        private void DSKhoaHoc_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = DSKhoaHoc_dgv.Rows[e.RowIndex];
                MaKhoaHoc_txt.ReadOnly = true;
                MaKhoaHoc_txt.Text = row.Cells["MaKhoaHoc"].Value?.ToString();
                TenKhoaHoc_txt.Text = row.Cells["TenKhoaHoc"].Value?.ToString();
                ThoiGian_txt.Text = row.Cells["ThoiGian"].Value.ToString();
                GioiHanGiangVien_num.Text = row.Cells["GioiHanGiangVien"].Value?.ToString();
                GioiHanSinhVien_num.Text = row.Cells["GioiHanSinhVien"].Value?.ToString();
                KinhPhiDongGop_num.Text = row.Cells["kinhPhiDongGop"].Value?.ToString();
                SoBuoiLyThuyet_num.Text = row.Cells["SoBuoiLyThuyet"].Value?.ToString();
                SoBuoiThucHanh_num.Text = row.Cells["SoBuoiThucHanh"].Value?.ToString();
                // KinhPhiDongGop_txt.text = convert.tostring(row.cells["kinhphidonggop"].value);
                ThemKhoaHoc_btn.Enabled = false;
                SuaKhoaHoc_btn.Enabled = true;
                XoaKhoaHoc_btn.Enabled = true;
            }
        }

        private void SuaKhoaHoc_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var mkh = MaKhoaHoc_txt.Text;
                tbl_KhoaHoc editObj = db.tbl_KhoaHocs.Where(o => o.MaKhoaHoc.Equals(mkh)).FirstOrDefault();
                if (!IsNumber(TenKhoaHoc_txt.Text))
                {
                    editObj.TenKhoaHoc = TenKhoaHoc_txt.Text.ToString();
                }
                else
                {
                    MessageBox.Show("Tên khóa học phải là chữ");
                }
                editObj.ThoiGian = ThoiGian_txt.Text.ToString();
                editObj.GioiHanSinhVien = Convert.ToInt32(GioiHanSinhVien_num.Value);
                editObj.GioiHanGiangVien = Convert.ToInt32(GioiHanGiangVien_num.Value);
                editObj.KinhPhiDongGop = Convert.ToInt32(KinhPhiDongGop_num.Value);
                editObj.SoBuoiLyThuyet = Convert.ToInt32(SoBuoiLyThuyet_num.Value);
                editObj.SoBuoiThucHanh = Convert.ToInt32(SoBuoiThucHanh_num.Value);
            }
            catch (Exception)
            {

                throw;
            }
            db.SubmitChanges();
            ReLoad();
        }

        private void pageSize_num_ValueChanged(object sender, EventArgs e)
        {
            pageSize = Convert.ToInt32(pageSize_num.Value);
            pageTotal();
        }

        private void Page_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPageIndex = Convert.ToInt32(Page_cmb.Text);
            var dskh = db.tbl_KhoaHocs.Skip((currentPageIndex - 1) * pageSize).Take(pageSize).ToList();
            DSKhoaHoc_dgv.DataSource = dskh;
        }
    }
}
