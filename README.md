Dependency Injection Example

Bu proje, Dependency Injection (DI) kullanarak, öğretmen bilgilerini bir Classroom sınıfı aracılığıyla ekrana yazdırmayı amaçlayan bir .NET Core Console uygulamasıdır.

Projede:

Teacher sınıfı, öğretmenin bilgilerini saklar ve döndürür.
Classroom sınıfı, bir Teacher nesnesini constructor aracılığıyla alır ve öğretmen bilgilerini döndüren bir metot sunar.
IOgretmen interface’i, Teacher sınıfının uyguladığı bir arayüzdür.
Bu yapı sayesinde, bağımlılıkları dışarıdan enjekte ederek sınıflar arasındaki bağımlılığı yönetir ve daha esnek bir yapı sağlar.
