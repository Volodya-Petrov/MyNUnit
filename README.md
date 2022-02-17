# MyNUnit
Command-line приложение, принимающее на вход путь и выполняющее запуск тестов, находящихся во всех сборках, расположенных по этому пути:

* тестом считается метод, помеченный атрибутом Test
* у атрибута может быть два аргумента — Expected для исключения, Ignore (со строковым параметром) — для отмены запуска и указания причины
* перед и после запуска каждого теста в классе должны запускаться методы, помеченные атрибутами Before и After
* перед и после запуска тестов в классе должны запускаться методы, помеченные атрибутами BeforeClass и AfterClass

Тесты запускаются параллельно.

Приложение выводит в стандартный поток вывода отчет:
* о результате и времени выполнения прошедших и упавших тестов
* о причине отключенных тестов
