# _Eau Clair's Salon_        

#### By **Christina Welch**

#### _A program that tracks stylists and clients for a salon_

## Technologies Used

* C#
* .net
* ASP.NET Core
* Razor
* CSS
* HTML
* Entity Framework
* SQL

## Description

_A project made for week 3 of Epicodus Schools C# and .net course to showcase knowledge of sql database integration. it tracks stylists for a mock salon and each stylists clients for a one to many database relationship._

![schema design](HairSalon/wwwroot/img/schema.png)

## Setup/Installation Requirements

* Clone this repository to your Desktop.
* in MySql Workbench navigate to Navigator > Administation Window and select Data Import/Restore.
* in import Options select Import from Self-Contained File.
* Under Default Schema to be Imported To, select the New button and name the database schema
* Navigate to the tab called Import Progress and click Start Import at the bottom right corner of the window.
* After you are finished with the above steps, reopen the Navigator > Schemas tab. Right click and select Refresh All. you should see the new database.
* Open Eau-Claire-s-Salon/HairSalon in VScode or a code editor of your choice.
* create a new file and name it appsettings.json
* in this file add the folloing:
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=[Your-Database-Name-Here];uid=root;pwd=[YOUR-PASSWORD-HERE];"
    }
}
Note: make sure to replace [Your-...-Here] sections with your password and database names.
* type dotnet run into the terminal

## Known Bugs

adding an appointment wont work and will send you to a broken page.

## License

MIT License

Copyright (c) [2021] [Christina Welch]