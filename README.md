# [![NBug](http://soygul.com/nbug/logo.png)](http://soygul.com/nbug/)

[![Build Status](https://travis-ci.org/soygul/NBug.svg)](https://travis-ci.org/soygul/NBug)

NBug is a .NET library created to automate the bug reporting process. It automatically creates and sends:

* Bug reports.
* Crash reports with minidump.
* Error/exception reports with stack trace + ext. info. It can also be set up as a user feedback system (i.e. feature requests).

Error reports can be sent to:

* E-mail addresses.
* HTTP(POST)/FTP servers.
* Azure Blob storage.
* Redmine/Mantis bug trackers.
* Any custom destination via implementing the [`IProtocolFactory`](NBug/Core/Submission/IProtocolFactory.cs) interface. See the source code for example implementations.

## Quickstart
Read the quickstart here: http://soygul.com/nbug/

In a typical scenario all you need is to add the NuGet package (or compile and use the `NBug.dll` directly, which is always more up-to-date) and add following to your application's `Program.cs` file (assuming it is a console app):

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

## Get it on [NuGet](https://www.nuget.org/packages/NBug/)

```powershell
Install-Package NBug
```

**Note**: NuGet versions tends to be outdated so it is better to compile the project yourself to get the latest changes.

## CodePlex Home
Old (up to v1.1.1 release) project source is hosted at CodePlex, where you can find more information about the project: http://nbug.codeplex.com/
