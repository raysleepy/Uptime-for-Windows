# Uptime for Windows

# Why
If you are used to uptime on Unix/Linux, you can't help but wonder why there isn't such a thing for Windows.

Uptime on Linux tells you three things:
1. Current system time
2. How long the system has been up
3. Load average for the last 1, 5 and 15 minutes

This is a quick attempt to address the first two items. Item #3 will be left for the future.

# How
Code is very simple. Pick your .NET framework to target. Version shouldn't really matter.

Build an all-inclusive single file as follows:
```
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true -p:PublishTrimmed=True -p:TrimMode=Link
```

Copy the resulting binary from, e.g.,
bin\Release\net7.0\win-x64\publish\Uptime.exe to a directory that's in your PATH.

