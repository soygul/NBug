# [![NBug](http://soygul.com/nbug/logo.png)](http://www.soygul.com/nbug/)
NBug is a .NET library created to automate the bug reporting process. It automatically creates and sends:
* Bug reports,
* Crash reports with minidump,
* Error/exception reports with stack trace + ext. info.
It can also be set up as a user feedback system (i.e. feature requests).

## Quickstart
Read the quickstart here: http://www.soygul.com/nbug/

In a typical scenario all you need is to add the NuGet package (or compile and use the `NBug.dll` directly) and add following to your application's `Program.cs` file (assuming it is a console app):

```csharp
// Uncomment the following after testing to see that NBug is working as configured
// NBug.Settings.ReleaseMode = true;

// NBug config
NBug.Settings.Destination1 = "Type=Mail;From=me@mycompany.com;To=bugtracker@mycompany.com;SmtpServer=smtp.mycompany.com;";

// Attach exception handlers after all configuration is done
AppDomain.CurrentDomain.UnhandledException += NBug.Handler.UnhandledException;
```

After this, any unhandled exception will be formatted and sent to the configured e-mail address, after the app is restarted by the user.

## Questions
You can post your question on StackOverflow with NBug tag: http://stackoverflow.com/questions/tagged/nbug

## Get it on [NuGet] (https://www.nuget.org/packages/NBug/)

```powershell
Install-Package NBug
```

## CodePlex Home
Old (up to v1.1.1 release) project source is hosted at CodePlex, where you can find more information about the project: http://nbug.codeplex.com/
