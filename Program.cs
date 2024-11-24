using System.Diagnostics;

namespace adb_remote
{
    class Program
    {
        private static string IPAddress = "192.168.2.231";
        private static Dictionary<string, Key> _stringToKeyMap = new Dictionary<string, Key>()
        {
            { "up", Key.up },
            {"down", Key.down},
            {"left", Key.left},
            {"right", Key.right},
            {"escape", Key.escape},
            {"backspace", Key.backspace},
            {"enter", Key.enter},
            {"a", Key.a},
            {"b", Key.b},
            {"c", Key.c},
            {"d", Key.d},
            {"e", Key.e},
            {"f", Key.f},
            {"g", Key.g},
            {"h", Key.h},
            {"i", Key.i},
            {"j", Key.j},
            {"k", Key.k},
            {"l", Key.l},
            {"m", Key.m},
            {"n", Key.n},
            {"o", Key.o},
            {"p", Key.p},
            {"q", Key.q},
            {"r", Key.r},
            {"s", Key.s},
            {"t", Key.t},
            {"u", Key.u},
            {"v", Key.v},
            {"w", Key.w},
            {"x", Key.x},
            {"y", Key.y},
            {"z", Key.z},
        };

        static void Main(string[] args)
        {
            var key = _stringToKeyMap[args[0].ToLower()];
            Console.WriteLine(args[0].ToLower());
            Console.WriteLine(key);
            adbCommand("kill-server");
            adbCommand("start-server");
            adbCommand("connect " + IPAddress);
            RemoteControlMode(key);
            ExitApplication();
        }
        private static void adbCommand(string adbCommand)
        {
            var p = new Process();
            p.StartInfo = new ProcessStartInfo("adb", adbCommand)
            {
                UseShellExecute = false
            };
            p.Start();
            p.WaitForExit();
        }
        private static void RemoteControlMode(Key key)
        {
                switch (key)
                {
                    case Key.up:
                        adbCommand("shell input keyevent 19");
                        break;
                    case Key.down:
                        adbCommand("shell input keyevent 20");
                        break;
                    case Key.left:
                        adbCommand("shell input keyevent 21");
                        break;
                    case Key.right:
                        adbCommand("shell input keyevent 22");
                        break;
                    case Key.escape:
                        adbCommand("shell input keyevent 3");
                        break;
                    case Key.backspace:
                        adbCommand("shell input keyevent 4");
                        break;
                    case Key.enter:
                        adbCommand("shell input keyevent 66");
                        break;
                    case Key.a:
                        adbCommand("shell input keyevent 29");
                        break;
                    case Key.b:
                        adbCommand("shell input keyevent 30");
                        break;
                    case Key.c:
                        adbCommand("shell input keyevent 31");
                        break;
                    case Key.d:
                        adbCommand("shell input keyevent 32");
                        break;
                    case Key.e:
                        adbCommand("shell input keyevent 33");
                        break;
                    case Key.f:
                        adbCommand("shell input keyevent 34");
                        break;
                    case Key.g:
                        adbCommand("shell input keyevent 35");
                        break;
                    case Key.h:
                        adbCommand("shell input keyevent 36");
                        break;
                    case Key.i:
                        adbCommand("shell input keyevent 37");
                        break;
                    case Key.j:
                        adbCommand("shell input keyevent 38");
                        break;
                    case Key.k:
                        adbCommand("shell input keyevent 39");
                        break;
                    case Key.l:
                        adbCommand("shell input keyevent 40");
                        break;
                    case Key.m:
                        adbCommand("shell input keyevent 41");
                        break;
                    case Key.n:
                        adbCommand("shell input keyevent 42");
                        break;
                    case Key.o:
                        adbCommand("shell input keyevent 43");
                        break;
                    case Key.p:
                        adbCommand("shell input keyevent 44");
                        break;
                    case Key.q:
                        adbCommand("shell input keyevent 45");
                        break;
                    case Key.r:
                        adbCommand("shell input keyevent 46");
                        break;
                    case Key.s:
                        adbCommand("shell input keyevent 47");
                        break;
                    case Key.t:
                        adbCommand("shell input keyevent 48");
                        break;
                    case Key.u:
                        adbCommand("shell input keyevent 49");
                        break;
                    case Key.v:
                        adbCommand("shell input keyevent 50");
                        break;
                    case Key.w:
                        adbCommand("shell input keyevent 51");
                        break;
                    case Key.x:
                        adbCommand("shell input keyevent 52");
                        break;
                    case Key.y:
                        adbCommand("shell input keyevent 53");
                        break;
                    case Key.z:
                        adbCommand("shell input keyevent 54");
                        break;
                    //case ConsoleKey.D0:
                    //    adbCommand("shell input keyevent 7");
                    //    break;
                    //case ConsoleKey.D1:
                    //    adbCommand("shell input keyevent 8");
                    //    break;
                    //case ConsoleKey.D2:
                    //    adbCommand("shell input keyevent 9");
                    //    break;
                    //case ConsoleKey.D3:
                    //    adbCommand("shell input keyevent 10");
                    //    break;
                    //case ConsoleKey.D4:
                    //    adbCommand("shell input keyevent 11");
                    //    break;
                    //case ConsoleKey.D5:
                    //    adbCommand("shell input keyevent 12");
                    //    break;
                    //case ConsoleKey.D6:
                    //    adbCommand("shell input keyevent 13");
                    //    break;
                    //case ConsoleKey.D7:
                    //    adbCommand("shell input keyevent 14");
                    //    break;
                    //case ConsoleKey.D8:
                    //    adbCommand("shell input keyevent 15");
                    //    break;
                    //case ConsoleKey.D9:
                    //    adbCommand("shell input keyevent 16");
                    //    break;
                    //case ConsoleKey.OemPeriod:
                    //    adbCommand("shell input keyevent 56");
                    //    break;
                    //case ConsoleKey.OemComma:
                    //    adbCommand("shell input keyevent 55");
                    //    break;
                }
            return;
        }

        private static void ExitApplication()
        {
            adbCommand("disconnect");
            adbCommand("kill-server");
            Environment.Exit(0);
        }
    }

    enum Key
    {
        up,
        down,
        left,
        right,
        escape,
        backspace,
        enter,
        a,
        b,
        c,
        d,
        e,
        f,
        g,
        h,
        i,
        j,
        k,
        l,
        m,
        n,
        o,
        p,
        q,
        r,
        s,
        t,
        u,
        v,
        w,
        x,
        y,
        z
    }

}
