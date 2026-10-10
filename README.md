🍕 Blazing Pizza Mobile App

Aplikasi pemesanan pizza interaktif berbasis .NET MAUI Blazor Hybrid dengan backend ASP.NET Core Web API. Proyek ini dirancang dengan tata letak UI yang responsif, pengelolaan status pesanan secara real-time, serta integrasi Quality Gate CI/CD menggunakan SonarCloud.

🚀 Fitur Utama

Katalog Pizza Interaktif: Menampilkan daftar pizza special dengan harga dan deskripsi dinamis.

Kustomisasi & Pemesanan: Mengatur ukuran pizza dan pilihan topping secara interaktif.

Manajemen Pesanan & Pelacakan: Halaman Checkout, riwayat pesanan (My Orders), dan pelacakan status detail pesanan secara lansung.

Global Layout & Navigation: Penggunaan komponen MainLayout.razor terpusat untuk navigasi dan footer hak cipta yang fleksibel.

Terintegrasi CI/CD & SonarCloud: Penataan kode yang bersih, bebas dari duplikasi dan celah keamanan (Quality Gate Passed).

🛠️ Teknologi yang Digunakan

Frontend

.NET MAUI Blazor Hybrid (.NET 8/9)

C# / Razor Components

CSS / Bootstrap Custom Styling

Backend API

ASP.NET Core Web API

Entity Framework Core

SQLite Database (pizza.db)

CI/CD & Quality Control

GitHub Actions

SonarCloud / SonarQube Code Analysis

📁 Struktur Proyek

PizzaMobileApp_72230670/
├── BlazingPizzaApp/             # Frontend Application (.NET MAUI Blazor)
│   ├── Components/
│   │   ├── Layout/              # MainLayout & NavMenu
│   │   ├── Pages/               # Home, Checkout, MyOrders, OrderDetail, NotFound
│   │   └── Shared/              # Dialogs & Shared UI Components
│   ├── Data/                    # App State Management & Services
│   └── Model/                   # Client-side Data Models
│
├── BlazingPizzaApp.API/         # Backend Web API (ASP.NET Core)
│   ├── Controllers/             # OrdersController, SpecialsController
│   ├── Data/                    # DbContext & Seed Data
│   ├── Models/                  # Server-side Entity Models
│   └── pizza.db                 # SQLite Database File
│
└── BlazingPizzaApp.slnx         # Solution File


💻 Cara Jalankan Proyek

1. Prasyarat

Visual Studio 2022 / 2026 (dengan workload .NET MAUI & Web Development).

.NET 8.0 SDK atau versi yang lebih baru.

2. Jalankan Backend API

Buka terminal dan masuk ke folder API:

cd BlazingPizzaApp.API


Jalankan server API:

dotnet run


API akan berjalan di alamat http://localhost:5000 / https://localhost:7219.

3. Jalankan Aplikasi Client (MAUI Blazor)

Buka terminal baru dan masuk ke folder Frontend:

cd BlazingPizzaApp


Jalankan aplikasi MAUI:

dotnet build
dotnet run


(Atau jalankan langsung melalui Visual Studio dengan menekan tombol F5).

👤 Penulis / Contributor

Yohanes Hilapok (@Jhonhil)
