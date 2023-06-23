# GlennisDevVisualStudio
RecipeShare App using Visual Studio
# GlennisDevVisualStudio
<br>
DEV GUIDE
<br>
<br>
For Mac
<br>
[x] Install Visual Studio for Mac
<br>
[x] Install dotNet Core SDK for macOS
<br>
[x] Run SQL Server container via Docker
<br>
<br>
Overview
<br>
Main Points
<br>
Requirements for Users:
<br>
•See and search all recipes-  This means we need to create a relational database to handle the individual recipes and their accompanying data (Read)
<br>
•Ability to add recipes, consists of Title, Instructions, and Image(Update); Here we need to decide to store actual image in the database or a reference to an external storage. For this particular exercise, I thought it would be better to access the images by reference, the trade off is that it makes for another transaction, but it will keep all of the images in another place keeping our database cleaner, and allowing to create functionality to resize images to be more uniform, in an abstracted way.
<br>
•Ability to rate and comment on individual recipes (Create); Store ratings in another table, create functionality to retrieve all ratings and get average, can store this in the Recipes Table for easy access.  Store Comments in its own table, and can be used to render when/where needed
<br>
•Ability to Edit recipes (Update); Create a request to the database endpoint to edit the recipe and save it in place.
<br>
<br>
•Relational Database
<br>
	-Decided to make 3 Tables
	<br>
		•Recipes
		<br>
		•Comments
		<br>
		•Ratings
<br>
<br>
Need to implement Search bar that can access recipes by keywords & ID’s
<br>
Need to set up authentication/ authorization of users; after authentication can assign JWTs
<br>
Will need to set up database of users with their info, ensure proper security measures are taken (Encryption etc)
<br>


Preliminary To Do List
<br>

[x] Set up ASP.NET Core Web App Template
<br>
[x] Set up SQL Server via Docker
<br>
[x] Create Models
<br>
    [x] Recipe Model includes RecipeID, Title, Instructions, Image, Rating, and Comments
    <br>
[x] Connect to SQL Server
<br>
[ ] Define schema for tables
<br>
<strong>**Create Controllers and Views**
<br>
[ ] Create Controllers to manage recipes
<br>
    [ ] Create CRUD actions for recipes
<br>
[ ] Create Controller to manage comments 
<br>
create new table for comments for each recipe, assign unique id number to each comment
<br>
[ ] Create Controller to manage titles
<br>
[ ] Create Controller to manage ratings / will be an average of all ratings
<br>
[ ] Create Controller to manage image directory
<br>
<br>
[ ] Create corresponding actions for each action
<br>
**Implemnent Search Functionality**
<br>
[ ] Add search bar to listing view
<br>
[ ] Implement Search Action in controller to filter recipes based on user input
<br>
<strong>**Add Rating and commenting Functionality**
<br>
[x] Model- add Properties
<br>
[ ] View- Create views for comments and ratings
<br>
[ ] Controller- Implement actions for rating and commenting
<br>
<strong>**Security**
<br>
[ ] Implement functionality that only allows registered users to add/edit recipes etc.
<br>
[ ] Implemnt the ASP.NET Core Identity library or similar for user management
<br>
<strong>**TEST AND REFINE**
<br>
[ ] Build and run the app
<br>
[ ] Test each user story and ensure it works according to expectations
<br>
<strong>**Additional Notes**
<br>
Be mindful of sanitizing and validating user input, and handling edge cases etc...
<br>
And of course encrypt user's data for security measures, and to protect the app from malicious injections
<br>
