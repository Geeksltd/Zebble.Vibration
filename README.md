[logo]: https://raw.githubusercontent.com/Geeksltd/Zebble.Vibration/master/icon.png "Zebble.Vibration"


## Zebble.Vibration

![logo]

A plugin for using device vibration in Zebble Apps.


[![NuGet](https://img.shields.io/nuget/v/Zebble.Vibration.svg?label=NuGet)](https://www.nuget.org/packages/Zebble.Vibration/)

> With this plugin you can check the vibration availability of the device and vibrate it on Android, iOS, and UWP.

<br>


### Setup
* Available on NuGet: [https://www.nuget.org/packages/Zebble.Vibration/](https://www.nuget.org/packages/Zebble.Vibration/)
* Install in your platform client projects.
* Available for iOS, Android and UWP.
<br>


### Api Usage

Call `Zebble.Device.Vibration` from any project to gain access to APIs.

##### Check availability:
```csharp
Zebble.Device.Vibration.IsAvailable();
```

##### Vibrate device:
```csharp
Zebble.Device.Vibration.Run(400.Milliseconds());
```
<br>

### Methods
| Method       | Return Type  | Parameters                          | Android | iOS | Windows |
| :----------- | :----------- | :-----------                        | :------ | :-- | :------ |
| Run         | Task| errorAction -> OnError| x       | x   | x       |
| IsAvailable         | bool| -| x       | x   | x       |
