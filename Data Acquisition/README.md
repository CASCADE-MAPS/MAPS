# Data Acquisition

The [Data Acquisition Unity package](https://github.com/CUEDOS/Unity/tree/master/alphas/Data%20Acquisition%20Tool.unitypackage) provides a tool which finds all fields and value-returning-methods in any monobehaviour-derived script and saves their values at a specified frequency to the specified tab separated text file.

## Selecting Fields to Save
The SaveData script may be attached to any object in the scene. With SaveData attached, select the GameObject you want to collect data from. Then, select from a list of all MonoBehaviour scripts attached to the GameObject. Finally, choose the fields from the script you wish to record.

<img src="https://github.com/CUEDOS/Unity/blob/master/bin/Data%20Acquisition%20Images/default%20inspector.png" alt="Inspector Window"/>

Upon adding the script reference, SaveData will populate a drop-down menu with all the fields and value-returning-methods it finds in the script. Simply select the values, by name, that you wish to save. Use the add/remove field buttons to select more/fewer fields.

<img src="https://github.com/CUEDOS/Unity/blob/master/bin/Data%20Acquisition%20Images/base%20physics%20inspector%20field%20drop%20down.png" alt="Data Saver Drop Down Populated"/>

## Saving Data
The SaveData script will automatically generate headers in the tab separated file it creates. Saving starts when the editor enters play-mode and will automatically finish when play-mode is exited. A blank line will be added between saving sessions if SaveData finds an existing file with the same name and path as the specified one.

The SaveData script invokes the .ToString() method to convert the field/method instance value to a string for saving. If you have your own data structures that you wish to save be sure to override the ToString method to ensure adequate saving.

**Note: Arrays and lists are not currently supported by this script, they will be added in a future update when the developer has more free time**
