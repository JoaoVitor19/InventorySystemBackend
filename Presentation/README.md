# Inventory Management System

Welcome to the Inventory Management System, a comprehensive solution designed to streamline your inventory control processes. This application leverages the power of Angular for a responsive and interactive front-end, and .NET 8 for a robust and scalable back-end. The Progressive Web App (PWA) functionality allows you to install and use this application like a native app on your desktop and mobile devices.

## Features

- **Cross-Platform Compatibility**: Access and manage your inventory seamlessly across Windows, macOS, Linux, iOS, and Android.
- **Modern Web Technologies**: Built with Angular, providing a rich user experience and fast performance.
- **Progressive Web App (PWA)**: Install the app on your device for a native-like experience, complete with offline capabilities.
- **Robust Back-End**: Powered by .NET 8, ensuring high performance and scalability.
- **Comprehensive Inventory Management**:
  - Add, view, update, and delete products.
  - Attach product images using camera or gallery.
  - Keep track of product descriptions, prices, and quantities.
- **Responsive Design**: Optimized for both desktop and mobile use.

## Getting Started

Follow these instructions to get a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

- **Node.js** (v14.x or later)
- **Angular CLI** (v13.x or later)
- **.NET 8 SDK**
- **SQLite** (for local development)

### Installing

1. **Clone the Repository**

   ```bash
   git clone https://github.com/yourusername/inventory-management-system.git
   cd inventory-management-system

2. **Set Up the Back-End**
   
   Navigate to the back-end directory, restore the dependencies and run.
   ```bash
    cd InventoryApi
    dotnet restore
    dotnet ef database update
    dotnet run

3. **Set Up the Front-End**
   
   Navigate to the front-end directory, install the dependencies and run.
   ```bash
    cd ../inventory-app
    npm install
    ng serve
 
4. **Access the Application**

   Open your browser and navigate to http://localhost:4200.

### Usage
- **Adding a Product**: Use the 'Add Product' button to input product details and attach an image.
- **Viewing Products**: The main page lists all products with options to edit or delete.
- **Updating a Product**: Click on the 'Edit' button next to a product, modify the details, and save.
- **Deleting a Product**: Click on the 'Delete' button next to a product to remove it from the inventory.

### Built With
- **Angular** - Front-end framework
- **.NET 8** - Back-end framework
- **SQLite** - Database
