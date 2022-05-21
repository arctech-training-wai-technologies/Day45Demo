using System.Collections.Specialized;
using System.Diagnostics;

namespace Day45Demo.SimpleBouncingBall;

public class Ball
{
    private int _x, _y;
    private const char DrawCharacter = '@';

    private bool _isMovingAhead = true;

    public Ball(int x, int y)
    {
        _x = x;
        _y = y;
    }

    public void Show()
    {
        Console.SetCursorPosition(_x, _y);
        Console.Write(DrawCharacter);
    }

    public void Hide()
    {
        Console.SetCursorPosition(_x, _y);
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
        _isMovingAhead = true;

        while (true)
        {
            if (_isMovingAhead)
                MoveRight();
            else
                MoveLeft();

            if (IsGoingOutOfHorizontalBoundary())
                _isMovingAhead = !_isMovingAhead;

            Debug.Print($"(x,y)=({_x},{_y}) isMovingAhead={_isMovingAhead}");

            Thread.Sleep(100);
        }
    }

    public void BounceVertically()
    {
        _isMovingAhead = true;

        while (true)
        {
            if (_isMovingAhead)
                MoveDown();
            else
                MoveUp();

            if (IsGoingOutOfVerticalBoundary())
                _isMovingAhead = !_isMovingAhead;

            Debug.Print($"(x,y)=({_x},{_y}) isMovingAhead={_isMovingAhead}");

            Thread.Sleep(100);
        }
    }

    private bool IsGoingOutOfVerticalBoundary()
    {
        return _y <= 1 || _y >= Console.WindowHeight - 1;
    }

    private bool IsGoingOutOfHorizontalBoundary()
    {
        return _x <= 1 || _x >= Console.WindowWidth - 1;
    }
}