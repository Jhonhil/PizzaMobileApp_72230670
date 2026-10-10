# 🍕 Blazing Pizza Mobile App

Aplikasi pemesanan pizza interaktif berbasis .NET MAUI Blazor Hybrid dengan backend ASP.NET Core Web API. Proyek ini dirancang dengan tata letak UI yang responsif, pengelolaan status pesanan yang dinamis, serta pengalaman pengguna yang lebih modern untuk kebutuhan pemesanan makanan.

## ✨ Fitur Utama

- **Katalog Pizza Interaktif**: Menampilkan daftar menu pizza spesial dengan harga dan deskripsi yang dapat diperbarui secara dinamis.
- **Kustomisasi & Pemesanan**: Memungkinkan pengguna untuk memilih ukuran pizza dan topping secara interaktif.
- **Manajemen Pesanan & Pelacakan**: Fitur checkout, riwayat pesanan (My Orders), serta pelacakan status pesanan secara real-time.
- **Layout Global & Navigasi**: Menggunakan komponen `MainLayout.razor` yang terpusat untuk navigasi, footer, dan tata letak aplikasi yang konsisten.
- **Integrasi CI/CD & SonarCloud**: Menjaga kualitas kode agar lebih bersih, minim duplikasi, dan aman dari potensi celah keamanan.

## 🛠️ Teknologi yang Digunakan

### Frontend
- .NET MAUI Blazor Hybrid (.NET 8/9)
- C#
- Razor Components
- CSS / Bootstrap Custom Styling

### Backend API
- ASP.NET Core Web API
- Entity Framework Core
- SQLite Database (`pizza.db`)

### CI/CD & Quality Control
- GitHub Actions
- SonarCloud / SonarQube Code Analysis

## 📁 Struktur Proyek

```text
PizzaMobileApp_72230670/
├── BlazingPizzaApp/               # Frontend Application (.NET MAUI Blazor)
│   ├── Components/
│   │   ├── Layout/                # MainLayout & NavMenu
│   │   ├── Pages/                 # Home, Checkout, MyOrders, OrderDetail, NotFound
│   │   └── Shared/                # Dialogs & Shared UI Components
│   └── Data/                      # App State Management & Services
├── BlazingPizzaApp.API/           # Backend Web API (ASP.NET Core)
│   ├── Controllers/               # OrdersController, SpecialsController
│   ├── Data/                      # DbContext & Seed Data
│   └── Models/                    # Server-side Entity Models
├── pizza.db                       # SQLite Database
├── BlazingPizzaApp.slnx           # Solution File
├── README.md
└── .github/                       # GitHub Actions / Workflow CI
```

## 🚀 Cara Menjalankan Proyek

### 1. Prasyarat

Pastikan perangkat Anda sudah memiliki:

- Visual Studio 2022 / 2026
- Workload: .NET MAUI dan Web Development
- .NET 8 SDK atau versi yang lebih baru

### 2. Menjalankan Backend API

Buka terminal dan masuk ke folder API:

```bash
cd BlazingPizzaApp.API
dotnet restore
dotnet run
```

API akan berjalan di:

- `http://localhost:5000`
- `https://localhost:7219`

### 3. Menjalankan Aplikasi Client (MAUI Blazor)

Buka terminal baru lalu jalankan:

```bash
cd BlazingPizzaApp
dotnet restore
dotnet build
dotnet run
```

Atau jalankan langsung dari Visual Studio dengan menekan tombol `F5`.

## 📝 Catatan Pengembangan

- Pastikan kedua terminal (API dan Client) berjalan secara bersamaan untuk aplikasi berfungsi dengan optimal.
- Database SQLite akan dibuat otomatis saat API pertama kali dijalankan.
- Untuk development, Anda dapat menggunakan Hot Reload dengan menambahkan flag `--hot-reload` pada perintah `dotnet run`.

## 👤 Penulis / Contributor

- Yohanes Hilapok (@Jhonhil)

---

**Last Updated**: Oktober 2026
