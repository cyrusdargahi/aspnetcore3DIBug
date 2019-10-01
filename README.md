# aspnet core 3.0 DI Bug
This project is an example of a DI bug in aspnet core 3.0

## Reproduce steps
Build and run the application.
On first and the second load in the browser you should see the output `0.01`.

## Actual behavior
On any page reloads after the (exactly) first two, weird thing start to happen. 
The output will now be a bizarre number taken from somewhere that isn't defined anywhere in the application code.

## Expected results
Expected result is to display the constant `0.01` result on any page (re)load.
 
