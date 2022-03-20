![Formatting](https://user-images.githubusercontent.com/33253710/159179440-2cadffa9-187d-488f-948f-81597e6718b7.jpg)

<p align=center>Some helper classes for formatting numbers in different ways.</p>

# Classes
- <b>Simple Format</b>, handles formatting numbers into generic simple style number with no prefix such as 12.7K, 1.43M etc.
- <b>Position Format</b>, handles formatting numbers into positions like in a race or on a leaderboard.

# Usage
### Simple Format
Returns the number entered as a string with the appropriate suffix for said number. The only public methods are extensions of their input types so you can use them like you do with <code>ToString()</code> to update them. 

### Position Format
Returns the number eneted as a string with the appropriate suffix for the position that the number denotes them as being.
