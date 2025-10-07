using UnityEngine;

public class PlayerSkinManager : MonoBehaviour
{
    public static PlayerSkinManager Instance;

    public SpriteRenderer playerRenderer;
    public Sprite defaultSkin;
    public Sprite blueSkin; // exemplo de skin comprável

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    public void UnlockSkin(string skinID)
    {
        switch (skinID)
        {
            case "SkinBlue":
                ApplySkin(blueSkin);
                break;
            default:
                ApplySkin(defaultSkin);
                break;
        }
    }

    void ApplySkin(Sprite newSkin)
    {
        playerRenderer.sprite = newSkin;
        Debug.Log("Skin alterada com sucesso!");
    }
}
