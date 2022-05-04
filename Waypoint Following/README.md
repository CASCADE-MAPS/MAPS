# WayPoint Following
The Waypoint Tools package provides the following:

* Custom editor tools used to create paths of waypoints
* Waypoint tracking script used to keep track of the current target waypoint
* Kinematic Controller used to move an object towards a target waypoint
* Look points used to point an object to face points of interest along the path

For a quick start guide [click here](https://github.com/CUEDOS/Unity/wiki/Way-Point-Following:-Quick-Start)

## Creating Waypoints
The WayPointManager script is used to create a path of waypoints in a scene. Waypoints are represented by the WayPoint class which contains information for the position of the waypoint and the position of the look point associated with the waypoint. A look point can be used to aim a camera while travelling between waypoints.

To use the waypoint Manager, attach the WayPointManager script to an empty game object in the scene. Name the game object something which can be used to identify the path you want to create - the waypoint Tracker will use the name you choose here to find the Manager during play mode. When dealing with only one path in your scene a name like "WayPoints" is suitable.

<img src="https://github.com/CUEDOS/Unity/blob/master/bin/Waypoint%20Images/WayPointManager%20name%20highlight.png" alt="Inspector Name Highlight"/>

To add a waypoint, click the Add WayPoint button. A new waypoint will be added to the scene, represented by a cube bearing the colour specified in the WayPoint Colour field (default is light green). Further waypoints will be added at an offset from the last waypoint in the path, the offset may be set using the New WayPoint Offset field.

### Look Points
Generally, waypoints will suffice for a movement task, however, it can also be useful to specify a point to look at during travel. Every waypoint has a look point for exactly this. By default these points are hidden to reduce clutter in the scene, but can be shown by ticking the Show LookPoints field in the WayPointManager script. Look points are represented by spheres bearing the colour specified in the LookPoint Colour field (default is blue). Look points are connected by lines to their waypoint position.

<img src="https://github.com/CUEDOS/Unity/blob/master/bin/Waypoint%20Images/WayPointManager%20look%20points.png" alt="Look Points"/>

## Tracking Waypoints
The WayPointTracker script is used to keep track of which waypoint should be the target of a controller. A tolerance distance is used to check when the object has come close enough to the current target waypoint. When this distance is reached, the Tracker advances to the next waypoint.

<img src="https://github.com/CUEDOS/Unity/blob/master/bin/Waypoint%20Images/WayPointTracker%20inspector.png" alt="Tracker Inspector"/>

Other scripts may use the WayPointTracker by calling the GetCurrentWayPoint, GetCurrentLookPoint and GetCurrentWayPointData functions.

## Following Waypoints
We provide an example Kinematic Controller which moves the drone towards the Tracker's target position with constant speed. The Controller also uses the current look point as a target for the drone's orientation.

<img src="https://github.com/CUEDOS/Unity/blob/master/bin/Waypoint%20Images/KinematicController%20inspector.png" alt="Controller Inspector"/>
