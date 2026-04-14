using System.Collections;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
 
public class TVController : MonoBehaviour
{
    public Renderer tvScreenRenderer;
    public AudioSource staticAudio;
 
    public Color offColor = Color.black;
    public Color onColor = new Color(0.95f, 0.96f, 0.97f, 1f);
 
    public float turnOnDelay = 0.6f;
    public int flickerCount = 6;
    public float flickerSpeed = 0.08f;
 
    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable interactable;
    private Material screenMaterial;
    private bool isOn = false;
    private bool isBusy = false;
 
    void Start()
    {
        interactable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable>();
        interactable.hoverEntered.AddListener(OnTVHoverEntered);
        screenMaterial = tvScreenRenderer.material;
        SetScreenOffInstant();
    }
 
    void OnTVHoverEntered(HoverEnterEventArgs args)
    {
        if (!isOn && !isBusy)
            StartCoroutine(TurnOnTV());
    }
 
    IEnumerator TurnOnTV()
    {
        isBusy = true;
        SetScreenOffInstant();
 
        yield return new WaitForSeconds(turnOnDelay);
 
        if (staticAudio != null)
            staticAudio.Play();
 
        for (int i = 0; i < flickerCount; i++)
        {
            SetScreenColor(onColor * Random.Range(0.3f, 1.2f));
            yield return new WaitForSeconds(flickerSpeed);
 
            SetScreenColor(offColor);
            yield return new WaitForSeconds(flickerSpeed * 0.6f);
        }
 
        SetScreenOnInstant();
        isOn = true;
        isBusy = false;
    }
 
    void SetScreenOffInstant()
    {
        SetScreenColor(offColor);
        SetEmission(Color.black);
    }
 
    void SetScreenOnInstant()
    {
        SetScreenColor(onColor);
        SetEmission(onColor * 2.5f);
    }
 
    void SetScreenColor(Color color)
    {
        if (screenMaterial.HasProperty("_BaseColor"))
            screenMaterial.SetColor("_BaseColor", color);
        else if (screenMaterial.HasProperty("_Color"))
            screenMaterial.SetColor("_Color", color);
 
        SetEmission(color * 2f);
    }
 
    void SetEmission(Color color)
    {
        if (screenMaterial.HasProperty("_EmissionColor"))
        {
            screenMaterial.EnableKeyword("_EMISSION");
            screenMaterial.SetColor("_EmissionColor", color);
        }
    }
}