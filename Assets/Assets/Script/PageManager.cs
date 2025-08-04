using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using TMPro;

public class PageManager : MonoBehaviour
{
    [System.Serializable]
    public class PageContent
    {
        public string title;
        public string body;
        public Sprite image;
        public AudioClip audioClip;
        public VideoClip videoClip;
    }

    public PageContent[] pages;
    public TMP_Text titleText;
    public TMP_Text bodyText;
    public RawImage imageDisplay;
    public AudioSource audioSource;
    public VideoPlayer videoPlayer;
    public Button nextButton;
    public Button backButton; // Added Back button

    private int currentPage = 0;
    public Button playButton;
    public AudioClip nextButtonSound;
    public AudioClip backButtonSound;
    public AudioClip playButtonSound;
    public AudioSource buttonAudioSource;

    void Start()
    {
        ShowPage(0);
        nextButton.onClick.AddListener(() => { PlayButtonSound(nextButtonSound); NextPage(); });
        backButton.onClick.AddListener(() => { PlayButtonSound(backButtonSound); PreviousPage(); });
        playButton.onClick.AddListener(() => { PlayButtonSound(playButtonSound); PlayVideo(); });
        UpdateButtonStates();
    }

    void PlayButtonSound(AudioClip clip)
    {
        if (clip != null && buttonAudioSource != null)
        {
            buttonAudioSource.PlayOneShot(clip);
        }
    }
    void ShowPage(int index)
    {
        if (index >= pages.Length) return;

        // Stop any media
        audioSource.Stop();
        videoPlayer.Stop();
        playButton.gameObject.SetActive(false); // Hide play button by default

        // Set text
        titleText.text = pages[index].title;
        bodyText.text = FormatBodyText(pages[index].body);

        // Image
        if (pages[index].image != null)
        {
            imageDisplay.texture = pages[index].image.texture;
            imageDisplay.enabled = true; // Show image
        }
        else
        {
            imageDisplay.enabled = false; // Hide image if not present
        }

        // Video
        if (pages[index].videoClip != null)
        {
            videoPlayer.clip = pages[index].videoClip;
            videoPlayer.gameObject.SetActive(true); // Show video
            playButton.gameObject.SetActive(true);  // Show play button only if video exists
            videoPlayer.Pause(); // Ensure video is not playing
        }
        else
        {
            videoPlayer.gameObject.SetActive(false); // Hide video if not present
            playButton.gameObject.SetActive(false);  // Hide play button if no video
        }

        // Audio
        if (pages[index].audioClip != null)
        {
            audioSource.clip = pages[index].audioClip;
            audioSource.Play();
        }

        UpdateButtonStates();
    }

    void NextPage()
    {
        currentPage++;
        if (currentPage < pages.Length)
        {
            ShowPage(currentPage);
        }
        else
        {
            currentPage = 0; // or disable the UI
            ShowPage(currentPage);
        }
    }

    void PreviousPage()
    {
        if (currentPage > 0)
        {
            currentPage--;
            ShowPage(currentPage);
        }
    }

    void UpdateButtonStates()
    {
        backButton.interactable = currentPage > 0;
    }
    void PlayVideo()
    {
        if (videoPlayer.clip != null)
        {
            if (videoPlayer.isPlaying)
            {
                videoPlayer.Pause();
            }
            else
            {
                videoPlayer.Play();
            }
        }
    }
    string FormatBodyText(string raw)
    {
        // Replace double newlines with <br><br> for paragraphs
        string formatted = raw.Replace("\n\n", "<br><br>");
        // Replace lines starting with * or - with bullet points
        formatted = System.Text.RegularExpressions.Regex.Replace(
            formatted,
            @"(^|\n)[\*\-]\s*(.+)",
            "$1• $2"
        );
        // Replace single newlines with <br>
        formatted = formatted.Replace("\n", "<br>");
        return formatted;
    }
}
