namespace abstraindo_um_jogo_rpg.src.entities
{
    public class Knight : Hero
    {
       public Knight(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;            
        } 
    }
}