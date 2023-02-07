using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TripodCam : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
    [SerializeField] private new GameObject camera;
    private CameraMovement cameraMovement;
    void Start()
    {
        cameraMovement = camera.GetComponent<CameraMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        cameraMovement.SetNeedPosAndRot(new Vector3(0.76f, 1.6f, 0.17f), Quaternion.Euler(35.683f, -38.757f, -0.008f));
    }
}
