using TextureSendReceive;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NetworkScript : MonoBehaviour
{
    public RawImage _CastingTexture;
    public TMP_InputField _IpAddress;
    TextureReceiver receiver;
    Texture2D targetTexture;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void StartCasting()
    {
        receiver = gameObject.AddComponent<TextureReceiver>();
        receiver.IP = _IpAddress.text;

        // initialize new target texture
        targetTexture = new Texture2D(1, 1);
        // Set target texture
        receiver.SetTargetTexture(targetTexture);
        _CastingTexture.texture = targetTexture;
    }

    public void StopCasting()
    {
        targetTexture = new Texture2D(1, 1);
        _CastingTexture.texture = targetTexture;

        receiver.CloseReceiver();
        Destroy(receiver);
    }
}
