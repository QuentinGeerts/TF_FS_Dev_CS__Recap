using TF_FS_Dev_CS__Recap.Interfaces;

namespace TF_FS_Dev_CS__Recap.Models;

public class VoitureSport : Voiture, ISport
{
    private bool _turbo;
    public bool Turbo { get { return _turbo; } }

    public void ToggleTurbo()
    {
        _turbo = !_turbo;
    }
}
