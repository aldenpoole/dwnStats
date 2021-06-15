# dwnStats

While we don't have a project dedicated database server, you need to do a couple of things for this to work on your machine.

If you don't have a database server set up, set one up using SqlServer Management Studio. Once it is set up, create a login for the server 
(open the security folder, right click security) that uses an Sql login. Make sure the project allows both Windows and Sql logins.

Once you've done that, change the connection string in appsettings.json to your database server and login information.

Finally, there may still be some errors if you do not have some extra packages I installed. VS may prompt you to install them, or you can start a new terminal
in the project and run:

dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer

Then, run it like any other VS project and go to localhost:5000/api/users
