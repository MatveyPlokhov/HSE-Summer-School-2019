# HSE Summer School 2019
**Для начала работы у вас должна быть установлена [Visual Studio](https://visualstudio.microsoft.com/ru/) и Xamarin**
---
## Оглавление:
1) [Создание проекта](#Создание-проекта)
2) [Устанавливаем дополнения](#Устанавливаем-дополнения)
3) [App Center](#App-Center)
4) [Ссылки](#Ссылки-которые-могут-пригодиться)
---
## Создание проекта
* Открываем Visual Studio

  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Visual%20Studio%20App%20Center/01.png)
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Visual%20Studio%20App%20Center/02.png)
* Создаем проект
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Visual%20Studio%20App%20Center/03.png)
* Выбираем между:
  * xamarin.forms
  * xamarin.android
  * xamarin.ios
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Visual%20Studio%20App%20Center/04.png)
    ```
    Лично я выбрал xamarin.android
    ```
* Назначаем путь и название
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Visual%20Studio%20App%20Center/05.png)
* Выбираем шаблон
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Visual%20Studio%20App%20Center/06.png)
  
[:arrow_up:Оглавление](#Оглавление)
---
## Устанавливаем дополнения
* В окне ```обозреватель решений``` нажимаем правой кнопкой мыши на проект и выбираем ```управление пакетами NuGet...```
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Visual%20Studio%20App%20Center/08.png)
* В ```обзоре``` ищем:
  * ```Microsoft.AppCenter.Crashes```
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Visual%20Studio%20App%20Center/09.png)
  * ```Microsoft.AppCenter.Analytics```
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Visual%20Studio%20App%20Center/10.png)
 * Скачиваем и устанавливаем дополнения
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Visual%20Studio%20App%20Center/11.png)
  
[:arrow_up:Оглавление](#Оглавление)
---
## App Center
* Открываем [App Center](https://appcenter.ms/)
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Visual%20Studio%20App%20Center/12.png)
* Входим/Регистрируемся
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Visual%20Studio%20App%20Center/13.png)
* Создаем новое приложение
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Visual%20Studio%20App%20Center/14.png)
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Visual%20Studio%20App%20Center/15.png)
  * Обязательно:
    * Название приложения
    * ОС
    * Платформа
  * Необязательно:
    * Иконка
    * Стадия релиза приложения
* Открываем вкладку ```overview``` 
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Visual%20Studio%20App%20Center/16.png)
* Пролистываем чуть ниже и из 2-ого пункта копируем текст:
  ```
  using Microsoft.AppCenter;
  using Microsoft.AppCenter.Analytics;
  using Microsoft.AppCenter.Crashes;
  ```
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Visual%20Studio%20App%20Center/17.png)
* Вставляем текст в начало кода 
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Visual%20Studio%20App%20Center/18.png)
* Далее копируем похожую строку кода:
  ```
  AppCenter.Start("'''PROGRAMM ID'''", typeof(Analytics), typeof(Crashes));
  ```
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Visual%20Studio%20App%20Center/19.png)
* Вставляем скопированный код в метод ```OnCreate()```
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Visual%20Studio%20App%20Center/20.png)
* Запускаем эмулятор
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Visual%20Studio%20App%20Center/21.png)
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Visual%20Studio%20App%20Center/22.png)
* После запуска эмулятора в окне ```analytics/overview``` у нас появляетя первая статистика
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Visual%20Studio%20App%20Center/23.png)
  
[:arrow_up:Оглавление](#Оглавление)
---
## Ссылки которые могут пригодиться:
* [Get Started with Xamarin](https://docs.microsoft.com/en-us/appcenter/sdk/getting-started/xamarin)
* [App Center Crashes](https://docs.microsoft.com/en-us/appcenter/sdk/crashes/xamarin)
* [Log Events and Crashes](http://patrickgoode.com/log-events-and-crashes-in-xamarin-forms-with-app-center/)

[:arrow_up:Оглавление](#Оглавление)
---

>
Привет
>
Лол
