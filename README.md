# dwnStats

While we don't have a project dedicated database server, you need to do a couple of things for this to work on your machine.

If you don't have a database server set up, set one up using SqlServer Management Studio. Once it is set up, create a login for the server 
(open the security folder, right click logins) that uses an Sql login. Make sure the project allows both Windows and Sql logins.

The connection string must then be added to the secret manager. The secret manager allows users to store senstivie database credentials in a file outside of the project itself. ASP.NET is automatically configured to read in any user secrets, allowing for the connection to that specified database. The user secrets are store in this path for Windows users: (%APPDATA%\Microsoft\UserSecrets\<user_secrets_id>\secrets.json) and this path for macOS and Linux users: (~/.microsoft/usersecrets/<user_secrets_id>/secrets.json). In order to set the database connection string as a user secret, run the following commands:

Initialize Secret Manager:
$: dotnet user-secrets init

Set Connection String as User Secret:
$: dotnet user-secrets set "ConnectionStrings:UserConnection" "Server=**your server name**;Initial Catalog=**name of the database**;User Id=**your user id**;Password=**your password**" --project "**path of the dotnet project**"

Other helpful commands:

View Secrets Stored in the Secret Manager:
$: dotnet user-secrets list

Delete Secrets Stored in the Secret Manager:
$: dotnet user-secrets clear


Finally, there may still be some errors if you do not have some extra packages I installed. VS may prompt you to install them, or you can start a new terminal
in the project and run:
```
dotnet add package Microsoft.AspNetCore.SpaServices.Extensions
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
dotnet add package Microsoft.AspNetCore.JsonPatch
dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson
```
Then, run it like any other VS project and go to localhost:5000/api/users
