# Programlama Dilleri ve Teknolojileri Yönetim Sistemi

Bu proje, programlama dilleri ve bu dillere ait teknolojilerin yönetimi için geliştirilmiş bir konsol uygulamasıdır. Katmanlı mimari (N-Tier Architecture) kullanılarak geliştirilmiştir.

## Proje Yapısı

Proje aşağıdaki katmanlardan oluşmaktadır:

1. **Core Katmanı**: Proje içinde kullanılan genel yapıları içerir.
   - IEntity
   - IRepository
   - IService

2. **Entities Katmanı**: Veritabanı tablolarına karşılık gelen entity sınıflarını içerir.
   - ProgrammingLanguage
   - Technology

3. **DataAccess Katmanı**: Veritabanı işlemlerini gerçekleştiren repository sınıflarını içerir.
   - ProgrammingLanguageRepository
   - TechnologyRepository

4. **Business Katmanı**: İş mantığı işlemlerini gerçekleştiren service sınıflarını içerir.
   - ProgrammingLanguageService
   - TechnologyService

5. **Presentation Katmanı**: Kullanıcı arayüzünü içeren konsol uygulaması.

## Özellikler

- Programlama dili ekleme, güncelleme, silme ve listeleme
- Teknoloji ekleme, güncelleme, silme ve listeleme
- Programlama dillerine göre teknolojileri görüntüleme
- Veri doğrulama ve hata yönetimi

## Kullanım

1. Projeyi klonlayın
2. Visual Studio veya başka bir IDE ile açın
3. Presentation projesini başlangıç projesi olarak ayarlayın
4. Uygulamayı çalıştırın

## Gereksinimler

- .NET Core 6.0 veya üzeri
- Visual Studio 2022 veya üzeri (önerilen) 