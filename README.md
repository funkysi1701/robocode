# Robocode @ YorkCodeDojo

> Robocode is a programming game, where the goal is to develop a robot battle tank to battle against other tanks in Java or .NET. The robot battles are running in real-time and on-screen.
[Robocode Site](http://robocode.sourceforge.net/)

Robocode runs on the Java Runtime but bots can be developed in Java or any language that is compiled down to IL (C#, F#, VB.NET)

## Get started
- Download Java http://java.com/en/download
- Download Robocode - http://robocode.sourceforge.net/download
 - [robocode-1.9.2.5-setup.jar](https://sourceforge.net/projects/robocode/files/robocode/1.9.2.5/robocode-1.9.2.5-setup.jar/download)
 - [robocode.dotnet-1.9.2.5-setup.jar](https://sourceforge.net/projects/robocode/files/robocode/1.9.2.5/robocode.dotnet-1.9.2.5-setup.jar/download)

## Write a bot

### Java example

```java

package example;

import robocode.HitByBulletEvent;
import robocode.Robot;
import robocode.ScannedRobotEvent;

public class MyBot extends Robot {

    public void run() {

        while (true) {
            ahead(100);
            turnRight(90);
            scan();
        }
    }

    public void onScannedRobot(ScannedRobotEvent e) {
        fire(1);
    }
}   

```

### C# example

```csharp

using Robocode;

namespace Example
{
    public class MyBot : Robot
    {
        public override void Run()
        {
            for (;;)
            {
                Ahead(100);
                TurnRight(90);
                Scan();
            }
        }

        public override void OnScannedRobot(ScannedRobotEvent e)
        {
            Fire(1);
        }
    }
}

```

## Resources
- [Wiki](http://robowiki.net/)
- [Java Examples](https://github.com/robo-code/robocode/blob/master/robocode.samples/src/main/java/sample/)
- [C# Examples](https://github.com/robo-code/robocode/blob/master/plugins/dotnet/robocode.dotnet.samples/src/SampleCs)

 