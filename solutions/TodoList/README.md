# User Story
1) As a user, i want to be able to see my to do list
2) As a user, i want to be able to add a new item to my to do list
3) As a user, when i closed the program, and reopened it again, i still can see my list
4) As a user, i can edit my to do list
5) As a user, i can delete item in my to do list
6) As a user, i can sort my to do list
7) As a user, i can complete my to do list
8) As a user, i can see all my completed to do list

# High level solution 
1) CLI (User interaction)
2) Data Storage (write it on a txt file)

# Source Code Structure
1) Paradigm: OOP
2) Layered Architecture 
    2.1) CLI (Handle the user input and the presentation)
    2.2) Business Logic
    2.3) Data
    2.4) Utility

# LifeCycle
1) Initialisation
2) Input handling
3) Display information
4) Termination

# Progress
1) Create DBService Singleton class to manage database connection
    - Convert DBService class into a Singleton (/)
    - implement connection between c# program to database using ADO.NET library ()
