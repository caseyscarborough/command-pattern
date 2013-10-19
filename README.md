# Command Design Pattern

This repository holds information and data that I've put together for a presentation in my senior level Software Engineering class. The presentation is over the [Command Design Pattern](http://en.wikipedia.org/wiki/Command_pattern).

## Running the Examples

Examples are provided in both C# and in Java. The examples are interchangeable. To run the C# examples, open the Visual Studio solution files using Visual Studio 2012, and build and run the solution.

To run the Java examples, you can also just open the folder in IntelliJ or Eclipse and run the Main.java file. If you have [Maven](http://maven.apache.org/download.cgi) installed, you can just package the application and run it:

> _Note: Your working directory must be the root of the Java project_.

```bash
mvn package
java -cp target/CommandPattern*.jar Main
```

