# Xamarin Instrumentation Test

This sample project demonstrates a possible issue (or my own misunderstanding) of performing Android instrumentation tests using Xamarin.

The contents of this project are:

* `SampleApp` - A simple, hello world application.
* `Sample` - An instrumentation test project.
* `build.sh` - Build script that builds both projects, installs them on the target device, and executes the instrumentation test.
* `logcat` - Output that happens as result of running `build.sh`.

## Commentary

When I add the `TargetPackage` property to the `Instrumentation` attribute on my `TestRunner` class, this is what causes the crash.  However, if I leave the `TargetPackage` off, the crash doesn't occur, but the `Instrumentation.TargetContext` property (at test run time) is the context of the test, and not of the target application.

I've included a logcat of the output that happens as a result of running the included build script.

The output I get on my terminal is:

    INSTRUMENTATION_RESULT: shortMsg=Process crashed.
    INSTRUMENTATION_CODE: 0
