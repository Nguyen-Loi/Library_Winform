create proc SP_DoiMatKHau(@param1 nvarchar(30),@param2 nvarchar(30))
as
update TaiKhoan set matKhau=@param1 where tenDangNhap=@param2