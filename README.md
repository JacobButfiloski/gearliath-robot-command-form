# gearliath-robot-command-form
Command Form to develop Autonomous commands without the need of real programming.

##How To Incorporate Into Your Project
- Install some form of JSON deserialization library (such as https://github.com/google/gson).
- Deserialize the JSON file the command form application creates in your app into a class.
- Move bot based on the deserialized steps.

##How to Build
- Open the .sln file in Visual Studio (preferably 2015, untested on other versions)
- Switch to Release mode.
- Build the project.
