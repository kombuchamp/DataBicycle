# DataBicycle


Database client application. Created on C# language using ADO.NET technology. Albeit graphical interface and comments in code are written in Russian, application structure is quite plain and self-explainatory, so anyone is free to use it. Any comments and advices are appreciated (since it is one of the first projects of mine)

============

Клиент-приложение для базы данных, написанное с целью освоения языка C# и технологии ADO.NET. Выполнено в виде информационно-поисковой системы по образцам оружия нелетального действия (МГТУ им. Н. Э. Баумана, кафедра СМ4 "Высокоточные летательные аппараты")

# Описание

Приложение написано на языке С#. Подключение к базе данных MSSQL происходит локально (файл базы данных .mdf должен находиться в рабочей директории программы). Для локального подключения к базе данных могут потреботваться некоторые компоненты SQL Server Express, без которых приложение может не запуститься (подробнее см. https://docs.microsoft.com/ru-ru/sql/database-engine/configure-windows/sql-server-016-express-localdb).

Для извлечения данных из БД используются инструменты ADO.NET. В базе данных в качестве примера созданы три таблицы, между ними реализованы связи один-ко-многим и многие-ко-многим.