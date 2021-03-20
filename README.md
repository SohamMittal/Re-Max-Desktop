# Re-Max-Desktop
This desktop software is a small implementation of the Re-Max Website

## Functional Requirements
### These are the functionalities of the Remax application :

F1 : The Admin has the full access of the application and can manage Employees, Houses and Clients.
F2 : The Agent manages his own Clients ie Buyers and Sellers ,and Houses
F3 : Any User can search for a one particular or all the Houses (by reference number) and for a particular or all Agents (by employee number).
The Analysis Functionality Requirements

This program is a multi-tier application consisting of Gui, Business and Datasource Layers.

#### GUI Layer:
Window C# Application with MDI (multiple documents interface) based on the user functionality requirements.
#### BUSINESS Layer:
Library of classes for the entities : Company, Employees(User, Admin or Agent), Clients(Buyer or Seller) and Houses.
#### DATASOURCE Layer:
Class that encapsulates the database (access) and provides public interfaces for feeding data to the business layer and writing data back to the database. Microsoft Access 
database that will contains all the needed data for Remax/

### Technical Requirements
#### For the GUI Layer:
Use friendly and thematic (Remax related colors and images) windows forms interfaces.
#### For the Business Layer:
Apply Object Oriented Concepts like classification (inheritance, composition and aggregate), encapsulation (dotNet’s objects).
#### For the Datasource Layer:
Use Ado.net.

### Files
Passwords.png : A list of the users with their passwords which grants you access to the program.
