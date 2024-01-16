using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera MainCamera;
    public Camera BlindCam;
    public float minimumInterval = 0.5f;
    public float maximumInterval = 2f;

    private float elapsedSwitchTime = 0f;

    void Start()
    {
        BlindCam.gameObject.SetActive(false);
        elapsedSwitchTime = GetRandomSpawnInterval();
    }

    void Update()
    {
        elapsedSwitchTime += Time.deltaTime;

        if (elapsedSwitchTime >= GetRandomSpawnInterval())
        {
            SwitchCamera();
            elapsedSwitchTime = 0f;
        }
    }

    void SwitchCamera()
    {
        if (MainCamera.gameObject.activeSelf)
        {
            MainCamera.gameObject.SetActive(false);
            BlindCam.gameObject.SetActive(true);
        }
        else
        {
            MainCamera.gameObject.SetActive(true);
            BlindCam.gameObject.SetActive(false);
        }
    }

    float GetRandomSpawnInterval()
    {
        return Random.Range(minimumInterval, maximumInterval);
    }
}
