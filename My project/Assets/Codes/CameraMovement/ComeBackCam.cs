using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ComeBackCam : MonoBehaviour, IPointerClickHandler
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
        cameraMovement.SetNeedPosAndRot(new Vector3(0.034f, 2.59f, -2.3f), Quaternion.Euler(23.176f, 0f, 0f));
    }
}
