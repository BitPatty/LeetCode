// https://leetcode.com/problems/print-in-order

using System.Threading;

public class Foo
{
  SemaphoreSlim semaphoreA = new SemaphoreSlim(1, 1);
  SemaphoreSlim semaphoreB = new SemaphoreSlim(1, 1);

  public Foo()
  {
    semaphoreA.Wait();
    semaphoreB.Wait();
  }

  public void First(Action printFirst)
  {
    printFirst();
    semaphoreA.Release();
  }

  public void Second(Action printSecond)
  {
    semaphoreA.Wait();
    printSecond();
    semaphoreB.Release();
  }

  public void Third(Action printThird)
  {
    semaphoreB.Wait();
    printThird();
  }
}