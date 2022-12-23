# Hair Salon 

#### a short code review project using databases

#### By Alex Johnson

## Technologies Used

* C#
* MySQL
* EFCore
* LINQ
* 


## Description/Objectives
 *  create an MVC web application to help her manage her employees (stylists) and their clients. Claire should be able to add a list of stylists working at the salon, and for each stylist, add clients who see that stylist. The stylists have specific specialties, so each client can only see (belong to) a single stylist.
User Stories

* As the salon owner, I need to be able to see a list of all stylists.
* As the salon owner, I need to be able to select a stylist, see their details, and see a list of all clients that belong to that stylist.
* As the salon owner, I need to add new stylists to our system when they are hired.
* As the salon owner, I need to be able to add new clients to a specific stylist. I should not be able to add a client if no stylists have been added.


## Setup/Installation Requirements
* clone the repo & open terminal in HairSalon directory  or navigate via commandline
* run these commands to install necessary dependencies:
     * $ dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0
     * $ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0

## Configuration
* In the HairSalon directory, create a file called appsettings.json
* enter the following code, updating the placeholders to your id

{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR_DATABASE_HERE];uid=[YOUR_UID];pwd=[YOUR_PASSWORD];"
    }
}
* save and close the file.


## Running the program
* open a terminal in main folder or navigate via commandline\
* enter $dotnet run build


## Known Bugs

* If you find additional bugs not listed here, please email me at alex.johnson293@gmail.com with the subject **[_Repo Name_] Bug** and include:
  * BUG: _A brief description of the bug_
  * FIX: _Suggestion for solution (if you have one!)_
  * If you'd like to be credited, please also include your **_github user profile link_**

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