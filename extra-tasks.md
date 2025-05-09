# ✅ Дополнительные Задания для проекта с Dapper и .NET Core

## 🎯 Цель

После завершения основного задания, выполните дополнительные задания ниже, чтобы углубить знания по Dapper, .NET Core, архитектуре и работе с БД.

---

### 1. 🔍 Поиск по имени и/ или email

Реализуйте метод поиска по имени или email с использованием LIKE.

---

### 2. 🧼 Количество товаров по категориям

Сделайте агрегатный запрос, который возвращает название категории и количество товаров в ней.

---

### 3. 📜 Список товаров с категориями и рынками

Сделайте JOIN-запрос, чтобы получить товар, его категорию и рынок в одном объекте.

---

### 4. 📆 Поле DateCreated во всех таблицах

Автоматически сохранять дату создания записи.

---

### 5. 🔄 Обновление цены по CategoryId

Реализовать метод массового обновления цен по CategoryId (например, +10%).

---

### 6. 🧑‍💼 Связь User и Markets

Один юзер может владеть несколькими рынками. Добавь UserId в Market и отрази связь.

---

### 7. 🕵️‍♂️ Список юзеров и количество рынков

JOIN + GROUP BY — показать список юзеров и сколько рынков у каждого.

---

### 8. 💰 Суммарная стоимость товаров по рынкам

Вычислите сумму (цена \* кол-во) всех товаров по рынкам.

---

### 9. 🛆 Товары сниже минимума

Список товаров, где `Quantity < MinQuantity`.

---

### 10. 📉 Найти рынок с минимальной суммой товаров

GROUP BY + MIN(сумма). Вывести один рынок.

---

### 11. 🏆 TOP-3 категории по товарам

TOP 3/Ограничение + сортировка по COUNT(\*) в каждой категории.

---

### 12. 🗓️ Новые юзеры за 7 дней

Фильтр DateCreated > GETDATE() - 7.

---

### 13. 📊 Средняя цена товаров по категориям

AVG(Цена) + GROUP BY CategoryId.

---

### 14. 📈 Сравнение кол-ва товаров по рынкам

Вывести MarketName + COUNT(\*) товаров.

---

### 15. 📃 Статистика: кто добавил сколько товаров

UserId + COUNT(\*) по товарам.

---