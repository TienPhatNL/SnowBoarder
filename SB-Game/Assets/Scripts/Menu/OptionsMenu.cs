using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public Slider volumeSlider;
    public GameObject optionsOverlay;
    public Toggle snowToggle; // Reference to the Snow Toggle
    public GameObject snowGenerator; // Reference to the SnowGenerator particle system

    void Start()
    {
        // Initialize volume slider
        volumeSlider.value = AudioListener.volume;
        volumeSlider.onValueChanged.AddListener(SetVolume);

        // Initialize snow toggle
        if (snowGenerator != null && snowToggle != null)
        {
            snowToggle.isOn = snowGenerator.activeSelf; // Set toggle state to match SnowGenerator's current state
            snowToggle.onValueChanged.AddListener(ToggleSnow);
        }
    }

    public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
    }

    public void ShowOptions()
    {
        optionsOverlay.SetActive(true);
    }

    public void HideOptions()
    {
        optionsOverlay.SetActive(false);
    }

    // Called when the Snow Toggle value changes
    public void ToggleSnow(bool isSnowEnabled)
    {
        if (snowGenerator != null)
        {
            snowGenerator.SetActive(isSnowEnabled); // Enable/disable the SnowGenerator
        }
    }
}