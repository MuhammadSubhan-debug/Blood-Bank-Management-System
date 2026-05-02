# Blood-Bank-Management-System
A C# Windows Forms based Blood Bank Management System with donor, patient, and inventory management.
🩸 Blood Bank Management System (BBMS)

A Windows Forms-based Blood Bank Management System developed in C# (.NET).
This application helps manage donors, patients, blood requests, appointments, and administrative operations efficiently.

📌 Features
👤 User Features
User Registration & Login
Email Verification using OTP
Book Donation Appointments
Create Blood Requests
View Request Status
Profile Picture Upload
🛠️ Admin Features
Manage Donors & Patients
View and Manage Blood Requests
Manage Inventory
View Appointments
Dashboard with system overview
🔐 Security & Validation
OTP-based Email Verification
Role-based Login (Admin/User)
Input Validation
📊 Additional Features
Error Logging System (logs file stores exceptions)
Profile Image Handling
Dynamic UI (dropdown animations, panels, etc.)
🏗️ Technologies Used
C# (.NET Framework)
Windows Forms
SQL Server
ADO.NET (SqlConnection, SqlCommand, DataReader)
GDI+ (Image Handling)
SMTP (Email OTP System)

⚙️ Setup Instructions
Clone the repository:
git clone https://github.com/your-username/BBMS.git
Open project in Visual Studio
Configure Database:
Create database in SQL Server
Update connection string in DBManager.cs
Run the project
📧 OTP Email Configuration

To enable OTP system:

Configure SMTP credentials in your email sending function
Use a valid email and app password (recommended for Gmail)
📝 Logging System
All system errors are stored in a log file
Helps in debugging and maintaining system reliability
Implemented using a custom Logger class
🚀 Future Improvements
Add charts/analytics dashboard
Improve UI design (modern styling)
Implement password hashing
Add API-based architecture
Deploy as web application (ASP.NET)
👨‍💻 Author

Muhammad Subhan
BSCS Student | C# Developer

📜 License

This project is for educational purposes.
ScreenShots of Project are given in github 
