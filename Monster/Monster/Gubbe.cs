namespace BashMonster; 


public class Gubbe
{
    public float maxHp = 100;
    public string name;
    public float hp;
    public float mass = 80;

    public Gubbe()
    {
        ResetHp();
    }

    void ResetHp()
    {
        hp = maxHp;
    }

    public void Injure(float dmg)
    {
    }


}