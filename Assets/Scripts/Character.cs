using System;

[Serializable]

public class character
{
    public int hp;
    public int sta;
    public enum Role {Necromancer, Phoenix, Saber, Seb};
    public Role role;
    public String bio;
}
