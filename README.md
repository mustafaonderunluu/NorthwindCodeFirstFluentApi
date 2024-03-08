# EntityFrameworkFluentApi
 Entity Framework Code First yaklaşımını kullanarak Northwind veritabanı şemasını oluşturur. Fluent API kullanılarak Customer ve Order sınıfları arasındaki ilişkiler belirlenmiştir.

Proje Yapısı

- **NorthwindEfCodeFirstFluentApi.Context:** Veritabanı bağlantısı ve DbSet tanımlamalarının bulunduğu kısım.
  - `NortwindContext`: DbContext sınıfı, DbSet tanımlamaları ve Fluent API konfigürasyonları burada bulunmaktadır.
  - `Customer` ve `Order` sınıfları: Veritabanı tablolarını temsil eden sınıflar.

- **NorthwindEfCodeFirstFluentApi.Entities.EfCodeFirstMappings:** Fluent API konfigürasyon sınıfları.
  - `CustomerMap`: Customer sınıfı için Fluent API konfigürasyonları.
  - `OrderMap`: Order sınıfı için Fluent API konfigürasyonları.
