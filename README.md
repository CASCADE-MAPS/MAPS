# Multi-fidelity Airspace and Platform Simulation (MAPS)

MAPS is a collection of simulation Collaboration Tools and Protocols, and 3D Airspace Environments developed in Unity.

A significant focus of CASCADE is facilitating decision making for drone missions. Work packages include a variety of drone missions across a range of environments, each with different challenges, risks, and importance. MAPS is the collation of tools, developed both within and outside of CASCADE, which enable decisions to be made regarding such missions. MAPS is developed with the intent to enable simulation of large numbers (>103) of drones, and other airspace users, with high spatial fidelity to gain a deep understanding of efficient flow patterns, risk, and robustness. The environment includes agent-based control to enable experiments with both centralised and de-centralised platforms, with each platform having authentic performance simulation such as payload/range, and manoeuvring limits.

- The simulation tools of MAPS provide a range of spatial fidelities, the capacity to simulate hundreds of drones in real-time, varying levels of decentralised control, and multiple virtual environments. All the tools in MAPS can be deployed in multi-user interactive simulation settings and in mixed reality simulations. 
-	MAPS incorporates models of risk, performance, autonomy, and sensors into a real-time interactive simulation. This enables researchers to interact with models in a manner representative of their use in real mission scenarios.  
-	MAPS provides a layer of accessibility to the tools of CASCADE through ease of access and thorough documentation in the form of text and video tutorials. 
-	MAPS is an excellent tool for outreach by virtue of its multi-user interactivity and mixed reality capabilities.

For more information please see [the wiki](https://github.com/CASCADE-MAPS/MAPS/wiki) or [the CASCADE website](https://cascadeuav.com/maps/)

# The MAPS Toolset
MAPS is primarily developed in the Unity engine. Unity provides many [beginner friendly tutorials](https://learn.unity.com/tutorials) on their website for getting started with the engine. This document provides links to each category of simulation tools developed and used within MAPS.

## General Engineering
This section includes tools developed for general simulation practice, such as saving data at regular intervals. While Unity is used in engineering fields, it is still a fairly new platform in this respect and so doesn’t provide the same scientific output capabilities as other platforms, such as MatLab.

- [Waypoint Following](https://github.com/CASCADE-MAPS/MAPS/tree/main/Waypoint%20Following)

- [Data Acquisition](https://github.com/CASCADE-MAPS/MAPS/tree/main/Data%20Acquisition)

## Drone Simulation
This section includes tools which have been used in various drone simulation applications. This ranges from basic waypoint following controllers and the tools to create a set of waypoints, to finite state machines for autonomous decision making in drones. [A drone delivery simulation Unity Project](https://github.com/CASCADE-MAPS/MAPS/tree/main/Drone%20Delivery/Drone%20Agents) is included in this repository. The project uses assets which are larger than 100 mb in size and so cannot be included in this repository. The assets are available on request if they are required to use the project.

## Web Deployment of Simulations
Unity simulations may be built for WebGL applications and then hosted using GitHub Pages. This workflow allows for simulations to be easily shared across platforms without the need to install additional software. For an example of this application, see the [multi-user drone inspection simulation](https://conorzam.github.io/MultiDrone/) developed in MAPS.

## Multi-user Simulation Environments
MAPS makes use of the multiplayer networking tools developed for Unity to provide multi-user simulation capabilities. This capability is available for developed simulations and prototypes and is not applicable during development. Developing a network capable simulation requires some foresight and planning to development. It can be difficult to retroactively enable networking for a large simulation as any moving parts generally need to be syncronised for clients. We currently use a free account with [Photon](https://www.photonengine.com/pun) to host our servers and avoid any port forwarding issues that come with client hosting. Photon Unity Networking is then used in the Unity project to configure the networking set up for the multi-user simulation.

## Mixed Reality
Unity provides various software development kits and documentation for getting started with [virtual reality](https://docs.unity3d.com/Manual/VROverview.html) and [augmented reality](https://docs.unity3d.com/Manual/AROverview.html) development. Rendering a simulation in mixed reality is generally straightforward, with virtual reality being as simple as installing the software development kit and ticking VR enabled in the settings. This section provides information for researchers looking to get started with mixed reality development in Unity.
