namespace TF_FS_Dev_CS__Recap.Models;

public class Voiture : Vehicule
{

    public override void SeDeplacer()
    {
        Console.WriteLine("Je me déplace en voiture.");
    }

    public void ChangerPneus()
    {
        Console.WriteLine("Changement des pneus...");
    }

}
