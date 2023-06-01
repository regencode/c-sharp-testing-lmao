using System.Collections;
using System.Collections.Generic;


public class IAnimal
{ 
    public string name = "IAnimal";
    public virtual string Name
    {
        get { return name; }
    }

    public virtual string Talk()
    {
        return "bawk";
    }

}

public class Dog : IAnimal
{
    public string name = "Dog";
    public override string Name
    {
        get { return name; }
    }
    public override string Talk()
    {
        return "aw";
    }

}
public class Chicken : IAnimal
{
    public string name = "Chicken";
    public override string Name
    {
        get { return name; }
    }
    public override string Talk()
    {
        return "bawk";
    }

}

public class Cow : IAnimal
{
    public string name = "Cow";
    public override string Name
    {
        get { return name; }
    }
    public override string Talk()
    {
        return "moo";
    }
}

public class Cat : IAnimal
{
    public string name = "Cat";
    public override string Name
    {
        get { return name; }
    }
    public override string Talk()
    {
        return "meow";
    }
}

public class Pig : IAnimal
{
    public string name = "Pig";
    public override string Name
    {
        get { return name; }
    }
    public override string Talk()
    {
        return "oink";
    }
}




/*
    Output must be ...
    Dog says aw aw!
    Chicken says bawk bawk!
    Cow says moo moo!
    Cat says meow meow!
    Pig says oink oink!
*/

class Test
{
    static void Main(String[] args)
    {

        Dictionary<string, IAnimal> _animals = new Dictionary<string, IAnimal>();



        IAnimal a = new Dog();
        _animals[a.Name] = a;
        
        a = new Chicken();
        _animals[a.Name] = a;

        a = new Cow();
        _animals[a.Name] = a;

        a = new Cat();
        _animals[a.Name] = a;

        a = new Pig();
        _animals[a.Name] = a;

        foreach (IAnimal anim in _animals.Values)
        {
            string talk = anim.Talk();
            string msg = string.Format("{0} says {1} {1} !\n", anim.Name, talk);
            Console.Write(msg);
        }        
    }
}
