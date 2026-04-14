using System.Collections;

using UnityEngine;

using UnityEngine.XR.Interaction.Toolkit;
 
public class BedSit : MonoBehaviour

{

    public Transform xrOrigin;

    public Transform sitPoint;
 
    public float hoverTime = 1.5f; // how long to hover before sitting
 
    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable interactable;

    private Coroutine hoverCoroutine;
 
    void Start()

    {

        interactable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable>();
 
        interactable.hoverEntered.AddListener(OnHoverEnter);

        interactable.hoverExited.AddListener(OnHoverExit);

    }
 
    void OnHoverEnter(HoverEnterEventArgs args)

    {

        hoverCoroutine = StartCoroutine(HoverSit());

    }
 
    void OnHoverExit(HoverExitEventArgs args)

    {

        if (hoverCoroutine != null)

        {

            StopCoroutine(hoverCoroutine);

            hoverCoroutine = null;

        }

    }
 
    IEnumerator HoverSit()

    {

        yield return new WaitForSeconds(hoverTime);
 
        xrOrigin.position = sitPoint.position;

        xrOrigin.rotation = sitPoint.rotation;

    }

}
 