# Інструкція зі встановлення проекту Hotel Booking

## Необхідні компоненти
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download)
- [Visual Studio 2022](https://visualstudio.microsoft.com/)
- [MongoDB Community](https://www.mongodb.com/try/download/community) (база даних)
- [MongoDB Compass](https://www.mongodb.com/products/compass) (для відображення бази даних)

  
## 1. Клонуйте репозиторій у Visual Studio:
https://github.com/ваш логін/Hotel_Booking.git

## 2. Відновіть залежності (Nu-Get пакети):
dotnet restore

## 3. Підключіть базу даних:
- Завантажте [MongoDB Community](https://www.mongodb.com/try/download/community) з налаштуваннями за замовчуванням (обов'язково поставте галочку "Install MongoDB as a Service")
- Встановіть [MongoDB Compass](https://www.mongodb.com/products/compass) та відкрийте його
- Підключіться до **mongodb://localhost:27017**
- Створіть всередині базу даних з ім'ям **HotelDB**
- Створіть колекції з іменами ідентичними як в папці **MongoDBData** з GitHub
- Імпортуйте дані:
    - Виберіть колекцію і натисніть кнопку **Add Data** у правому верхньому куті
    - Вибери **Import File**
    - **Select File**: обери відповідний JSON-файл з папки **MongoDBData**
    - **File Type** - Json
    - Натисніть **Import**

## 4. Запустіть проект


# Тестування

## 1. Зробіть все вище перераховане

## 2. Підключіть колекцію в базу даних для тестування:
- - Створіть всередині базу даних з ім'ям **HotelDB_Test**
- Створіть колекцію з іменем **Hotels**
- Імпортуйте дані:
    - Виберіть колекцію і натисніть кнопку **Add Data** у правому верхньому куті
    - Вибери **Import File**
    - **Select File**: обери відповідний JSON-файл з папки **MongoDBTestData**
    - **File Type** - Json
    - Натисніть **Import**
 
## 3. Запусти тестування:
dotnet test
