# 🚗 GalleryApp - Araba ve Fotoğraf Galerisi

Modern, siyah temalı bir araba ve fotoğraf galerisi uygulaması. Admin ve müşteri rolleri ile kapsamlı içerik yönetimi.

## ✨ Özellikler

### 🎨 **Modern UI/UX**
- Siyah tema ile glassmorphism efektleri
- Neon butonlar ve animasyonlar
- Responsive tasarım
- Bootstrap 5 + Font Awesome

### 🔐 **Kimlik Doğrulama Sistemi**
- ASP.NET Core Identity entegrasyonu
- Admin ve Customer rolleri
- Giriş/Çıkış sistemi
- Yetkilendirme kontrolü

### 🚗 **Araba Galerisi**
- BMW, Mercedes, Audi gibi markalar
- Detaylı araba bilgileri (marka, model, yıl, motor)
- Kategori sistemi
- CRUD işlemleri (Admin)

### 📸 **Fotoğraf Galerisi**
- Kategori bazlı organizasyon
- Yüksek kaliteli görüntüleme
- Açıklama ve etiketleme
- CRUD işlemleri (Admin)

### 🏷️ **Kategori Yönetimi**
- Esnek kategori sistemi
- Araba ve fotoğraf kategorileri
- Kolay erişim ve organizasyon

## 🛠️ Teknolojiler

- **Backend**: ASP.NET Core 8.0
- **Veritabanı**: SQL Server + Entity Framework Core
- **Frontend**: Bootstrap 5, HTML5, CSS3, JavaScript
- **Kimlik**: ASP.NET Core Identity
- **İkonlar**: Font Awesome 6.0

## 🚀 Kurulum

### Gereksinimler
- .NET 8.0 SDK
- SQL Server LocalDB
- Visual Studio 2022 veya VS Code

### Adımlar
1. Projeyi klonlayın:
   ```bash
   git clone https://github.com/kullaniciadi/GalleryApp.git
   cd GalleryApp
   ```

2. Paketleri yükleyin:
   ```bash
   dotnet restore
   ```

3. Veritabanını oluşturun:
   ```bash
   dotnet ef database update
   ```

4. Uygulamayı çalıştırın:
   ```bash
   dotnet run
   ```

5. Tarayıcıda açın: `https://localhost:5001`

## 👥 Kullanıcı Rolleri

### 🔑 **Admin**
- Tüm CRUD işlemlerini yapabilir
- Arabaları ekleyebilir/düzenleyebilir/silebilir
- Fotoğrafları yönetebilir
- Kategorileri oluşturabilir
- İlk kayıt olan kullanıcı otomatik admin olur

### 👤 **Customer**
- Sadece içerikleri görüntüleyebilir
- Arabaları ve fotoğrafları inceleyebilir
- Düzenleme yetkisi yoktur

## 📁 Proje Yapısı

```
GalleryApp/
├── Controllers/          # MVC Controller'lar
│   ├── AccountController.cs
│   ├── CarController.cs
│   ├── PhotoController.cs
│   └── CategoryController.cs
├── Models/              # Veri modelleri
│   ├── ApplicationUser.cs
│   ├── Car.cs
│   ├── Photo.cs
│   └── Category.cs
├── Views/               # Razor View'lar
│   ├── Account/
│   ├── Car/
│   ├── Photo/
│   └── Category/
├── Data/                # Veritabanı context
│   └── GalleryDbContext.cs
└── wwwroot/            # Statik dosyalar
```

## 🔧 Yapılandırma

### Veritabanı Bağlantısı
`appsettings.json` dosyasında connection string'i düzenleyin:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=GalleryAppDb;Trusted_Connection=true;MultipleActiveResultSets=true;TrustServerCertificate=true"
  }
}
```

### Güvenlik
- Production ortamında `appsettings.Production.json` kullanın
- Hassas bilgileri Azure Key Vault'ta saklayın
- HTTPS kullanın

## 🎯 Kullanım

1. **İlk Kurulum**: İlk kullanıcı olarak kayıt olun (otomatik admin olur)
2. **Kategoriler**: Önce kategoriler oluşturun
3. **Arabalar**: BMW, Mercedes gibi arabaları ekleyin
4. **Fotoğraflar**: Araba fotoğraflarını yükleyin
5. **Müşteriler**: Diğer kullanıcılar sadece görüntüleyebilir

## 🤝 Katkıda Bulunma

1. Fork yapın
2. Feature branch oluşturun (`git checkout -b feature/amazing-feature`)
3. Commit yapın (`git commit -m 'Add amazing feature'`)
4. Push yapın (`git push origin feature/amazing-feature`)
5. Pull Request oluşturun

## 📝 Lisans

Bu proje MIT lisansı altında lisanslanmıştır.

## 👨‍💻 Geliştirici

**Mustafa** - [GitHub](https://github.com/kullaniciadi)

## 🙏 Teşekkürler

- ASP.NET Core ekibine
- Bootstrap ekibine
- Font Awesome ekibine
- Tüm açık kaynak topluluğuna

---

⭐ Bu projeyi beğendiyseniz yıldız vermeyi unutmayın!
