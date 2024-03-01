using TF_FS_Dev_CS__Recap.Interfaces;
using TF_FS_Dev_CS__Recap.Models;

Vehicule vehicule = new Vehicule();
vehicule.SeDeplacer();

object vehicule2 = new Vehicule(); // Cast implicite
Vehicule vehicule3 = (Vehicule)vehicule2; // Cast explicite
// Vehicule vehicule4 = vehicule2 as Vehicule;



Voiture voiture1 = new Voiture();
voiture1.SeDeplacer();


Vehicule vehiculeVoiture = new Voiture(); // Cast implicite → Voiture est un véhicule
Voiture voiture2 = (Voiture)vehiculeVoiture; // Cast explicite → Car une vehicule n'est pas forcément une voiture

Moto moto1 = new Moto();
Bateau bateau1 = new Bateau();


Garage monGarage = new Garage();

monGarage.AjouterVehicule(vehicule);
monGarage.AjouterVehicule(vehicule3);
monGarage.AjouterVehicule(bateau1);
monGarage.AjouterVehicule(moto1);
monGarage.AjouterVehicule(voiture2);

// vehiculeVoiture → vehicule
// Accès qu'aux membres d'une vehicule
((Voiture)vehiculeVoiture).ChangerPneus();


Vehicule vehiculeVide = new Voiture();
vehiculeVide.SeDeplacer();

VoitureSport voitureSport = new VoitureSport();
//vehiculeSport.Turbo = true;
voitureSport.ToggleTurbo();


ISport vehiculeSport = new VoitureSport();
//vehiculeSport.Turbo = true;
vehiculeSport.ToggleTurbo();


