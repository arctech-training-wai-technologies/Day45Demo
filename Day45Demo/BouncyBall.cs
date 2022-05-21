using Day45Demo.SimpleBouncingBall;

public class BouncyBall
{
    public static void Test()
    {
        Console.Clear();
        var ball = new Ball(50, 10);
        ball.Show();

        //ball.BounceHorizontally();
        ball.BounceVertically();

        //for (int i = 0; i < 20; i++)
        //{
        //    ball.MoveLeft();
        //    Thread.Sleep(100);
        //}
    }
}