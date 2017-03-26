Các bước để sử dụng chương trình có sử dụng Database.

- Mở SQL Server 2008 R2 và kết nối
- Click chuột phải vào Database -> Attach -> Add -> Chọn đường dẫn đến file QLDiem.mdf 
trong folder Release -> OK
- Vào folder Source -> N.H.T Game -> App.config -> Edit
tìm đến đoạn mã:
<connectionStrings>
    <add name="QLDiemConnectionString" connectionString="Data Source=.;Initial Catalog=QLDiem;Integrated Security=True" />
</connectionStrings>

sửa thành:
<connectionStrings>
    <add name="QLDiemConnectionString" connectionString="Data Source= (Tên serverName);Initial Catalog=QLDiem;Integrated Security=True" />
</connectionStrings>

ví dụ:
<connectionStrings>
    <add name="QLDiemConnectionString" connectionString="Data Source= ./DUCTHANG;Initial Catalog=QLDiem;Integrated Security=True" />
</connectionStrings>

- Chạy file .exe để sử dụng tại folder Release -> N.H.T Game.exe

----FIX Lỗi Attach file .mdf----
Chọn folder Release -> chuột phải chọn Properties -> chọn tab Security -> Edit 
-> tại Group or usernames chọn User -> tích chọn Full Control và Modify tại Pemission for Users -> OK