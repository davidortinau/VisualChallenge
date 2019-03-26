# Visual Challenge Summary

Screenshot (result of timeboxed exercise):  

![Screenshot (result of timeboxed exercise)](screenshots/comparison.png "Screenshot (result of timeboxed exercise)")

Key feedback:  

1. Quick to get going; material design propagated to all native controls as expected via the application shell
2. Visuals were mostly achieved in this case via the use of the material design icons and ImageButton controls. Half the time was spent identifying best-fit icons and adding them to the project(s). It would be useful to have a faster/more direct way to incorporate Material design assets into platform targets
3. Bottom tab visual behaviour was not the same across platforms, though it required much less work with shell than standard Xamarin.Forms. For example, Android makes the selected tab icon (and text) larger. Use of *dimens.xml* was required in order to override the default sizes
4. OnPlatform was required to address differences in default paddings/margins and associated alignment issues 
5. Minor differences in default text appearance