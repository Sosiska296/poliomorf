ad zero = new ad();
ad one = new Via();
ad two = new Moon();
zero.voice();
one.voice();
two.voice();
class ad
{
    public virtual void voice()
    {
        Console.WriteLine("IMP");
    }
}
class Via : ad
{
    public override void voice()
    {
        Console.WriteLine("I will be okay");
    }
}
class Moon : ad
{
    public override void voice()
    {
        Console.WriteLine("stars");
    }
}