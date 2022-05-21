namespace Day45Demo.SimpleBouncingBall;

public class BouncyBall
{
    public static void Test()
    {
        Console.Clear();

        var ball = new Ball(50, 10);
        var ball2 = new Ball(20, 20);

        ball.Show();
        ball2.Show();

        var t1 = new Thread(ball.BounceVertically);
        var t2 = new Thread(ball2.BounceHorizontally);

        t1.Start();
        t2.Start();

        //Console.ReadKey();
    }

    public static void Test2()
    {
        var random = new Random();
        var balls = new Ball[20];

        for (var i = 0; i < balls.Length; i++)
        {
            var x = random.Next(0, Console.WindowWidth);
            var y = random.Next(0, Console.WindowHeight);

            balls[i] = new Ball(x, y);

            var t = new Thread(balls[i].BounceHorizontally);
            t.Start();
        }
    }
}