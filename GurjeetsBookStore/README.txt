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

