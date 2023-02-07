using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HeadphonesCam : MonoBehaviour, IPointerClickHandler
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
        cameraMovement.SetNeedPosAndRot(new Vector3(-0.3954054f, 1.656074f, 0.7469103f), Quaternion.Euler(56.412f, 7.314f, -0.002f));
    }
}
