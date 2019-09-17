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

  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Files/01.png)
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Files/02.png)
* Создаем проект
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Files/03.png)
* Выбираем между:
  * xamarin.forms
  * xamarin.android
  * xamarin.ios
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Files/04.png)
    ```
    Лично я выбрал xamarin.forms
    ```
* Назначаем путь и название
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Files/05.png)
* Выбираем шаблон
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Files/06.png)
  
[:arrow_up:Оглавление](#Оглавление)
---
## Устанавливаем дополнения
* В окне ```обозреватель решений``` нажимаем правой кнопкой мыши и выбираем ```управление пакетами NuGet...```

  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Files/07.png)
* В ```обзоре``` ищем:
  * ```Microsoft.AppCenter.Crashes```
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Files/08.png)
  * ```Microsoft.AppCenter.Analytics```
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Files/09.png)
 * Скачиваем и устанавливаем дополнения
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Files/10.png)
  
[:arrow_up:Оглавление](#Оглавление)
---
## App Center
* Открываем [App Center](https://appcenter.ms/)
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Files/11.png)
* Входим/Регистрируемся
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Files/12.png)
* Создаем новое приложение на Android и IOS. ```Если же вы создавали проект для определенной ОС то выбираем только её.```

  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Files/14.png)
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Files/15.png)
  * Обязательно:
    * Название приложения
    * ОС
    * Платформа
  * Необязательно:
    * Иконка
    * Стадия релиза приложения
* Открываем файл ```App.xaml.cs``` и копируем в самое начало эти строки:
  ```
  using Microsoft.AppCenter;
  using Microsoft.AppCenter.Analytics;
  using Microsoft.AppCenter.Crashes;
  ```
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Files/16.png)
* Далее, копируем код ниже в метод ```OnStart()```:
  ```
  AppCenter.Start("ios={Your App Secret};android={Your App Secret}", typeof(Analytics), typeof(Crashes));
  ```  
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Files/18.png)
* Заменяем **{Your App Secret}** на код соответствующий в App Center Overview
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Files/17.png)
* Запускаем эмулятор

  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Files/19.png)

  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Files/20.png)
* После запуска эмулятора в окне ```analytics``` у нас появляетя первая статистика
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Files/21.png)
* Теперь давайте сделаем тестовую ошибку в конструкторе [try{}catch{}](https://metanit.com/sharp/tutorial/2.14.php) и отправим об этом информацию в App Center
  ```
  //тестовая ошибка
  Crashes.GenerateTestCrash();
  //отправка ошибки на сервер
  Crashes.TrackError(exception);
  ```
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Files/22.png)
* Ошибка произойдет, но мы этого не увидим в самом эмуляторе, поэтому давайте заглянем в App Center ```diagnostics```
  ![](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Files/23.png)
  
[:arrow_up:Оглавление](#Оглавление)
---
## Ссылки которые могут пригодиться:
* [Get Started with Xamarin](https://docs.microsoft.com/en-us/appcenter/sdk/getting-started/xamarin)
* [App Center Crashes](https://docs.microsoft.com/en-us/appcenter/sdk/crashes/xamarin)
* [Log Events and Crashes](http://patrickgoode.com/log-events-and-crashes-in-xamarin-forms-with-app-center/)
* [Презентация](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Files/DevOps.pptx)
* [Текст к презентации](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Files/DevOps_text.docx)
* [Проект](https://github.com/MatveyPlokhov/HSE-Summer-School-2019/blob/master/Files/FirstApp)

[:arrow_up:Оглавление](#Оглавление)
---
