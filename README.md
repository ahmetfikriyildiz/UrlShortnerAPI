# 🔗 URL Shortener API (.NET 7 / C#)

A minimal and efficient URL shortening REST API built using **ASP.NET Core Web API**. Supports redirecting, custom aliases, and basic link analytics.

---

## 📦 Features

- ✅ Shorten long URLs  
- ✅ Create custom short aliases  
- ✅ Redirect to original URLs  
- ✅ Track creation date and usage  
- ✅ Rate limiting & expiration (optional)

---

## ⚙️ Tech Stack

- **Framework**: ASP.NET Core 7  
- **Database**: Entity Framework Core with SQL Server / PostgreSQL  
- **ORM**: EF Core  
- **Extras**: Swagger, Serilog, FluentValidation

---

## 🚀 Getting Started

### 1. Clone the repository
```bash
git clone https://github.com/your-username/url-shortener-api.git
cd url-shortener-api
```

### 2. Set up the database
Update your connection string in `appsettings.json`:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=UrlShortenerDb;Trusted_Connection=True;"
}
```

Run migrations:
```bash
dotnet ef database update
```

### 3. Run the API
```bash
dotnet run
```

API will be available at:  
`https://localhost:5001` or `http://localhost:5000`

---

## 📡 API Endpoints

### 🔹 POST `/api/url`
**Create a shortened URL**
```json
{
  "originalUrl": "https://example.com/some/long/url",
  "customAlias": "myalias" // optional
}
```

**Response**
```json
{
  "shortUrl": "https://short.ly/myalias",
  "originalUrl": "https://example.com/some/long/url",
  "expiresAt": "2025-05-01T00:00:00Z"
}
```

---

### 🔹 GET `/{alias}`
**Redirect to original URL**  
Automatically redirects from the short link to the full URL.

---

### 🔹 GET `/api/url/{alias}`
**Get URL details**  
Returns metadata for the shortened link (e.g., creation date, original URL).

---

## 🧪 Testing

Swagger UI is available at:  
`/swagger/index.html`

You can also test with Postman or CURL.

---

## 🧰 Future Improvements

- ✅ Add click count tracking  
- 🔄 Support link expiration policies  
- 🛡️ JWT authentication for user-specific links  
- 📊 Dashboard for analytics

---

## 📄 License

MIT License
