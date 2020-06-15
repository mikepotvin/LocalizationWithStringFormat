# Adding StringFormat to TranslateExtension

If you're tasked with adding localization to your Xamarin Application you may start with the [TranslateExtension](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/localization/text) example from Xamarin. This allows you to add String Resources to your `AppResources.resx` file and consume them using XAML or C#.

This solution works well until you need to append a colon or any character to one of your String Resources. In the example below, we have Name & Special Ability on both pages. On the List Page the text is appended with a colon.

![enter image description here](https://i.imgur.com/xJD1cMn.png)

Now let's take a look at what the String Resources & XAML would look like:

### Without StringFormat

![enter image description here](https://i.imgur.com/WKFfERr.png)

    <Label Text="{local:Translate Name}" />
    <Label Text="{local:Translate NameWithColon}" />

As you can see, this is going to lead to duplicate resources which in a larger application would be a nightmare to maintain.

### With StringFormat

![enter image description here](https://i.imgur.com/kHiSQI0.png)

    <Label Text="{local:Translate Name" />
    <Label Text="{local:Translate Name, StringFormat='{0}:'}" />

Much better.

### Adding String Format Property to Translate Extension

This part is rather simple. You'll need to add a `StringFormat` property to the `TranslateExtension.cs` class and apply the format in the `ProvideValue` method.

```
[ContentProperty("Text")]
public class TranslateExtension : IMarkupExtension
{
    readonly CultureInfo ci = null;
    const string ResourceId = "LocalizationWithStringFormat.Resources.AppResources";

    static readonly Lazy<ResourceManager> ResMgr = new Lazy<ResourceManager>(() => new ResourceManager(ResourceId, IntrospectionExtensions.GetTypeInfo(typeof(TranslateExtension)).Assembly));

    public string Text { get; set; }
    public string StringFormat { get; set; }

    public TranslateExtension()
    {
        if (Device.RuntimePlatform == Device.iOS || Device.RuntimePlatform == Device.Android)
        {
            ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
        }
    }

    public object ProvideValue(IServiceProvider serviceProvider)
    {
        if (Text == null)
            return string.Empty;

        var translation = ResMgr.Value.GetString(Text, ci);
        if (translation == null)
        {
#if DEBUG
            throw new ArgumentException(
                string.Format("Key '{0}' was not found in resources '{1}' for culture '{2}'.", Text, ResourceId, ci.Name),
                "Text");
#else
            translation = Text; // HACK: returns the key, which GETS DISPLAYED TO THE USER
#endif
        }

        if (!string.IsNullOrWhiteSpace(StringFormat))
        {
            return string.Format(StringFormat, translation);
        }

        return translation;
    }
}
```

Simple.
