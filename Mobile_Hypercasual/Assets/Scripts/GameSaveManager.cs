using UnityEngine;

public class GameSaveManager : MonoBehaviour
{

    // Salvar posição do player
    public void SavePlayerPosition(Vector3 position)
    {
        PlayerPrefs.SetFloat("PlayerPosX", position.x);
        PlayerPrefs.SetFloat("PlayerPosY", position.y);
        PlayerPrefs.SetFloat("PlayerPosZ", position.z);
        PlayerPrefs.Save();
        Debug.Log("Player position saved: " + position);
    }

    // Carregar posição do player
    public Vector3 LoadPlayerPosition()
    {
        float x = PlayerPrefs.GetFloat("PlayerPosX", 0f);
        float y = PlayerPrefs.GetFloat("PlayerPosY", 0f);
        float z = PlayerPrefs.GetFloat("PlayerPosZ", 0f);
        Vector3 pos = new Vector3(x, y, z);
        Debug.Log("Player position loaded: " + pos);
        return pos;
    }

    // Resetar progresso
    public void ResetProgress()
    {
        PlayerPrefs.DeleteKey("PlayerPosX");
        PlayerPrefs.DeleteKey("PlayerPosY");
        PlayerPrefs.DeleteKey("PlayerPosZ");
        Debug.Log("Progress reset.");
    }
}


