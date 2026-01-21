
# LandSoft Backend

## Giới thiệu

**LandSoft Backend** là hệ thống backend được xây dựng bằng **ASP.NET Core (.NET 8)**, cung cấp các API phục vụ cho hệ thống LandSoft (quản lý, xử lý nghiệp vụ và tích hợp với frontend hoặc các dịch vụ khác).

Dự án được thiết kế theo hướng:

* Dễ mở rộng
* Dễ bảo trì
* Phù hợp cho môi trường phát triển và production

---

## Công nghệ sử dụng

* **.NET 8 (ASP.NET Core)**
* RESTful API
* Entity Framework Core 
* SQL Server 
* Swagger / OpenAPI

---

## Yêu cầu hệ thống

Trước khi cài đặt, đảm bảo máy bạn đã có:

* **.NET SDK 8.0+**
  👉 [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)
* Git
* IDE khuyến nghị:

  * Visual Studio 2022 (17.8+)
  * Hoặc Visual Studio Code

Kiểm tra .NET đã cài:

```bash
dotnet --version
```

---

## Cấu trúc thư mục (ví dụ)

```
LandSoft/
├── src/
│   ├── LandSoft.API/
│   ├── LandSoft.Application/
│   ├── LandSoft.Domain/
│   └── LandSoft.Infrastructure/
├── LandSoft.slnx
└── README.md
```

---

## Cài đặt dự án

### 1. Clone repository

```bash
git clone <repository-url>
cd LandSoft
```

---

### 2. Restore dependencies

```bash
dotnet restore
```

---

### 3. Cấu hình môi trường

Kiểm tra file `appsettings.json` hoặc `appsettings.Development.json` và cập nhật:

* Connection String database
* Các biến môi trường cần thiết (JWT, API Key, v.v.)

Ví dụ:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=LandSoftDb;User Id=sa;Password=your_password;"
  }
}
```

---

## Build dự án

```bash
dotnet build
```

Build thành công sẽ không có lỗi (`Build succeeded`).

---

## Chạy dự án

### Chạy ở môi trường Development

```bash
dotnet run --project src/LandSoft.API
```

Hoặc:

```bash
cd src/LandSoft.API
dotnet run
```

---

## Truy cập API

Sau khi chạy thành công:

* API:

  ```
  https://localhost:5001
  hoặc
  http://localhost:5000
  ```

* Swagger UI:

  ```
  https://localhost:5001/swagger
  ```

---

## Publish (Production)

```bash
dotnet publish -c Release -o publish
```

Thư mục `publish/` sẽ chứa file deploy.

---

## Git Ignore

Dự án **không commit** các thư mục sau:

```
.vs/
bin/
obj/
```

---

## Đóng góp

1. Fork dự án
2. Tạo branch mới
3. Commit thay đổi
4. Tạo Pull Request

---

## License

Dự án này thuộc quyền sở hữu của **LandSoft**.
Mọi quyền được bảo lưu.

---


