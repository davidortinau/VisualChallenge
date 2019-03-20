# Visual Challenge

To take a single page design from a previous project that should look the same on iOS and Android, and attempt to recreate it using the latest Visual feature of Xamarin.Forms.

## Challenge Quick Start

This is testing **Visual**, not your prowess as a mobile developer. I want to learn how successful you are when using this new feature. Or not. 

1. Fork this repository
2. Choose a single page design from a previous or current project to recreate from scratch. The more real world the better. Plus, you can reuse assets.
3. Open `VisualChallengePage.xaml`. Take an hour (or more if you really want to) and build that screen. Making it super functional doesn't matter, just how it looks and feels.
4. Submit a pull request of your progress back to this repository. Include:
    - a screenshot of iOS and Android
    - your feedback on what went well, and what didn't
    - what you would like to see us doing differently in support of this goal: same design on iOS and Android


# What is Visual?

Visual is a new way to declare the "visual" design system you want rendering your native controls. By default, controls are renderered the way Apple and Google created them. With Visual, you can choose Material as the design system that will then render the same on iOS and Android. 

For example, this sample app sets the Visual preference on the application `Shell` and it is propogated to all controls in the application.

```
<Shell xmlns="http://xamarin.com/schemas/2014/forms" 
       xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml" 
       xmlns:local="clr-namespace:VisualChallenge"
       RouteHost="companyname.com"
       RouteScheme="app"
       Route="VisualChallenge"
       FlyoutBehavior="Disabled"
       Title="VisualChallenge"
       x:Class="VisualChallenge.AppShell"
       Visual="Material">
```

Any control may override this propogation by declaring its own Visual preference:

```
<Button Visual="Default" ... />
```

> **More than Styles:** Visual goes beyond styling the controls, to also unifying behavior and layout. This is work you may often do yourself when achieving the same look and feel between iOS and Android.


Read more about this at [https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/visual](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/visual).

## What is Material?

Material is Google's modern design system that is popular not only on Android, but has lately found its way to iOS and the Web also. Google publishes a package of Material controls for iOS, and that's the starting point for the Xamarin.Forms native control renderers when you selected `Visual="Material"`.

For more information, visit [material.io](https://material.io/).

## Instructions on Updating your own project
- Install https://www.nuget.org/packages/Xamarin.Forms.Visual.Material/4.0.0.169046-pre5  into your ios project
- Add FormsMaterial.Init() after the Forms.Init() call in your AppDelegate on ios

