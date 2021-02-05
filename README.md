# Trash Simulator
### **WINNER** of the Best Hardware Hack from MLH & Digi-key at Knight Hacks 2020!


[![Demo video](https://github.com/jordansmithsgames/jordansmithsgames/blob/main/readmes/trashsimulator/thumbsup.png)](https://www.youtube.com/embed/vJtxs6iU228)

(Psst, check out the [Devpost](https://devpost.com/software/trash-simulator)!)

# Inspiration
Here is the crazy, gross and funny story of this application's origins:

After constantly hearing about the horrors of trash building up in the ocean and reading statistics about how much (potentially carcinogenic) plastic we've all already eaten over the last decade, two of our team members decided to try to live zero waste. Unfortunately, the apartment building they lived in didn't have any recycling facilities. At first, they convinced themselves that they would take the recycling to a nearby recycling center weekly, and in the meantime carefully wash and sort the recycling into orderly piles near the trash bin.

This did not happen.

Recycling is far more difficult than it is made out to be, and finding the time to sort and transport the recycling to a public facility isn't as easy as it sounds. But their commitment was strong. Stronger than the piles of recyclables that began to pile up around their apartment. Stronger than the complaints of their roommates. Stronger than the condemnation of visitors to the apartment, callously remarking such reprisals as "dude what the heck take your recyclables out" and "man you really gotta clean lol".

As the cups began to tower, our team members had an epiphany: when you have to directly face how much trash you produce, you want to produce less of it. When you have to sort out six different types of bottles and mix up clamshells from brittle plastics while scrubbing Styrofoam food containers in a cold sweat during the hour before your grandma arrives from out of town, you realize that maybe it's better to just stop buying the stuff in the first place.

We wanted to bring that sweaty, frustrating, trash-smelling experience to the world, to help them learn something really important: waste plastic and disposable trash is hard to deal with even under ideal circumstances. We got to that realization by being forced to see the impact of our consumption right in front of our eyes, in our homes where we live. While it would be pretty gross to ask everyone to do that in real life, they can get their first taste (smell?) here in our VR app.

And we really like portal! Say hi to Poubelle for us!

# What it does
DEMO VIDEO QUALITY IS WAY LOWER THAN THE ACTUAL SIMULATION. THE ACTUAL SIMULATION LOOKS REALLY GOOD. WE WISH YOU COUD TRY IT IN PERSON.

TRASH SIMULATOR leads the user through an experience where they are forced to witness the full impact of a years worth of their plastic and disposables consumption, dumped at their feet in a heap. "Poubelle" (named after the French word for trash) is a trashbot AI powered by IBM Watson, who communicates with the user with natural language processing and text-to-speech APIs. In story mode, the player interacts with Poubelle in a guided experience that employs humor to explore the realities of excessive disposables waste (an even greater challenge as individuals consumer more plastic than ever during quarantine). The user is able to respond in a variety of ways to Poubelles questions, drawing from intants we built over the course of the hackathon. At the end of the story mode experience, the user is able to see the impact of a full year's worth of consumption at the rates they indicated.

In the free play mode, the user is able to visualize various amounts of trash generation on a weekly, monthly, and yearly basis. They can enter whatever amounts they want to experiment with to see firsthand the impact of consuming disposable materials. Sometimes the results are surprising- seeing the trash build up and fill the room really drives home the importance of reducing consumption and making environmentally conscious choices. The experience also allows the user to constantly interact with the AI and ask questions about recycling and receive answers.

# How we built it
To build TRASH SIMULATOR we split our group into a design and coding team. Due to the number of APIs and the complexity of the design, we often had to switch between roles on the fly. Our two teams work can be broken down as follows:

**DESIGN TEAM (Patrick and Austin)** The design team is particularly proud of the work that we did on this project. All the assets that are visible in the scene were modelled by us during this hackathon, and we put a lot of work into producing a modern, clean, and realistic aesthetic. We used Maya to produce the hard surface models like the house, glass fixtures, bed, and couch frame. These were textured in Substance Painter, and the product was exported into unity and assembled using the Autodesk material shaders. The cloth features were produced using Maya's nCloth feature, which we learned to use during this hackathon. We were amazed by the realistic cloth features that were produced using this method, especially the couch cushions and bed cover. Lastly, Patrick put forward a special effort to produce the beautiful lighting and scenery in this scene using Unity. We also made sure to add fun easter eggs in the scene (look at the coffee cups!).

Secondly, the design team also helped to storyboard and develop the artificial intelligence that we used, IBM's Watson. We wrote all the lines for Poubelle, and designed the natural language intents which allow the user to speak with him. Thus, we contributed to the design of the overall final product as well as the interaction design.

**CODING TEAM (Jordan and Ines)** The coding team developed the AI integration with IBM's Watson, Google Firebase, and scripted every interaction that takes place inside the Unity environment. Overall, they incorporated the use of five APIs and technologies in this build:

IBM Assistant
IBM Speech to Text
IBM Text to Speech
Oculus Integration
Google Firebase Authentication
This was a serious undertaking which required nearly the entire hackathon to calibrate correctly. The coding team had to rebuild a typing implementation from the ground up in order to use Google Firebase for authenticating the users. We experimented with different Unity builds and found that Android build settings suited our project well. The coding team was also responsible for combining and supporting the work of the design team. They took the raw output from Maya, several experimental Unity scenes developing the various APIs, and combined it all into one Unity scene. They designed the user interface, Poubelles speech track, and overall ensured a high quality level in our build.

**Challenges we ran into**

Every Hackathon is a grueling experience that tests every member of the teams strength and resolve to complete the project. KnightHacks 2020 was no different. As always, Firebase integration was a major pain to configure. Scripting the natural language interactions was something that none of us have ever done, and it proved to be quite difficult to get it right.

# Accomplishments that we're proud of
The staggering amount of work that we were able to cram into TRASH SIMULATOR is something that our team is extremely proud of, especially the integration of a Google Cloud technology within an Oculus Quest application, as these two technologies usually don't get along with each other well enough to deploy. We're also very proud of the main scene's design and polish, with the custom models and their detailed textures, as well as the overall simple and easy-to-use functionality of the program.

# What we learned
We learned the entire pipeline of creating an Oculus Quest application, from modeling to texturing, to prototyping APIs and UI elements, and bringing it all home into one application. We also learned the ins and outs of Unity's light rendering system to make the scene pop, as well as the power of Oculus' toolkit for Unity to interact with UI elements via laser pointers.

#What's next for TRASH SIMULATOR
Ideally, we'd like to expand the story mode to be more like a Portal 2 type simulation, where the AI is not benevolent to the player, as well as polishing the experience and deploying it to the Oculus store. WE ALSO WANT TO ADD A MULTIPLAYER MODE where the experience can be shared between players and the amount of trash is even more.
