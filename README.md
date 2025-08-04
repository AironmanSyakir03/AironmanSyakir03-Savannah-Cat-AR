BCM3263 
Augmented Reality

FINAL ASSESSMENT
SAVANNAH CAT

NAME & STUDENT ID.
MOHAMAD AIMAN SYAKIR BIN MOHAMAD KHIR
CD22009

Lecturer:
TS. DR. RAHMAH MOKHTAR

YouTube link : 
[Savannah Cat AR Demonstration](https://youtu.be/KXpCrxCrMho)
Material and APK Google Drive link :
[BCM3263 Augmented Reality](https://drive.google.com/drive/folders/1rB3oEtHmD0OjIovOHEW3GyqY9aPfPDV1?usp=sharing)


PART A

Introduction
Savannah Cat Augmented Reality Application is an innovative Augmented Reality experience designed to educate and assist both current and future Savannah cat owners. The application allows users to interact with a life-sized, animated 3D Savannah cat in real space through their smartphones or tablets. This immersive tool provides detailed information about the breed’s behavior, care requirements, feeding habits, and living environment needs. By combining visual learning with interactive features, the application bridges the gap between traditional pet care resources and modern technology, making it easier and more engaging for users to  understand the unique characteristics and responsibilities of owning a Savannah cat.

 
Benefits
The implementation of the Savannah Cat AR application provides several strategic advantages to the users.

1	Enhanced learning Experience	
- The application offers users a more engaging and effective way to learn about Savannah cats through Augmented Reality. By interacting with a realistic 3D model, users can visualize physical features, observe simulated behaviors, and access care information in an intuitive format. This immersive learning helps users absorb and retain information more easily compared to traditional reading materials.
2	Better Decision-Making for Potential Owners
- For individuals considering adopting or purchasing a Savannah cat, the application serves as a practical decision-making tool. By providing clear and accessible information on the breed’s temperament, activity level, space requirement, and care needs, the app helps users assess whether the Savannah cat is a suitable match for their lifestyle, thus reducing the risk of pet abandonment or mistreatment.
3	Promote Responsibility in Pet’s Owner
- Current Savannah cat owners benefit from on-demand access to care tips, feeding guidelines, and grooming advice. And behavior explanations. This promotes better pet management and strengthens the bond between the owner and the cat. The AR component also allows users to simulate certain behaviors and responses, giving them better insight into their pet’s needs.
4	Improved Accessibility of Information
- The application makes breed-specific information easily accessible to users at any time and place through their mobile devices. This convenience empowers users to learn and make informed choices without needing to consult lengthy books or unreliable online sources. The visual and interactive nature of the app is especially helpful for younger users or those with lower literacy levels.

 
Development
Steps in developing the Savannah Cat AR Application:
1.	Open Unity Hub and select 3D Core to set up the project.
2.	Import Vuforia packages.
3.	Adding AR Camera.
3.1.	Click on the “+” icon in Hierarchy, go to Vuforia Engine and select AR Camera. 
3.2.	In AR Camera, open the Vuforia Engine configuration to add the license & database that was acquired from the Vuforia website. 
3.3.	Set the play mode to “WEBCAM” to view the AR system during development.
4.	Adding Image Target.
4.1.	To add image target, click on the “+” icon in Hierarchy, go to Vuforia Engine and select “Image Target”. 
4.2.	In “Image Target Behaviour”, select the database and the image that will be used as the marker.
5.	Creating a 3D model.
5.1.	For the 3D model & animation, Meshy.ai is used to ease the development. 
5.2.	Find a few savannah cat images on the internet, and add them into Meshy. 
5.3.	The software will generate 4 models based on reference images.
5.4.	Using the best 3D model generated, generate a texture based on the reference image and select a suitable topology.
5.5.	With this usable textured 3D model, add a quadruped rig and walking animation to the 3D model. Meshy.ai will automatically adjust the rig and make sure the animation works. 
5.6.	Finally, download the 3D animated model and import it into a Unity project.
6.	Adding a 3D model into Unity.
6.1.	Create a folder named “3D Model” and drag the .fbx file into the folder. 
6.2.	In the rig tab in the inspector, change animation type to legacy, avatar definition to create from this model, and click apply. 
6.3.	In the  animation tab, enable loop time to keep the model animated nonstop. 
6.4.	Finally, in the  materials tab, extract the texture and materials from the model and click apply.
7.	Adding a 3D model into the hierarchy.
7.1.	The model from the project into the hierarchy. 
7.2.	Adjust the position and scale to suit the environment. 
7.3.	Add an animator component and create an animator controller named “CatWalk”. 
7.4.	Open the controller and add the animation for the details in the project.
7.5.	Drag the animator controller into the model in the animator component.
8.	Creating UI to display the cat’s details.
8.1.	Add a canvas by clicking the “+” in hierarchy, UI > canvas. Name the canvas “Cat’s Detail”. 
8.2.	Adjust the canvas size and orientation to the intended size. 
8.3.	Drag ARCamera from the hierarchy into the  Eventan  Camera in the inspector.
8.4.	Add panel by clicking the “+” in hierarchy, UI > panel.
8.5.	Set the background to a  suitable color or use e image.
8. a 6.	Add text by clicking the “+” in hierarchy, UI > TextMeshPro. Name the text to title. Do the same for page title and body text with a suitable,e name. 
8.7.	For the title, in the text section, change the text to the title of this AR system, “Savannah Cat”. Adjust the font, relative appropriately. 
8.8.	For the page title and body text, do not change the text. Enable auto-size for a dynamic font sizing relative to paragraph size. Adjust the font and color appropriately.
8.9.	Add raw im by clicking the “+” in hierarchy, UI > Raw Image. Name  the image to “Page Image”.
8.10.	Add another raw image, but name the image “Video Player”. In the project, right-click and create a render texture. Use toor Dimension, set the size to fit in the canvas, and drag the render texture into the  Video Player texture. Add a video player component to the raw image.
8.11.	Add audio by creating an empty gameObject and adding an audio source component. Name the gameObject to Page Audio.
8.12.	Create a control button by clicking the “+” in hierarchy, UI > button. Adjust the size and color appropriately. Do the same for the other two buttons.
8.,13.	Name the button “Next Button”, “Back Button”, and “Play Button”. Change the text according to the button and change the font, size, and color appropriately.
8.14.	To manage the UI, create an empty gameObject named “PageManager”.
8.15.	Add a  new script using the “Add Component” button named PageManager.cs.
8.16.	Open the script and add the script as below.
1.	using UnityEngine;
2.	using UnityEngine.UI;
3.	using UnityEngine.Video;
4.	using TMPro;
5.	
6.	public class PageManager : MonoBehaviour
7.	{
8.	    [System.Serializable]
9.	    public class PageContent
10.	    {
11.	        public string title;
12.	        public string body;
13.	        public Sprite image;
14.	        public AudioClip audioClip;
15.	        public VideoClip videoClip;
16.	    }
17.	
18.	    public PageContent[] pages;
19.	    public TMP_Text titleText;
20.	    public TMP_Text bodyText;
21.	    public RawImage imageDisplay;
22.	    public AudioSource audioSource;
23.	    public VideoPlayer videoPlayer;
24.	    public Button nextButton;
25.	    public Button backButton; // Added Back button
26.	
27.	    private int currentPage = 0;
28.	    public Button playButton;
29.	
30.	    void Start()
31.	    {
32.	        ShowPage(0);
33.	        nextButton.onClick.AddListener(NextPage);
34.	        backButton.onClick.AddListener(PreviousPage);
35.	        playButton.onClick.AddListener(PlayVideo); // Add this line
36.	        UpdateButtonStates();
37.	    }
38.	
39.	    void ShowPage(int index)
40.	    {
41.	        if (index >= pages.Length) return;
42.	
43.	        // Stop any media
44.	        audioSource.Stop();
45.	        videoPlayer.Stop();
46.	        playButton.gameObject.SetActive(false); // Hide play button by default
47.	
48.	        // Set text
49.	        titleText.text = pages[index].title;
50.	        bodyText.text = FormatBodyText(pages[index].body);
51.	
52.	        // Image
53.	        if (pages[index].image != null)
54.	        {
55.	            imageDisplay.texture = pages[index].image.texture;
56.	            imageDisplay.enabled = true; // Show image
57.	        }
58.	        else
59.	        {
60.	            imageDisplay.enabled = false; // Hide image if not present
61.	        }
62.	
63.	        // Video
64.	        if (pages[index].videoClip != null)
65.	        {
66.	            videoPlayer.clip = pages[index].videoClip;
67.	            videoPlayer.gameObject.SetActive(true); // Show video
68.	            playButton.gameObject.SetActive(true);  // Show play button only if video exists
69.	            videoPlayer.Pause(); // Ensure video is not playing
70.	        }
71.	        else
72.	        {
73.	            videoPlayer.gameObject.SetActive(false); // Hide video if not present
74.	            playButton.gameObject.SetActive(false);  // Hide play button if no video
75.	        }
76.	
77.	        // Audio
78.	        if (pages[index].audioClip != null)
79.	        {
80.	            audioSource.clip = pages[index].audioClip;
81.	            audioSource.Play();
82.	        }
83.	
84.	        UpdateButtonStates();
85.	    }
86.	
87.	    void NextPage()
88.	    {
89.	        currentPage++;
90.	        if (currentPage < pages.Length)
91.	        {
92.	            ShowPage(currentPage);
93.	        }
94.	        else
95.	        {
96.	            currentPage = 0; // or disable the UI
97.	            ShowPage(currentPage);
98.	        }
99.	    }
100.	
101.	    void PreviousPage()
102.	    {
103.	        if (currentPage > 0)
104.	        {
105.	            currentPage--;
106.	            ShowPage(currentPage);
107.	        }
108.	    }
109.	
110.	    void UpdateButtonStates()
111.	    {
112.	        backButton.interactable = currentPage > 0;
113.	    }
114.	    void PlayVideo()
115.	    {
116.	        if (videoPlayer.clip != null)
117.	        {
118.	            if (videoPlayer.isPlaying)
119.	            {
120.	                videoPlayer.Pause();
121.	            }
122.	            else
123.	            {
124.	                videoPlayer.Play();
125.	            }
126.	        }
127.	    }
128.	    string FormatBodyText(string raw)
129.	    {
130.	        // Replace double newlines with <br><br> for paragraphs
131.	        string formatted = raw.Replace("\n\n", "<br><br>");
132.	        // Replace lines starting with * or - with bullet points
133.	        formatted = System.Text.RegularExpressions.Regex.Replace(
134.	            formatted,
135.	            @"(^|\n)[\*\-]\s*(.+)",
136.	            "$1• $2"
137.	        );
138.	        // Replace single newlines with <br>
139.	        formatted = formatted.Replace("\n", "<br>");
140.	        return formatted;
141.	    }142.	}

8.17.	The code will manage the details in the UI. A new page can be added to the UI, and each page will have its own page title, description, image, audio clip, and video clip.
8.18.	Configure the script by dragging the page title object into the title text, page body text into the body text, Page Image into image display, Page Audio into audio source, Video Player into video player, Next Button into next button, Back Button into back button, and Play Button into play button.
9.	Building APK.
9.1.	Open file > Build Setting.
9.2.	Select Android to build an  .apk file that can be installed on an Android device.
9.3.	Open player settings and set the minimum API level to Android 10 (API Level 29) because this is the minimum level that supports the Vuforia AR kit.
9.4.	In the  build setting, add a scene by clicking the Add Open Scene and change the setting based on the development phase accordingly.
9.5.	To finalize the build, click Build and select the location for the .apk file.
10.	Installing on an Android device.
10.1.	Transfer the .apk file to an Android device.
10.2.	Open the file in the file manager. Android will install the APK. (If this is the first time installing an .apk file from the file manager, Android will request permission to trust the file from the file manager)
10.3.	When the installation is finished, open the application and test the functionality.
 
Marketing Plan
To maximize the outreach and impact of the Savannah Cat AR application, targeted marketing strategies can be implemented aimed at increasing user awareness and promoting responsible pet ownership. Table 2 shows the recommended marketing plans for this application with a detailed explanation.
Table 2 Marketing plans to expand Savannah Cat AR influence
No.	Plans	Explanation
1	Social Media Campaign with AR Demonstration	A strategic social media campaign can be launched to showcase the key feature of the AR application, particularly its interactive 3D Savannah cat model. Platforms such as Instagram, TikTok, and Facebook are effective channels for visual content and have proven to be successful in engaging pet lovers and tech-savvy audiences (Statista, 2024). The marketing team can produce short, engaging videos demonstrating how the AR cat behaves in real environments, accompanied by educational facts about the breed. 
Additionally, QR codes linked to the app download page can be embedded in social media posts, stories, and paid advertisements, allowing for seamless access.
2	Partnership with Pet Clinics and Pet Shops	Establishing collaborative partnerships with veterinary clinics and pet-related retail outlets can provide on-site promotional opportunities. These locations offer direct access to current and potential pet owners who are already engaged in pet care decisions. By placing standees with QR codes or tablets preloaded with the AR app, visitors can instantly try the experience and learn about the Savannah cat breed. Printed brochures featuring the app and services offered can also be distributed as take-home materials.
Weakness
While the Savannah Cat AR application offers a modern and engaging platform for educating pet owners, it also has limitations that need to be addressed for enhanced effectiveness and broader usability.
Weakness
1	Limited Device Compatibility	
- One of the primary  challenges of AR applications is that they often require high-performance mobile devices with support for AR frameworks such as ARCore for Android or ARKit for iOS. Users with older or lower-end smartphones may not be able to access or sun the application. This limits the reach of the application, particularly among users in rural or lower-income communities (Carmigniani et al., 2010, pp. 341–377). Future updates should consider a lightweight or web-based version of the app to improve accessibility across various device types.
2	Lack of Personalization Features
- This application currently provides general information about Savannah cats but lacks interactive features tailored to the user’s specific situation, such as the age of their cat, living environment, or level of experience as a pet owner. Adding customization options, such as user profiles or interactive quizzes that adapt content based on user input, could make the app more valuable for individual users.
3	Limited Interactivity and Realism
- Although the 3D model allows users to view and rotate the Savannah cat in AR, the range of interactions is still basic. The user cannot simulate complex behavior such as feeding, grooming, playing, or receiving real-time responses from the virtual cat. This may reduce long-term user engagement. According to Azuma (2015), increasing the realism and interactivity of AR experiences enhances immersion and user retention. Future iterations of the application should consider adding behavior simulations or voice-assisted interactions to make the experience more dynamic and lifelike.


 
Part B

Video Presentation with Demonstration
https://youtu.be/KXpCrxCrMho
 

References

Azuma, R. (2015). Location-Based Mixed and Augmented Reality Storytelling. Fundamentals of Wearable Computers and Augmented Reality, Woodrow Barfield, 11(2), 259–276.
Barfield, W. (2015). Fundamentals of Wearable Computers and Augmented Reality, second edition. CRC Press.
Carmigniani, J., Furht, B., Anisetti, M., Ceravolo, P., Damiani, E., & Ivkovic, M. (2010). Augmented reality technologies, systems, and applications. Multimedia Tools and Applications, 51(1), 341–377. https://doi.org/10.1007/s11042-010-0660-6
Dixon, S. J. (n.d.). Biggest social media platforms by users 202. Statista. Retrieved June 23, 2025, from https://www.statista.com/statistics/272014/global-social-networks-ranked-by-number-of-users/
Savannah: Personality, Diet, Grooming, Training. (n.d.). Petplan.Co.Uk. Retrieved June 23, 2025, from https://www.petplan.co.uk/cat-insurance/cat-breeds/savannah.html

