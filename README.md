<div align="center">
    <h1>Recycling Machine</h1>
    <h3>
        <a href="#">
            Live demo
        </a>
        <span> | </span>
        <a href="https://github.com/kzrepo/RecyclingMachine">
            GitHub
        </a>
    </h3>
    <p>Machine for recycling empty bottles and cans.</p>
    <p><b>Status:</b> 🛠️ The application is in active development 🛠️</p>
    <br>
    <p>Technologies and tools:</p>
    <p>
        <img src="docs/img/dotnet.svg" width="40" height="40" alt="dotnet"/>
        <img src="docs/img/csharp.svg" width="40" height="40" alt="csharp"/>
        <img src="docs/img/sqlserver.svg" width="40" height="40" alt="sqlserver"/>
        <img src="docs/img/html5.svg" width="40" height="40" alt="html"/>
        <img src="docs/img/css3.svg" width="40" height="40" alt="css"/>
        <img src="docs/img/js.svg" width="40" height="40" alt="javascript"/>
        <img src="docs/img/md.svg" width="40" height="40" alt="markdown"/>
        <img src="docs/img/git.svg" width="40" height="40" alt="git"/>
        <img src="docs/img/github.svg" width="40" height="40" alt="github"/>
        <img src="docs/img/vs.svg" width="40" height="40" alt="visualstudio2022"/>
    </p>
</div>
<br>



## Implementation of the project

### Technical requirements

- The project is created in Visual Studio 2022 Version 17.3.3
- Version .NET 6.0
- Database - Code-First approach

### Project elements

- [ ] Database project
  - [x] ItemParameter - a table for storing the information needed to validate the inserted bottle or can
  - [ ] ReturnedItem - a table with all returned items
  - [x] Voucher - a table with printet vouchers
- [ ] Admin site project
  - [x] Manage item parameters
  - [ ] Show table with returned items
  - [x] Show table with Vouchers
  - [ ] Page with statistics
- [ ] Customer panel project
  - [ ] Text UI
  - [ ] Graphic UI
- [ ] Business logic project
  - [ ] Admin site
  - [ ] Customer panel
- [ ] Seeds
  - [ ] Default ItemParameter values
  - [ ] Sample data with voucher and returned items
- [ ] Login to Admin site
- [ ] Test project
  - [ ] Unit tests



## Technical Assignment

### Task Details
Implement a reverse vending machine (bottle deposit machine), as can be found at many norwegian grocery stores. This is a machine where you the store. You are free to choose how you want present/implement the UI.

### Requirements
The product owner has put together the following list of user stories for this
application.

> RS-001  
> As a drinks' manufacturer,  
> I'd like the system to accept empty bottles  
> So that we can reacquire used bottles for recycling.  

> RS-002  
> As a drinks' manufacturer,  
> I'd like the system to accept empty cans,  
> So that we can reacquire used cans for recycling.  

> RS-003  
> As a customer,  
> I'd like the system to give me a voucher as a reward for turning in bottles,  
> So that I can buy stuff  

> RS-004  
> As a drinks' manufacturer,  
> I'd like a backend system to log whenever a bottle/can is turned in or a voucher is printed,  
> So that we can report the efficiency of each recycling station.  

### Specifications and Clarifications

- Cans are valued at 2 NOK each.
- Bottles are valued at 3 NOK each.
- Inputting a bottle/can should be represented through a UI element, e.g. a buttodsn or a console prompt.
- For the purposes of this application, it is enough to present the printed voucher on screen.
- You can assume that all containers have a valid sticker on it for valid identification.
- The hardware running on the recycling machine is only able to process cans at a rate of 0,5 per second and plastic bottles at a rate of 1 per second.