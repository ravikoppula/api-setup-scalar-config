# api-setup-scalar-config

Sample API to set up scalar config and organize the program.cs file

## Prerequisites

- .NET 6.0 SDK or later
- Visual Studio 2022 or later / Visual Studio Code
- Postman or any other API testing tool

## Getting Started

1. **Clone the repository:**
   ```bash
   git clone https://github.com/yourusername/api-setup-scalar-config.git
   cd api-setup-scalar-config
   ```

2. **Open the project:**
   - Open the project in Visual Studio by double-clicking the `.sln` file.
   - Or open the project in Visual Studio Code by running:
     ```bash
     code .
     ```

3. **Restore dependencies:**
   ```bash
   dotnet restore
   ```

4. **Build the project:**
   ```bash
   dotnet build
   ```

5. **Run the project:**
   ```bash
   dotnet run
   ```

## API Endpoints

### GET /api/values

- **Description:** Retrieves a list of values.
- **Response:**
  ```json
  [
    "value1",
    "value2"
  ]
  ```

### POST /api/values

- **Description:** Adds a new value.
- **Request Body:**
  ```json
  {
    "value": "new value"
  }
  ```
- **Response:**
  ```json
  {
    "id": 1,
    "value": "new value"
  }
  ```

## Configuration

The scalar configuration can be set up in the `appsettings.json` file.

```json
{
  "ScalarConfig": {
    "Setting1": "value1",
    "Setting2": "value2"
  }
}
```

## Organizing `Program.cs`

The `Program.cs` file is organized to set up the scalar configuration and configure services.

```csharp
// ...existing code...
var builder = WebApplication.CreateBuilder(args);

// Configure services
builder.Services.Configure<ScalarConfig>(builder.Configuration.GetSection("ScalarConfig"));

// ...existing code...

var app = builder.Build();

// ...existing code...

app.Run();
```

## Testing

Use Postman or any other API testing tool to test the endpoints.

1. **GET /api/values**
   - Send a GET request to `https://localhost:5001/api/values`
   - Verify the response.

2. **POST /api/values**
   - Send a POST request to `https://localhost:5001/api/values` with the following body:
     ```json
     {
       "value": "new value"
     }
     ```
   - Verify the response.

## License

This project is licensed under the MIT License.
