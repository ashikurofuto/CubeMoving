using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private PanelInputs panelInputs;
    [SerializeField] private Spawn spawn;

    private void Awake()
    {
        panelInputs.OnPressed += StartGame;
    }

    private void StartGame()
    {
        spawn.StartSpawnAndRepeat(true);
        panelInputs.OnPressed -= StartGame;
        panelInputs.OnPressed += StopGame;
    }
    private void StopGame()
    {
        spawn.StartSpawnAndRepeat(false);
        panelInputs.OnPressed += StartGame;
        panelInputs.OnPressed -= StopGame;
    }
}
