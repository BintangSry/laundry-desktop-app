
# 🧺 Aplikasi Laundry Desktop | Laundry Desktop App

Aplikasi desktop modern dan sederhana untuk mengelola layanan laundry — dibangun menggunakan **C# Windows Forms** dan **MySQL**.  
A simple and modern desktop application for managing laundry services — built with **C# Windows Forms** and **MySQL**.

---

## ✨ Fitur | Features

- 🧾 Kelola transaksi laundry | Manage laundry transactions  
- 👤 Manajemen pelanggan | Customer management  
- 👕 Lacak status laundry | Track laundry status  
- 💰 Penanganan pembayaran | Payment handling  
- 📊 Laporan harian / mingguan / bulanan | Reports (daily / weekly / monthly)  
- 🔐 Sistem login pengguna (admin & operator) | User login system (admin/operator)

---

## 🛠️ Teknologi yang Digunakan | Tech Stack

- **Frontend:** C# (Windows Forms)  
- **Backend:** MySQL  
- **Framework UI:** Native WinForms  
- **Database Tool:** XAMPP / MySQL Workbench

---

## 🚀 Memulai Proyek | Getting Started

### 1. Clone Repositori | Clone the Repository

```bash
git clone https://github.com/BintangSry/laundry-desktop-app.git
```

### 2. Siapkan Database | Set Up the Database

- Import file `laundry.sql` ke server MySQL Anda  
- Gunakan **phpMyAdmin** atau **MySQL Workbench** jika diperlukan  
- Import the `laundry.sql` file into your MySQL server  
- You can use **phpMyAdmin** or **MySQL Workbench**

### 3. Konfigurasi Koneksi Database | Configure the Database Connection

- Buka proyek di **Visual Studio**  
- Perbarui string koneksi jika diperlukan  
- Open the project in **Visual Studio**  
- Update the connection string if needed:

```csharp
string connectionString = "server=localhost;uid=root;pwd=;database=laundry";
```

### 4. Jalankan Aplikasi | Run the Application

- Buka file `.sln` di Visual Studio  
- Tekan **F5** atau **Ctrl + F5** untuk menjalankan  
- Open the `.sln` file in Visual Studio  
- Press **F5** or **Ctrl + F5** to run the project

---

## 📸 Tangkapan Layar | Screenshots

| Dashboard | Transaksi / Transactions |
|----------|--------------------------|
| ![Dashboard](https://github.com/BintangSry/laundry-desktop-app/blob/main/Screenshots/Screenshot%202025-07-22%20122851.png) | ![Transactions](https://github.com/BintangSry/laundry-desktop-app/blob/main/Screenshots/Screenshot%202025-07-22%20122851.png) |

---

## 👤 Penulis | Author

**Bintang Sry**  
📧 Email: [bintangsry31@gmail.com](mailto:bintangsry31@gmail.com)  
🔗 GitHub: [github.com/BintangSry](https://github.com/BintangSry)

---

## 📄 Lisensi | License

Proyek ini dilisensikan di bawah **MIT License**.  
This project is licensed under the **MIT License**.  
Lihat file [LICENSE](./LICENSE) untuk detail lebih lanjut.  
See the [LICENSE](./LICENSE) file for more details.

---

## 🙌 Kontribusi | Contributing

Pull request sangat disambut!  
Silakan buka *issue* terlebih dahulu untuk mendiskusikan perubahan besar.  
Pull requests are welcome!  
For major changes, please open an issue first to discuss your ideas.
