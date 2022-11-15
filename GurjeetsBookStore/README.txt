Name : Gurjeet singh 
Date : 7-11-2022
Assignment 2

Part 1:
         Earlier started the project but failed in initialising it in github because i just made git locally due to which remote repository is not added in it so,
         I deleted all files and now starting again.

4:13pm - Started the assignment 2 and just completed first commit.
4:23pm - Commented sign in flag in Startup.cs file as per requirement. 
4:49pm - Did the test debugging but it did not work in the browser so I turned sslPort into comment. Then again, I test debugging and now it is working.
5:21pm  - Replacing the bootstap file existing in the project with the bootstrap.css downloaded from bootswatch.com and selected the slate theme. Replacing
         the the existing site.css with the given css file in blackboard.Then updated the filename from bootstrap.min.css to bootstrap.css and also changed
         the light to dark and bg-white to bg-primary and also removed the text dark from line 23 & 25. Also, updated _LoginPartial.cshtml file by removing
         text-dark from it. Run the file and it works.
5:25pm - As i am doing the assignment in college lab so now going to home and will prepare my food and then start again.

8:11:2022

1:05am - After a long break, I again start working on assignment. I added additional stylesheets and scripts from the CSS_JS.txt file in _Layout.cshtml. 
1:37am - I Added a dropdown to the NavBar in _Layout.cshtml file. Then, i am going to check in browser but it shows run time error. After that, i checked 
         and realize that i am using folder view and i changed it with solution view. I bulid again and now, it works in browser.
1:57am - I Changed nav link name ‘Dropdown’ to ‘Content Management’ in _Layout.cshtml file.   
2:05am - I feel little sleepy and I am taking a little break and having a coffee. 
2.20am - I start working on adding projects. I added three new projects and give name GurjeetsBooks.DataAccess, GurjeetsBooks.Models GurjeetsBooks.Utility .
2.30am - I Copied the 'Data' folder and paste to .DataAccess project and delete the origanal 'Data' folder.
2:56am - I got an error because Relational framework version 7.0.0 is not compatible with .net version 3.1 .
        (Package Microsoft.EntityFrameworkCore.Relational 7.0.0 is not compatible with netcoreapp3.1 (.NETCoreApp,Version=v3.1)).
        Now, finding the compatible version.
3:35am - I found the compatible version which is 3.1.16 and then I installed Microsoft.EntityFrameworkCore.Relational and Core.SqlServer packages.
3.47am - I deleted the Migrations folder in Data folder.
3.51am - In DataAccess, I added NuGet package.
3.57am - In ApplicationDbcontext.cs File, I modified namespace to reflect the project.
4:03am - I deleted all default Class1.cs files in all three projects.
4:19am - After building Project, I got four errors. Some errors are in Startup.cs file. Now, i am trying to solve these.
4:30am - I moved Models in to GurjeetsBooks.Models and then i deleted original Models folder.
4:32am - In Error.cshtml, i modified namespace with ViewModels.
4.37am - In project, i added reference to .DataAccess and .Models .
4:48am - I Rename Models folder name to ViewModels and changed namespace in ErrorViewModel.cs file.
4:53am - Modified the Data field to DtaAccess in Startup.cs file.
4:56am - Changed THE Reference Of ViewModels in Homecontroller.cs.
4:20pm - Next day, I am trying to understand my errors why i got these errors.
4:32pm - I understood my errors and its time to fix it. In Error.cshtml file i have two error. First was line break error in model and second was 
         model path was short for ErrorViewModel. 
4:49pm - For fixing errors in Error.cshtml file i modified the model path and fixed line break in model.
5:15pm - I fixed the third error which was in _ViewImports.cshtml file. Because, i changed the Model folder name. Due3to which, i changed 
         models with ViewModels for reference.

13:11:2022

8:40pm - In the utility project, I created detailed static class and named SD.cs and i modified its properties with public static.Then i added 
         reference to main project and in DataAccess project, i gave reference to models and utility. 
8:52pm - I added customer area with MVC area to Areas.
8:58pm - I changed the routes in startup.cs file in the ScaffoldingReadMe.txt file.
9:04pm - I moved HomeController.cs file to Area > Customer > Controllers folder and i deleted Data and Models folder.

14:11:2022

3:36pm - I started working on Assignment again.
3:40pm - I modified HomeController.cs file for defining the explicitly in the customer area.
3:49pm - I moved views to Home and i modified namespace in Homecontroller file.
3:52pm - I bulid the application and then run. Index file working but it required layout file.
3:59pm - I copied to file and that is _viewimport and _viewstart to customer area.
4:04pm - I modified _viewstart.cshtml file for reflecting new path.
4:06pm - Finally, i run the application and its working without any error.
4:16pm - In Area, i added a new area for Admin.
4.30pm - I copied and added view files and Afterthat, I deleted Data and Models folder and deleted controllers folder too.
4:32pm - I builed the application and test. It works without any error.

Part 2:

4:47pm - I tested the application for builting and it run in the browser without any error.
4:51pm - I reviewed the appsettings.json file and I created the migration and i modified datbase name.
4:55pm - I got an error (Your target project 'GurjeetsBookStore' doesn't match your migrations assembly 'GurjeetsBooks.DataAccess'.)
4:56pm - To solve this error, i changed project 'GurjeetsBookStore' to default project 'GurjeetsBooks.DataAccess'. I tested the app and it worked.
5:07pm - Added new migration file and its name is '20221114220513_AddDefaultIdentityMigration.cs'.
5:18pm - After completing migration, i updated datbase with command 'update-database'.
5:20pm - I reviewed all files and folder in updated datbase. I tested application and it worked.
5:39pm - I add a new class in .models and added a migration via console with command 'add-migration AddCategoryToDb'.
5:50pm - In ApplicationDbContext.cs file, I added category model in database.
5:59pm - I updated database and i checked that new category table is displyed in sql.
6:12pm - I created new folder and name it 'Repository' and added a new IRepository folder inside it.
6:16pm -  I added new interface inside of IRepository folder and and name it IRepository.cs.
6:32pm -  I modified IRepository.cs for doing all crud operations.
6:55pm - Added a new repository class in repository folder. I modified the code with help of assignment folder's  Repository file.


15:11:2022

12:42am - Created category repository interface with it's class.
12:59am - modified category interface and added update method in categoryRepositry class
01:28am - removed throw new exception line from category repositry
02:08am - Created ISP_CAll interface with it's class SP_Call and implemented properties and methods of the class with connect to interface.
03:16am - created Inter face for IUnitOWork and implemented inner properties
03:19am - Created Class For UnitOfWork and addd potiential fix whit implementation of methods.
03:20am - Added reference as Scoped of both UnitOfwork in startup.cs
04:28am - Created CategoryControlles file and modified to use IUnitOfWork interface
04:39am - created index view for Category controller in Admin area and added code from the given file
04:44am - Added link of index view from Category controller added in the dropdown of nav and privacy page link removed
05:24am - Added javascript file for category in index.cshtml file. it is implementing datatable.
05:27am - added js file according to slide but there is no data in the table
05:36am - added Upsert method in category controller to add new category and created a view related to it with a form
9:01am - I created partial File for create form.
9:06am - Foe edit form, i created partial file.
9:07am - I added ASP action on create a link and modified to for use partial.

 - Corrected that upsert file error of Model.Id != 0, zero instead of null