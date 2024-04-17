# Язык C#

C# = C Sharp - Язык со статической типизацией

## Работа в терминале
`mkdir` — создание директории

## Команды

* Создание проекта на языка C# `dotnet new console`

* Отредактировать файл *Program.cs*

* Запустить программу — `dotnet run`

* Ctrl + C остановка программы


## Синтаксис

// Комментарий

/* */ Блочный комментарий

char символьный тип данных предполагает хранение одиночных символов

Console.WriteLine(Если символы, то в двойные кавычки, если один символ - в одинарные, если число - без кавычек)

Чтобы появились пробелы и текст программы выглядел читаемым нужно выделить текст программы и в контексном меню нажать Format Document (Shift + Alt + F)

= знак присваивания

== логическое сравнение

Переменные начинаются с маленькой буквы, и только с буквы, не с цифры, Camel Case, без знаков подчёркивания.

% или mod возвращет остаток от деления

if оператор условия

while оператор цикла

## Установка. Настройка для VS Code

Установить .NET (DotNet)
Установить расширение C# в Visual Code

Создание файла .gitignore, то есть шаблона исключений для этой среды разработки.
dotnet new gitignore

Включение OmniSharp
Visual Code. Menu File. Preferences > Settings (Ctrl + ,). Extensions > C# > OmniSharp > Dotnet>Server: Use Omnisharp

## Функции

Write не переводит строку
WriteLine переводит строку

count++ счетчик увеличивается на единицу (иттератор)

void - если функция ничего не возвращает

## Visual Studio Code

Shift+! запускает меню добавления сниппета 

## Ссылки

[Десятиминутная почта](https://10minutemail.net/)
Может пригодиться для перерегистрации ограниченных продуктов