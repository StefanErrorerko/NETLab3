# NETLab3

Lab3 | Design Patterns (породжуючі) | Singleton

Музика Стефан
ІС-02
11-й варіант

Реалізувати задачу «Розпорядник гри». Гра складається з ігрового простору та списку ігрових фішок. Забезпечити можливість створення тільки одного примірника розпорядника.

ОРПЗ .NET ЛР #3

Гральна дошка описана класом Gameboard. Вона має поле Size – це кількість полів на гральній дошці.
Фішка описана абстрактним класом Chip. Кожна фішка має властивість Value що визначає її вагу у грі.
Дошка та фішки створює розпорядник гри, як її власник. Кожна гра може вирізнятись різною кількістю полів на дошці та кількістю фішок. Тому тут очевидним є зв’язок «композиція».
Користувач застосунком має можливість через консоль увести кількість полів на дошці (її розмір), кількість фішок кожного типу.

![3 (1)](https://user-images.githubusercontent.com/76735417/175928424-7fd2321d-388b-4358-a053-807bd2dd13c9.png)
