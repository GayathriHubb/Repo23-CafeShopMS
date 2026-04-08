This is a Cafe Shop Management System built with C# using Windows Forms (.NET Framework). The application provides a complete solution for managing a cafe's operations including user authentication, product management, customer records, order processing, and staff management.

Technology Stack | 
Language: C# (100%),
UI Framework: Windows Forms,
Database: SQL Server (LocalDB with .mdf file),
IDE/Tool: Visual Studio (.NET Framework)

Project Architecture
1. Core Components |
Component	Purpose |
Login.cs | User authentication system with role-based access (Admin/Cashier),
Register.cs |	New user registration with approval workflow,
Program.cs	| Application entry point launching the Login form,
AvailableProducts.cs|  Retrieves available cafe products from database,
ProductsData.cs	| Product management and CRUD operations,
OrdersData.cs	| Order processing and management,
CustomersData.cs | Customer information management,
UsersData.cs | User account management,
CafeShopData.cs |	Global data sharing across forms

Key Features | 
Authentication & Authorization
Login Form: Validates credentials against the Users table |
Role-Based Access:
Admin: Full access to AdminMainForm with cashier management,
Cashier: Limited access to StaffMainForm for order processin,g
Registration: New users register and await admin approval before accessing the system,
Status Tracking: Active/Approval/Inactive user statuses,
Admin Features (UCAdminCashiers.cs),
Manage cashier accounts,
View and approve pending registrations,
Dashboard (UCDashBoard.cs) for system overview,
Cashier Features (StaffMainForm.cs),
Process customer orders (UCStaffOrders.cs),
View available products (UCProducts.cs),
Manage transactions,
Access customer information (UCCustomers.cs),
Database Operations,
Product inventory management with stock tracking,
Order history and transaction records,
Customer data storage,
User credentials and role management

Key Workflows
Login Flow:

User enters credentials → Validated against Users table
Check status (Active/Approval) → If approved, fetch user role
Route to appropriate form (Admin or Cashier)

Order Management Flow:

Cashier selects available products,
Creates order with quantities,
System calculates total price,
Order saved to database with timestamp

This is a practical, production-like cafe management system with proper role-based security, database integration, and modular UI design.
