# Cobit-19

## More about the Project

### Project Title

The COBIT-19 project is based on the COBIT-19 FRAMEWORK. It is software developed as part of the Information Systems Engineering curriculum by North West University honors students 2023 hereby known as the COBIT Consultants. The software is a solution by Mr Phenyo Modisane (the client). It is based on the simplification and automation of audits within organizations. 

### Project Description

The COBIT 19 framework software solution idea is based on the simplification and automation of audits within organizations. Information Technology (IT) audits are essential in the governance and management of an organization, they make it possible to manage and allocate tasks, resources and people within the organization. The overall effectiveness of an IT audit determines the productivity and functioning of an organization. At the end of the day an effective organization is equal to a productive organization which in turn equals to profitability. However, organizations are still using the legacy system; which can be time consuming, error prone and costly. Moreover, they may lead to inconsistencies and inefficiencies in the audit process.  
 
The scale at which digital transformation takes place within organizations driving them to transform their business models and processes, which requires new approaches to governance and management of information technology; the mitigation and management of cyber security threats and the growing number of regulatory requirements related to information technology i.e. ISO and ITIL, all of these aforementioned factors are important when  auditing an organization but the auditing task becomes daunting and prone to errors and inefficiencies when using the traditional manual auditing processes. Thankfully, these issues are addressed by the COBIT19 Framework software proposed by the client.
 
The client has commissioned the project team to develop software to address the mentioned factors, to simplify and automate audits with the objective of improving the performance of an organization. The COBIT19 framework will provide organizations with the opportunity to improve their IT governance and management practices, to give an organization an overview perspective of its efficiency and areas that need improvement.  The comprehensive documentation for the project can be found [here](https://github.com/Bile62/Cobit-19/tree/476c9c1ae97768aa158f2f41d83fc574e3af643d/Documentation)

## Installation

### Prerequisites
*	[Download](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) SQL Server(Developer Option)
*	[Download](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16) SQL Server Management Studios 
* [Download](https://dotnet.microsoft.com/en-us/download) .NET 6.0 
* To [access](https://lucid.app/lucidchart/3e0403bd-b21a-4e15-9941-fc89a6feb698/edit?viewport_loc=-486%2C-103%2C2626%2C1245%2Cux54lk_FbWo4&invitationId=inv_feeea902-9a12-442e-b3a9-afd7e395ecde) the  ERD diagram for the project

### Steps

1.	Clone this repository - https://github.com/GerniVisser/Cobit-19
2.	Restore Packages - Right-click on the project in the Solution Explorer and select "Restore NuGet Packages" to restore all the required dependencies.
3.	Apply Database Migrations – Open the Package Manager Console (Tools -> NuGet Package Manager -> Package Manager Console), then run the following command:
   ```Update-Database ```
5.	Run the project

### SQL Server Management Studios

To open database in SSMS, you will need to follow the following steps:
1.	Open SQL Server Management Studios
2.	The connection information will be as follows:
Server Name – localhost
Authentication – Windows Authentication
3.	Navigate to Databases in the Object Explorer
4.	You should then see CobitDb listed as one of the databases, you will then be able to view the data stored in this database from here.

### 2022 COBIT solution sample

The COBIT-19 solution as developed by the honors class of 2022 can be found [here](https://assessmentcenterza.azurewebsites.net/) for your reference.

 Use the following credentials to login:
 
 ```Username: Admin@COBIT19.com ```

 ```Password: Modisane12#```


### Tests


### Collaborators
1. [GerniVisser](https://github.com/GerniVisser)
2. [DanielCoetzee](https://github.com/DeradoZA)
3. [givenmnisi6](https://github.com/givenmnisi6)
4. [Bile62](https://github.com/Bile62)
5. [Keagan Badenhorst](https://github.com/keagan420)

         
