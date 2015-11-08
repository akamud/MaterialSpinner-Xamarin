# MaterialSpinner-Xamarin
![](https://raw.githubusercontent.com/akamud/MaterialSpinner-Xamarin/master/art/Icon.png)  
Xamarin bindings for [MaterialSpinner](https://github.com/ganfra/MaterialSpinner) by [@ganfra](https://github.com/ganfra)

Spinner with Material Design - Down to API 9

This library provides you a Spinner with the Material style. You can use it like any regular Spinner. Add floating label text, hint and error messages.

## Installing
![](https://img.shields.io/nuget/v/MaterialSpinner-Xamarin.svg?style=flat)  
[NuGet package](https://www.nuget.org/packages/MaterialSpinner-Xamarin/) available:
```
PM> Install-Package MaterialSpinner-Xamarin
```

## Usage

There is a sample project available [here](https://github.com/akamud/MaterialSpinner-Xamarin/tree/master/sample)

Using in a XML:

```XML
<fr.ganfra.materialspinner.MaterialSpinner
  android:id="@+id/spinner1"
  android:layout_width="fill_parent"
  android:layout_height="wrap_content"
  app:ms_arrowColor="#0000FF"
  app:ms_floatingLabelColor="#00FF00"
  app:ms_floatingLabelText="floating label"
  app:ms_hint="hint"
  app:ms_arrowSize="16dp"
  app:ms_multiline="true" />
```

You can set a hint and a floating label text. If no floating label text is provided, the hint will be set instead.

You use it like a regular spinner, setting an adapter to it:

```C#
string[] ITEMS = {"Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6"};
var adapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleSpinnerItem, ITEMS);
adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
var spinner = FindViewById<MaterialSpinner>(Resource.Id.spinner1);
spinner.Adapter = adapter;
```

If you need to set an error message, you can do it the same way as an EditText:

```C#
// Activate
spinner.Error = "Error";
// Deactivate
spinner.Error = null;
```

You can choose to have a scrolling animation or to set the error message on multiple lines with the `ms_multiline` attribute in XML (default is true).

## Gif example

![](https://github.com/akamud/MaterialSpinner-Xamarin/blob/master/screenshot.gif)

## License
[MIT License](https://github.com/akamud/MaterialSpinner-Xamarin/blob/master/LICENSE.md)
