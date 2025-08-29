using UnityEngine;

public class SaveButtonHandler : MonoBehaviour
{

    public GameSaveManager saveManager;
    public Transform player;

    public void SaveGame()
    {
        if (saveManager != null && player != null)
        {
            saveManager.SavePlayerPosition(player.position);
            Debug.Log("Game saved!");
        }
    }
}

