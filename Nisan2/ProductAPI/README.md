# Product API

Bu proje, ürün yönetimi için geliştirilmiş bir RESTful API'dir. ASP.NET Core Web API kullanılarak geliştirilmiştir.

## Özellikler

- Ürün ekleme, listeleme, güncelleme ve silme işlemleri
- SQL Server veritabanı entegrasyonu
- Swagger UI ile API dokümantasyonu
- ADO.NET ile veritabanı işlemleri

## Gereksinimler

- .NET 8.0 SDK
- SQL Server
- Visual Studio 2022 veya VS Code (isteğe bağlı)

## Kurulum

1. Projeyi klonlayın:
```bash
git clone [repo-url]
cd ProductAPI
```

2. Veritabanını oluşturun:
   - SQL Server Management Studio'yu açın
   - `Database/CreateDatabase.sql` scriptini çalıştırın

3. Bağlantı ayarlarını kontrol edin:
   - `appsettings.json` dosyasındaki connection string'i kendi SQL Server ayarlarınıza göre güncelleyin:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=ProductDB;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

4. Projeyi çalıştırın:
```bash
dotnet run
```

## API Endpoints

| Method | Endpoint | Açıklama |
|--------|----------|-----------|
| GET | /api/Product | Tüm ürünleri listeler |
| GET | /api/Product/{id} | Belirli bir ürünü getirir |
| POST | /api/Product | Yeni ürün ekler |
| PUT | /api/Product/{id} | Var olan ürünü günceller |
| DELETE | /api/Product/{id} | Ürünü siler |

## Örnek İstekler

### Yeni Ürün Ekleme (POST /api/Product)
```json
{
  "name": "Test Ürün",
  "price": 99.99,
  "stock": 100
}
```

## Swagger UI

API'yi test etmek için Swagger UI'ı kullanabilirsiniz:
- http://localhost:5163/swagger (HTTP)
- https://localhost:7161/swagger (HTTPS)

## Proje Yapısı

```
ProductAPI/
├── Controllers/
│   └── ProductController.cs
├── Models/
│   └── Product.cs
├── Data/
│   └── DbHelper.cs
├── Database/
│   └── CreateDatabase.sql
├── Properties/
│   └── launchSettings.json
├── appsettings.json
└── Program.cs
```

## Hata Yönetimi

- API, tüm CRUD operasyonları için uygun HTTP durum kodları döndürür
- Hata durumlarında anlamlı mesajlar ile birlikte 400 veya 500 serisi durum kodları döndürülür
- Veritabanı işlemleri try-catch blokları ile korunmuştur

## Güvenlik

- HTTPS desteği
- SQL injection koruması (parametreli sorgular)
- Temel hata yönetimi ve loglama

## Lisans

Bu proje MIT lisansı altında lisanslanmıştır. 