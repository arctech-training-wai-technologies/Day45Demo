using System.Collections.Specialized;
using System.Diagnostics;

namespace Day45Demo.SimpleBouncingBall;

public class Ball
{
    private int _x, _y;
    private const char drawCharacter = '@';

    private bool isMovingAhead = true;

    public Ball(int x, int y)
    {
        _x = x;
        _y = y;
    }

    public void Show()
    {
        Console.SetCursorPosition(_x, _y);
        Console.Write(drawCharacter);
    }

    public void Hide()
    {
        Console.SetCursorPosition(_x, _y);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Write(' ');
        Console.ResetColor();
    }



    public void MoveRight()
    {
        Hide();
        _x++;
        Show();
    }

    public void MoveLeft()
    {
        Hide();
        _x--;
        Show();
    }

    public void MoveUp()
    {
        Hide();
        _y--;
        Show();
    }

    public void MoveDown()
    {
        Hide();
        _y++;
        Show();
    }

    public void BounceHorizontally()
    {
        isMovingAhead = true;

        while (true)
        {
            if(isMovingAhead)
                MoveRight();
            else
                MoveLeft();

            if (_x <= 1 || _x >= Console.WindowWidth - 1)
                isMovingAhead = !isMovingAhead;

            Debug.Print($"(x,y)=({_x},{_y}) isMovingRight={isMovingAhead}");

            Thread.Sleep(20);
        }
    }

    public void BounceVertically()
    {
        isMovingAhead = true;

        while (true)
        {
            if (isMovingAhead)
                MoveDown();
            else
                MoveUp();

            if (_y <= 1 || _y >= Console.WindowHeight - 1)
                isMovingAhead = !isMovingAhead;

            Debug.Print($"(x,y)=({_x},{_y}) isMovingRight={isMovingAhead}");

            Thread.Sleep(20);
        }
    }
}