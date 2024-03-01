namespace TF_FS_Dev_CS__Recap.Models;

public class Garage
{
    // Attributs
    private readonly List<Vehicule> _vehicules = new ();

    public void AjouterVehicule (Vehicule vehicule)
    {
        if (vehicule == null) throw new ArgumentNullException("Votre vehicule est null");

        _vehicules.Add (vehicule);
    }

}
