Name : Gurjeet singh 
Date : 2022-11-7 
Assignment 2


                                                        Part - 1

     2022-11-7


       Earlier started the project but failed in initialising it in github because i just made git locally due to which remote repository is not 
       
       added in it so, I deleted all files and now starting again.

0413 - Started the assignment 2 and just completed first commit.

0423 - Commented sign in flag in Startup.cs file as per requirement. 

0449 - Did the test debugging but it did not work in the browser so I turned sslPort into comment. Then again, I test debugging and now it is working.

0521 - Replacing the bootstap file existing in the project with the bootstrap.css downloaded from bootswatch.com and selected the slate theme. Replacing
       
        the the existing site.css with the given css file in blackboard.Then updated the filename from bootstrap.min.css to bootstrap.css and also changed
       
        the light to dark and bg-white to bg-primary and also removed the text dark from line 23 & 25. Also, updated _LoginPartial.cshtml file by removing
       
        text-dark from it. Run the file and it works.

0525 - As i am doing the assignment in college lab so now going to home and will prepare my food and then start again.


    2022-11-8


0105 - After a long break, I again start working on assignment. I added additional stylesheets and scripts from the CSS_JS.txt file in _Layout.cshtml. 

0137 - I Added a dropdown to the NavBar in _Layout.cshtml file. Then, i am going to check in browser but it shows run time error. After that, i checked 

        and realize that i am using folder view and i changed it with solution view. I bulid again and now, it works in browser.

0157 - I Changed nav link name ‘Dropdown’ to ‘Content Management’ in _Layout.cshtml file.   

0205 - I feel little sleepy and I am taking a little break and having a coffee. 

0220 - I start working on adding projects. I added three new projects and give name GurjeetsBooks.DataAccess, GurjeetsBooks.Models GurjeetsBooks.Utility .

0230 - I Copied the 'Data' folder and paste to .DataAccess project and delete the origanal 'Data' folder.

0256 - I got an error because Relational framework version 7.0.0 is not compatible with .net version 3.1 .

       (Package Microsoft.EntityFrameworkCore.Relational 7.0.0 is not compatible with netcoreapp3.1 (.NETCoreApp,Version=v3.1)).

       Now, finding the compatible version.

0335 - I found the compatible version which is 3.1.16 and then I installed Microsoft.EntityFrameworkCore.Relational and Core.SqlServer packages.

0347 - I deleted the Migrations folder in Data folder.

0351 - In DataAccess, I added NuGet package.

0357 - In ApplicationDbcontext.cs File, I modified namespace to reflect the project.

0403 - I deleted all default Class1.cs files in all three projects.

0419 - After building Project, I got four errors. Some errors are in Startup.cs file. Now, i am trying to solve these.

0430 - I moved Models in to GurjeetsBooks.Models and then i deleted original Models folder.

0432 - In Error.cshtml, i modified namespace with ViewModels.

0437 - In project, i added reference to .DataAccess and .Models .

0448 - I Rename Models folder name to ViewModels and changed namespace in ErrorViewModel.cs file.

0453 - Modified the Data field to DtaAccess in Startup.cs file.

0456 - Changed THE Reference Of ViewModels in Homecontroller.cs.

0420 - Next day, I am trying to understand my errors why i got these errors.

0432 - I understood my errors and its time to fix it. In Error.cshtml file i have two error. First was line break error in model and second was 

         model path was short for ErrorViewModel. 

0449 - For fixing errors in Error.cshtml file i modified the model path and fixed line break in model.

0515 - I fixed the third error which was in _ViewImports.cshtml file. Because, i changed the Model folder name. Due3to which, i changed 

         models with ViewModels for reference.



    2022-11-13


0840 - In the utility project, I created detailed static class and named SD.cs and i modified its properties with public static.Then i added 

         reference to main project and in DataAccess project, i gave reference to models and utility. 

0852 - I added customer area with MVC area to Areas.

0858 - I changed the routes in startup.cs file in the ScaffoldingReadMe.txt file.

0904 - I moved HomeController.cs file to Area > Customer > Controllers folder and i deleted Data and Models folder.


    2022-11-14


0336 - I started working on Assignment again.

0340 - I modified HomeController.cs file for defining the explicitly in the customer area.

0349 - I moved views to Home and i modified namespace in Homecontroller file.

0352 - I bulid the application and then run. Index file working but it required layout file.

0359 - I copied to file and that is _viewimport and _viewstart to customer area.

0404 - I modified _viewstart.cshtml file for reflecting new path.

0406 - Finally, i run the application and its working without any error.

0416 - In Area, i added a new area for Admin.

0430 - I copied and added view files and Afterthat, I deleted Data and Models folder and deleted controllers folder too.

0432 - I builed the application and test. It works without any error.



                                                        Part - 2

     2022-11-14


0447 - I tested the application for builting and it run in the browser without any error.

0451 - I reviewed the appsettings.json file and I created the migration and i modified datbase name.

0455 - I got an error (Your target project 'GurjeetsBookStore' doesn't match your migrations assembly 'GurjeetsBooks.DataAccess'.

0456 - To solve this error, i changed project 'GurjeetsBookStore' to default project 'GurjeetsBooks.DataAccess'. I tested the app and it worked.

0507 - Added new migration file and its name is '20221114220513_AddDefaultIdentityMigration.cs'.

0518 - After completing migration, i updated datbase with command 'update-database'.

0520 - I reviewed all files and folder in updated datbase. I tested application and it worked.

0539 - I add a new class in .models and added a migration via console with command 'add-migration AddCategoryToDb'.

0550 - In ApplicationDbContext.cs file, I added category model in database.

0559 - I updated database and i checked that new category table is displyed in sql.

0612 - I created new folder and name it 'Repository' and added a new IRepository folder inside it.

0616 - I added new interface inside of IRepository folder and and name it IRepository.cs.

0632 - I modified IRepository.cs for doing all crud operations.

0655 - Added a new repository class in repository folder. I modified the code with help of assignment folder's  Repository file.


     2022-11-15


1242 - Created category repository interface with it's class.

1259 - modified category interface and added update method in categoryRepositry class

0128 - removed throw new exception line from category repositry

0208 - Created ISP_CAll interface with it's class SP_Call and implemented properties and methods of the class with connect to interface.

0316 - created Inter face for IUnitOWork and implemented inner properties

0319 - Created Class For UnitOfWork and addd potiential fix whit implementation of methods.

0320 - Added reference as Scoped of both UnitOfwork in startup.cs

0428 - Created CategoryControlles file and modified to use IUnitOfWork interface

0439 - created index view for Category controller in Admin area and added code from the given file

0444 - Added link of index view from Category controller added in the dropdown of nav and privacy page link removed

0524 - Added javascript file for category in index.cshtml file. it is implementing datatable.

0527 - added js file according to slide but there is no data in the table

0536 - added Upsert method in category controller to add new category and created a view related to it with a form

0901 - I created partial File for create form.

0906 - Foe edit form, i created partial file.

0907 - I added ASP action on create a link and modified to for use partial.

0916 - Corrected that upsert file error of Model.Id != 0, zero instead of null.



     2022-11-21


0811 - Modified and added a new category in categorycontroller.cs file for edit button.

0823 - I stucked with an error. When i tried to update category name, it was not updating the category name. 
     
        I tried to find where a did wrong. After a few minutes, I found that i added == in if condition then i 
        
        changed it with !=  for updating category name if its not null.  
        
0830 - Now it was updating category name.

1004 - Added API call HTTPDelete methodin the categoryController.cs

1030 - I implemented the HTTPDelete with delete method in Category file.

1039 - A0dded onclick event to Delete functionality in Category file.

1058 - Added delete URL function code from slide.

1100 - I saved and run the application. It runs without any error.



                                                    Part-3

        2022-11-21


1130 - I bulid the application and test The Application.

1132 - I created Cover type CRUD and added CoverType.cs in Model's folder.

1142 - I added ID and Name in covertype.cs file.

1152 - I added CoverType to Repository folder.


        2022-11-22


1206 - I added class named CoverTypeRepository and modified.

1216 - Added interface named ICoverTypeRepository and changed data.

1222 - I modified UnitOfWork and IUnitofWork file for adding CoverType.

1236 - I created migration and update database. 

1239 - This  migration '20221122053601_AddCoverTypetoDb.cs' file is created by command.

0102 -  I changed my theme as per your instruction with 'LUX'.

        
        2022-11-23

1055 - I added a controller for covertype and added all method like update and delete for covertype.

1140 - I added a index file for CoverType in Area/Admin/Views.

1155 - Added a upsert file and modified for CoverType.


        2022-11-24

1204 - Added Nav link for CoverType in Layout file. Then saved and run in browser.

1215 - Added a new javascript file for CoverType. Then Bulit the appliction and run.

       Application runs in browser and all buttons are working.

1249 - I added a new class in the gurjeetbooks.model project and i set its class to public and add code that given in slide.

1258 - I run a command to add a new migration for an addProductToDb and i updated the database.

0105 - This new migartion file '20221124060225_addProductToDb.cs' is added.

0115 - Added a new interface for IProductRepository and changed class.

0123 - I added ProductRepository Class and changed update method.

0136 - I addded product to IUnitofWork.cs and UnitofWork.cs files.

0142 - I bulit the application and checked  i got error. It was a spealing error. i added 's' after product in IunitofWork file.
    
       Then I add right words and application works in browser.

0150 - I added a controller for product in Area>Admin> Controller.

0159 - Afterthat, i added IWebHostEnvironment and changed its class to public.

0330 - I created a view model in model to hold the Product.
      
       I added a class named ProductVM. I installed  Microsoft.AspNetCore.Mvc.ViewFeatures Packge and modified its class.

0349 - In product Controller file, i modified the IActionResult upsert calls to the productVM view model with using statements.

0355 - For including Covertype and category properties i modified API call.

0358 - I added a index view for Product. Modified its properties and added Title/ ISBN/ Price/ Author/ .

0402 - I added a javascriprt file product and changed its url to pointed Product.

0406 - For adding product to navigation bar, I modified layout.cshtml and add link to product in nav bar.

0407 - I saved and run the appliction, Its working in browser and it showing product list in browser.
       
       I completed two section of Part 3 and i am tired. Now, I am going to take break .

       
            2022-11-30


0950 - In product controller file, i added upsert method.
1010 - Added New upsert view for product and modified.
1030 - Modified get method in product controller and rebulit the application.