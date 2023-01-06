# Hair Salon 

#### a short code review project using databases

#### By Alex Johnson

## Technologies Used

* C#
* MySQL/MySQL Workbench
* EFCore
* LINQ


## Description/Objectives
 *  create an MVC web application to help her manage her employees (stylists) and their clients. Claire should be able to add a list of stylists working at the salon, and for each stylist, add clients who see that stylist. The stylists have specific specialties, so each client can only see (belong to) a single stylist.

## Setup/Installation Requirements

* clone the repo & open terminal in `HairSalon directory` or navigate there directly via commandline
* run these commands to install necessary dependencies:
     * `dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0`
     * `dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0`

* Open MySQLWorkbench & navigate to the administration tab
* Select "Import from Self Contained File"
* Select the .sql file in the top level directory named `alex_johnson` and import as a new schema with the same name 
* Select start import
* Confirm the installation was successful by reviewing any errors

## Configuration
* In the `HairSalon` directory, create a file called `appsettings.json`
* enter the following code, updating the placeholders to your information:
`{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=alex_johnson;uid=[YOUR_UID];pwd=[YOUR_PASSWORD];"
    }
}`
* save and close the file.

## Running the program
* open a terminal in the `HairSalon` directory or navigate via commandline
* enter `dotnet run build`

## Known Bugs


## Additional Thanks


## Future implementations

## License
MIT License

Copyright (c) 2022 Alex Johnson

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR 
PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS 
BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE
OR OTHER DEALINGS IN THE SOFTWARE.
